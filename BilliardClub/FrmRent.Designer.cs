namespace BilliardClub
{
    partial class FrmRent
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbPlayingBoardType = new System.Windows.Forms.ComboBox();
            this.lblDebt = new System.Windows.Forms.Label();
            this.lblPlayingBoardTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGameStart = new Telerik.WinControls.UI.RadButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchPlayingBoard = new System.Windows.Forms.TextBox();
            this.cmbSearchPlayingBoardBy = new System.Windows.Forms.ComboBox();
            this.gridPlayingBoard = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.cmbSearchMemberBy = new System.Windows.Forms.ComboBox();
            this.gridMember = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnGameStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayingBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayingBoard.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.label5.Location = new System.Drawing.Point(15, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "انتخاب نوع بازی";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("B Yekan", 12F);
            this.lblName.Location = new System.Drawing.Point(226, 435);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(282, 20);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "...";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPlayingBoardType
            // 
            this.cmbPlayingBoardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayingBoardType.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.cmbPlayingBoardType.FormattingEnabled = true;
            this.cmbPlayingBoardType.Items.AddRange(new object[] {
            "عنوان"});
            this.cmbPlayingBoardType.Location = new System.Drawing.Point(12, 469);
            this.cmbPlayingBoardType.Name = "cmbPlayingBoardType";
            this.cmbPlayingBoardType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPlayingBoardType.Size = new System.Drawing.Size(92, 28);
            this.cmbPlayingBoardType.TabIndex = 41;
            // 
            // lblDebt
            // 
            this.lblDebt.Font = new System.Drawing.Font("B Yekan", 12F);
            this.lblDebt.Location = new System.Drawing.Point(228, 468);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(280, 20);
            this.lblDebt.TabIndex = 46;
            this.lblDebt.Text = "...";
            this.lblDebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayingBoardTitle
            // 
            this.lblPlayingBoardTitle.Font = new System.Drawing.Font("B Yekan", 12F);
            this.lblPlayingBoardTitle.Location = new System.Drawing.Point(222, 501);
            this.lblPlayingBoardTitle.Name = "lblPlayingBoardTitle";
            this.lblPlayingBoardTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPlayingBoardTitle.Size = new System.Drawing.Size(286, 20);
            this.lblPlayingBoardTitle.TabIndex = 45;
            this.lblPlayingBoardTitle.Text = "...";
            this.lblPlayingBoardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(530, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "میز انتخابی";
            // 
            // btnGameStart
            // 
            this.btnGameStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGameStart.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnGameStart.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGameStart.Location = new System.Drawing.Point(12, 503);
            this.btnGameStart.Name = "btnGameStart";
            // 
            // 
            // 
            this.btnGameStart.RootElement.ControlBounds = new System.Drawing.Rectangle(12, 503, 110, 24);
            this.btnGameStart.Size = new System.Drawing.Size(92, 49);
            this.btnGameStart.TabIndex = 43;
            this.btnGameStart.Text = "شروع بازی";
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(530, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "میزان بدهی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(530, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "نام و نام خانوادگی";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.radGroupBox2.Controls.Add(this.label1);
            this.radGroupBox2.Controls.Add(this.txtSearchPlayingBoard);
            this.radGroupBox2.Controls.Add(this.cmbSearchPlayingBoardBy);
            this.radGroupBox2.Controls.Add(this.gridPlayingBoard);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox2.Font = new System.Drawing.Font("B Yekan", 12F);
            this.radGroupBox2.HeaderText = "انتخاب بازی";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 207);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radGroupBox2.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 207, 200, 100);
            this.radGroupBox2.Size = new System.Drawing.Size(634, 215);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "انتخاب بازی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label1.Location = new System.Drawing.Point(534, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "جستجو بر اساس";
            // 
            // txtSearchPlayingBoard
            // 
            this.txtSearchPlayingBoard.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtSearchPlayingBoard.Location = new System.Drawing.Point(259, 25);
            this.txtSearchPlayingBoard.Name = "txtSearchPlayingBoard";
            this.txtSearchPlayingBoard.Size = new System.Drawing.Size(144, 28);
            this.txtSearchPlayingBoard.TabIndex = 37;
            this.txtSearchPlayingBoard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchPlayingBoard.TextChanged += new System.EventHandler(this.txtSearchPlayingBoard_TextChanged);
            // 
            // cmbSearchPlayingBoardBy
            // 
            this.cmbSearchPlayingBoardBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchPlayingBoardBy.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.cmbSearchPlayingBoardBy.FormattingEnabled = true;
            this.cmbSearchPlayingBoardBy.Items.AddRange(new object[] {
            "عنوان"});
            this.cmbSearchPlayingBoardBy.Location = new System.Drawing.Point(409, 25);
            this.cmbSearchPlayingBoardBy.Name = "cmbSearchPlayingBoardBy";
            this.cmbSearchPlayingBoardBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearchPlayingBoardBy.Size = new System.Drawing.Size(118, 28);
            this.cmbSearchPlayingBoardBy.TabIndex = 36;
            // 
            // gridPlayingBoard
            // 
            this.gridPlayingBoard.AutoSizeRows = true;
            this.gridPlayingBoard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridPlayingBoard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPlayingBoard.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridPlayingBoard.Location = new System.Drawing.Point(2, 62);
            // 
            // 
            // 
            this.gridPlayingBoard.MasterTemplate.AllowAddNewRow = false;
            this.gridPlayingBoard.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gridPlayingBoard.MasterTemplate.AllowColumnReorder = false;
            this.gridPlayingBoard.MasterTemplate.AllowDeleteRow = false;
            this.gridPlayingBoard.MasterTemplate.AllowDragToGroup = false;
            this.gridPlayingBoard.MasterTemplate.AllowEditRow = false;
            this.gridPlayingBoard.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn1.HeaderText = "ردیف";
            gridViewTextBoxColumn1.Name = "colCounter";
            gridViewTextBoxColumn1.Width = 41;
            this.gridPlayingBoard.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.gridPlayingBoard.MasterTemplate.EnableGrouping = false;
            this.gridPlayingBoard.Name = "gridPlayingBoard";
            this.gridPlayingBoard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.gridPlayingBoard.RootElement.ControlBounds = new System.Drawing.Rectangle(2, 62, 240, 150);
            this.gridPlayingBoard.Size = new System.Drawing.Size(630, 151);
            this.gridPlayingBoard.TabIndex = 39;
            this.gridPlayingBoard.Text = "لیست میز‌ها";
            this.gridPlayingBoard.SelectionChanged += new System.EventHandler(this.gridPlayingBoard_SelectionChanged);
            this.gridPlayingBoard.DataBindingComplete += new Telerik.WinControls.UI.GridViewBindingCompleteEventHandler(this.gridPlayingBoard_DataBindingComplete);
            this.gridPlayingBoard.Click += new System.EventHandler(this.gridPlayingBoard_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.radGroupBox1.Controls.Add(this.label9);
            this.radGroupBox1.Controls.Add(this.txtSearchMember);
            this.radGroupBox1.Controls.Add(this.cmbSearchMemberBy);
            this.radGroupBox1.Controls.Add(this.gridMember);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("B Yekan", 12F);
            this.radGroupBox1.HeaderText = "انتخاب عضو";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radGroupBox1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 200, 100);
            this.radGroupBox1.Size = new System.Drawing.Size(634, 207);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "انتخاب عضو";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label9.Location = new System.Drawing.Point(533, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 21);
            this.label9.TabIndex = 40;
            this.label9.Text = "جستجو بر اساس";
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtSearchMember.Location = new System.Drawing.Point(259, 24);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(144, 28);
            this.txtSearchMember.TabIndex = 37;
            this.txtSearchMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchMember.TextChanged += new System.EventHandler(this.txtSearchMember_TextChanged);
            // 
            // cmbSearchMemberBy
            // 
            this.cmbSearchMemberBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchMemberBy.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.cmbSearchMemberBy.FormattingEnabled = true;
            this.cmbSearchMemberBy.Items.AddRange(new object[] {
            "کد مشتری",
            "نام و نام خانوادگی",
            "کد ملی"});
            this.cmbSearchMemberBy.Location = new System.Drawing.Point(409, 24);
            this.cmbSearchMemberBy.Name = "cmbSearchMemberBy";
            this.cmbSearchMemberBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearchMemberBy.Size = new System.Drawing.Size(118, 28);
            this.cmbSearchMemberBy.TabIndex = 36;
            // 
            // gridMember
            // 
            this.gridMember.AutoSizeRows = true;
            this.gridMember.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridMember.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridMember.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridMember.Location = new System.Drawing.Point(2, 58);
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
            gridViewTextBoxColumn2.HeaderText = "ردیف";
            gridViewTextBoxColumn2.Name = "colCounter";
            gridViewTextBoxColumn2.Width = 41;
            this.gridMember.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2});
            this.gridMember.MasterTemplate.EnableGrouping = false;
            this.gridMember.Name = "gridMember";
            this.gridMember.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.gridMember.RootElement.ControlBounds = new System.Drawing.Rectangle(2, 58, 240, 150);
            this.gridMember.Size = new System.Drawing.Size(630, 147);
            this.gridMember.TabIndex = 39;
            this.gridMember.Text = "لیست اعضا";
            this.gridMember.DataBindingComplete += new Telerik.WinControls.UI.GridViewBindingCompleteEventHandler(this.gridMember_DataBindingComplete);
            this.gridMember.Click += new System.EventHandler(this.gridMember_Click);
            // 
            // FrmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbPlayingBoardType);
            this.Controls.Add(this.lblDebt);
            this.Controls.Add(this.lblPlayingBoardTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGameStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmRent";
            this.Text = "اجاره میز بازی";
            this.Load += new System.EventHandler(this.FrmRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnGameStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayingBoard.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayingBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView gridMember;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSearchMemberBy;
        private System.Windows.Forms.TextBox txtSearchMember;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchPlayingBoard;
        private System.Windows.Forms.ComboBox cmbSearchPlayingBoardBy;
        private Telerik.WinControls.UI.RadGridView gridPlayingBoard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadButton btnGameStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayingBoardTitle;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPlayingBoardType;
    }
}