
namespace DovizUygulamasi
{
    partial class RegisterForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.yanamLabel = new System.Windows.Forms.Label();
            this.loginlinkLabel = new System.Windows.Forms.LinkLabel();
            this.needHelplinkLabel = new System.Windows.Forms.LinkLabel();
            this.registerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DovizUygulamasi.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(-15, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.BackColor = System.Drawing.Color.Thistle;
            this.userIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userIDTextBox.ForeColor = System.Drawing.Color.DarkViolet;
            this.userIDTextBox.Location = new System.Drawing.Point(173, 83);
            this.userIDTextBox.MaxLength = 20;
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(244, 34);
            this.userIDTextBox.TabIndex = 2;
            this.userIDTextBox.Text = "USER ID";
            this.userIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Thistle;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.DarkViolet;
            this.passwordTextBox.Location = new System.Drawing.Point(173, 149);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(244, 34);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "PASSWORD";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.BackColor = System.Drawing.Color.Thistle;
            this.passwordTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox2.ForeColor = System.Drawing.Color.DarkViolet;
            this.passwordTextBox2.Location = new System.Drawing.Point(173, 212);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.Size = new System.Drawing.Size(244, 34);
            this.passwordTextBox2.TabIndex = 4;
            this.passwordTextBox2.Text = "PASSWORD";
            this.passwordTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox2.UseSystemPasswordChar = true;
            // 
            // yanamLabel
            // 
            this.yanamLabel.AutoSize = true;
            this.yanamLabel.BackColor = System.Drawing.Color.Transparent;
            this.yanamLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yanamLabel.ForeColor = System.Drawing.Color.Black;
            this.yanamLabel.Location = new System.Drawing.Point(170, 477);
            this.yanamLabel.Name = "yanamLabel";
            this.yanamLabel.Size = new System.Drawing.Size(175, 17);
            this.yanamLabel.TabIndex = 7;
            this.yanamLabel.Text = "Already have an account?";
            // 
            // loginlinkLabel
            // 
            this.loginlinkLabel.ActiveLinkColor = System.Drawing.Color.DarkViolet;
            this.loginlinkLabel.AutoSize = true;
            this.loginlinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginlinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginlinkLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginlinkLabel.ForeColor = System.Drawing.Color.DarkViolet;
            this.loginlinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.loginlinkLabel.LinkColor = System.Drawing.Color.DarkViolet;
            this.loginlinkLabel.Location = new System.Drawing.Point(351, 477);
            this.loginlinkLabel.Name = "loginlinkLabel";
            this.loginlinkLabel.Size = new System.Drawing.Size(47, 17);
            this.loginlinkLabel.TabIndex = 9;
            this.loginlinkLabel.TabStop = true;
            this.loginlinkLabel.Text = "Login.";
            this.loginlinkLabel.VisitedLinkColor = System.Drawing.Color.DarkViolet;
            this.loginlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginlinkLabel_LinkClicked);
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
            this.needHelplinkLabel.Location = new System.Drawing.Point(334, 303);
            this.needHelplinkLabel.Name = "needHelplinkLabel";
            this.needHelplinkLabel.Size = new System.Drawing.Size(83, 17);
            this.needHelplinkLabel.TabIndex = 10;
            this.needHelplinkLabel.TabStop = true;
            this.needHelplinkLabel.Text = "Need Help?";
            this.needHelplinkLabel.VisitedLinkColor = System.Drawing.Color.DarkGoldenrod;
            this.needHelplinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.needHelplinkLabel_LinkClicked);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(173, 279);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(125, 41);
            this.registerButton.TabIndex = 11;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DovizUygulamasi.Properties.Resources._25596;
            this.ClientSize = new System.Drawing.Size(629, 503);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.needHelplinkLabel);
            this.Controls.Add(this.loginlinkLabel);
            this.Controls.Add(this.yanamLabel);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_Close_Event);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.Label yanamLabel;
        private System.Windows.Forms.LinkLabel loginlinkLabel;
        private System.Windows.Forms.LinkLabel needHelplinkLabel;
        private System.Windows.Forms.Button registerButton;
    }
}