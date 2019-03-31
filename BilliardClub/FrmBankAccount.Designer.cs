namespace BilliardClub
{
    partial class FrmBankAccount
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankAccount));
            this.label2 = new System.Windows.Forms.Label();
            this.کنترلبرقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعیینبهاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBankTitle = new System.Windows.Forms.TextBox();
            this.gridBankAccount = new Telerik.WinControls.UI.RadGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNo = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnYes = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridBankAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBankAccount.MasterTemplate)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label2.Location = new System.Drawing.Point(571, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 120;
            this.label2.Text = "عنوان بانک";
            // 
            // کنترلبرقToolStripMenuItem
            // 
            this.کنترلبرقToolStripMenuItem.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.کنترلبرقToolStripMenuItem.Name = "کنترلبرقToolStripMenuItem";
            this.کنترلبرقToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.کنترلبرقToolStripMenuItem.Text = "کنترل برق";
            // 
            // تعیینبهاءToolStripMenuItem
            // 
            this.تعیینبهاءToolStripMenuItem.Name = "تعیینبهاءToolStripMenuItem";
            this.تعیینبهاءToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.تعیینبهاءToolStripMenuItem.Text = "تعیین بهاء";
            // 
            // txtBankTitle
            // 
            this.txtBankTitle.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtBankTitle.Location = new System.Drawing.Point(373, 12);
            this.txtBankTitle.MaxLength = 30;
            this.txtBankTitle.Name = "txtBankTitle";
            this.txtBankTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBankTitle.Size = new System.Drawing.Size(192, 28);
            this.txtBankTitle.TabIndex = 0;
            this.txtBankTitle.Enter += new System.EventHandler(this.txtBankTitle_Enter);
            // 
            // gridBankAccount
            // 
            this.gridBankAccount.AutoSizeRows = true;
            this.gridBankAccount.ContextMenuStrip = this.contextMenuStrip1;
            this.gridBankAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridBankAccount.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridBankAccount.Location = new System.Drawing.Point(0, 171);
            // 
            // 
            // 
            this.gridBankAccount.MasterTemplate.AllowAddNewRow = false;
            this.gridBankAccount.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gridBankAccount.MasterTemplate.AllowColumnReorder = false;
            this.gridBankAccount.MasterTemplate.AllowDeleteRow = false;
            this.gridBankAccount.MasterTemplate.AllowDragToGroup = false;
            this.gridBankAccount.MasterTemplate.AllowEditRow = false;
            this.gridBankAccount.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.HeaderText = "ردیف";
            gridViewTextBoxColumn1.Name = "colCounter";
            gridViewTextBoxColumn1.Width = 41;
            this.gridBankAccount.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.gridBankAccount.MasterTemplate.EnableGrouping = false;
            this.gridBankAccount.Name = "gridBankAccount";
            this.gridBankAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridBankAccount.Size = new System.Drawing.Size(655, 231);
            this.gridBankAccount.TabIndex = 8;
            this.gridBankAccount.Text = "لیست شماره حساب ها";
            this.gridBankAccount.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.gridBankAccount_ContextMenuOpening);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعیینبهاءToolStripMenuItem,
            this.کنترلبرقToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 52);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label1.Location = new System.Drawing.Point(571, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 122;
            this.label1.Text = "شماره حساب";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtAccountNumber.Location = new System.Drawing.Point(373, 46);
            this.txtAccountNumber.MaxLength = 30;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAccountNumber.Size = new System.Drawing.Size(192, 28);
            this.txtAccountNumber.TabIndex = 1;
            this.txtAccountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label3.Location = new System.Drawing.Point(571, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 124;
            this.label3.Text = "شماره کارت";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtCardNumber.Location = new System.Drawing.Point(373, 80);
            this.txtCardNumber.MaxLength = 30;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCardNumber.Size = new System.Drawing.Size(192, 28);
            this.txtCardNumber.TabIndex = 2;
            this.txtCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardNumber_KeyDown);
            this.txtCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardNumber_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilliardClub.Properties.Resources.pos;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 125;
            this.pictureBox1.TabStop = false;
            // 
            // btnNo
            // 
            this.btnNo.Enabled = false;
            this.btnNo.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.Location = new System.Drawing.Point(12, 131);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(84, 34);
            this.btnNo.TabIndex = 7;
            this.btnNo.Text = "خیر";
            this.btnNo.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnDelete.Image = global::BilliardClub.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(193, 131);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnYes
            // 
            this.btnYes.Enabled = false;
            this.btnYes.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnYes.Image = global::BilliardClub.Properties.Resources.yes;
            this.btnYes.Location = new System.Drawing.Point(102, 131);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(84, 34);
            this.btnYes.TabIndex = 6;
            this.btnYes.Text = "بلی";
            this.btnYes.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnEdit.Image = global::BilliardClub.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(283, 131);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 34);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnSave.Image = global::BilliardClub.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(373, 131);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "ذخیره";
            this.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Image = global::BilliardClub.Properties.Resources.Save;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Text = "ذخیره";
            // 
            // FrmBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBankTitle);
            this.Controls.Add(this.gridBankAccount);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmBankAccount";
            this.Text = "ثبت شماره حساب";
            this.Load += new System.EventHandler(this.FrmBankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBankAccount.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBankAccount)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem کنترلبرقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعیینبهاءToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBankTitle;
        private Telerik.WinControls.UI.RadGridView gridBankAccount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Telerik.WinControls.UI.RadButton btnNo;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnYes;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}