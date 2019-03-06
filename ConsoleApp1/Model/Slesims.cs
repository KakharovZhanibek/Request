using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20.Model
{
    public class Slesims
    {
        public string BUKRS { get; set; }
        public string WERKS { get; set; }
        public string MTART { get; set; }
        public string MTART_TXT { get; set; }
        public string MTART_PROIZVOD_COUNTRY { get; set; }
        public double BSTART { get; set; } = 0;
        private double SUMM_;
        public double SUMM {
            get
            {
                return SUMM_;
            }
            set
            {
                if(BSTART < 0)
                    value = value * -1; 

                SUMM_ = value;
            }
        }
    }
}
