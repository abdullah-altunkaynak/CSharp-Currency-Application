
namespace DovizUygulamasi
{
    partial class MainForm
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
            this.lastTLabel = new System.Windows.Forms.Label();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hesaplaButton = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.officename4 = new System.Windows.Forms.Label();
            this.officename3 = new System.Windows.Forms.Label();
            this.officename2 = new System.Windows.Forms.Label();
            this.officename1 = new System.Windows.Forms.Label();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.difference4 = new System.Windows.Forms.Label();
            this.sell4 = new System.Windows.Forms.Label();
            this.buy4 = new System.Windows.Forms.Label();
            this.difference3 = new System.Windows.Forms.Label();
            this.sell3 = new System.Windows.Forms.Label();
            this.buy3 = new System.Windows.Forms.Label();
            this.difference2 = new System.Windows.Forms.Label();
            this.sell2 = new System.Windows.Forms.Label();
            this.buy2 = new System.Windows.Forms.Label();
            this.difference1 = new System.Windows.Forms.Label();
            this.sell1 = new System.Windows.Forms.Label();
            this.buy1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.rubleLabel = new System.Windows.Forms.Label();
            this.dinarLabel = new System.Windows.Forms.Label();
            this.sterlinLabel = new System.Windows.Forms.Label();
            this.euroLabel = new System.Windows.Forms.Label();
            this.dolarLabel = new System.Windows.Forms.Label();
            this.tlLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.walletIDlabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.userIDlabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lastTLabel
            // 
            this.lastTLabel.AutoSize = true;
            this.lastTLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastTLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastTLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lastTLabel.Location = new System.Drawing.Point(124, 19);
            this.lastTLabel.Name = "lastTLabel";
            this.lastTLabel.Size = new System.Drawing.Size(126, 24);
            this.lastTLabel.TabIndex = 1;
            this.lastTLabel.Text = "Son İşlemler";
            this.lastTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fromComboBox
            // 
            this.fromComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Items.AddRange(new object[] {
            "Dolar",
            "Türk Lirası",
            "Euro",
            "Ruble",
            "Dinar",
            "Sterlin"});
            this.fromComboBox.Location = new System.Drawing.Point(206, 13);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(148, 33);
            this.fromComboBox.TabIndex = 4;
            this.fromComboBox.Text = "Dolar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(360, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "TO";
            // 
            // toComboBox
            // 
            this.toComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Items.AddRange(new object[] {
            "Dolar",
            "Türk Lirası",
            "Euro",
            "Ruble",
            "Dinar",
            "Sterlin"});
            this.toComboBox.Location = new System.Drawing.Point(409, 14);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(155, 33);
            this.toComboBox.TabIndex = 6;
            this.toComboBox.Text = "Türk Lirası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(570, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resultLabel.Location = new System.Drawing.Point(601, 19);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(96, 25);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "RESULT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.hesaplaButton);
            this.panel2.Controls.Add(this.valueTextBox);
            this.panel2.Controls.Add(this.resultLabel);
            this.panel2.Controls.Add(this.toComboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.fromComboBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(357, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 52);
            this.panel2.TabIndex = 9;
            // 
            // hesaplaButton
            // 
            this.hesaplaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.hesaplaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplaButton.ForeColor = System.Drawing.Color.White;
            this.hesaplaButton.Location = new System.Drawing.Point(703, 9);
            this.hesaplaButton.Name = "hesaplaButton";
            this.hesaplaButton.Size = new System.Drawing.Size(146, 43);
            this.hesaplaButton.TabIndex = 64;
            this.hesaplaButton.Text = "Hesapla";
            this.hesaplaButton.UseVisualStyleBackColor = false;
            this.hesaplaButton.Click += new System.EventHandler(this.hesaplaButton_Click);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.valueTextBox.Location = new System.Drawing.Point(15, 14);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(176, 30);
            this.valueTextBox.TabIndex = 9;
            this.valueTextBox.TextChanged += new System.EventHandler(this.ValueTextBoxValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.officename4);
            this.panel1.Controls.Add(this.officename3);
            this.panel1.Controls.Add(this.officename2);
            this.panel1.Controls.Add(this.officename1);
            this.panel1.Controls.Add(this.buttonSell);
            this.panel1.Controls.Add(this.buttonBuy);
            this.panel1.Controls.Add(this.difference4);
            this.panel1.Controls.Add(this.sell4);
            this.panel1.Controls.Add(this.buy4);
            this.panel1.Controls.Add(this.difference3);
            this.panel1.Controls.Add(this.sell3);
            this.panel1.Controls.Add(this.buy3);
            this.panel1.Controls.Add(this.difference2);
            this.panel1.Controls.Add(this.sell2);
            this.panel1.Controls.Add(this.buy2);
            this.panel1.Controls.Add(this.difference1);
            this.panel1.Controls.Add(this.sell1);
            this.panel1.Controls.Add(this.buy1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(357, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 665);
            this.panel1.TabIndex = 10;
            // 
            // officename4
            // 
            this.officename4.AutoSize = true;
            this.officename4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.officename4.Location = new System.Drawing.Point(91, 468);
            this.officename4.Name = "officename4";
            this.officename4.Size = new System.Drawing.Size(60, 19);
            this.officename4.TabIndex = 63;
            this.officename4.Text = "Kıymet";
            // 
            // officename3
            // 
            this.officename3.AutoSize = true;
            this.officename3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.officename3.Location = new System.Drawing.Point(91, 382);
            this.officename3.Name = "officename3";
            this.officename3.Size = new System.Drawing.Size(66, 19);
            this.officename3.TabIndex = 62;
            this.officename3.Text = "Yıldırım";
            // 
            // officename2
            // 
            this.officename2.AutoSize = true;
            this.officename2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.officename2.Location = new System.Drawing.Point(91, 296);
            this.officename2.Name = "officename2";
            this.officename2.Size = new System.Drawing.Size(59, 19);
            this.officename2.TabIndex = 61;
            this.officename2.Text = "Yaman";
            // 
            // officename1
            // 
            this.officename1.AutoSize = true;
            this.officename1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.officename1.Location = new System.Drawing.Point(91, 197);
            this.officename1.Name = "officename1";
            this.officename1.Size = new System.Drawing.Size(93, 19);
            this.officename1.TabIndex = 60;
            this.officename1.Text = "Altınkaynak";
            // 
            // buttonSell
            // 
            this.buttonSell.BackColor = System.Drawing.Color.Red;
            this.buttonSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSell.ForeColor = System.Drawing.Color.White;
            this.buttonSell.Location = new System.Drawing.Point(741, 598);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(96, 54);
            this.buttonSell.TabIndex = 58;
            this.buttonSell.Text = "Sat";
            this.buttonSell.UseVisualStyleBackColor = false;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBuy.ForeColor = System.Drawing.Color.White;
            this.buttonBuy.Location = new System.Drawing.Point(644, 598);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(96, 54);
            this.buttonBuy.TabIndex = 57;
            this.buttonBuy.Text = "Satın Al";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // difference4
            // 
            this.difference4.AutoSize = true;
            this.difference4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.difference4.Location = new System.Drawing.Point(786, 478);
            this.difference4.Name = "difference4";
            this.difference4.Size = new System.Drawing.Size(18, 19);
            this.difference4.TabIndex = 55;
            this.difference4.Text = "1";
            // 
            // sell4
            // 
            this.sell4.AutoSize = true;
            this.sell4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sell4.Location = new System.Drawing.Point(587, 478);
            this.sell4.Name = "sell4";
            this.sell4.Size = new System.Drawing.Size(18, 19);
            this.sell4.TabIndex = 54;
            this.sell4.Text = "1";
            // 
            // buy4
            // 
            this.buy4.AutoSize = true;
            this.buy4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buy4.Location = new System.Drawing.Point(336, 478);
            this.buy4.Name = "buy4";
            this.buy4.Size = new System.Drawing.Size(18, 19);
            this.buy4.TabIndex = 53;
            this.buy4.Text = "1";
            // 
            // difference3
            // 
            this.difference3.AutoSize = true;
            this.difference3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.difference3.Location = new System.Drawing.Point(786, 384);
            this.difference3.Name = "difference3";
            this.difference3.Size = new System.Drawing.Size(18, 19);
            this.difference3.TabIndex = 51;
            this.difference3.Text = "1";
            // 
            // sell3
            // 
            this.sell3.AutoSize = true;
            this.sell3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sell3.Location = new System.Drawing.Point(587, 382);
            this.sell3.Name = "sell3";
            this.sell3.Size = new System.Drawing.Size(18, 19);
            this.sell3.TabIndex = 50;
            this.sell3.Text = "1";
            // 
            // buy3
            // 
            this.buy3.AutoSize = true;
            this.buy3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buy3.Location = new System.Drawing.Point(336, 382);
            this.buy3.Name = "buy3";
            this.buy3.Size = new System.Drawing.Size(18, 19);
            this.buy3.TabIndex = 49;
            this.buy3.Text = "1";
            // 
            // difference2
            // 
            this.difference2.AutoSize = true;
            this.difference2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.difference2.Location = new System.Drawing.Point(786, 296);
            this.difference2.Name = "difference2";
            this.difference2.Size = new System.Drawing.Size(18, 19);
            this.difference2.TabIndex = 47;
            this.difference2.Text = "1";
            // 
            // sell2
            // 
            this.sell2.AutoSize = true;
            this.sell2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sell2.Location = new System.Drawing.Point(587, 296);
            this.sell2.Name = "sell2";
            this.sell2.Size = new System.Drawing.Size(18, 19);
            this.sell2.TabIndex = 46;
            this.sell2.Text = "1";
            // 
            // buy2
            // 
            this.buy2.AutoSize = true;
            this.buy2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buy2.Location = new System.Drawing.Point(336, 296);
            this.buy2.Name = "buy2";
            this.buy2.Size = new System.Drawing.Size(18, 19);
            this.buy2.TabIndex = 45;
            this.buy2.Text = "1";
            // 
            // difference1
            // 
            this.difference1.AutoSize = true;
            this.difference1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.difference1.Location = new System.Drawing.Point(786, 197);
            this.difference1.Name = "difference1";
            this.difference1.Size = new System.Drawing.Size(18, 19);
            this.difference1.TabIndex = 43;
            this.difference1.Text = "1";
            // 
            // sell1
            // 
            this.sell1.AutoSize = true;
            this.sell1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sell1.Location = new System.Drawing.Point(587, 197);
            this.sell1.Name = "sell1";
            this.sell1.Size = new System.Drawing.Size(18, 19);
            this.sell1.TabIndex = 42;
            this.sell1.Text = "1";
            // 
            // buy1
            // 
            this.buy1.AutoSize = true;
            this.buy1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buy1.Location = new System.Drawing.Point(336, 197);
            this.buy1.Name = "buy1";
            this.buy1.Size = new System.Drawing.Size(18, 19);
            this.buy1.TabIndex = 41;
            this.buy1.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(772, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Fark";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(568, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Satış";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(321, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Alış";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(91, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Büro Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(1291, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Profil";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profilePanel
            // 
            this.profilePanel.BackColor = System.Drawing.Color.Gainsboro;
            this.profilePanel.Controls.Add(this.rubleLabel);
            this.profilePanel.Controls.Add(this.dinarLabel);
            this.profilePanel.Controls.Add(this.sterlinLabel);
            this.profilePanel.Controls.Add(this.euroLabel);
            this.profilePanel.Controls.Add(this.dolarLabel);
            this.profilePanel.Controls.Add(this.tlLabel);
            this.profilePanel.Controls.Add(this.label16);
            this.profilePanel.Controls.Add(this.label15);
            this.profilePanel.Controls.Add(this.label14);
            this.profilePanel.Controls.Add(this.label13);
            this.profilePanel.Controls.Add(this.label12);
            this.profilePanel.Controls.Add(this.label11);
            this.profilePanel.Controls.Add(this.label10);
            this.profilePanel.Controls.Add(this.walletIDlabel);
            this.profilePanel.Controls.Add(this.label9);
            this.profilePanel.Controls.Add(this.userIDlabel);
            this.profilePanel.Controls.Add(this.label8);
            this.profilePanel.Location = new System.Drawing.Point(1214, 57);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(200, 665);
            this.profilePanel.TabIndex = 12;
            // 
            // rubleLabel
            // 
            this.rubleLabel.AutoSize = true;
            this.rubleLabel.Location = new System.Drawing.Point(69, 546);
            this.rubleLabel.Name = "rubleLabel";
            this.rubleLabel.Size = new System.Drawing.Size(16, 17);
            this.rubleLabel.TabIndex = 16;
            this.rubleLabel.Text = "0";
            // 
            // dinarLabel
            // 
            this.dinarLabel.AutoSize = true;
            this.dinarLabel.Location = new System.Drawing.Point(66, 491);
            this.dinarLabel.Name = "dinarLabel";
            this.dinarLabel.Size = new System.Drawing.Size(16, 17);
            this.dinarLabel.TabIndex = 15;
            this.dinarLabel.Text = "0";
            // 
            // sterlinLabel
            // 
            this.sterlinLabel.AutoSize = true;
            this.sterlinLabel.Location = new System.Drawing.Point(70, 439);
            this.sterlinLabel.Name = "sterlinLabel";
            this.sterlinLabel.Size = new System.Drawing.Size(16, 17);
            this.sterlinLabel.TabIndex = 14;
            this.sterlinLabel.Text = "0";
            // 
            // euroLabel
            // 
            this.euroLabel.AutoSize = true;
            this.euroLabel.Location = new System.Drawing.Point(64, 384);
            this.euroLabel.Name = "euroLabel";
            this.euroLabel.Size = new System.Drawing.Size(16, 17);
            this.euroLabel.TabIndex = 13;
            this.euroLabel.Text = "0";
            // 
            // dolarLabel
            // 
            this.dolarLabel.AutoSize = true;
            this.dolarLabel.Location = new System.Drawing.Point(64, 329);
            this.dolarLabel.Name = "dolarLabel";
            this.dolarLabel.Size = new System.Drawing.Size(16, 17);
            this.dolarLabel.TabIndex = 12;
            this.dolarLabel.Text = "0";
            // 
            // tlLabel
            // 
            this.tlLabel.AutoSize = true;
            this.tlLabel.Location = new System.Drawing.Point(105, 276);
            this.tlLabel.Name = "tlLabel";
            this.tlLabel.Size = new System.Drawing.Size(16, 17);
            this.tlLabel.TabIndex = 11;
            this.tlLabel.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(3, 546);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 17);
            this.label16.TabIndex = 10;
            this.label16.Text = "Ruble :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(3, 491);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "Dinar :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(3, 439);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Sterlin :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(3, 384);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Euro :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(3, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Dolar :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(3, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Türk Lirası :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(53, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "CÜZDAN";
            // 
            // walletIDlabel
            // 
            this.walletIDlabel.AutoSize = true;
            this.walletIDlabel.Location = new System.Drawing.Point(64, 166);
            this.walletIDlabel.Name = "walletIDlabel";
            this.walletIDlabel.Size = new System.Drawing.Size(16, 17);
            this.walletIDlabel.TabIndex = 3;
            this.walletIDlabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(53, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "WalletID :";
            // 
            // userIDlabel
            // 
            this.userIDlabel.AutoSize = true;
            this.userIDlabel.Location = new System.Drawing.Point(64, 47);
            this.userIDlabel.Name = "userIDlabel";
            this.userIDlabel.Size = new System.Drawing.Size(59, 17);
            this.userIDlabel.TabIndex = 1;
            this.userIDlabel.Text = "USERID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(53, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kullanıcı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(351, 665);
            this.dataGridView1.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DovizUygulamasi.Properties.Resources._255961;
            this.ClientSize = new System.Drawing.Size(1420, 721);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lastTLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Close_Event);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lastTLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label officename4;
        private System.Windows.Forms.Label officename3;
        private System.Windows.Forms.Label officename2;
        private System.Windows.Forms.Label officename1;
        private System.Windows.Forms.Button hesaplaButton;
        public System.Windows.Forms.ComboBox fromComboBox;
        public System.Windows.Forms.ComboBox toComboBox;
        public System.Windows.Forms.Label sell4;
        public System.Windows.Forms.Label sell3;
        public System.Windows.Forms.Label sell2;
        public System.Windows.Forms.Label sell1;
        public System.Windows.Forms.Label buy1;
        public System.Windows.Forms.Label buy2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel profilePanel;
        public System.Windows.Forms.Label rubleLabel;
        public System.Windows.Forms.Label dinarLabel;
        public System.Windows.Forms.Label sterlinLabel;
        public System.Windows.Forms.Label euroLabel;
        public System.Windows.Forms.Label dolarLabel;
        public System.Windows.Forms.Label tlLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label walletIDlabel;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label userIDlabel;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label difference1;
        public System.Windows.Forms.Label resultLabel;
        public System.Windows.Forms.Label difference4;
        public System.Windows.Forms.Label buy4;
        public System.Windows.Forms.Label difference3;
        public System.Windows.Forms.Label buy3;
        public System.Windows.Forms.Label difference2;
        public System.Windows.Forms.TextBox valueTextBox;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}