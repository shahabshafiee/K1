using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using Janus.Windows.GridEX;
namespace KeyvanCRM
{
    public partial class frmCardex : KeyvanCRM.frmBase
    {
        PersianCalendar persianCalendar = new PersianCalendar();
        DataSet dataSetCardex = new DataSet();
        public frmCardex()
        {
            InitializeComponent();
        }
        public frmCardex(string code)
        {

            InitializeComponent();
            this.txtCustomerCode.Text = code;
            txtCustomerCode.Enabled = false;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCutomerCode_TextChanged(object sender, EventArgs e)
        {
            if (dataSetCardex.Tables["Cardex"]!=null)
            {
                dataSetCardex.Tables["Cardex"].Rows.Clear();
            }
            lblCustomerName.Text = "äÇã ãÔÊÑí";
            string customerCode = "null";
            if (txtCustomerCode.Text != "")
            {
                customerCode = txtCustomerCode.Text;
            }
            string customerID = "";
            SqlCommand cmdCustomer = new SqlCommand("select * from Customer where Code=" + customerCode, myConnection);
            try
            {
                myConnection.Open();
                SqlDataReader dataReaderCustomer = cmdCustomer.ExecuteReader();
                dataReaderCustomer.Read();
                if (dataReaderCustomer.HasRows)
                {
                    customerID = dataReaderCustomer["CustomerID"].ToString();
                    lblCustomerName.Text = dataReaderCustomer["FirstName"].ToString() + " " + dataReaderCustomer["LastName"].ToString();
                }
                dataReaderCustomer.Close();

                if (customerID != "")
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from CustomerTransaction where CustomerID=" + customerID+" order by TransactionDate", myConnection);
                    dataAdapter.Fill(dataSetCardex, "Cardex");
                    gridCustomerTransaction.SetDataBinding(dataSetCardex, "Cardex");
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
            finally
            {
                myConnection.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }

        private void gridCustomerTransaction_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (e.Row.RowType == RowType.Record & e.Row.Cells.Count > 0)
            {
                DateTime dt = (DateTime)e.Row.Cells["TransactionDate"].Value;
                string persianDate =
                        "0".Substring(0, 2 - persianCalendar.GetHour(dt).ToString().Length) + persianCalendar.GetHour(dt).ToString() + ":" +
                        "0".Substring(0, 2 - persianCalendar.GetMinute(dt).ToString().Length) + persianCalendar.GetMinute(dt).ToString() + " " +
                        persianCalendar.GetYear(dt).ToString() + "/" +
                        "0".Substring(0, 2 - persianCalendar.GetMonth(dt).ToString().Length) + persianCalendar.GetMonth(dt).ToString() + "/" +
                        "0".Substring(0, 2 - persianCalendar.GetDayOfMonth(dt).ToString().Length) + persianCalendar.GetDayOfMonth(dt).ToString();
                e.Row.Cells["TransactionDate"].Text = persianDate;
            }

        }
    }
}

