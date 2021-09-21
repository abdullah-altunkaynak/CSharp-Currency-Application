using DovizUygulamasi.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovizUygulamasi
{
    public static class CalculateExtensions
    {
        public static MainForm mainForm { get; set; }
        public static TextBox toTextBox { get; set; }                                
        public static MainScreenCurrency mainScreenCurrency { get; set; }
        // x/usd , usd/x currencyDinar.CalculateCurrency(currencyDinar.ForexBuying, currencyTl.ForexBuying)       
        // usd/x ve usd/x currencyRuble.CalculateCurrency(1 / currencyRuble.ForexBuying, currencyTl.ForexBuying)
        // usd/x ve x/usd currencyTl.CalculateCurrency(1/currencyTl.ForexBuying, 1/currencyEuro.ForexBuying)
        public static void FillControlWCurrency(double fromCurrency, double toCurrency)
        {
            mainForm.buy1.Text = (fromCurrency * toCurrency).ToString();
            mainForm.buy2.Text = (fromCurrency * toCurrency).ToString();
            mainForm.buy3.Text = (fromCurrency * toCurrency).ToString();
            mainForm.buy4.Text = (fromCurrency * toCurrency).ToString();
            mainForm.sell1.Text = mainForm.exchangeOffice1.calculateCurrencySell(fromCurrency * toCurrency, mainForm.exchangeOffice1.buySellDifference).ToString();
            mainForm.sell2.Text = mainForm.exchangeOffice2.calculateCurrencySell(fromCurrency * toCurrency, mainForm.exchangeOffice2.buySellDifference).ToString();
            mainForm.sell3.Text = mainForm.exchangeOffice3.calculateCurrencySell(fromCurrency * toCurrency, mainForm.exchangeOffice3.buySellDifference).ToString();
            mainForm.sell4.Text = mainForm.exchangeOffice4.calculateCurrencySell(fromCurrency * toCurrency, mainForm.exchangeOffice4.buySellDifference).ToString();
            mainForm.difference1.Text = mainForm.exchangeOffice1.buySellDifference.ToString();
            mainForm.difference2.Text = mainForm.exchangeOffice2.buySellDifference.ToString();
            mainForm.difference3.Text = mainForm.exchangeOffice3.buySellDifference.ToString();
            mainForm.difference4.Text = mainForm.exchangeOffice4.buySellDifference.ToString();
            mainScreenCurrency.currencyBuying = (fromCurrency * toCurrency);
            mainScreenCurrency.currencySelling = mainForm.exchangeOffice1.calculateCurrencySell(fromCurrency * toCurrency, mainForm.exchangeOffice1.buySellDifference);
        }
        public static void FromComboBox(this ComboBox frmComboBox, ComboBox toComboBox)
           {
               switch (frmComboBox.Text)
               {
                    case "Dolar":
                    DolartoComboBox(toComboBox);
                        break;
                    case "Türk Lirası":
                    TltoComboBox(toComboBox);
                        break;
                    case "Euro":
                    EurotoComboBox(toComboBox);
                        break;
                    case "Ruble":
                    RubletoComboBox(toComboBox);
                        break;
                    case "Dinar":
                    DinartoComboBox(toComboBox);
                        break;
                    case "Sterlin":
                    SterlintoComboBox(toComboBox);
                        break;
                }
            mainScreenCurrency.fromCurrencyName = frmComboBox.Text;
            mainScreenCurrency.toCurrencyName = toComboBox.Text;
            }
        public static void DolartoComboBox(ComboBox toComboBox)
            {
                switch (toComboBox.Text)
                {
                case "Dolar":
                    mainForm.resultLabel.Text = mainForm.valueTextBox.Text;
                    break;
                case "Türk Lirası":
                    mainForm.resultLabel.Text = (mainForm.currencyTl.ForexBuying * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencyDolar.ForexBuying, mainForm.currencyTl.ForexBuying);
                    break;
                case "Euro":
                    mainForm.resultLabel.Text = (1 / mainForm.currencyEuro.ForexBuying * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencyDolar.ForexBuying, 1 / mainForm.currencyEuro.ForexBuying);
                    break;
                case "Ruble":
                    mainForm.resultLabel.Text = (mainForm.currencyRuble.ForexBuying * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencyDolar.ForexBuying, mainForm.currencyRuble.ForexBuying);
                    break;
                case "Dinar":
                    mainForm.resultLabel.Text = (1 / mainForm.currencyDinar.ForexBuying * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencyDolar.ForexBuying, 1 / mainForm.currencyDinar.ForexBuying);
                    break;
                case "Sterlin":
                    mainForm.resultLabel.Text = (1 / mainForm.currencySterlin.ForexBuying * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencyDolar.ForexBuying, 1 / mainForm.currencySterlin.ForexBuying);
                    break;
                }
            }
        public static void TltoComboBox(ComboBox toComboBox)
        {
            switch (toComboBox.Text)
            {
                case "Dolar":
                    mainForm.resultLabel.Text = (1 / mainForm.currencyTl.ForexBuying * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(1 / mainForm.currencyTl.ForexBuying, mainForm.currencyDolar.ForexBuying);
                    break;
                case "Türk Lirası":
                    mainForm.resultLabel.Text = mainForm.valueTextBox.Text;
                    break;
                case "Euro":
                    mainForm.resultLabel.Text = (mainForm.currencyTl.CalculateCurrency(1 / mainForm.currencyTl.ForexBuying, 1 / mainForm.currencyEuro.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(1 / mainForm.currencyTl.ForexBuying, 1 / mainForm.currencyEuro.ForexBuying);
                    break;
                case "Ruble":
                    mainForm.resultLabel.Text = (mainForm.currencyTl.CalculateCurrency(1 / mainForm.currencyTl.ForexBuying, mainForm.currencyRuble.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(1 / mainForm.currencyTl.ForexBuying, mainForm.currencyRuble.ForexBuying);
                    break;
                case "Dinar":
                    mainForm.resultLabel.Text = (mainForm.currencyTl.CalculateCurrency(1 / mainForm.currencyTl.ForexBuying, 1 / mainForm.currencyDinar.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(1 / mainForm.currencyTl.ForexBuying, 1 / mainForm.currencyDinar.ForexBuying);
                    break;
                case "Sterlin":
                    mainForm.resultLabel.Text = (mainForm.currencyTl.CalculateCurrency(1 / mainForm.currencyTl.ForexBuying, 1 / mainForm.currencySterlin.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(1 / mainForm.currencyTl.ForexBuying, 1 / mainForm.currencySterlin.ForexBuying);
                    break;
            }
        }
        public static void EurotoComboBox(ComboBox toComboBox)
        {
            switch (toComboBox.Text)
            {
                case "Dolar":
                    mainForm.resultLabel.Text = (mainForm.currencyEuro.ForexBuying * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencyEuro.ForexBuying, mainForm.currencyDolar.ForexBuying);
                    break;
                case "Türk Lirası":
                    mainForm.resultLabel.Text = (mainForm.currencyEuro.CalculateCurrency(mainForm.currencyEuro.ForexBuying, mainForm.currencyTl.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencyEuro.ForexBuying, mainForm.currencyTl.ForexBuying);
                    break;
                case "Euro":
                    mainForm.resultLabel.Text = mainForm.valueTextBox.Text;
                    break;
                case "Ruble":
                    mainForm.resultLabel.Text = (mainForm.currencyEuro.CalculateCurrency(mainForm.currencyEuro.ForexBuying, mainForm.currencyRuble.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencyEuro.ForexBuying, mainForm.currencyRuble.ForexBuying);
                    break;
                case "Dinar":
                    mainForm.resultLabel.Text = (mainForm.currencyEuro.CalculateCurrency(mainForm.currencyEuro.ForexBuying, 1 / mainForm.currencyDinar.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencyEuro.ForexBuying, 1 / mainForm.currencyDinar.ForexBuying);
                    break;
                case "Sterlin":
                    mainForm.resultLabel.Text = (mainForm.currencyEuro.CalculateCurrency(mainForm.currencyEuro.ForexBuying, 1 / mainForm.currencySterlin.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencyEuro.ForexBuying, 1 / mainForm.currencySterlin.ForexBuying);
                    break;
            }
        }
        public static void RubletoComboBox(ComboBox toComboBox)
        {
            switch (toComboBox.Text)
            {
                case "Dolar":
                    mainForm.resultLabel.Text = (1 / mainForm.currencyRuble.ForexBuying * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(1 / mainForm.currencyRuble.ForexBuying, mainForm.currencyDolar.ForexBuying);
                    break;
                case "Türk Lirası":
                    mainForm.resultLabel.Text = (mainForm.currencyRuble.CalculateCurrency(1 / mainForm.currencyRuble.ForexBuying, mainForm.currencyTl.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(1 / mainForm.currencyRuble.ForexBuying, mainForm.currencyTl.ForexBuying);
                    break;
                case "Euro":
                    mainForm.resultLabel.Text = (mainForm.currencyRuble.CalculateCurrency(1 / mainForm.currencyRuble.ForexBuying, 1 / mainForm.currencyEuro.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(1 / mainForm.currencyRuble.ForexBuying, 1 / mainForm.currencyEuro.ForexBuying);
                    break;
                case "Ruble":
                    mainForm.resultLabel.Text = mainForm.valueTextBox.Text;
                    break;
                case "Dinar":
                    mainForm.resultLabel.Text = (mainForm.currencyRuble.CalculateCurrency(1 / mainForm.currencyRuble.ForexBuying, 1 / mainForm.currencyDinar.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(1 / mainForm.currencyRuble.ForexBuying, 1 / mainForm.currencyDinar.ForexBuying);
                    break;
                case "Sterlin":
                    mainForm.resultLabel.Text = (mainForm.currencyRuble.CalculateCurrency(1 / mainForm.currencyRuble.ForexBuying, 1 / mainForm.currencySterlin.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(1 / mainForm.currencyRuble.ForexBuying, 1 / mainForm.currencySterlin.ForexBuying);
                    break;
            }
        }
        public static void DinartoComboBox(ComboBox toComboBox)
        {
            switch (toComboBox.Text)
            {
                case "Dolar":
                    mainForm.resultLabel.Text = (mainForm.currencyDinar.ForexBuying * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencyDinar.ForexBuying, mainForm.currencyDolar.ForexBuying);
                    break;
                case "Türk Lirası":
                    mainForm.resultLabel.Text = (mainForm.currencyDinar.CalculateCurrency(mainForm.currencyDinar.ForexBuying, mainForm.currencyTl.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencyDinar.ForexBuying, mainForm.currencyTl.ForexBuying);
                    break;
                case "Euro":
                    mainForm.resultLabel.Text = (mainForm.currencyDinar.CalculateCurrency(mainForm.currencyDinar.ForexBuying, 1 / mainForm.currencyEuro.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencyDinar.ForexBuying, 1 / mainForm.currencyEuro.ForexBuying);
                    break;
                case "Ruble":
                    mainForm.resultLabel.Text = (mainForm.currencyDinar.CalculateCurrency(mainForm.currencyDinar.ForexBuying, mainForm.currencyRuble.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencyDinar.ForexBuying, mainForm.currencyRuble.ForexBuying);
                    break;
                case "Dinar":
                    mainForm.resultLabel.Text = mainForm.valueTextBox.Text;
                    break;
                case "Sterlin":
                    mainForm.resultLabel.Text = (mainForm.currencyDinar.CalculateCurrency(mainForm.currencyDinar.ForexBuying, 1 / mainForm.currencySterlin.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencyDinar.ForexBuying, 1 / mainForm.currencySterlin.ForexBuying);
                    break;
            }
        }
        public static void SterlintoComboBox(ComboBox toComboBox)
        {
            switch (toComboBox.Text)
            {
                case "Dolar":
                    mainForm.resultLabel.Text = (mainForm.currencySterlin.ForexBuying * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencySterlin.ForexBuying, mainForm.currencyDolar.ForexBuying);
                    break;
                case "Türk Lirası":
                    mainForm.resultLabel.Text = (mainForm.currencySterlin.CalculateCurrency(mainForm.currencySterlin.ForexBuying, mainForm.currencyTl.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencySterlin.ForexBuying, mainForm.currencyTl.ForexBuying);
                    break;
                case "Euro":
                    mainForm.resultLabel.Text = (mainForm.currencySterlin.CalculateCurrency(mainForm.currencySterlin.ForexBuying, 1 / mainForm.currencyEuro.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencySterlin.ForexBuying, 1 / mainForm.currencyEuro.ForexBuying);
                    break;
                case "Ruble":
                    mainForm.resultLabel.Text = (mainForm.currencySterlin.CalculateCurrency(mainForm.currencySterlin.ForexBuying, mainForm.currencyRuble.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencySterlin.ForexBuying, mainForm.currencyRuble.ForexBuying);
                    break;
                case "Dinar":
                    mainForm.resultLabel.Text = (mainForm.currencySterlin.CalculateCurrency(mainForm.currencySterlin.ForexBuying, 1 / mainForm.currencyDinar.ForexBuying) * Convert.ToDouble(mainForm.valueTextBox.Text)).ToString();
                    FillControlWCurrency(mainForm.currencySterlin.ForexBuying, 1 / mainForm.currencyDinar.ForexBuying);
                    break;
                case "Sterlin":
                    mainForm.resultLabel.Text = mainForm.valueTextBox.Text;
                    break;
            }
        }
        public static void ValueChanged(this TextBox fromTextBox, bool buyorsell, ComboBox exchangeOfficeComboBox)
        {
            if (buyorsell)// satma işlemi ise
            {
                toTextBox.Text = (mainScreenCurrency.currencyBuying * Convert.ToDouble(fromTextBox.Text)).ToString();
            }
            else// satın alma işlemi ise
            {               
                switch (exchangeOfficeComboBox.Text)
                {
                    case "Altınkaynak":
                        toTextBox.Text = (mainForm.exchangeOffice1.calculateCurrencySell(mainScreenCurrency.currencyBuying, mainForm.exchangeOffice1.buySellDifference) * Convert.ToDouble(fromTextBox.Text)).ToString();
                        User.transactExchangeOfficeID = mainForm.exchangeOffice1.ID;
                        break;
                    case "Yaman":
                        toTextBox.Text = (mainForm.exchangeOffice2.calculateCurrencySell(mainScreenCurrency.currencyBuying, mainForm.exchangeOffice2.buySellDifference) * Convert.ToDouble(fromTextBox.Text)).ToString();
                        User.transactExchangeOfficeID = mainForm.exchangeOffice2.ID;
                        break;
                    case "Yıldırım":
                        toTextBox.Text = (mainForm.exchangeOffice3.calculateCurrencySell(mainScreenCurrency.currencyBuying, mainForm.exchangeOffice3.buySellDifference) * Convert.ToDouble(fromTextBox.Text)).ToString();
                        User.transactExchangeOfficeID = mainForm.exchangeOffice3.ID;
                        break;
                    case "Kıymet":
                        toTextBox.Text = (mainForm.exchangeOffice4.calculateCurrencySell(mainScreenCurrency.currencyBuying, mainForm.exchangeOffice4.buySellDifference) * Convert.ToDouble(fromTextBox.Text)).ToString();
                        User.transactExchangeOfficeID = mainForm.exchangeOffice4.ID;
                        break;

                }
            }
        }
        public static void MainScreenDataGridView()
        {
            string queryTransactionTable = "SELECT * FROM TransactionsTable";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DovizUygulamasi.Properties.Settings.CurrencyDatabaseConnectionString"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter(queryTransactionTable, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds);
            mainForm.dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

    }
}
