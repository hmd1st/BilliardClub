namespace BilliardClub
{
    partial class FrmMember
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMember));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGetCode = new Telerik.WinControls.UI.RadButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridMember = new Telerik.WinControls.UI.RadGridView();
            this.btnNo = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnYes = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember.MasterTemplate)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(659, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "نام";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTitle.Location = new System.Drawing.Point(534, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(118, 27);
            this.txtTitle.TabIndex = 6;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // cmbLevel
            // 
            this.cmbLevel.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Location = new System.Drawing.Point(343, 48);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbLevel.Size = new System.Drawing.Size(143, 28);
            this.cmbLevel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(491, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "سطح";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.txtBirthDate.Location = new System.Drawing.Point(144, 14);
            this.txtBirthDate.Mask = "1300/00/00";
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(83, 27);
            this.txtBirthDate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(233, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "تاریخ تولد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(836, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "کد";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(725, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(105, 27);
            this.textBox1.TabIndex = 14;
            // 
            // btnGetCode
            // 
            this.btnGetCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCode.Location = new System.Drawing.Point(688, 14);
            this.btnGetCode.Name = "btnGetCode";
            this.btnGetCode.Size = new System.Drawing.Size(31, 23);
            this.btnGetCode.TabIndex = 8;
            this.btnGetCode.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(459, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "نام خانوادگی";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLastName.Location = new System.Drawing.Point(295, 12);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.Size = new System.Drawing.Size(157, 27);
            this.txtLastName.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(811, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "جنیست";
            // 
            // cmbSex
            // 
            this.cmbSex.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "آقا",
            "خانم"});
            this.cmbSex.Location = new System.Drawing.Point(725, 45);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSex.Size = new System.Drawing.Size(81, 28);
            this.cmbSex.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(663, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "شماره ملی";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNationalCode.Location = new System.Drawing.Point(538, 45);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNationalCode.Size = new System.Drawing.Size(118, 27);
            this.txtNationalCode.TabIndex = 20;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(12, 164);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(126, 37);
            this.radButton1.TabIndex = 23;
            this.radButton1.Text = "انتخاب تصویر";
            // 
            // radButton2
            // 
            this.radButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton2.Location = new System.Drawing.Point(502, 78);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(31, 23);
            this.radButton2.TabIndex = 15;
            this.radButton2.Text = "+";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox2.Location = new System.Drawing.Point(688, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(105, 27);
            this.textBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(539, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(143, 28);
            this.comboBox1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilliardClub.Properties.Resources.Images_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // gridMember
            // 
            this.gridMember.AutoSizeRows = true;
            this.gridMember.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridMember.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridMember.Location = new System.Drawing.Point(0, 224);
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
            this.gridMember.Size = new System.Drawing.Size(869, 263);
            this.gridMember.TabIndex = 30;
            this.gridMember.Text = "radGridView1";
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.Location = new System.Drawing.Point(402, 184);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(84, 34);
            this.btnNo.TabIndex = 29;
            this.btnNo.Text = "خیر";
            this.btnNo.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnDelete.Image = global::BilliardClub.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(583, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 34);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnYes.Image = global::BilliardClub.Properties.Resources.yes;
            this.btnYes.Location = new System.Drawing.Point(492, 184);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(84, 34);
            this.btnYes.TabIndex = 28;
            this.btnYes.Text = "بلی";
            this.btnYes.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnEdit.Image = global::BilliardClub.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(673, 184);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 34);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnSave.Image = global::BilliardClub.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(763, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 34);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "ذخیره";
            this.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Image = global::BilliardClub.Properties.Resources.Save;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Text = "ذخیره";
            // 
            // FrmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 487);
            this.Controls.Add(this.gridMember);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnGetCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Name = "FrmMember";
            this.Text = "ثبت عضو";
            this.Load += new System.EventHandler(this.FrmMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnGetCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtBirthDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private Telerik.WinControls.UI.RadButton btnGetCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNationalCode;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Telerik.WinControls.UI.RadGridView gridMember;
        private Telerik.WinControls.UI.RadButton btnNo;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnYes;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnSave;
    }
}