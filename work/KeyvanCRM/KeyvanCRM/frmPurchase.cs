using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KeyvanCRM
{
    public partial class frmPurchase : KeyvanCRM.frmBase
    {
        DataTable purchaseTable = new DataTable("PurchaseTable");

        bool hasCustomer = false;
        string customerID;
        public frmPurchase()
        {
            InitializeComponent();
        }
        private void btnCardex_Click(object sender, EventArgs e)
        {
            frmCardex customerCardex = new frmCardex(txtCustomerCode.Text);
            customerCardex.ShowDialog();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {
            lblCustomerName.Text = "‰«„ „‘ —Ì";
            string customerCode = "null";
            if (txtCustomerCode.Text!="")
            {
                customerCode = txtCustomerCode.Text;
            }
            string selectStr="Select * from Customer Where Code=" + customerCode;
            SqlCommand cmdCustomer = new SqlCommand(selectStr, myConnection);
            myConnection.Open();
            SqlDataReader dataReaderCustomer = cmdCustomer.ExecuteReader();
            dataReaderCustomer.Read();
            if (dataReaderCustomer.HasRows)
            {
                hasCustomer = true;
                customerID = dataReaderCustomer["CustomerID"].ToString();
                lblCustomerName.Text = dataReaderCustomer["FirstName"].ToString()+" "
                    +dataReaderCustomer["LastName"].ToString();
                btnOK.Enabled = true;
            }
            else
            {
                btnOK.Enabled = false;

            }
            dataReaderCustomer.Close();
            myConnection.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection.Open();
                foreach (DataRow row in purchaseTable.Rows)
                {
                    string spStr = "exec usp_InsertNewCustomerTransaction " + customerID +
                        "," + row["PurchaseAmount"].ToString() + ",0,'" + 
                        row["Comment"].ToString()+"'";
                    SqlCommand cmdSave = new SqlCommand(spStr, myConnection);
                    cmdSave.ExecuteNonQuery();
                }
                myConnection.Close();
                MessageBox.Show("Save Successfull");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }            
        }

        private void txtPurchaseAmount_TextChanged(object sender, EventArgs e)
        {
            if (hasCustomer)
            {
            }
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            purchaseTable.Columns.Add("PurchaseAmount");
            purchaseTable.Columns.Add("Comment");
            gridPurchase.DataSource = purchaseTable;
        }
    }
}

