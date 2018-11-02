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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchType = new System.Windows.Forms.TextBox();
            this.gridMember = new Telerik.WinControls.UI.RadGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.cmbType);
            this.radGroupBox1.Controls.Add(this.btnSearch);
            this.radGroupBox1.Controls.Add(this.label7);
            this.radGroupBox1.Controls.Add(this.txtSearchType);
            this.radGroupBox1.Controls.Add(this.gridMember);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.HeaderText = "لیست اعضا";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox1.Size = new System.Drawing.Size(771, 249);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "لیست اعضا";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radGridView1);
            this.radGroupBox2.Controls.Add(this.comboBox1);
            this.radGroupBox2.Controls.Add(this.radButton1);
            this.radGroupBox2.Controls.Add(this.textBox1);
            this.radGroupBox2.Controls.Add(this.label1);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox2.HeaderText = "لیست صندوق";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 249);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox2.Size = new System.Drawing.Size(771, 202);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "لیست صندوق";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "کد عضویت",
            "شماره ملی",
            "نام خانوادگی"});
            this.cmbType.Location = new System.Drawing.Point(268, 27);
            this.cmbType.Name = "cmbType";
            this.cmbType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbType.Size = new System.Drawing.Size(118, 28);
            this.cmbType.TabIndex = 40;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.Location = new System.Drawing.Point(12, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 37);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "جستجو";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(392, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "جستجو بر اساس";
            // 
            // txtSearchType
            // 
            this.txtSearchType.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearchType.Location = new System.Drawing.Point(144, 27);
            this.txtSearchType.Name = "txtSearchType";
            this.txtSearchType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchType.Size = new System.Drawing.Size(118, 27);
            this.txtSearchType.TabIndex = 37;
            // 
            // gridMember
            // 
            this.gridMember.AutoSizeRows = true;
            this.gridMember.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridMember.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridMember.Location = new System.Drawing.Point(2, 64);
            // 
            // 
            // 
            this.gridMember.MasterTemplate.AllowAddNewRow = false;
            this.gridMember.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gridMember.MasterTemplate.AllowColumnReorder = false;
            this.gridMember.MasterTemplate.AllowDeleteRow = false;
            this.gridMember.MasterTemplate.AllowDragToGroup = false;
            this.gridMember.MasterTemplate.AllowEditRow = false;
            this.gridMember.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.HeaderText = "ردیف";
            gridViewTextBoxColumn1.Name = "colCounter";
            gridViewTextBoxColumn1.Width = 41;
            this.gridMember.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.gridMember.MasterTemplate.EnableGrouping = false;
            this.gridMember.Name = "gridMember";
            this.gridMember.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridMember.Size = new System.Drawing.Size(767, 183);
            this.gridMember.TabIndex = 36;
            this.gridMember.Text = "radGridView1";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "کد عضویت",
            "شماره ملی",
            "نام خانوادگی"});
            this.comboBox1.Location = new System.Drawing.Point(268, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(118, 28);
            this.comboBox1.TabIndex = 40;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radButton1.Location = new System.Drawing.Point(12, 21);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(126, 37);
            this.radButton1.TabIndex = 39;
            this.radButton1.Text = "جستجو";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(392, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "جستجو بر اساس";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(144, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(118, 27);
            this.textBox1.TabIndex = 37;
            // 
            // radGridView1
            // 
            this.radGridView1.AutoSizeRows = true;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGridView1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radGridView1.Location = new System.Drawing.Point(2, 64);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AllowDeleteRow = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            this.radGridView1.MasterTemplate.AllowEditRow = false;
            this.radGridView1.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn2.HeaderText = "ردیف";
            gridViewTextBoxColumn2.Name = "colCounter";
            gridViewTextBoxColumn2.Width = 41;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2});
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGridView1.Size = new System.Drawing.Size(767, 136);
            this.radGridView1.TabIndex = 36;
            this.radGridView1.Text = "radGridView1";
            // 
            // FrmMemberCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 561);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmMemberCabinet";
            this.Text = "FrmMemberCabinet";
            this.Load += new System.EventHandler(this.FrmMemberCabinet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private System.Windows.Forms.ComboBox cmbType;
        private Telerik.WinControls.UI.RadButton btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchType;
        private Telerik.WinControls.UI.RadGridView gridMember;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}