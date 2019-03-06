using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20.Model
{
    public enum currency
    {
        kzt=398, rub=256, usd=323
    }
    public enum SalesChanelTxt
    {
        opt=8, roz=7, net=12
    }
    public class Sales
    {
        public string Burks { get; set; }
        public string Werks { get; set; }
        public string Lgort { get; set; }
        public int SalesChanel { get; private set; }

        private SalesChanelTxt SalesChanelTxt_;
        public SalesChanelTxt SalesChanelTxt {
            get
            {
                return SalesChanelTxt_;
            }
            set
            {
                SalesChanelTxt_ = value;
                SalesChanel = (int)value;
                
                //switch (value)
                //{
                //    case SalesChanelTxt.opt:
                //        SalesChanel = 8;
                //        break;
                //    case SalesChanelTxt.roz:
                //        SalesChanel = 7;
                //        break;
                //    case SalesChanelTxt.net:
                //        SalesChanel = 12;
                //        break;
                //    default:
                //        break;
                //}
            }
        }
        public string Kunnr { get; set; }
        public string KunnrTxt { get; set; }
        public int KunnrBin { get; set; }
        public string KunnrAdrUr { get; set; }
        public string KunnrArdDost { get; set; }
        public string ID_OUT_DELIVERY_DATA { get; set; }
        public int Bstart { get; set; }
        public double Summ { get; set; }
        public string SummWithCur {
            get
            {
                return Summ + " " + currency.ToString();
            }
        }
        public currency currency { get; set; } = currency.kzt;

    }
}
