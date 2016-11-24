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
    public partial class frmStatus : KeyvanCRM.frmBase
    {
        public frmStatus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = "Insert into CustomerStatus (CustomerStatusName) values('" + textBox1.Text + "')";
            SqlCommand myCommand = new SqlCommand(cmd,myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Text = "Kamal";
        }
    }
}

