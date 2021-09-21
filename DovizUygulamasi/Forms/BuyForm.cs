using DovizUygulamasi.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovizUygulamasi
{
    public partial class BuyForm : Form
    {
        public MainForm mainForm = new MainForm();
        public bool buyorsell = false; // false = buy, true = sell
        public BuyForm()
        {
            InitializeComponent();
        }
        private void BuyForm_Load(object sender, EventArgs e)
        {
            Button1.Enabled = true;
            fromLabel.Text = CalculateExtensions.mainScreenCurrency.fromCurrencyName   ;//mainForm.fromComboBox.Text;
            toLabel.Text = CalculateExtensions.mainScreenCurrency.toCurrencyName;
            if (buyorsell) // eğer satma işlemi ise
            {
                Button1.BackColor = Color.Red;
                Button1.Text = "SAT";
                toTextBox.Text = (Convert.ToDouble(mainForm.buy1.Text) * Convert.ToDouble(fromTextBox.Text)).ToString();
            }
            else // eğer satın alma işlemi ise
            {
                Button1.BackColor = Color.LimeGreen;
                Button1.Text = "SATIN AL";
                toTextBox.Text = (Convert.ToDouble(mainForm.sell1.Text) * Convert.ToDouble(fromTextBox.Text)).ToString();
            }
            CalculateExtensions.toTextBox = toTextBox;
        }
        // Bu fonksiyonu fromtextbox'a girilen değerin sayı ya da "," olmasını sağlamak için kullanıyoruz.
        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr) && chr != ',')
                    return false;
            }
            return true;
        }
        private void TextBoxValueChanged(object sender, EventArgs e)
        {
            toTextBox.Text = String.Empty;
            if (fromTextBox.Text != string.Empty && SayiMi(fromTextBox.Text))
            {
                fromTextBox.ValueChanged(buyorsell, exchangeOfficeComboBox);                                                
                Button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen doğru değer giriniz.");
                Button1.Enabled = false;
            }               
        }
        private void ComboBoxValueChanged(object sender, EventArgs e)
        {
            fromTextBox.ValueChanged(buyorsell, exchangeOfficeComboBox);
        }
        // Bu fonksiyon ile cüzdan değerimizi kontrol ediyoruz yeterli mi değil mi.
        private void Button1_Click(object sender, EventArgs e)
        {
            if (toLabel.toLabelExtension(fromLabel, fromTextBox, toTextBox))
            {
                User.UpdateWallet();
                User.AddTransactionTable(exchangeOfficeComboBox, fromLabel, toLabel, fromTextBox, toTextBox);
                CalculateExtensions.MainScreenDataGridView();
                User.ProfileScreenUpdate();
            }
            else
                MessageBox.Show("Bakiye bilgileri kontrol edip tekrar deneyebilirsin.");
        }
    }
}
