using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace KeyvanCRM
{
    public partial class frmPayment : KeyvanCRM.frmBase
    {
        bool hasCustomer = false;
        string customerID;
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCardex_Click(object sender, EventArgs e)
        {
         frmCardex customerCardex = new frmCardex(txtCustomerCode.Text);
         customerCardex.ShowDialog();
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
                lblCustomerName.Text = dataReaderCustomer["FirstName"].ToString() + 
                    " " + dataReaderCustomer["LastName"].ToString(); ;
               
            }
            dataReaderCustomer.Close();
            myConnection.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string spStr = "exec usp_InsertNewCustomerTransaction " + customerID + 
                ",0," + txtPurchaseAmount.Text + ",'" + txtComment.Text+"'";
            SqlCommand cmdSave = new SqlCommand(spStr, myConnection);
            try
            {
                myConnection.Open();
                cmdSave.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Save Successfull");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }            
        }

        private void txtPurchaseAmount_TextChanged(object sender, EventArgs e)
        {
            if (hasCustomer & txtPurchaseAmount.Text!="")
            {
                btnOK.Enabled = true;
            }
        }
    }
}

