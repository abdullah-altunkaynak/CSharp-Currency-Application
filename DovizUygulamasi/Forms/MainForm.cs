using DovizUygulamasi.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DovizUygulamasi
{  
    public partial class MainForm : Form
    {   
        public LoginForm loginForm;
        public BuyForm buyForm;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Currency currencyTl;
        public Currency currencyEuro;
        public Currency currencySterlin;
        public Currency currencyDinar;
        public Currency currencyRuble;
        public Currency currencyDolar;
        public ExchangeOffice exchangeOffice1;
        public ExchangeOffice exchangeOffice2;
        public ExchangeOffice exchangeOffice3;
        public ExchangeOffice exchangeOffice4;
        MainScreenCurrency mainScreenCurrency = new MainScreenCurrency();
        public MainForm()
        {
            InitializeComponent();
        }       
        private void MainForm_Load(object sender, EventArgs e)
        {
            XmlDocument xmlVerisi = new XmlDocument();
            xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            //Xpath kısmında yazmamız gereken etiketleri öğrenebilmemiz için siteye giriyoruz sayfa kaynağını görüntüle diyoruz ve etiketleri inceleyip,
            //string.format()kısmında etikete göre işlem yapıyoruz.
            //TCMB sitesinde kurlar nokta ile ayırılı onları virgül ile almalıyız yoksa noktayı görmüyor.
            currencyTl = new Currency("Türk Lirası", Convert.ToDouble(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ',')));
            currencyEuro = new Currency("Euro", Convert.ToDouble(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/CrossRateOther", "EUR")).InnerText.Replace('.', ',')));
            currencySterlin = new Currency("Sterlin", Convert.ToDouble(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/CrossRateOther", "GBP")).InnerText.Replace('.', ',')));
            currencyDinar = new Currency("Dinar", Convert.ToDouble(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/CrossRateOther", "KWD")).InnerText.Replace('.', ',')));
            currencyRuble = new Currency("Ruble", Convert.ToDouble(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/CrossRateUSD", "RUB")).InnerText.Replace('.', ',')));
            currencyDolar = new Currency("Dolar", 1);
            // Ofis bürolarının değerlerini class yapısı halinde alıyoruz kullanım kolaylığı sağlaması için.
            string query = "SELECT * FROM ExchangeOfficeTable";
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DovizUygulamasi.Properties.Settings.CurrencyDatabaseConnectionString"].ConnectionString);
            cmd = new SqlCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();           
            dr.Read();
            exchangeOffice1 = new ExchangeOffice();
            exchangeOffice1.ID = (int)dr[0];
            exchangeOffice1.exchangeOfficeName = dr[1].ToString();
            exchangeOffice1.buySellDifference = Convert.ToDouble(dr[2]);
            dr.Read();
            exchangeOffice2 = new ExchangeOffice();
            exchangeOffice2.ID = (int)dr[0];
            exchangeOffice2.exchangeOfficeName = dr[1].ToString();
            exchangeOffice2.buySellDifference = Convert.ToDouble(dr[2]);
            dr.Read();
            exchangeOffice3 = new ExchangeOffice();
            exchangeOffice3.ID = (int)dr[0];
            exchangeOffice3.exchangeOfficeName = dr[1].ToString();
            exchangeOffice3.buySellDifference = Convert.ToDouble(dr[2]);
            dr.Read();
            exchangeOffice4 = new ExchangeOffice();
            exchangeOffice4.ID = (int)dr[0];
            exchangeOffice4.exchangeOfficeName = dr[1].ToString();
            exchangeOffice4.buySellDifference = Convert.ToDouble(dr[2]);
            con.Close();
            /*List<ExchangeOffice> offices = new List<ExchangeOffice>(); Liste şeklinde kullanmak bu projede uygun olmaz!!
            string query = "SELECT * FROM ExchangeOfficeTable";
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DovizUygulamasi.Properties.Settings.CurrencyDatabaseConnectionString"].ConnectionString);
            cmd = new SqlCommand(query, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                offices.Add(new ExchangeOffice()
                {
                    ID = (int)dr[0],
                    exchangeOfficeName = dr[1].ToString(),
                    buySellDifference = Convert.ToDouble(dr[2])
                });
            }*/
            // mainformun ilk değerlerini bu kısımda atıyoruz.
            officename1.Text = exchangeOffice1.exchangeOfficeName;
            officename2.Text = exchangeOffice2.exchangeOfficeName;
            officename3.Text = exchangeOffice3.exchangeOfficeName;
            officename4.Text = exchangeOffice4.exchangeOfficeName;
            hesaplaButton.Enabled = false;
            //CalculateXtensions diye oluşturduğumuz class'taki değerleri bu formdaki değerlerle eşliyoruz bundan sonra işlemi o class
            //üzerinden yapıcaz ve bütün formlara etkisi olucak.
            CalculateExtensions.mainForm = this;
            CalculateExtensions.MainScreenDataGridView();
            CalculateExtensions.mainScreenCurrency = mainScreenCurrency;
            CalculateExtensions.FillControlWCurrency(currencyDolar.ForexBuying, currencyTl.ForexBuying);
        }
        private void hesaplaButton_Click(object sender, EventArgs e)//Tüm işlemler hesapla butonuna basılınca yapılacak!!
        {
            fromComboBox.FromComboBox(toComboBox);
        }
        // satın  al butonuna tıklanırsa buyform'a buyorsell'i false olarak gönderiyoruz.
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            BuyForm buyForm = new BuyForm();
            buyForm.mainForm = this;
            buyForm.buyorsell = false;
            buyForm.Show();           
        }
        // sat butonuna tıklanırsa buyform'a buyorsell'i true olarak gönderiyoruz.
        private void buttonSell_Click(object sender, EventArgs e)
        {
            BuyForm buyForm = new BuyForm();
            buyForm.mainForm = this;
            buyForm.buyorsell = true;
            buyForm.Show();
        }
        private void MainForm_Close_Event(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }

        private void ValueTextBoxValueChanged(object sender, EventArgs e)
        {           
            hesaplaButton.Enabled = true;
        }
    }
}