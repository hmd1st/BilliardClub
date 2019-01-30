namespace BilliardClub
{
    partial class FrmClosePlayingBoard
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radioOther = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.radioMySelf = new System.Windows.Forms.RadioButton();
            this.btnSelect = new Telerik.WinControls.UI.RadButton();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.cmbSearchMemberBy = new System.Windows.Forms.ComboBox();
            this.gridMember = new Telerik.WinControls.UI.RadGridView();
            this.lblPayment = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayingBorad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMemberRenter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.radGroupBox1.Controls.Add(this.radioOther);
            this.radGroupBox1.Controls.Add(this.label9);
            this.radGroupBox1.Controls.Add(this.radioMySelf);
            this.radGroupBox1.Controls.Add(this.btnSelect);
            this.radGroupBox1.Controls.Add(this.txtSearchMember);
            this.radGroupBox1.Controls.Add(this.cmbSearchMemberBy);
            this.radGroupBox1.Controls.Add(this.gridMember);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGroupBox1.Font = new System.Drawing.Font("B Yekan", 12F);
            this.radGroupBox1.HeaderText = "حساب کننده";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 222);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radGroupBox1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 222, 200, 100);
            this.radGroupBox1.Size = new System.Drawing.Size(704, 304);
            this.radGroupBox1.TabIndex = 9;
            this.radGroupBox1.Text = "حساب کننده";
            // 
            // radioOther
            // 
            this.radioOther.AutoSize = true;
            this.radioOther.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioOther.Location = new System.Drawing.Point(520, 36);
            this.radioOther.Name = "radioOther";
            this.radioOther.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioOther.Size = new System.Drawing.Size(81, 24);
            this.radioOther.TabIndex = 41;
            this.radioOther.TabStop = true;
            this.radioOther.Text = "شخص ثالث";
            this.radioOther.UseVisualStyleBackColor = true;
            this.radioOther.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(374, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "جستجو بر اساس";
            // 
            // radioMySelf
            // 
            this.radioMySelf.AutoSize = true;
            this.radioMySelf.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioMySelf.Location = new System.Drawing.Point(623, 36);
            this.radioMySelf.Name = "radioMySelf";
            this.radioMySelf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioMySelf.Size = new System.Drawing.Size(53, 24);
            this.radioMySelf.TabIndex = 8;
            this.radioMySelf.TabStop = true;
            this.radioMySelf.Text = "خودم";
            this.radioMySelf.UseVisualStyleBackColor = true;
            this.radioMySelf.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelect.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnSelect.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.Location = new System.Drawing.Point(12, 34);
            this.btnSelect.Name = "btnSelect";
            // 
            // 
            // 
            this.btnSelect.RootElement.ControlBounds = new System.Drawing.Rectangle(12, 34, 110, 24);
            this.btnSelect.Size = new System.Drawing.Size(56, 28);
            this.btnSelect.TabIndex = 38;
            this.btnSelect.Text = "انتخاب";
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtSearchMember.Location = new System.Drawing.Point(74, 34);
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
            this.cmbSearchMemberBy.Location = new System.Drawing.Point(224, 34);
            this.cmbSearchMemberBy.Name = "cmbSearchMemberBy";
            this.cmbSearchMemberBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearchMemberBy.Size = new System.Drawing.Size(144, 28);
            this.cmbSearchMemberBy.TabIndex = 36;
            // 
            // gridMember
            // 
            this.gridMember.AutoSizeRows = true;
            this.gridMember.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridMember.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridMember.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridMember.Location = new System.Drawing.Point(2, 68);
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
            gridViewTextBoxColumn3.HeaderText = "ردیف";
            gridViewTextBoxColumn3.Name = "colCounter";
            gridViewTextBoxColumn3.Width = 41;
            this.gridMember.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3});
            this.gridMember.MasterTemplate.EnableGrouping = false;
            this.gridMember.Name = "gridMember";
            this.gridMember.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.gridMember.RootElement.ControlBounds = new System.Drawing.Rectangle(2, 68, 240, 150);
            this.gridMember.Size = new System.Drawing.Size(700, 234);
            this.gridMember.TabIndex = 39;
            this.gridMember.Text = "لیست اعضا";
            // 
            // lblPayment
            // 
            this.lblPayment.Font = new System.Drawing.Font("B Yekan", 12F);
            this.lblPayment.Location = new System.Drawing.Point(285, 174);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPayment.Size = new System.Drawing.Size(255, 54);
            this.lblPayment.TabIndex = 7;
            this.lblPayment.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Yekan", 12F);
            this.label6.Location = new System.Drawing.Point(582, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "مبلغ پرداختی";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.Font = new System.Drawing.Font("B Yekan", 12F);
            this.lblElapsedTime.Location = new System.Drawing.Point(285, 117);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblElapsedTime.Size = new System.Drawing.Size(255, 54);
            this.lblElapsedTime.TabIndex = 5;
            this.lblElapsedTime.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 12F);
            this.label4.Location = new System.Drawing.Point(582, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "میزان استفاده";
            // 
            // lblPlayingBorad
            // 
            this.lblPlayingBorad.Font = new System.Drawing.Font("B Yekan", 12F);
            this.lblPlayingBorad.Location = new System.Drawing.Point(285, 61);
            this.lblPlayingBorad.Name = "lblPlayingBorad";
            this.lblPlayingBorad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPlayingBorad.Size = new System.Drawing.Size(255, 54);
            this.lblPlayingBorad.TabIndex = 3;
            this.lblPlayingBorad.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 12F);
            this.label2.Location = new System.Drawing.Point(582, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام دستگاه";
            // 
            // lblMemberRenter
            // 
            this.lblMemberRenter.Font = new System.Drawing.Font("B Yekan", 12F);
            this.lblMemberRenter.Location = new System.Drawing.Point(285, 9);
            this.lblMemberRenter.Name = "lblMemberRenter";
            this.lblMemberRenter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMemberRenter.Size = new System.Drawing.Size(255, 54);
            this.lblMemberRenter.TabIndex = 1;
            this.lblMemberRenter.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 12F);
            this.label1.Location = new System.Drawing.Point(582, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "اجاره کننده میز";
            // 
            // FrmClosePlayingBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 526);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblElapsedTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlayingBorad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMemberRenter);
            this.Controls.Add(this.label1);
            this.Name = "FrmClosePlayingBoard";
            this.Text = "تسویه حساب";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmClosePlayingBoard_FormClosed);
            this.Load += new System.EventHandler(this.FrmClosePlayingBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMemberRenter;
        private System.Windows.Forms.Label lblPlayingBorad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioMySelf;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.RadioButton radioOther;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadButton btnSelect;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.ComboBox cmbSearchMemberBy;
        private Telerik.WinControls.UI.RadGridView gridMember;
    }
}