using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KeyvanCRM
{
    public partial class frmApplicationConsole : KeyvanCRM.frmBase
    {
        public frmApplicationConsole()
        {
            InitializeComponent();
        }

        private void explorerBar1_ItemClick(object sender, Janus.Windows.ExplorerBar.ItemEventArgs e)
        {
            switch (e.Item.Key)
            {
                case "ItemNewCustomer":
                    frmCustomer newCustomer = new frmCustomer();
                    newCustomer.MdiParent = this;
                    newCustomer.Show();
                    break;
                case "ItemNewSale":
                    frmPurchase newSale = new frmPurchase();
                    newSale.MdiParent = this;
                    newSale.Show();
                    break;
                case "ItemNewRecieve":
                    frmPayment newRecieve = new frmPayment();
                    newRecieve.MdiParent = this;
                    newRecieve.Show();
                    break;
                case "ItemCardex":
                    frmCardex cardex = new frmCardex();
                    cardex.MdiParent = this;
                    cardex.Show();
                    break;
                case "ItemCheck":
                    frmCustomerList NewCheck = new frmCustomerList();
                    NewCheck.MdiParent= this;
                    NewCheck.Show();
                    break;
                default:
                    break;
            }
        }
    }
}

