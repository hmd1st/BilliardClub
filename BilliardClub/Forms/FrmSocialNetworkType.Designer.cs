namespace BilliardClub
{
    partial class FrmSocialNetworkType
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSocialNetworkType));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.gridSocialNetworkType = new Telerik.WinControls.UI.RadGridView();
            this.btnNo = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnYes = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridSocialNetworkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSocialNetworkType.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label1.Location = new System.Drawing.Point(426, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 90;
            this.label1.Text = "عنوان";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtTitle.Location = new System.Drawing.Point(162, 8);
            this.txtTitle.MaxLength = 30;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(255, 28);
            this.txtTitle.TabIndex = 83;
            this.txtTitle.Enter += new System.EventHandler(this.txtTitle_Enter);
            this.txtTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTitle_KeyDown);
            // 
            // gridSocialNetworkType
            // 
            this.gridSocialNetworkType.AutoSizeRows = true;
            this.gridSocialNetworkType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridSocialNetworkType.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridSocialNetworkType.Location = new System.Drawing.Point(0, 98);
            // 
            // 
            // 
            this.gridSocialNetworkType.MasterTemplate.AllowAddNewRow = false;
            this.gridSocialNetworkType.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gridSocialNetworkType.MasterTemplate.AllowColumnReorder = false;
            this.gridSocialNetworkType.MasterTemplate.AllowDeleteRow = false;
            this.gridSocialNetworkType.MasterTemplate.AllowDragToGroup = false;
            this.gridSocialNetworkType.MasterTemplate.AllowEditRow = false;
            this.gridSocialNetworkType.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.HeaderText = "ردیف";
            gridViewTextBoxColumn1.Name = "colCounter";
            gridViewTextBoxColumn1.Width = 41;
            this.gridSocialNetworkType.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.gridSocialNetworkType.MasterTemplate.EnableGrouping = false;
            this.gridSocialNetworkType.Name = "gridSocialNetworkType";
            this.gridSocialNetworkType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridSocialNetworkType.Size = new System.Drawing.Size(484, 263);
            this.gridSocialNetworkType.TabIndex = 89;
            this.gridSocialNetworkType.Text = "لیست عنوان شبکه های اجتماعی";
            this.gridSocialNetworkType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridSocialNetworkType_KeyDown);
            // 
            // btnNo
            // 
            this.btnNo.Enabled = false;
            this.btnNo.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.Location = new System.Drawing.Point(19, 54);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(84, 34);
            this.btnNo.TabIndex = 88;
            this.btnNo.Text = "خیر";
            this.btnNo.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnDelete.Image = global::BilliardClub.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(200, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 34);
            this.btnDelete.TabIndex = 86;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnYes
            // 
            this.btnYes.Enabled = false;
            this.btnYes.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnYes.Image = global::BilliardClub.Properties.Resources.yes;
            this.btnYes.Location = new System.Drawing.Point(109, 54);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(84, 34);
            this.btnYes.TabIndex = 87;
            this.btnYes.Text = "بلی";
            this.btnYes.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnEdit.Image = global::BilliardClub.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(290, 54);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 34);
            this.btnEdit.TabIndex = 85;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnSave.Image = global::BilliardClub.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(380, 54);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 34);
            this.btnSave.TabIndex = 84;
            this.btnSave.Text = "ذخیره";
            this.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Image = global::BilliardClub.Properties.Resources.Save;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Text = "ذخیره";
            // 
            // FrmSocialNetworkType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.gridSocialNetworkType);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmSocialNetworkType";
            this.Text = "ثبت عنوان شبکه های اجتماعی";
            this.Load += new System.EventHandler(this.FrmSocialNetworkType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSocialNetworkType.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSocialNetworkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private Telerik.WinControls.UI.RadGridView gridSocialNetworkType;
        private Telerik.WinControls.UI.RadButton btnNo;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnYes;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnSave;
    }
}