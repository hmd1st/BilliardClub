namespace BilliardClub
{
    partial class FrmMembersCabinetsManagement
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
        /// Required method for Designer support - do not modifytxtsearch
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gridCabinetMembers = new Telerik.WinControls.UI.RadGridView();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCabinetMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCabinetMembers.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtSearch.Location = new System.Drawing.Point(100, 12);
            this.txtSearch.MaxLength = 30;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(146, 28);
            this.txtSearch.TabIndex = 67;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // gridCabinetMembers
            // 
            this.gridCabinetMembers.AutoSizeRows = true;
            this.gridCabinetMembers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridCabinetMembers.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridCabinetMembers.Location = new System.Drawing.Point(0, 48);
            // 
            // 
            // 
            this.gridCabinetMembers.MasterTemplate.AllowAddNewRow = false;
            this.gridCabinetMembers.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gridCabinetMembers.MasterTemplate.AllowColumnReorder = false;
            this.gridCabinetMembers.MasterTemplate.AllowDeleteRow = false;
            this.gridCabinetMembers.MasterTemplate.AllowDragToGroup = false;
            this.gridCabinetMembers.MasterTemplate.AllowEditRow = false;
            this.gridCabinetMembers.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.HeaderText = "ردیف";
            gridViewTextBoxColumn1.Name = "colCounter";
            gridViewTextBoxColumn1.Width = 41;
            this.gridCabinetMembers.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.gridCabinetMembers.MasterTemplate.EnableGrouping = false;
            this.gridCabinetMembers.Name = "gridCabinetMembers";
            this.gridCabinetMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridCabinetMembers.Size = new System.Drawing.Size(470, 348);
            this.gridCabinetMembers.TabIndex = 73;
            this.gridCabinetMembers.Text = "لیست صندوق امانات اختصاص یافته";
            this.gridCabinetMembers.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.gridCabinetMembers_ContextMenuOpening);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnDelete.Image = global::BilliardClub.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(12, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 28);
            this.btnDelete.TabIndex = 72;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "عضو",
            "صندوق امانت"});
            this.cmbSearchBy.Location = new System.Drawing.Point(252, 12);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearchBy.Size = new System.Drawing.Size(107, 28);
            this.cmbSearchBy.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(365, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "جستجو بر اساس:";
            // 
            // FrmMembersCabinetsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.gridCabinetMembers);
            this.Controls.Add(this.btnDelete);
            this.Name = "FrmMembersCabinetsManagement";
            this.Text = "مدیریت صندوق های اختصاص یافته";
            this.Load += new System.EventHandler(this.FrmMembersCabinetsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCabinetMembers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCabinetMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private Telerik.WinControls.UI.RadGridView gridCabinetMembers;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label label1;
    }
}