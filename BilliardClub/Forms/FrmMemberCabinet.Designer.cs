namespace BilliardClub
{
    partial class FrmMemberCabinet
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
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.gridCabinetAvailables = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.btnMemberCabinetList = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCabinetAvailables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCabinetAvailables.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMemberCabinetList)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.gridCabinetAvailables);
            this.radGroupBox2.Controls.Add(this.radButton1);
            this.radGroupBox2.Controls.Add(this.txtSearch);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGroupBox2.HeaderText = "لیست صندوق های در دسترس";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 153);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox2.Size = new System.Drawing.Size(676, 274);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "لیست صندوق های در دسترس";
            // 
            // gridCabinetAvailables
            // 
            this.gridCabinetAvailables.AutoSizeRows = true;
            this.gridCabinetAvailables.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridCabinetAvailables.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridCabinetAvailables.Location = new System.Drawing.Point(2, 60);
            // 
            // 
            // 
            this.gridCabinetAvailables.MasterTemplate.AllowAddNewRow = false;
            this.gridCabinetAvailables.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gridCabinetAvailables.MasterTemplate.AllowColumnReorder = false;
            this.gridCabinetAvailables.MasterTemplate.AllowDeleteRow = false;
            this.gridCabinetAvailables.MasterTemplate.AllowDragToGroup = false;
            this.gridCabinetAvailables.MasterTemplate.AllowEditRow = false;
            this.gridCabinetAvailables.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.HeaderText = "ردیف";
            gridViewTextBoxColumn1.Name = "colCounter";
            gridViewTextBoxColumn1.Width = 41;
            this.gridCabinetAvailables.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.gridCabinetAvailables.MasterTemplate.EnableGrouping = false;
            this.gridCabinetAvailables.Name = "gridCabinetAvailables";
            this.gridCabinetAvailables.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridCabinetAvailables.Size = new System.Drawing.Size(672, 212);
            this.gridCabinetAvailables.TabIndex = 36;
            this.gridCabinetAvailables.Text = "لیست صندوقهای در دسترس";
            this.gridCabinetAvailables.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.gridCabinetAvailables_ContextMenuOpening);
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radButton1.Location = new System.Drawing.Point(12, 27);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(82, 27);
            this.radButton1.TabIndex = 39;
            this.radButton1.Text = "جستجو";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(100, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(201, 27);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.Font = new System.Drawing.Font("B Yekan", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblName.Location = new System.Drawing.Point(375, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(289, 67);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "...";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmit.Location = new System.Drawing.Point(200, 120);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(101, 27);
            this.btnSubmit.TabIndex = 40;
            this.btnSubmit.Text = "اختصاص صندوق";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnMemberCabinetList
            // 
            this.btnMemberCabinetList.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMemberCabinetList.Location = new System.Drawing.Point(2, 120);
            this.btnMemberCabinetList.Name = "btnMemberCabinetList";
            this.btnMemberCabinetList.Size = new System.Drawing.Size(192, 27);
            this.btnMemberCabinetList.TabIndex = 41;
            this.btnMemberCabinetList.Text = "مدیریت صندوق های اختصاص یافته";
            this.btnMemberCabinetList.Click += new System.EventHandler(this.btnMemberCabinetList_Click);
            // 
            // FrmMemberCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 427);
            this.Controls.Add(this.btnMemberCabinetList);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.radGroupBox2);
            this.Name = "FrmMemberCabinet";
            this.Text = "اختصاص صندوق امانات";
            this.Load += new System.EventHandler(this.FrmMemberCabinet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCabinetAvailables.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCabinetAvailables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMemberCabinetList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGridView gridCabinetAvailables;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblName;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private Telerik.WinControls.UI.RadButton btnMemberCabinetList;
    }
}