using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace DovizUygulamasi.Classes
{
    public static class User
    {
        public static int UserID { get; set; }
        public static string UserName { get; set; }
        public static int WalletID { get; set; }
        public static double currencyDolar { get; set; }
        public static double currencyEuro { get; set; }
        public static double currencyDinar { get; set; }
        public static double currencyTl { get; set; }
        public static double currencySterlin { get; set; }
        public static double currencyRuble { get; set; }
        public static int transactExchangeOfficeID { get; set; }
        public static MainForm mainForm { get; set; }
        public static bool UserControl(string userName, string password)
        {
            // Burada cast as binary kullanmamızın nedeni büyük/küçük harf duyarlılığı yaratmaktır.
            string query = "SELECT * FROM UserTable where Cast(UserName as binary) = Cast(@userName as binary) AND Cast(Password as binary) = Cast(@password as binary)";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DovizUygulamasi.Properties.Settings.CurrencyDatabaseConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                UserID = (int)dr[0];
                WalletID = UserID;
                UserName = dr[1].ToString();
                dr.Close();
            }
            else
                return false;
            string profileDataQuery = "SELECT * FROM Wallet where UserID = @UserID";
            cmd = new SqlCommand(profileDataQuery, con);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {               
                currencyEuro = Convert.ToDouble(dr[1]);
                currencyDinar = Convert.ToDouble(dr[2]);
                currencyRuble = Convert.ToDouble(dr[3]);
                currencySterlin = Convert.ToDouble(dr[4]);
                currencyTl = Convert.ToDouble(dr[5]);
                currencyDolar = Convert.ToDouble(dr[6]);
                dr.Close();
            }
            dr.Close();
            con.Close();
            return true;
        }
        public static bool UserRegister(string userName, string password)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DovizUygulamasi.Properties.Settings.CurrencyDatabaseConnectionString"].ConnectionString);
            //İlk query verilere göre usertable'a user eklemek ikinci query bu user için wallet oluşturmak.
            string registerQuery = "insert into UserTable(UserName, Password) values (@user, @pass)";
            string userIDQuery = "SELECT ID FROM UserTable where Cast(UserName as binary) = Cast(@userName as binary)";
            string registerWalletQuery = "insert into Wallet(UserID, Euro, Dinar, Ruble, Sterlin, Tl, Dolar) values (@userID, @euro, @dinar, @ruble, @sterlin, @tl, @dolar)";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(registerQuery, con);
                cmd.Parameters.AddWithValue("@user", userName);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(userIDQuery, con);
                cmd.Parameters.AddWithValue("@userName", userName);
                SqlDataReader dr = cmd.ExecuteReader();
                int userID = 0;
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        userID = (int)dr[0];
                        dr.Close();
                    }
                }
                cmd = new SqlCommand(registerWalletQuery, con);
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@euro", 100);
                cmd.Parameters.AddWithValue("@dinar", 0);
                cmd.Parameters.AddWithValue("@ruble", 0);
                cmd.Parameters.AddWithValue("@sterlin", 0);
                cmd.Parameters.AddWithValue("@tl", 100);
                cmd.Parameters.AddWithValue("@dolar", 100);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception error)
            {
                con.Close();
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + error.Message);
                return false;
            }
        }
        public static bool BalanceCheck(double walletValue, double needValue)
        {
            if (walletValue < needValue)
                return false;
            else
                return true; 
        }
        public static bool fromLabelExtension(Label fromLabel, TextBox fromTextBox)
        {
            switch (fromLabel.Text)
            {
                case "Dolar":
                    if (BalanceCheck(currencyDolar, Convert.ToDouble(fromTextBox.Text)))
                        currencyDolar = (currencyDolar - Convert.ToDouble(fromTextBox.Text));
                        
                    else
                    {
                        MessageBox.Show("Bakiye yetersiz!");
                        return false;
                    }
                    break;
                case "Türk Lirası":
                    if (BalanceCheck(currencyTl, Convert.ToDouble(fromTextBox.Text)))
                        currencyTl = (currencyTl - Convert.ToDouble(fromTextBox.Text));
                    else
                    {
                        MessageBox.Show("Bakiye yetersiz!");
                        return false;
                    }
                    break;
                case "Euro":
                    if (BalanceCheck(currencyEuro, Convert.ToDouble(fromTextBox.Text)))
                        currencyEuro = (currencyEuro - Convert.ToDouble(fromTextBox.Text));
                    else
                    {
                        MessageBox.Show("Bakiye yetersiz!");
                        return false;
                    }
                    break;
                case "Dinar":
                    if (BalanceCheck(currencyDinar, Convert.ToDouble(fromTextBox.Text)))
                        currencyDinar = (currencyDinar - Convert.ToDouble(fromTextBox.Text));
                    else
                    {
                        MessageBox.Show("Bakiye yetersiz!");
                        return false;
                    }
                    break;
                case "Ruble":
                    if (BalanceCheck(currencyRuble, Convert.ToDouble(fromTextBox.Text)))
                        currencyRuble = (currencyRuble - Convert.ToDouble(fromTextBox.Text));
                    else
                    {
                        MessageBox.Show("Bakiye yetersiz!");
                        return false;
                    }
                    break;
                case "Sterlin":
                    if (BalanceCheck(currencySterlin, Convert.ToDouble(fromTextBox.Text)))
                        currencySterlin = (currencySterlin - Convert.ToDouble(fromTextBox.Text));
                    else
                    {
                        MessageBox.Show("Bakiye yetersiz!");
                        return false;
                    }
                    break;
            }
            return true;
        }
        public static bool toLabelExtension(this Label toLabel, Label fromLabel, TextBox fromTextBox, TextBox toTextBox)
        {
            if (fromLabelExtension(fromLabel, fromTextBox))
            {
                switch (toLabel.Text)
                {
                    case "Dolar":
                        currencyDolar = (currencyDolar + Convert.ToDouble(toTextBox.Text));
                        break;
                    case "Türk Lirası":
                        currencyTl = (currencyTl + Convert.ToDouble(toTextBox.Text));
                        break;
                    case "Euro":
                        currencyEuro = (currencyEuro + Convert.ToDouble(toTextBox.Text));
                        break;
                    case "Dinar":
                        currencyDinar = (currencyDinar + Convert.ToDouble(toTextBox.Text));
                        break;
                    case "Ruble":
                        currencyRuble = (currencyRuble + Convert.ToDouble(toTextBox.Text));
                        break;
                    case "Sterlin":
                        currencySterlin = (currencySterlin + Convert.ToDouble(toTextBox.Text));
                        break;
                }
                return true;
            }
            else
                return false;
        }
        public static void UpdateWallet()
        {
            try
            {
                string queryUpdateWallet = "UPDATE Wallet set Euro=@euro, Dinar=@dinar, Ruble=@ruble, Sterlin=@sterlin, Tl=@tl, Dolar=@dolar where UserID=@userID ";
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DovizUygulamasi.Properties.Settings.CurrencyDatabaseConnectionString"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(queryUpdateWallet, con);
                cmd.Parameters.AddWithValue("@euro", currencyEuro);
                cmd.Parameters.AddWithValue("@dinar", currencyDinar);
                cmd.Parameters.AddWithValue("@ruble", currencyRuble);
                cmd.Parameters.AddWithValue("@sterlin", currencySterlin);
                cmd.Parameters.AddWithValue("@tl", currencyTl);
                cmd.Parameters.AddWithValue("@dolar", currencyDolar);
                cmd.Parameters.AddWithValue("@userID", UserID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("İşlem başarılı.");
            }
            catch (Exception error)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + error.Message);
            }
        }
        public static void AddTransactionTable(ComboBox exchangeOfficeComboBox, Label fromLabel, Label toLabel, TextBox fromTextBox, TextBox toTextBox)
        {
            if (fromLabel.Text == "" || toLabel.Text == "")
                MessageBox.Show("Döviz bilgileri seçilmemiş ana ekrandan döviz seçip hesapla diyerek işlem yapmak istediğiniz dövizi seçebilirsiniz");
            else if (exchangeOfficeComboBox.SelectedIndex == -1)
                MessageBox.Show("Döviz bürosu seçmelisiniz.");
            else
            {
                try
                {
                    string queryTransactions = "insert into TransactionsTable(UserID, GivenUnit, ReceivedUnit, GivenAmount, ReceivedAmount, ExchangeOfficeID, DateTime)" +
                        " values (@userID, @givenunit, @receivedunit, @givenamount, @receivedamount, @exchangeofficeID, @dateTime)";
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DovizUygulamasi.Properties.Settings.CurrencyDatabaseConnectionString"].ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(queryTransactions, con);
                    cmd.Parameters.AddWithValue("@userID", UserID);
                    cmd.Parameters.AddWithValue("@givenunit", fromLabel.Text);
                    cmd.Parameters.AddWithValue("@receivedunit", toLabel.Text);
                    cmd.Parameters.AddWithValue("@givenamount", Convert.ToDouble(fromTextBox.Text));
                    cmd.Parameters.AddWithValue("@receivedamount", Convert.ToDouble(toTextBox.Text));
                    cmd.Parameters.AddWithValue("@exchangeofficeID", transactExchangeOfficeID);
                    cmd.Parameters.AddWithValue("@dateTime", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Son işlemler kısmından görebilirsiniz!");
                }
                catch (Exception error)
                {

                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + error.Message);
                }
            }
        }
        public static void ProfileScreenUpdate()
        {
            mainForm.walletIDlabel.Text = User.WalletID.ToString();
            mainForm.euroLabel.Text = User.currencyEuro.ToString();
            mainForm.dinarLabel.Text = User.currencyDinar.ToString();
            mainForm.rubleLabel.Text = User.currencyRuble.ToString();
            mainForm.sterlinLabel.Text = User.currencySterlin.ToString();
            mainForm.tlLabel.Text = User.currencyTl.ToString();
            mainForm.dolarLabel.Text = User.currencyDolar.ToString();
            mainForm.userIDlabel.Text = User.UserName;
        }
    }
}
