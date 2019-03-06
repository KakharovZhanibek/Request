using ConsoleApplication20.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceRequest sr = new ServiceRequest();
            sr.GetRequestData().getInfo();
        }
    }
}
