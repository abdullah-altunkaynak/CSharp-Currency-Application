using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DovizUygulamasi
{
    // her verinin dolarla karşılığı bilinmeli
    /* Çapraz kur hesaplamasında 3 birim olmalıdır. Örenğin euro, dolar ve tl. Burada euro ve tl nin dolarla karşılığı bilinirse
       euro ve doların birbirleri ile karşılığı bilinebilir. Şöyleki; Euro/Dolar ve Dolar/Tl değeri bilinirse işlem bizim için 
       daha kolay olur. Bunun için işlem yapılacağı zaman x/usd ve usd/x formatına dönüşüm yapıp sınıfta metotu kullanıyoruz.
      */
    public class Currency
    {
        public string Name { get; }
        public double ForexBuying { get; }

        public Currency(string name, double forexBuying)
        {
            Name = name;
            ForexBuying = forexBuying;
        }
        public double CalculateForExchange(double forexBuying) // Bu USD/x, USD/x için
        {
            forexBuying = 1 / forexBuying;
            return forexBuying;
        }
        public double CalculateCurrency(double from, double to)// Bu x/USD , USD/x için  USD/x ve x/USD
        {                                                                                // tl ve euro
            to = from * to;
            return to;
        }
    }
    // Main Ekranındaki döviz verilerini buyform ekranında kullanabilmek için bu sınıf olmalı.
    // Bu sınıfı oluşturmadan önce direk olarak label.text'leri çekerek işlem yapıyordum bu da bana güvenlik açığı oluşturuyordu.
    public class MainScreenCurrency
    {
        public string fromCurrencyName { get; set; }
        public string toCurrencyName { get; set; }
        public double currencyBuying { get; set; }
        public double currencySelling { get; set; }
    }
}
