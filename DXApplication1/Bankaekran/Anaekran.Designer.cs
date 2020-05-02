namespace Bankaekran
{
    partial class Anaekran
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
            this.kullaniciAdiTxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.kullaniciParolaTxt = new Bunifu.Framework.BunifuCustomTextbox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kullaniciAdiTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kullaniciAdiTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(68, 126);
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(239, 21);
            this.kullaniciAdiTxt.TabIndex = 0;
            // 
            // kullaniciParolaTxt
            // 
            this.kullaniciParolaTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.kullaniciParolaTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kullaniciParolaTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kullaniciParolaTxt.Location = new System.Drawing.Point(68, 178);
            this.kullaniciParolaTxt.Name = "kullaniciParolaTxt";
            this.kullaniciParolaTxt.PasswordChar = '*';
            this.kullaniciParolaTxt.Size = new System.Drawing.Size(239, 21);
            this.kullaniciParolaTxt.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(136, 216);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(103, 40);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Giriş";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(157, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hesap İd";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(165, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Anaekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.kullaniciParolaTxt);
            this.Controls.Add(this.kullaniciAdiTxt);
            this.Name = "Anaekran";
            this.Text = "KS Bankası Masaüstü Uygulaması";
            this.Load += new System.EventHandler(this.Anaekran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.BunifuCustomTextbox kullaniciAdiTxt;
        private Bunifu.Framework.BunifuCustomTextbox kullaniciParolaTxt;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}