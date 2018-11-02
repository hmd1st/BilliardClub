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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup4 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup5 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement5 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup7 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement4 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup8 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement8 = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup6 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement7 = new Telerik.WinControls.UI.RadButtonElement();
            this.btnExit = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CloseButton = false;
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab2});
            this.radRibbonBar1.EnableTabScrollingOnMouseWheel = true;
            this.radRibbonBar1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radRibbonBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.MaximizeButton = false;
            this.radRibbonBar1.MinimizeButton = false;
            this.radRibbonBar1.Name = "radRibbonBar1";
            this.radRibbonBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radRibbonBar1.Size = new System.Drawing.Size(932, 172);
            this.radRibbonBar1.StartMenuItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnExit});
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "نرم افزار مدیریت باشگاه بیلیارد توپ هشت";
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.radRibbonBar1.GetChildAt(0))).Text = "نرم افزار مدیریت باشگاه بیلیارد توپ هشت";
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
            this.radRibbonBarGroup7,
            this.radRibbonBarGroup8});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "اطلاعات";
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
            this.radButtonElement1.Image = ((System.Drawing.Image)(resources.GetObject("radButtonElement1.Image")));
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
            this.radButtonElement5.Name = "radButtonElement5";
            this.radButtonElement5.Text = "radButtonElement5";
            this.radButtonElement5.Click += new System.EventHandler(this.radButtonElement5_Click);
            // 
            // radRibbonBarGroup7
            // 
            this.radRibbonBarGroup7.AccessibleDescription = "عناوین بازی ها";
            this.radRibbonBarGroup7.AccessibleName = "عناوین بازی ها";
            this.radRibbonBarGroup7.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement4});
            this.radRibbonBarGroup7.Name = "radRibbonBarGroup7";
            this.radRibbonBarGroup7.Text = "عناوین بازی ها";
            // 
            // radButtonElement4
            // 
            this.radButtonElement4.AccessibleDescription = "radButtonElement4";
            this.radButtonElement4.AccessibleName = "radButtonElement4";
            this.radButtonElement4.Name = "radButtonElement4";
            this.radButtonElement4.Text = "radButtonElement4";
            this.radButtonElement4.Click += new System.EventHandler(this.radButtonElement4_Click);
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
            this.radButtonElement8.Name = "radButtonElement8";
            this.radButtonElement8.Text = "radButtonElement8";
            this.radButtonElement8.Click += new System.EventHandler(this.radButtonElement8_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.AccessibleDescription = "عملیات";
            this.ribbonTab2.AccessibleName = "عملیات";
            this.ribbonTab2.IsSelected = false;
            this.ribbonTab2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup6,
            this.radRibbonBarGroup1});
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
            this.radRibbonBarGroup6.Text = "ثبت اعضاء";
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.AccessibleDescription = "radButtonElement3";
            this.radButtonElement3.AccessibleName = "radButtonElement3";
            this.radButtonElement3.AutoSize = true;
            this.radButtonElement3.Image = null;
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.StretchHorizontally = true;
            this.radButtonElement3.StretchVertically = true;
            this.radButtonElement3.Text = "radButtonElement3";
            this.radButtonElement3.Click += new System.EventHandler(this.radButtonElement3_Click);
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.AccessibleDescription = "ثبت میز بازی";
            this.radRibbonBarGroup1.AccessibleName = "ثبت میز بازی";
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement7});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "ثبت میز بازی";
            // 
            // radButtonElement7
            // 
            this.radButtonElement7.AccessibleDescription = "radButtonElement7";
            this.radButtonElement7.AccessibleName = "radButtonElement7";
            this.radButtonElement7.Image = null;
            this.radButtonElement7.Name = "radButtonElement7";
            this.radButtonElement7.StretchHorizontally = true;
            this.radButtonElement7.StretchVertically = true;
            this.radButtonElement7.Text = "radButtonElement7";
            this.radButtonElement7.Click += new System.EventHandler(this.radButtonElement7_Click);
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 532);
            this.Controls.Add(this.radRibbonBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = true;
            this.Name = "FrmMain";
            this.Text = "نرم افزار مدیریت باشگاه بیلیارد توپ هشت";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
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
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup7;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement4;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup6;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement7;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup8;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement8;
        private Telerik.WinControls.UI.RadMenuItem btnExit;
    }
}