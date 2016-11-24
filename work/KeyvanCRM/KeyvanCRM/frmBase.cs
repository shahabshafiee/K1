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
    public partial class frmBase : Form
    {
        protected SqlConnection myConnection;
        public frmBase()
        {
            InitializeComponent();
            myConnection = new SqlConnection("Server=.;Database=KeyvanCRM;Trusted_Connection=true");
        }
    }
}