namespace BilliardClub
{
    partial class FrmSetRaspberryRelays
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.lstRaspberryRelays = new System.Windows.Forms.ListView();
            this.colIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDevice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRelay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpPlayingBoard = new Telerik.WinControls.UI.RadGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPlayingBoard = new System.Windows.Forms.ComboBox();
            this.cmbPlayingBoardTitle = new System.Windows.Forms.ComboBox();
            this.cmbPlayingBoardGroupTitle = new System.Windows.Forms.ComboBox();
            this.grpRelay = new Telerik.WinControls.UI.RadGroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRaspberryRelay = new System.Windows.Forms.ComboBox();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPlayingBoard)).BeginInit();
            this.grpPlayingBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpRelay)).BeginInit();
            this.grpRelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::BilliardClub.Properties.Resources.Power;
            this.pictureBox12.Location = new System.Drawing.Point(12, 12);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(164, 139);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 6;
            this.pictureBox12.TabStop = false;
            // 
            // lstRaspberryRelays
            // 
            this.lstRaspberryRelays.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colDevice,
            this.colRelay});
            this.lstRaspberryRelays.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstRaspberryRelays.Font = new System.Drawing.Font("B Yekan", 10F);
            this.lstRaspberryRelays.FullRowSelect = true;
            this.lstRaspberryRelays.GridLines = true;
            this.lstRaspberryRelays.Location = new System.Drawing.Point(0, 220);
            this.lstRaspberryRelays.MultiSelect = false;
            this.lstRaspberryRelays.Name = "lstRaspberryRelays";
            this.lstRaspberryRelays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstRaspberryRelays.RightToLeftLayout = true;
            this.lstRaspberryRelays.Size = new System.Drawing.Size(431, 198);
            this.lstRaspberryRelays.TabIndex = 45;
            this.lstRaspberryRelays.UseCompatibleStateImageBehavior = false;
            this.lstRaspberryRelays.View = System.Windows.Forms.View.Details;
            // 
            // colIndex
            // 
            this.colIndex.Text = "ردیف";
            this.colIndex.Width = 50;
            // 
            // colDevice
            // 
            this.colDevice.Text = "دستگاه";
            this.colDevice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDevice.Width = 305;
            // 
            // colRelay
            // 
            this.colRelay.Text = "رله";
            this.colRelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colRelay.Width = 72;
            // 
            // grpPlayingBoard
            // 
            this.grpPlayingBoard.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.grpPlayingBoard.Controls.Add(this.label1);
            this.grpPlayingBoard.Controls.Add(this.label3);
            this.grpPlayingBoard.Controls.Add(this.label2);
            this.grpPlayingBoard.Controls.Add(this.cmbPlayingBoard);
            this.grpPlayingBoard.Controls.Add(this.cmbPlayingBoardTitle);
            this.grpPlayingBoard.Controls.Add(this.cmbPlayingBoardGroupTitle);
            this.grpPlayingBoard.Font = new System.Drawing.Font("B Yekan", 10F);
            this.grpPlayingBoard.HeaderText = "انتخاب دستگاه";
            this.grpPlayingBoard.Location = new System.Drawing.Point(182, 12);
            this.grpPlayingBoard.Name = "grpPlayingBoard";
            this.grpPlayingBoard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpPlayingBoard.Size = new System.Drawing.Size(239, 139);
            this.grpPlayingBoard.TabIndex = 46;
            this.grpPlayingBoard.Text = "انتخاب دستگاه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label1.Location = new System.Drawing.Point(133, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 111;
            this.label1.Text = "عنوان  دستگاه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label3.Location = new System.Drawing.Point(133, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 110;
            this.label3.Text = "عنوان گروه بازی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label2.Location = new System.Drawing.Point(133, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 109;
            this.label2.Text = "شماره دستگاه";
            // 
            // cmbPlayingBoard
            // 
            this.cmbPlayingBoard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayingBoard.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.cmbPlayingBoard.FormattingEnabled = true;
            this.cmbPlayingBoard.Location = new System.Drawing.Point(5, 101);
            this.cmbPlayingBoard.Name = "cmbPlayingBoard";
            this.cmbPlayingBoard.Size = new System.Drawing.Size(124, 28);
            this.cmbPlayingBoard.TabIndex = 45;
            // 
            // cmbPlayingBoardTitle
            // 
            this.cmbPlayingBoardTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayingBoardTitle.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.cmbPlayingBoardTitle.FormattingEnabled = true;
            this.cmbPlayingBoardTitle.Location = new System.Drawing.Point(5, 61);
            this.cmbPlayingBoardTitle.Name = "cmbPlayingBoardTitle";
            this.cmbPlayingBoardTitle.Size = new System.Drawing.Size(124, 28);
            this.cmbPlayingBoardTitle.TabIndex = 44;
            this.cmbPlayingBoardTitle.SelectedIndexChanged += new System.EventHandler(this.cmbPlayingBoardTitle_SelectedIndexChanged);
            // 
            // cmbPlayingBoardGroupTitle
            // 
            this.cmbPlayingBoardGroupTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayingBoardGroupTitle.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.cmbPlayingBoardGroupTitle.FormattingEnabled = true;
            this.cmbPlayingBoardGroupTitle.Location = new System.Drawing.Point(5, 21);
            this.cmbPlayingBoardGroupTitle.Name = "cmbPlayingBoardGroupTitle";
            this.cmbPlayingBoardGroupTitle.Size = new System.Drawing.Size(124, 28);
            this.cmbPlayingBoardGroupTitle.TabIndex = 43;
            this.cmbPlayingBoardGroupTitle.SelectedIndexChanged += new System.EventHandler(this.cmbPlayingBoardGroupTitle_SelectedIndexChanged);
            // 
            // grpRelay
            // 
            this.grpRelay.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.grpRelay.Controls.Add(this.label4);
            this.grpRelay.Controls.Add(this.cmbRaspberryRelay);
            this.grpRelay.Font = new System.Drawing.Font("B Yekan", 10F);
            this.grpRelay.HeaderText = "انتخاب رله";
            this.grpRelay.Location = new System.Drawing.Point(182, 157);
            this.grpRelay.Name = "grpRelay";
            this.grpRelay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpRelay.Size = new System.Drawing.Size(239, 57);
            this.grpRelay.TabIndex = 47;
            this.grpRelay.Text = "انتخاب رله";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label4.Location = new System.Drawing.Point(133, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 112;
            this.label4.Text = "شماره رله";
            // 
            // cmbRaspberryRelay
            // 
            this.cmbRaspberryRelay.DropDownHeight = 75;
            this.cmbRaspberryRelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRaspberryRelay.DropDownWidth = 124;
            this.cmbRaspberryRelay.Font = new System.Drawing.Font("B Yekan", 9.75F);
            this.cmbRaspberryRelay.FormattingEnabled = true;
            this.cmbRaspberryRelay.IntegralHeight = false;
            this.cmbRaspberryRelay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cmbRaspberryRelay.Location = new System.Drawing.Point(5, 21);
            this.cmbRaspberryRelay.Name = "cmbRaspberryRelay";
            this.cmbRaspberryRelay.Size = new System.Drawing.Size(124, 28);
            this.cmbRaspberryRelay.TabIndex = 43;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnDelete.Image = global::BilliardClub.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(12, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 34);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnSave.Image = global::BilliardClub.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(100, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 34);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "ذخیره";
            this.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Image = global::BilliardClub.Properties.Resources.Save;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Text = "ذخیره";
            // 
            // FrmSetRaspberryRelays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 418);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpRelay);
            this.Controls.Add(this.grpPlayingBoard);
            this.Controls.Add(this.lstRaspberryRelays);
            this.Controls.Add(this.pictureBox12);
            this.Name = "FrmSetRaspberryRelays";
            this.Text = "تنظیمات کنترل برق";
            this.Load += new System.EventHandler(this.FrmSetRaspberryRelays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPlayingBoard)).EndInit();
            this.grpPlayingBoard.ResumeLayout(false);
            this.grpPlayingBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpRelay)).EndInit();
            this.grpRelay.ResumeLayout(false);
            this.grpRelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.ListView lstRaspberryRelays;
        private System.Windows.Forms.ColumnHeader colIndex;
        private System.Windows.Forms.ColumnHeader colDevice;
        private System.Windows.Forms.ColumnHeader colRelay;
        private Telerik.WinControls.UI.RadGroupBox grpPlayingBoard;
        private System.Windows.Forms.ComboBox cmbPlayingBoard;
        private System.Windows.Forms.ComboBox cmbPlayingBoardTitle;
        private System.Windows.Forms.ComboBox cmbPlayingBoardGroupTitle;
        private Telerik.WinControls.UI.RadGroupBox grpRelay;
        private System.Windows.Forms.ComboBox cmbRaspberryRelay;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}