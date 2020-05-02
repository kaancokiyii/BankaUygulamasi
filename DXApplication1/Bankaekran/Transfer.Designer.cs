namespace Bankaekran
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.karsıhesaptxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.Gönderparatxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.transferButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.anahesapLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kendihesaptxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.karsimüsteriidtxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(36, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karşı Hesap id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(32, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gönderilecek Para Miktarı";
            // 
            // karsıhesaptxt
            // 
            this.karsıhesaptxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.karsıhesaptxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.karsıhesaptxt.Location = new System.Drawing.Point(35, 109);
            this.karsıhesaptxt.Name = "karsıhesaptxt";
            this.karsıhesaptxt.Size = new System.Drawing.Size(230, 20);
            this.karsıhesaptxt.TabIndex = 1;
            // 
            // Gönderparatxt
            // 
            this.Gönderparatxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gönderparatxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.Gönderparatxt.Location = new System.Drawing.Point(35, 224);
            this.Gönderparatxt.Name = "Gönderparatxt";
            this.Gönderparatxt.Size = new System.Drawing.Size(230, 20);
            this.Gönderparatxt.TabIndex = 1;
            // 
            // transferButton
            // 
            this.transferButton.Active = false;
            this.transferButton.Activecolor = System.Drawing.Color.Blue;
            this.transferButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transferButton.BackColor = System.Drawing.Color.Blue;
            this.transferButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transferButton.BorderRadius = 0;
            this.transferButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.transferButton.ButtonText = "Para Gönder";
            this.transferButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transferButton.DisabledColor = System.Drawing.Color.Gray;
            this.transferButton.Iconcolor = System.Drawing.Color.Transparent;
            this.transferButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("transferButton.Iconimage")));
            this.transferButton.Iconimage_right = null;
            this.transferButton.Iconimage_right_Selected = null;
            this.transferButton.Iconimage_Selected = null;
            this.transferButton.IconMarginLeft = 0;
            this.transferButton.IconMarginRight = 0;
            this.transferButton.IconRightVisible = true;
            this.transferButton.IconRightZoom = 0D;
            this.transferButton.IconVisible = true;
            this.transferButton.IconZoom = 90D;
            this.transferButton.IsTab = false;
            this.transferButton.Location = new System.Drawing.Point(35, 259);
            this.transferButton.Name = "transferButton";
            this.transferButton.Normalcolor = System.Drawing.Color.Blue;
            this.transferButton.OnHovercolor = System.Drawing.Color.Aqua;
            this.transferButton.OnHoverTextColor = System.Drawing.Color.White;
            this.transferButton.selected = false;
            this.transferButton.Size = new System.Drawing.Size(230, 48);
            this.transferButton.TabIndex = 2;
            this.transferButton.Text = "Para Gönder";
            this.transferButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transferButton.Textcolor = System.Drawing.Color.White;
            this.transferButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // anahesapLbl
            // 
            this.anahesapLbl.AutoSize = true;
            this.anahesapLbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.anahesapLbl.Location = new System.Drawing.Point(-4, 320);
            this.anahesapLbl.Name = "anahesapLbl";
            this.anahesapLbl.Size = new System.Drawing.Size(67, 17);
            this.anahesapLbl.TabIndex = 0;
            this.anahesapLbl.Text = "Anahesap";
            this.anahesapLbl.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(36, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kendi Hesap id";
            // 
            // kendihesaptxt
            // 
            this.kendihesaptxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kendihesaptxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.kendihesaptxt.Location = new System.Drawing.Point(35, 167);
            this.kendihesaptxt.Name = "kendihesaptxt";
            this.kendihesaptxt.Size = new System.Drawing.Size(230, 20);
            this.kendihesaptxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(36, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Karşı Müşteri İD";
            // 
            // karsimüsteriidtxt
            // 
            this.karsimüsteriidtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.karsimüsteriidtxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.karsimüsteriidtxt.Location = new System.Drawing.Point(35, 49);
            this.karsimüsteriidtxt.Name = "karsimüsteriidtxt";
            this.karsimüsteriidtxt.Size = new System.Drawing.Size(230, 20);
            this.karsimüsteriidtxt.TabIndex = 1;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(308, 337);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.Gönderparatxt);
            this.Controls.Add(this.kendihesaptxt);
            this.Controls.Add(this.karsimüsteriidtxt);
            this.Controls.Add(this.karsıhesaptxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.anahesapLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.BunifuCustomTextbox karsıhesaptxt;
        private Bunifu.Framework.BunifuCustomTextbox Gönderparatxt;
        private Bunifu.Framework.UI.BunifuFlatButton transferButton;
        private System.Windows.Forms.Label anahesapLbl;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.BunifuCustomTextbox kendihesaptxt;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.BunifuCustomTextbox karsimüsteriidtxt;
    }
}