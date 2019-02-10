namespace BilliardClub
{
    partial class FrmPlayingBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlayingBoard));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.btnAddPlayingboardGroupTitle = new Telerik.WinControls.UI.RadButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPlayingBoardGroupTitle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnNo = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnYes = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnAddPlayingboardTitle = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlayingBoardTitle = new System.Windows.Forms.ComboBox();
            this.gridPlayingBoard = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPlayingboardGroupTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPlayingboardTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayingBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayingBoard.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPlayingboardGroupTitle
            // 
            this.btnAddPlayingboardGroupTitle.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnAddPlayingboardGroupTitle.Image = global::BilliardClub.Properties.Resources.add;
            this.btnAddPlayingboardGroupTitle.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddPlayingboardGroupTitle.Location = new System.Drawing.Point(233, 12);
            this.btnAddPlayingboardGroupTitle.Name = "btnAddPlayingboardGroupTitle";
            this.btnAddPlayingboardGroupTitle.Size = new System.Drawing.Size(21, 28);
            this.btnAddPlayingboardGroupTitle.TabIndex = 96;
            this.btnAddPlayingboardGroupTitle.Click += new System.EventHandler(this.btnAddPlayingboardGroupTitle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label3.Location = new System.Drawing.Point(394, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 105;
            this.label3.Text = "عنوان گروه بازی";
            // 
            // cmbPlayingBoardGroupTitle
            // 
            this.cmbPlayingBoardGroupTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayingBoardGroupTitle.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cmbPlayingBoardGroupTitle.FormattingEnabled = true;
            this.cmbPlayingBoardGroupTitle.Location = new System.Drawing.Point(260, 12);
            this.cmbPlayingBoardGroupTitle.Name = "cmbPlayingBoardGroupTitle";
            this.cmbPlayingBoardGroupTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPlayingBoardGroupTitle.Size = new System.Drawing.Size(128, 28);
            this.cmbPlayingBoardGroupTitle.TabIndex = 95;
            this.cmbPlayingBoardGroupTitle.SelectedIndexChanged += new System.EventHandler(this.cmbPlayingBoardGroupTitle_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label2.Location = new System.Drawing.Point(146, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 104;
            this.label2.Text = "شماره دستگاه";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtNumber.Location = new System.Drawing.Point(12, 12);
            this.txtNumber.MaxLength = 30;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumber.Size = new System.Drawing.Size(128, 28);
            this.txtNumber.TabIndex = 97;
            this.txtNumber.Enter += new System.EventHandler(this.txtNumber_Enter);
            this.txtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumber_KeyDown);
            // 
            // btnNo
            // 
            this.btnNo.Enabled = false;
            this.btnNo.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.Location = new System.Drawing.Point(23, 109);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(84, 34);
            this.btnNo.TabIndex = 102;
            this.btnNo.Text = "خیر";
            this.btnNo.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnDelete.Image = global::BilliardClub.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(204, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 34);
            this.btnDelete.TabIndex = 100;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnYes
            // 
            this.btnYes.Enabled = false;
            this.btnYes.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnYes.Image = global::BilliardClub.Properties.Resources.yes;
            this.btnYes.Location = new System.Drawing.Point(113, 109);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(84, 34);
            this.btnYes.TabIndex = 101;
            this.btnYes.Text = "بلی";
            this.btnYes.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnEdit.Image = global::BilliardClub.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(294, 109);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 34);
            this.btnEdit.TabIndex = 99;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnSave.Image = global::BilliardClub.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(384, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 34);
            this.btnSave.TabIndex = 98;
            this.btnSave.Text = "ذخیره";
            this.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Image = global::BilliardClub.Properties.Resources.Save;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Text = "ذخیره";
            // 
            // btnAddPlayingboardTitle
            // 
            this.btnAddPlayingboardTitle.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnAddPlayingboardTitle.Image = global::BilliardClub.Properties.Resources.add;
            this.btnAddPlayingboardTitle.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddPlayingboardTitle.Location = new System.Drawing.Point(233, 59);
            this.btnAddPlayingboardTitle.Name = "btnAddPlayingboardTitle";
            this.btnAddPlayingboardTitle.Size = new System.Drawing.Size(21, 28);
            this.btnAddPlayingboardTitle.TabIndex = 107;
            this.btnAddPlayingboardTitle.Click += new System.EventHandler(this.btnAddPlayingboardTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label1.Location = new System.Drawing.Point(394, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 108;
            this.label1.Text = "عنوان  دستگاه";
            // 
            // cmbPlayingBoardTitle
            // 
            this.cmbPlayingBoardTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayingBoardTitle.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cmbPlayingBoardTitle.FormattingEnabled = true;
            this.cmbPlayingBoardTitle.Location = new System.Drawing.Point(260, 59);
            this.cmbPlayingBoardTitle.Name = "cmbPlayingBoardTitle";
            this.cmbPlayingBoardTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPlayingBoardTitle.Size = new System.Drawing.Size(128, 28);
            this.cmbPlayingBoardTitle.TabIndex = 106;
            this.cmbPlayingBoardTitle.SelectedIndexChanged += new System.EventHandler(this.cmbPlayingBoardTitle_SelectedIndexChanged);
            // 
            // gridPlayingBoard
            // 
            this.gridPlayingBoard.AutoSizeRows = true;
            this.gridPlayingBoard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPlayingBoard.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridPlayingBoard.Location = new System.Drawing.Point(0, 149);
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
            this.gridPlayingBoard.Size = new System.Drawing.Size(491, 331);
            this.gridPlayingBoard.TabIndex = 103;
            this.gridPlayingBoard.Text = "لیست شماره میزها";
            this.gridPlayingBoard.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.gridPlayingBoard_ContextMenuOpening);
            this.gridPlayingBoard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridPlayingBoard_KeyDown);
            // 
            // FrmPlayingBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 480);
            this.Controls.Add(this.btnAddPlayingboardTitle);
            this.Controls.Add(this.btnAddPlayingboardGroupTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPlayingBoardTitle);
            this.Controls.Add(this.cmbPlayingBoardGroupTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.gridPlayingBoard);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmPlayingBoard";
            this.Text = "مدیریت میزهای بازی";
            this.Activated += new System.EventHandler(this.FrmPlayingBoard_Activated);
            this.Load += new System.EventHandler(this.FrmPlayingBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPlayingboardGroupTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPlayingboardTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayingBoard.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlayingBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btnAddPlayingboardGroupTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPlayingBoardGroupTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private Telerik.WinControls.UI.RadButton btnNo;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnYes;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnAddPlayingboardTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPlayingBoardTitle;
        private Telerik.WinControls.UI.RadGridView gridPlayingBoard;
    }
}