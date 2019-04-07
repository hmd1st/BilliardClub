namespace BilliardClub
{
    partial class FrmInitialSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInitialSetting));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRaspBerryIP = new System.Windows.Forms.TextBox();
            this.tipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNo = new Telerik.WinControls.UI.RadButton();
            this.btnYes = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(386, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "آدرس آی پی تابلو کنترلر برق:";
            // 
            // txtRaspBerryIP
            // 
            this.txtRaspBerryIP.Font = new System.Drawing.Font("B Yekan", 10F);
            this.txtRaspBerryIP.Location = new System.Drawing.Point(236, 15);
            this.txtRaspBerryIP.MaxLength = 15;
            this.txtRaspBerryIP.Name = "txtRaspBerryIP";
            this.txtRaspBerryIP.Size = new System.Drawing.Size(144, 28);
            this.txtRaspBerryIP.TabIndex = 46;
            this.txtRaspBerryIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRaspBerryIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRaspBerryIP_KeyDown);
            this.txtRaspBerryIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRaspBerryIP_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilliardClub.Properties.Resources.help;
            this.pictureBox1.Location = new System.Drawing.Point(198, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.Location = new System.Drawing.Point(12, 12);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(84, 34);
            this.btnNo.TabIndex = 20;
            this.btnNo.Text = "خروج";
            this.btnNo.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btnYes.Image = global::BilliardClub.Properties.Resources.yes;
            this.btnYes.Location = new System.Drawing.Point(102, 12);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(84, 34);
            this.btnYes.TabIndex = 45;
            this.btnYes.Text = "تایید";
            this.btnYes.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // FrmInitialSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 59);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRaspBerryIP);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label1);
            this.Name = "FrmInitialSetting";
            this.Text = "تنظیمات اولیه";
            this.Load += new System.EventHandler(this.FrmInitialSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnYes;
        private Telerik.WinControls.UI.RadButton btnNo;
        private System.Windows.Forms.TextBox txtRaspBerryIP;
        private System.Windows.Forms.ToolTip tipHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}