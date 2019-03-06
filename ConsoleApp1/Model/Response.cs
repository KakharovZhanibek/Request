using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20.Model
{
    public enum status
    {
        ok, err
    }
    public class Response
    {
        public void getInfo()
        {
            Console.WriteLine(status);

            if (status==status.ok)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(Error);
        }
        public status status { get; set; }
        public string Error { get; set; }
    }
}
