namespace BilliardClub.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup4 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup5 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement5 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement7 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup8 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement8 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup11 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement11 = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup6 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup9 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement9 = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab3 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement6 = new Telerik.WinControls.UI.RadButtonElement();
            this.btnExit = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.btnCabinetMemberManagement = new Telerik.WinControls.UI.RadMenuItem();
            this.panUsingPlayingBoards = new Telerik.WinControls.UI.RadPanorama();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panUsingPlayingBoards)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "اجاره میز";
            this.radMenuItem2.AccessibleName = "اجاره میز";
            this.radMenuItem2.Font = new System.Drawing.Font("B Yekan", 12F);
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "اجاره میز";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "اجاره میز";
            this.radMenuItem3.AccessibleName = "اجاره میز";
            this.radMenuItem3.Font = new System.Drawing.Font("B Yekan", 12F);
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "اجاره میز";
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab2,
            this.ribbonTab3});
            this.radRibbonBar1.EnableTabScrollingOnMouseWheel = true;
            this.radRibbonBar1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radRibbonBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.MaximizeButton = false;
            this.radRibbonBar1.MinimizeButton = false;
            this.radRibbonBar1.Name = "radRibbonBar1";
            this.radRibbonBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radRibbonBar1.Size = new System.Drawing.Size(1262, 174);
            this.radRibbonBar1.StartMenuItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnExit,
            this.radMenuItem1,
            this.btnCabinetMemberManagement});
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Click += new System.EventHandler(this.radRibbonBar1_Click);
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.radRibbonBar1.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadQuickAccessToolBar)(this.radRibbonBar1.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.AccessibleDescription = "اطلاعات";
            this.ribbonTab1.AccessibleName = "اطلاعات";
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup3,
            this.radRibbonBarGroup4,
            this.radRibbonBarGroup5,
            this.radRibbonBarGroup1,
            this.radRibbonBarGroup8,
            this.radRibbonBarGroup11});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "اطلاعات پایه";
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.AccessibleDescription = "عناوین شبکه اجتماعی";
            this.radRibbonBarGroup3.AccessibleName = "عناوین شبکه اجتماعی";
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.RightToLeft = false;
            this.radRibbonBarGroup3.Text = "عناوین شبکه اجتماعی";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.AccessibleDescription = "radButtonElement1";
            this.radButtonElement1.AccessibleName = "radButtonElement1";
            this.radButtonElement1.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButtonElement1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement1.Image = global::BilliardClub.Properties.Resources.socialnetwork;
            this.radButtonElement1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.Text = "radButtonElement1";
            this.radButtonElement1.Click += new System.EventHandler(this.radButtonElement1_Click);
            // 
            // radRibbonBarGroup4
            // 
            this.radRibbonBarGroup4.AccessibleDescription = "عناوین شماره تماس";
            this.radRibbonBarGroup4.AccessibleName = "عناوین شماره تماس";
            this.radRibbonBarGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement2});
            this.radRibbonBarGroup4.Name = "radRibbonBarGroup4";
            this.radRibbonBarGroup4.Text = "عناوین شماره تماس";
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.AccessibleDescription = "radButtonElement2";
            this.radButtonElement2.AccessibleName = "radButtonElement2";
            this.radButtonElement2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement2.Image = global::BilliardClub.Properties.Resources.phone_icons;
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.Text = "radButtonElement2";
            this.radButtonElement2.Click += new System.EventHandler(this.radButtonElement2_Click);
            // 
            // radRibbonBarGroup5
            // 
            this.radRibbonBarGroup5.AccessibleDescription = "نوع عضویت";
            this.radRibbonBarGroup5.AccessibleName = "نوع عضویت";
            this.radRibbonBarGroup5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement5});
            this.radRibbonBarGroup5.Name = "radRibbonBarGroup5";
            this.radRibbonBarGroup5.Text = "نوع عضویت";
            // 
            // radButtonElement5
            // 
            this.radButtonElement5.AccessibleDescription = "radButtonElement5";
            this.radButtonElement5.AccessibleName = "radButtonElement5";
            this.radButtonElement5.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement5.Image = global::BilliardClub.Properties.Resources.membership;
            this.radButtonElement5.Name = "radButtonElement5";
            this.radButtonElement5.Text = "radButtonElement5";
            this.radButtonElement5.Click += new System.EventHandler(this.radButtonElement5_Click);
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.AccessibleDescription = "ثبت میز بازی";
            this.radRibbonBarGroup1.AccessibleName = "ثبت میز بازی";
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement7});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "مدیریت میزهای بازی";
            // 
            // radButtonElement7
            // 
            this.radButtonElement7.AccessibleDescription = "radButtonElement7";
            this.radButtonElement7.AccessibleName = "radButtonElement7";
            this.radButtonElement7.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement7.Image = global::BilliardClub.Properties.Resources.tblnumber;
            this.radButtonElement7.Name = "radButtonElement7";
            this.radButtonElement7.StretchHorizontally = true;
            this.radButtonElement7.StretchVertically = true;
            this.radButtonElement7.Text = "radButtonElement7";
            this.radButtonElement7.Click += new System.EventHandler(this.radButtonElement7_Click);
            // 
            // radRibbonBarGroup8
            // 
            this.radRibbonBarGroup8.AccessibleDescription = "صندوق امانات";
            this.radRibbonBarGroup8.AccessibleName = "صندوق امانات";
            this.radRibbonBarGroup8.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement8});
            this.radRibbonBarGroup8.Name = "radRibbonBarGroup8";
            this.radRibbonBarGroup8.Text = "صندوق امانات";
            // 
            // radButtonElement8
            // 
            this.radButtonElement8.AccessibleDescription = "radButtonElement8";
            this.radButtonElement8.AccessibleName = "radButtonElement8";
            this.radButtonElement8.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement8.Image = global::BilliardClub.Properties.Resources.cabinet;
            this.radButtonElement8.Name = "radButtonElement8";
            this.radButtonElement8.Text = "radButtonElement8";
            this.radButtonElement8.Click += new System.EventHandler(this.radButtonElement8_Click);
            // 
            // radRibbonBarGroup11
            // 
            this.radRibbonBarGroup11.AccessibleDescription = "تنظیمات سیستم برق";
            this.radRibbonBarGroup11.AccessibleName = "تنظیمات سیستم برق";
            this.radRibbonBarGroup11.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement11});
            this.radRibbonBarGroup11.Name = "radRibbonBarGroup11";
            this.radRibbonBarGroup11.Text = "تنظیمات سیستم برق";
            // 
            // radButtonElement11
            // 
            this.radButtonElement11.AccessibleDescription = "radButtonElement11";
            this.radButtonElement11.AccessibleName = "radButtonElement11";
            this.radButtonElement11.Name = "radButtonElement11";
            this.radButtonElement11.Text = "radButtonElement11";
            this.radButtonElement11.Click += new System.EventHandler(this.radButtonElement11_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.AccessibleDescription = "عملیات";
            this.ribbonTab2.AccessibleName = "عملیات";
            this.ribbonTab2.IsSelected = false;
            this.ribbonTab2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup6,
            this.radRibbonBarGroup9});
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "عملیات";
            // 
            // radRibbonBarGroup6
            // 
            this.radRibbonBarGroup6.AccessibleDescription = "عضوها";
            this.radRibbonBarGroup6.AccessibleName = "عضوها";
            this.radRibbonBarGroup6.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement3});
            this.radRibbonBarGroup6.Name = "radRibbonBarGroup6";
            this.radRibbonBarGroup6.Text = "مدیریت اعضا";
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.AccessibleDescription = "radButtonElement3";
            this.radButtonElement3.AccessibleName = "radButtonElement3";
            this.radButtonElement3.AutoSize = true;
            this.radButtonElement3.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement3.Image = global::BilliardClub.Properties.Resources.members_icon;
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.StretchHorizontally = true;
            this.radButtonElement3.StretchVertically = true;
            this.radButtonElement3.Text = "radButtonElement3";
            this.radButtonElement3.Click += new System.EventHandler(this.radButtonElement3_Click);
            // 
            // radRibbonBarGroup9
            // 
            this.radRibbonBarGroup9.AccessibleDescription = "مدیریت صندوق های امانت";
            this.radRibbonBarGroup9.AccessibleName = "مدیریت صندوق های امانت";
            this.radRibbonBarGroup9.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement9});
            this.radRibbonBarGroup9.Name = "radRibbonBarGroup9";
            this.radRibbonBarGroup9.Text = "مدیریت صندوق های امانت";
            // 
            // radButtonElement9
            // 
            this.radButtonElement9.AccessibleDescription = "radButtonElement9";
            this.radButtonElement9.AccessibleName = "radButtonElement9";
            this.radButtonElement9.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement9.Image = global::BilliardClub.Properties.Resources.cabinet1;
            this.radButtonElement9.Name = "radButtonElement9";
            this.radButtonElement9.Text = "radButtonElement9";
            this.radButtonElement9.Click += new System.EventHandler(this.radButtonElement9_Click);
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.AccessibleDescription = "اجاره";
            this.ribbonTab3.AccessibleName = "اجاره";
            this.ribbonTab3.IsSelected = false;
            this.ribbonTab3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup2});
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "اجاره";
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.AccessibleDescription = "اجاره میز";
            this.radRibbonBarGroup2.AccessibleName = "اجاره میز";
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement6});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "اجاره میز";
            // 
            // radButtonElement6
            // 
            this.radButtonElement6.AccessibleDescription = "radButtonElement6";
            this.radButtonElement6.AccessibleName = "radButtonElement6";
            this.radButtonElement6.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement6.Image = global::BilliardClub.Properties.Resources.bill2;
            this.radButtonElement6.Name = "radButtonElement6";
            this.radButtonElement6.Text = "radButtonElement6";
            this.radButtonElement6.Click += new System.EventHandler(this.radButtonElement6_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleDescription = "خروج";
            this.btnExit.AccessibleName = "خروج";
            this.btnExit.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.Name = "btnExit";
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "اجاره میز";
            this.radMenuItem1.AccessibleName = "اجاره میز";
            this.radMenuItem1.Font = new System.Drawing.Font("B Yekan", 12F);
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "اجاره میز";
            // 
            // btnCabinetMemberManagement
            // 
            this.btnCabinetMemberManagement.AccessibleDescription = "مدیریت صندوق های امانت";
            this.btnCabinetMemberManagement.AccessibleName = "مدیریت صندوق های امانت";
            this.btnCabinetMemberManagement.Font = new System.Drawing.Font("B Yekan", 12F);
            this.btnCabinetMemberManagement.Name = "btnCabinetMemberManagement";
            this.btnCabinetMemberManagement.Text = "مدیریت صندوق های امانت";
            this.btnCabinetMemberManagement.Click += new System.EventHandler(this.btnCabinetMemberManagement_Click);
            // 
            // panUsingPlayingBoards
            // 
            this.panUsingPlayingBoards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panUsingPlayingBoards.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panUsingPlayingBoards.Location = new System.Drawing.Point(0, 174);
            this.panUsingPlayingBoards.Name = "panUsingPlayingBoards";
            this.panUsingPlayingBoards.RowsCount = 2;
            this.panUsingPlayingBoards.ShowGroups = true;
            this.panUsingPlayingBoards.Size = new System.Drawing.Size(1262, 353);
            this.panUsingPlayingBoards.TabIndex = 1;
            this.panUsingPlayingBoards.Text = "لیست میزهای در حال استفاده";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 527);
            this.ControlBox = false;
            this.Controls.Add(this.panUsingPlayingBoards);
            this.Controls.Add(this.radRibbonBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = true;
            this.Name = "FrmMain";
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panUsingPlayingBoards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup4;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup5;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement5;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup6;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement7;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup8;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement8;
        private Telerik.WinControls.UI.RadMenuItem btnExit;
        private Telerik.WinControls.UI.RibbonTab ribbonTab3;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement6;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem btnCabinetMemberManagement;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup9;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement9;
        private Telerik.WinControls.UI.RadPanorama panUsingPlayingBoards;
        private System.Windows.Forms.Timer timerTime;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup11;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement11;
    }
}