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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.cmbSearchMemberBy = new System.Windows.Forms.ComboBox();
            this.gridMember = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.txtSearchPlayingBoard = new System.Windows.Forms.TextBox();
            this.cmbSearchPlayingBoardBy = new System.Windows.Forms.ComboBox();
            this.gridPlayingBoard = new Telerik.WinControls.UI.RadGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGameStart = new Telerik.WinControls.UI.RadButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayingBoardTitle = new System.Windows.Forms.Label();
            this.lblDebt = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayingBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayingBoard.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGameStart)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.radGroupBox1.Controls.Add(this.label9);
            this.radGroupBox1.Controls.Add(this.btnSave);
            this.radGroupBox1.Controls.Add(this.txtSearchMember);
            this.radGroupBox1.Controls.Add(this.cmbSearchMemberBy);
            this.radGroupBox1.Controls.Add(this.gridMember);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox1.HeaderText = "اعضا";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radGroupBox1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 200, 100);
            this.radGroupBox1.Size = new System.Drawing.Size(634, 207);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "اعضا";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(533, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "جستجو بر اساس";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnSave.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(12, 24);
            this.btnSave.Name = "btnSave";
            // 
            // 
            // 
            this.btnSave.RootElement.ControlBounds = new System.Drawing.Rectangle(12, 24, 110, 24);
            this.btnSave.Size = new System.Drawing.Size(123, 28);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "انتخاب";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            gridViewTextBoxColumn1.HeaderText = "ردیف";
            gridViewTextBoxColumn1.Name = "colCounter";
            gridViewTextBoxColumn1.Width = 41;
            this.gridMember.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
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
            this.gridMember.Click += new System.EventHandler(this.gridMember_Click);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.radGroupBox2.Controls.Add(this.label1);
            this.radGroupBox2.Controls.Add(this.radButton1);
            this.radGroupBox2.Controls.Add(this.txtSearchPlayingBoard);
            this.radGroupBox2.Controls.Add(this.cmbSearchPlayingBoardBy);
            this.radGroupBox2.Controls.Add(this.gridPlayingBoard);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox2.HeaderText = "میزها";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 207);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radGroupBox2.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 207, 200, 100);
            this.radGroupBox2.Size = new System.Drawing.Size(634, 226);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "میزها";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(533, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "جستجو بر اساس";
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radButton1.Font = new System.Drawing.Font("B Yekan", 10F);
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radButton1.Location = new System.Drawing.Point(12, 24);
            this.radButton1.Name = "radButton1";
            // 
            // 
            // 
            this.radButton1.RootElement.ControlBounds = new System.Drawing.Rectangle(12, 24, 110, 24);
            this.radButton1.Size = new System.Drawing.Size(123, 28);
            this.radButton1.TabIndex = 38;
            this.radButton1.Text = "انتخاب";
            // 
            // txtSearchPlayingBoard
            // 
            this.txtSearchPlayingBoard.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtSearchPlayingBoard.Location = new System.Drawing.Point(259, 24);
            this.txtSearchPlayingBoard.Name = "txtSearchPlayingBoard";
            this.txtSearchPlayingBoard.Size = new System.Drawing.Size(144, 28);
            this.txtSearchPlayingBoard.TabIndex = 37;
            this.txtSearchPlayingBoard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbSearchPlayingBoardBy
            // 
            this.cmbSearchPlayingBoardBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchPlayingBoardBy.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.cmbSearchPlayingBoardBy.FormattingEnabled = true;
            this.cmbSearchPlayingBoardBy.Items.AddRange(new object[] {
            "عنوان"});
            this.cmbSearchPlayingBoardBy.Location = new System.Drawing.Point(409, 24);
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
            this.gridPlayingBoard.Location = new System.Drawing.Point(2, 61);
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
            gridViewTextBoxColumn2.HeaderText = "ردیف";
            gridViewTextBoxColumn2.Name = "colCounter";
            gridViewTextBoxColumn2.Width = 41;
            this.gridPlayingBoard.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2});
            this.gridPlayingBoard.MasterTemplate.EnableGrouping = false;
            this.gridPlayingBoard.Name = "gridPlayingBoard";
            this.gridPlayingBoard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.gridPlayingBoard.RootElement.ControlBounds = new System.Drawing.Rectangle(2, 61, 240, 150);
            this.gridPlayingBoard.Size = new System.Drawing.Size(630, 163);
            this.gridPlayingBoard.TabIndex = 39;
            this.gridPlayingBoard.Text = "لیست میز‌ها";
            this.gridPlayingBoard.Click += new System.EventHandler(this.gridPlayingBoard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(494, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "نام و نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(494, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "میزان بدهی";
            // 
            // btnGameStart
            // 
            this.btnGameStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGameStart.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnGameStart.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGameStart.Location = new System.Drawing.Point(12, 555);
            this.btnGameStart.Name = "btnGameStart";
            // 
            // 
            // 
            this.btnGameStart.RootElement.ControlBounds = new System.Drawing.Rectangle(12, 555, 110, 24);
            this.btnGameStart.Size = new System.Drawing.Size(134, 34);
            this.btnGameStart.TabIndex = 43;
            this.btnGameStart.Text = "شروع بازی";
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(494, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "میز انتخابی";
            // 
            // lblPlayingBoardTitle
            // 
            this.lblPlayingBoardTitle.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPlayingBoardTitle.Location = new System.Drawing.Point(166, 511);
            this.lblPlayingBoardTitle.Name = "lblPlayingBoardTitle";
            this.lblPlayingBoardTitle.Size = new System.Drawing.Size(306, 20);
            this.lblPlayingBoardTitle.TabIndex = 45;
            this.lblPlayingBoardTitle.Text = "...";
            this.lblPlayingBoardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDebt
            // 
            this.lblDebt.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDebt.Location = new System.Drawing.Point(166, 478);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(306, 20);
            this.lblDebt.TabIndex = 46;
            this.lblDebt.Text = "...";
            this.lblDebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.Location = new System.Drawing.Point(166, 445);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(306, 20);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "...";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 601);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDebt);
            this.Controls.Add(this.lblPlayingBoardTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGameStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmRent";
            this.Text = "اجاره";
            this.Load += new System.EventHandler(this.FrmRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayingBoard.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayingBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGameStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadGridView gridMember;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSearchMemberBy;
        private System.Windows.Forms.TextBox txtSearchMember;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton radButton1;
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
    }
}