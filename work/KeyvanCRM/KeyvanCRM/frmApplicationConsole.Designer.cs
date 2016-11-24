namespace KeyvanCRM
{
    partial class frmApplicationConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Janus.Windows.ExplorerBar.ExplorerBarGroup explorerBarGroup1 = new Janus.Windows.ExplorerBar.ExplorerBarGroup();
            Janus.Windows.ExplorerBar.ExplorerBarItem explorerBarItem1 = new Janus.Windows.ExplorerBar.ExplorerBarItem();
            Janus.Windows.ExplorerBar.ExplorerBarItem explorerBarItem2 = new Janus.Windows.ExplorerBar.ExplorerBarItem();
            Janus.Windows.ExplorerBar.ExplorerBarItem explorerBarItem3 = new Janus.Windows.ExplorerBar.ExplorerBarItem();
            Janus.Windows.ExplorerBar.ExplorerBarItem explorerBarItem4 = new Janus.Windows.ExplorerBar.ExplorerBarItem();
            Janus.Windows.ExplorerBar.ExplorerBarItem explorerBarItem5 = new Janus.Windows.ExplorerBar.ExplorerBarItem();
            this.explorerBar1 = new Janus.Windows.ExplorerBar.ExplorerBar();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // visualStyleManager1
            // 
            this.visualStyleManager1.DefaultColorScheme = "Scheme2";
            // 
            // explorerBar1
            // 
            this.explorerBar1.Dock = System.Windows.Forms.DockStyle.Right;
            explorerBarItem1.Key = "ItemNewCustomer";
            explorerBarItem1.Text = "„‘ —Ì ÃœÌœ";
            explorerBarItem2.Key = "ItemNewSale";
            explorerBarItem2.Text = "›—Ê‘";
            explorerBarItem3.Key = "ItemNewRecieve";
            explorerBarItem3.Text = "œ—Ì«› ";
            explorerBarItem4.Key = "ItemCardex";
            explorerBarItem4.Text = "ﬂ«—  „⁄Ì‰";
            explorerBarItem5.Key = "ItemCheck";
            explorerBarItem5.Text = "çò";
            explorerBarGroup1.Items.AddRange(new Janus.Windows.ExplorerBar.ExplorerBarItem[] {
            explorerBarItem1,
            explorerBarItem2,
            explorerBarItem3,
            explorerBarItem4,
            explorerBarItem5});
            explorerBarGroup1.Key = "Group1";
            explorerBarGroup1.Text = "„‰ÊÌ »—‰«„Â";
            this.explorerBar1.Groups.AddRange(new Janus.Windows.ExplorerBar.ExplorerBarGroup[] {
            explorerBarGroup1});
            this.explorerBar1.Location = new System.Drawing.Point(590, 0);
            this.explorerBar1.Name = "explorerBar1";
            this.explorerBar1.Size = new System.Drawing.Size(208, 507);
            this.explorerBar1.TabIndex = 3;
            this.explorerBar1.Text = "explorerBar1";
            this.explorerBar1.VisualStyleManager = this.visualStyleManager1;
            this.explorerBar1.ItemClick += new Janus.Windows.ExplorerBar.ItemEventHandler(this.explorerBar1_ItemClick);
            // 
            // frmApplicationConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(798, 507);
            this.Controls.Add(this.explorerBar1);
            this.IsMdiContainer = true;
            this.Name = "frmApplicationConsole";
            this.Text = "Õ«Ã Õ”Ì‰ ‘»«‰Ì";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.explorerBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.ExplorerBar.ExplorerBar explorerBar1;

    }
}
