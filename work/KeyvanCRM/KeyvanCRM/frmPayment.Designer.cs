namespace KeyvanCRM {     partial class frmPayment     {         /// <summary>         /// Required designer variable.         /// </summary>         private System.ComponentModel.IContainer components = null;          /// <summary>         /// Clean up any resources being used.         /// </summary>         /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>         protected override void Dispose(bool disposing)         {             if (disposing && (components != null))             {                 components.Dispose();             }             base.Dispose(disposing);         }          #region Windows Form Designer generated code          /// <summary>         /// Required method for Designer support - do not modify         /// the contents of this method with the code editor.         /// </summary>         private void InitializeComponent()         {
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.btnCardex = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPurchase = new System.Windows.Forms.GroupBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPurchaseAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelButton.SuspendLayout();
            this.groupBoxCustomer.SuspendLayout();
            this.groupBoxPurchase.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnCancel);
            this.panelButton.Controls.Add(this.btnOK);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 178);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(392, 45);
            this.panelButton.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(224, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(305, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "ذخيره";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.btnCardex);
            this.groupBoxCustomer.Controls.Add(this.lblCustomerName);
            this.groupBoxCustomer.Controls.Add(this.txtCustomerCode);
            this.groupBoxCustomer.Controls.Add(this.label1);
            this.groupBoxCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCustomer.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(392, 70);
            this.groupBoxCustomer.TabIndex = 0;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "مشتري";
            // 
            // btnCardex
            // 
            this.btnCardex.Location = new System.Drawing.Point(6, 12);
            this.btnCardex.Name = "btnCardex";
            this.btnCardex.Size = new System.Drawing.Size(75, 23);
            this.btnCardex.TabIndex = 1;
            this.btnCardex.Text = "كارت معين";
            this.btnCardex.UseVisualStyleBackColor = true;
            this.btnCardex.Click += new System.EventHandler(this.btnCardex_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCustomerName.Location = new System.Drawing.Point(87, 17);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(125, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "نام مشتري";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerCode.Location = new System.Drawing.Point(218, 12);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(100, 21);
            this.txtCustomerCode.TabIndex = 0;
            this.txtCustomerCode.TextChanged += new System.EventHandler(this.txtCustomerCode_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(324, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "كد مشتري:";
            // 
            // groupBoxPurchase
            // 
            this.groupBoxPurchase.Controls.Add(this.txtComment);
            this.groupBoxPurchase.Controls.Add(this.label3);
            this.groupBoxPurchase.Controls.Add(this.txtPurchaseAmount);
            this.groupBoxPurchase.Controls.Add(this.label2);
            this.groupBoxPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPurchase.Location = new System.Drawing.Point(0, 70);
            this.groupBoxPurchase.Name = "groupBoxPurchase";
            this.groupBoxPurchase.Size = new System.Drawing.Size(392, 108);
            this.groupBoxPurchase.TabIndex = 1;
            this.groupBoxPurchase.TabStop = false;
            this.groupBoxPurchase.Text = "پرداخت";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.Location = new System.Drawing.Point(6, 47);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(312, 55);
            this.txtComment.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "توضيحات:";
            // 
            // txtPurchaseAmount
            // 
            this.txtPurchaseAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPurchaseAmount.Location = new System.Drawing.Point(218, 20);
            this.txtPurchaseAmount.Name = "txtPurchaseAmount";
            this.txtPurchaseAmount.Size = new System.Drawing.Size(100, 21);
            this.txtPurchaseAmount.TabIndex = 0;
            this.txtPurchaseAmount.TextChanged += new System.EventHandler(this.txtPurchaseAmount_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "مبلغ پرداخت:";
            // 
            // frmPayment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(392, 223);
            this.Controls.Add(this.groupBoxPurchase);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.panelButton);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "frmPayment";
            this.Text = "پرداخت";
            this.panelButton.ResumeLayout(false);
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.groupBoxPurchase.ResumeLayout(false);
            this.groupBoxPurchase.PerformLayout();
            this.ResumeLayout(false);

        }          #endregion          private System.Windows.Forms.Panel panelButton;         private System.Windows.Forms.GroupBox groupBoxCustomer;         private System.Windows.Forms.GroupBox groupBoxPurchase;         private System.Windows.Forms.Button btnCancel;         private System.Windows.Forms.Button btnOK;         private System.Windows.Forms.Button btnCardex;         private System.Windows.Forms.Label lblCustomerName;         private System.Windows.Forms.TextBox txtCustomerCode;         private System.Windows.Forms.Label label1;         private System.Windows.Forms.TextBox txtComment;         private System.Windows.Forms.Label label3;         private System.Windows.Forms.TextBox txtPurchaseAmount;
        private System.Windows.Forms.Label label2;     } } 