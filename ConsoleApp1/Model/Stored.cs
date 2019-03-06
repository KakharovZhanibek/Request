using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20.Model
{
    public enum MTART_EINE
    {
        штука, пачка, упаковка
    }
    public class Stored
    {
        public string BUKRS { get; set; }
        public string DATA_BSTART { get; set; }
        public int MTART { get; set; }
        public string MTART_TXT { get; set; }
        public MTART_EINE MTART_EINE { get; set; }
        public double BSTART { get; set; }
        public double SUMM { get; set; }
    }
}
