using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovizUygulamasi
{
    // Büro adı ve alış-satış farkının bilinmesi bizim için tüm işlemleri yapmamıza yeterlidir.
    public class ExchangeOffice
    {
        public int ID { get; set; }
        public string exchangeOfficeName { get; set; }
        public double buySellDifference { get; set; }
        public double calculateCurrencySell(double currencyBuy, double buySellDifference)
        {
            double currencySell;
            currencySell = currencyBuy + (currencyBuy * buySellDifference / 100);
            return currencySell;
        }       
    }
}
