
namespace DovizUygulamasi
{
    partial class LoginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.yanamLabel = new System.Windows.Forms.Label();
            this.needHelplinkLabel = new System.Windows.Forms.LinkLabel();
            this.registerlinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.BackColor = System.Drawing.Color.Thistle;
            this.userIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userIDTextBox.ForeColor = System.Drawing.Color.DarkViolet;
            this.userIDTextBox.Location = new System.Drawing.Point(175, 187);
            this.userIDTextBox.MaxLength = 20;
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(244, 34);
            this.userIDTextBox.TabIndex = 1;
            this.userIDTextBox.Text = "USER ID";
            this.userIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Thistle;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.DarkViolet;
            this.passwordTextBox.Location = new System.Drawing.Point(175, 271);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(244, 34);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "PASSWORD";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::DovizUygulamasi.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(196, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(175, 322);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(125, 41);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // yanamLabel
            // 
            this.yanamLabel.AutoSize = true;
            this.yanamLabel.BackColor = System.Drawing.Color.Transparent;
            this.yanamLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yanamLabel.ForeColor = System.Drawing.Color.Black;
            this.yanamLabel.Location = new System.Drawing.Point(172, 477);
            this.yanamLabel.Name = "yanamLabel";
            this.yanamLabel.Size = new System.Drawing.Size(160, 17);
            this.yanamLabel.TabIndex = 6;
            this.yanamLabel.Text = "You are not a member?";
            // 
            // needHelplinkLabel
            // 
            this.needHelplinkLabel.ActiveLinkColor = System.Drawing.Color.DarkGoldenrod;
            this.needHelplinkLabel.AutoSize = true;
            this.needHelplinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.needHelplinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.needHelplinkLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.needHelplinkLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.needHelplinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.needHelplinkLabel.LinkColor = System.Drawing.Color.DarkGoldenrod;
            this.needHelplinkLabel.Location = new System.Drawing.Point(336, 346);
            this.needHelplinkLabel.Name = "needHelplinkLabel";
            this.needHelplinkLabel.Size = new System.Drawing.Size(83, 17);
            this.needHelplinkLabel.TabIndex = 4;
            this.needHelplinkLabel.TabStop = true;
            this.needHelplinkLabel.Text = "Need Help?";
            this.needHelplinkLabel.VisitedLinkColor = System.Drawing.Color.DarkGoldenrod;
            this.needHelplinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.needHelplinkLabel_LinkClicked);
            // 
            // registerlinkLabel
            // 
            this.registerlinkLabel.ActiveLinkColor = System.Drawing.Color.DarkViolet;
            this.registerlinkLabel.AutoSize = true;
            this.registerlinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.registerlinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerlinkLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerlinkLabel.ForeColor = System.Drawing.Color.DarkViolet;
            this.registerlinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.registerlinkLabel.LinkColor = System.Drawing.Color.DarkViolet;
            this.registerlinkLabel.Location = new System.Drawing.Point(336, 477);
            this.registerlinkLabel.Name = "registerlinkLabel";
            this.registerlinkLabel.Size = new System.Drawing.Size(66, 17);
            this.registerlinkLabel.TabIndex = 8;
            this.registerlinkLabel.TabStop = true;
            this.registerlinkLabel.Text = "Register.";
            this.registerlinkLabel.VisitedLinkColor = System.Drawing.Color.DarkViolet;
            this.registerlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerlinkLabel_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DovizUygulamasi.Properties.Resources._25596;
            this.ClientSize = new System.Drawing.Size(629, 503);
            this.Controls.Add(this.registerlinkLabel);
            this.Controls.Add(this.needHelplinkLabel);
            this.Controls.Add(this.yanamLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userIDTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label yanamLabel;
        private System.Windows.Forms.LinkLabel needHelplinkLabel;
        private System.Windows.Forms.LinkLabel registerlinkLabel;
    }
}

