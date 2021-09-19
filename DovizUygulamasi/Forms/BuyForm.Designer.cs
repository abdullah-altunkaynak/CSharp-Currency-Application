
namespace DovizUygulamasi
{
    partial class BuyForm
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
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exchangeOfficeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toLabel.Location = new System.Drawing.Point(494, 34);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(34, 20);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "TO";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fromLabel.Location = new System.Drawing.Point(230, 32);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(62, 20);
            this.fromLabel.TabIndex = 5;
            this.fromLabel.Text = "FROM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(381, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "to";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fromTextBox.Location = new System.Drawing.Point(182, 66);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(163, 27);
            this.fromTextBox.TabIndex = 7;
            this.fromTextBox.Text = "1";
            this.fromTextBox.TextChanged += new System.EventHandler(this.TextBoxValueChanged);
            // 
            // toTextBox
            // 
            this.toTextBox.Enabled = false;
            this.toTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toTextBox.Location = new System.Drawing.Point(431, 66);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(188, 27);
            this.toTextBox.TabIndex = 8;
            this.toTextBox.Text = "Alacağın Miktar";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.LimeGreen;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(520, 116);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(99, 35);
            this.Button1.TabIndex = 9;
            this.Button1.Text = "AL";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(379, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "->";
            // 
            // exchangeOfficeComboBox
            // 
            this.exchangeOfficeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exchangeOfficeComboBox.FormattingEnabled = true;
            this.exchangeOfficeComboBox.Items.AddRange(new object[] {
            "Altınkaynak",
            "Yaman",
            "Yıldırım",
            "Kıymet"});
            this.exchangeOfficeComboBox.Location = new System.Drawing.Point(3, 66);
            this.exchangeOfficeComboBox.Name = "exchangeOfficeComboBox";
            this.exchangeOfficeComboBox.Size = new System.Drawing.Size(163, 28);
            this.exchangeOfficeComboBox.TabIndex = 11;
            this.exchangeOfficeComboBox.Text = "Altınkaynak";
            this.exchangeOfficeComboBox.SelectedValueChanged += new System.EventHandler(this.ComboBoxValueChanged);
            // 
            // BuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DovizUygulamasi.Properties.Resources._25596;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 163);
            this.Controls.Add(this.exchangeOfficeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BuyForm";
            this.Text = "BuyForm";
            this.Load += new System.EventHandler(this.BuyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox exchangeOfficeComboBox;
    }
}