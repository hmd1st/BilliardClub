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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayingBorad = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblMemberRenter = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radioOther = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.radioMySelf = new System.Windows.Forms.RadioButton();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.cmbSearchMemberBy = new System.Windows.Forms.ComboBox();
            this.gridMember = new Telerik.WinControls.UI.RadGridView();
            this.btnPayment = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbBankAccount = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCardPaymentIdentity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioCard = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIsCredit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.lblElapsedTime);
            this.radGroupBox1.Controls.Add(this.label4);
            this.radGroupBox1.Controls.Add(this.lblPlayingBorad);
            this.radGroupBox1.Controls.Add(this.lblPayment);
            this.radGroupBox1.Controls.Add(this.lblMemberRenter);
            this.radGroupBox1.Controls.Add(this.label6);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox1.HeaderText = "اطلاعات اجاره کننده میز";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radGroupBox1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 200, 100);
            this.radGroupBox1.Size = new System.Drawing.Size(674, 84);
            this.radGroupBox1.TabIndex = 9;
            this.radGroupBox1.Text = "اطلاعات اجاره کننده میز";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.label1.Location = new System.Drawing.Point(582, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "اجاره کننده میز";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.label2.Location = new System.Drawing.Point(582, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام دستگاه";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.lblElapsedTime.Location = new System.Drawing.Point(12, 18);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblElapsedTime.Size = new System.Drawing.Size(154, 20);
            this.lblElapsedTime.TabIndex = 5;
            this.lblElapsedTime.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.label4.Location = new System.Drawing.Point(208, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "میزان استفاده";
            // 
            // lblPlayingBorad
            // 
            this.lblPlayingBorad.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.lblPlayingBorad.Location = new System.Drawing.Point(359, 37);
            this.lblPlayingBorad.Name = "lblPlayingBorad";
            this.lblPlayingBorad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPlayingBorad.Size = new System.Drawing.Size(181, 25);
            this.lblPlayingBorad.TabIndex = 3;
            this.lblPlayingBorad.Text = "...";
            // 
            // lblPayment
            // 
            this.lblPayment.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.lblPayment.Location = new System.Drawing.Point(12, 42);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPayment.Size = new System.Drawing.Size(154, 20);
            this.lblPayment.TabIndex = 7;
            this.lblPayment.Text = "...";
            // 
            // lblMemberRenter
            // 
            this.lblMemberRenter.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.lblMemberRenter.Location = new System.Drawing.Point(359, 18);
            this.lblMemberRenter.Name = "lblMemberRenter";
            this.lblMemberRenter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMemberRenter.Size = new System.Drawing.Size(181, 20);
            this.lblMemberRenter.TabIndex = 1;
            this.lblMemberRenter.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.label6.Location = new System.Drawing.Point(208, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "مبلغ محاسبه شده";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radioOther);
            this.radGroupBox2.Controls.Add(this.label9);
            this.radGroupBox2.Controls.Add(this.radioMySelf);
            this.radGroupBox2.Controls.Add(this.txtSearchMember);
            this.radGroupBox2.Controls.Add(this.cmbSearchMemberBy);
            this.radGroupBox2.Controls.Add(this.gridMember);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox2.HeaderText = "اطلاعات اجاره کننده میز";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 84);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox2.Size = new System.Drawing.Size(674, 195);
            this.radGroupBox2.TabIndex = 10;
            this.radGroupBox2.Text = "اطلاعات اجاره کننده میز";
            // 
            // radioOther
            // 
            this.radioOther.AutoSize = true;
            this.radioOther.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioOther.Location = new System.Drawing.Point(499, 18);
            this.radioOther.Name = "radioOther";
            this.radioOther.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioOther.Size = new System.Drawing.Size(81, 24);
            this.radioOther.TabIndex = 48;
            this.radioOther.TabStop = true;
            this.radioOther.Text = "شخص ثالث";
            this.radioOther.UseVisualStyleBackColor = true;
            this.radioOther.CheckedChanged += new System.EventHandler(this.radioOther_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(312, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "جستجو بر اساس";
            // 
            // radioMySelf
            // 
            this.radioMySelf.AutoSize = true;
            this.radioMySelf.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioMySelf.Location = new System.Drawing.Point(602, 18);
            this.radioMySelf.Name = "radioMySelf";
            this.radioMySelf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioMySelf.Size = new System.Drawing.Size(53, 24);
            this.radioMySelf.TabIndex = 42;
            this.radioMySelf.TabStop = true;
            this.radioMySelf.Text = "خودم";
            this.radioMySelf.UseVisualStyleBackColor = true;
            this.radioMySelf.CheckedChanged += new System.EventHandler(this.radioMySelf_CheckedChanged);
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtSearchMember.Location = new System.Drawing.Point(12, 18);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(144, 28);
            this.txtSearchMember.TabIndex = 44;
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
            this.cmbSearchMemberBy.Location = new System.Drawing.Point(162, 18);
            this.cmbSearchMemberBy.Name = "cmbSearchMemberBy";
            this.cmbSearchMemberBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearchMemberBy.Size = new System.Drawing.Size(144, 28);
            this.cmbSearchMemberBy.TabIndex = 43;
            // 
            // gridMember
            // 
            this.gridMember.AutoSizeRows = true;
            this.gridMember.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridMember.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridMember.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridMember.Location = new System.Drawing.Point(2, 52);
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
            this.gridMember.RootElement.ControlBounds = new System.Drawing.Rectangle(2, 52, 240, 150);
            this.gridMember.Size = new System.Drawing.Size(670, 141);
            this.gridMember.TabIndex = 46;
            this.gridMember.Text = "لیست اعضا";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPayment.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnPayment.Image = global::BilliardClub.Properties.Resources.Cash_register_icon;
            this.btnPayment.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayment.Location = new System.Drawing.Point(12, 21);
            this.btnPayment.Name = "btnPayment";
            // 
            // 
            // 
            this.btnPayment.RootElement.ControlBounds = new System.Drawing.Rectangle(12, 21, 110, 24);
            this.btnPayment.Size = new System.Drawing.Size(103, 28);
            this.btnPayment.TabIndex = 45;
            this.btnPayment.Text = "پرداخت";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.radGroupBox3.Controls.Add(this.label12);
            this.radGroupBox3.Controls.Add(this.cmbBankAccount);
            this.radGroupBox3.Controls.Add(this.label11);
            this.radGroupBox3.Controls.Add(this.txtAccountNumber);
            this.radGroupBox3.Controls.Add(this.label10);
            this.radGroupBox3.Controls.Add(this.txtCardNumber);
            this.radGroupBox3.Controls.Add(this.label8);
            this.radGroupBox3.Controls.Add(this.txtCardPaymentIdentity);
            this.radGroupBox3.Controls.Add(this.label7);
            this.radGroupBox3.Controls.Add(this.radioCash);
            this.radGroupBox3.Controls.Add(this.label5);
            this.radGroupBox3.Controls.Add(this.radioCard);
            this.radGroupBox3.Controls.Add(this.txtPrice);
            this.radGroupBox3.Controls.Add(this.label3);
            this.radGroupBox3.Controls.Add(this.cmbIsCredit);
            this.radGroupBox3.Controls.Add(this.btnPayment);
            this.radGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox3.HeaderText = "اطلاعات پرداخت";
            this.radGroupBox3.Location = new System.Drawing.Point(0, 279);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radGroupBox3.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 279, 200, 100);
            this.radGroupBox3.Size = new System.Drawing.Size(674, 67);
            this.radGroupBox3.TabIndex = 46;
            this.radGroupBox3.Text = "اطلاعات پرداخت";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(542, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 20);
            this.label12.TabIndex = 59;
            this.label12.Text = "پرداخت به حساب";
            // 
            // cmbBankAccount
            // 
            this.cmbBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankAccount.Enabled = false;
            this.cmbBankAccount.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.cmbBankAccount.FormattingEnabled = true;
            this.cmbBankAccount.Location = new System.Drawing.Point(329, 68);
            this.cmbBankAccount.Name = "cmbBankAccount";
            this.cmbBankAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbBankAccount.Size = new System.Drawing.Size(207, 28);
            this.cmbBankAccount.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(247, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 56;
            this.label11.Text = "شماره حساب";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Enabled = false;
            this.txtAccountNumber.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtAccountNumber.Location = new System.Drawing.Point(34, 101);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(207, 28);
            this.txtAccountNumber.TabIndex = 57;
            this.txtAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(247, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "شماره کارت";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Enabled = false;
            this.txtCardNumber.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtCardNumber.Location = new System.Drawing.Point(34, 68);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(207, 28);
            this.txtCardNumber.TabIndex = 55;
            this.txtCardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(542, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "شناسه پرداخت";
            // 
            // txtCardPaymentIdentity
            // 
            this.txtCardPaymentIdentity.Enabled = false;
            this.txtCardPaymentIdentity.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtCardPaymentIdentity.Location = new System.Drawing.Point(329, 101);
            this.txtCardPaymentIdentity.Name = "txtCardPaymentIdentity";
            this.txtCardPaymentIdentity.Size = new System.Drawing.Size(207, 28);
            this.txtCardPaymentIdentity.TabIndex = 53;
            this.txtCardPaymentIdentity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label7.Location = new System.Drawing.Point(161, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "ریال";
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.Checked = true;
            this.radioCash.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioCash.Location = new System.Drawing.Point(450, 23);
            this.radioCash.Name = "radioCash";
            this.radioCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioCash.Size = new System.Drawing.Size(43, 24);
            this.radioCash.TabIndex = 50;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "نقد";
            this.radioCash.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(312, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "مبلغ پرداختی";
            // 
            // radioCard
            // 
            this.radioCard.AutoSize = true;
            this.radioCard.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioCard.Location = new System.Drawing.Point(393, 23);
            this.radioCard.Name = "radioCard";
            this.radioCard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioCard.Size = new System.Drawing.Size(51, 24);
            this.radioCard.TabIndex = 49;
            this.radioCard.Text = "کارت";
            this.radioCard.UseVisualStyleBackColor = true;
            this.radioCard.CheckedChanged += new System.EventHandler(this.radioCard_CheckedChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtPrice.Location = new System.Drawing.Point(191, 21);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(115, 28);
            this.txtPrice.TabIndex = 49;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(596, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "نوع پرداخت";
            // 
            // cmbIsCredit
            // 
            this.cmbIsCredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsCredit.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.cmbIsCredit.FormattingEnabled = true;
            this.cmbIsCredit.Items.AddRange(new object[] {
            "نقدی",
            "نسیه"});
            this.cmbIsCredit.Location = new System.Drawing.Point(499, 21);
            this.cmbIsCredit.Name = "cmbIsCredit";
            this.cmbIsCredit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbIsCredit.Size = new System.Drawing.Size(91, 28);
            this.cmbIsCredit.TabIndex = 46;
            // 
            // FrmClosePlayingBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 346);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmClosePlayingBoard";
            this.Text = "تسویه حساب";
            this.Load += new System.EventHandler(this.FrmClosePlayingBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private System.Windows.Forms.RadioButton radioOther;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioMySelf;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.ComboBox cmbSearchMemberBy;
        private Telerik.WinControls.UI.RadGridView gridMember;
        private Telerik.WinControls.UI.RadButton btnPayment;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioCard;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIsCredit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCardPaymentIdentity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbBankAccount;
    }
}