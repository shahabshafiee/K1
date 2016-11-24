using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Janus.Windows.GridEX;
using System.Globalization;


namespace KeyvanCRM
{
    
    public partial class frmCustomerList : KeyvanCRM.frmBase
    {
        PersianCalendar persianCalendar = new PersianCalendar();
        DataSet datasetCheck = new DataSet();
        SqlDataAdapter dataAdapter;
        public frmCustomerList()
        {
            InitializeComponent();
        }
        

        private void frmCheck_Load(object sender, EventArgs e)
        {
            myConnection.Open();
            dataAdapter = new SqlDataAdapter("Select * from Customer", myConnection);
            dataAdapter.Fill(datasetCheck, "Customer");
            gridEX1.SetDataBinding(datasetCheck, "Customer");
            gridEX1.RootTable.Columns["Balance"].EditType = EditType.NoEdit;
            gridEX1.RootTable.Columns["Code"].EditType = EditType.NoEdit;
            gridEX1.RootTable.Columns["LastPaymentDate"].EditType = EditType.NoEdit;
            myConnection.Close();
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCustomer newCustomer = new frmCustomer();
            newCustomer.MdiParent = this.MdiParent;
            newCustomer.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            try
            {
                myConnection.Open();
                dataAdapter.Update(datasetCheck, "Customer");
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridEX1_FormattingRow(object sender, RowLoadEventArgs e)
        {
            if (e.Row.RowType == RowType.Record & e.Row.Cells.Count > 0 & e.Row.Cells["LastPaymentDate"].Value.ToString()!="")
            {
                DateTime dt = (DateTime)e.Row.Cells["LastPaymentDate"].Value;
                string persianDate =
                        "0".Substring(0, 2 - persianCalendar.GetHour(dt).ToString().Length) + persianCalendar.GetHour(dt).ToString() + ":" +
                        "0".Substring(0, 2 - persianCalendar.GetMinute(dt).ToString().Length) + persianCalendar.GetMinute(dt).ToString() + " " +
                        persianCalendar.GetYear(dt).ToString() + "/" +
                        "0".Substring(0, 2 - persianCalendar.GetMonth(dt).ToString().Length) + persianCalendar.GetMonth(dt).ToString() + "/" +
                        "0".Substring(0, 2 - persianCalendar.GetDayOfMonth(dt).ToString().Length) + persianCalendar.GetDayOfMonth(dt).ToString();
                e.Row.Cells["LastPaymentDate"].Text = persianDate;
            }

        }
    }
}

