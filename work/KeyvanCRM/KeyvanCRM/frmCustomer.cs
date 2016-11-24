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
    public partial class frmCustomer : KeyvanCRM.frmBase
    {
        int lastCodeInt;
        public frmCustomer()
        {
            InitializeComponent();
        }           
             
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text!=""&txtFirstName.Text!=""&txtIntroducer.Text!=""&txtLastName.Text!=""&txtTelephone.Text!="")
            {
                string insertNewCustomerStr = "insert into Customer (Code,FirstName,LastName,Telephone,Introducer,Address)" +
                                        "values (" + txtCode.Text + ",'" + txtFirstName.Text + "','" +
                                        txtLastName.Text + "','" + txtTelephone.Text + "','" + txtIntroducer.Text +
                                        "','" + txtAddress.Text + "')";
                SqlCommand cmdInsertNewCustomer = new SqlCommand(insertNewCustomerStr, myConnection);
                myConnection.Open();
                cmdInsertNewCustomer.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("„‘ —? Ãœ?œ –Œ?—Â ‘œ");
            }
            else
            {
                string notNullErrorMsg="«ﬁ·«„ ";
                if (txtAddress.Text=="")
                {
                    notNullErrorMsg += "¬œ—”°";
                }
                if (txtFirstName.Text=="")
                {
                    notNullErrorMsg += "‰«„°";
                }
                if (txtIntroducer.Text=="")
                {
                    notNullErrorMsg+="„⁄—›°";
                }
                if (txtLastName.Text=="")
	            {
		            notNullErrorMsg+="‰«„ Œ«‰Ê«œê?°";
	            }
                if (txtTelephone.Text=="")
	            {
		            notNullErrorMsg+=" ·›‰°";
	            }
                DialogResult result =
                      MessageBox.Show(notNullErrorMsg + "«Ã»«—Ì „Ì»«‘‰œ", "Œÿ«Ì «ﬁ·«„ «Ã»«—Ì",
                          MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Error,
                          MessageBoxDefaultButton.Button1,
                          MessageBoxOptions.RightAlign);
             }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void txtCustomerCode_ButtonClick(object sender, EventArgs e)
        {
            SqlCommand getLastCode = new SqlCommand("select top 1 Code from Customer order by code desc", myConnection);
            myConnection.Open();
            SqlDataReader readerLastCode = getLastCode.ExecuteReader();
            readerLastCode.Read();
            if (readerLastCode.HasRows)
            {
                string lastCodeStr = readerLastCode["Code"].ToString();

                lastCodeInt = int.Parse(lastCodeStr);
                lastCodeInt++;

            }
            else
            {
                lastCodeInt = 101;
            }
            myConnection.Close();
            txtCode.Text = lastCodeInt.ToString();
        }
    }
}

