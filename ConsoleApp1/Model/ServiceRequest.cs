using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20.Model
{
    public class ServiceRequest
    {
        public string PathToSave { get; set; }

        public Response GetRequestData()
        {
            
            Request r1 = new Request();
            Console.WriteLine("Пожалуйста введите тип запроса: ");

            int type_req = 0;
            Int32.TryParse(Console.ReadLine(),out type_req);

            if(type_req <= Enum.GetNames(typeof(TypeRequest)).Length)
            {
                r1.Req = (TypeRequest)type_req;
            }

            Console.WriteLine("Пожалуйста введите код поставщика:");
            r1.Kunnr = Console.ReadLine();

            Console.WriteLine("Пожалуйста введите Код БЕ в SAP ERP. Код БЕ может быть заполнен, а может и не заполнен. ");
            r1.Bukrs = Console.ReadLine();

            Console.WriteLine("Пожалуйста введите Завод, в рамках которого необходимо передать данные по продажам из системы SAP ERP. ");
            r1.Werks = Console.ReadLine();

            Console.WriteLine("Пожалуйста введите Дату с начала периода");

            DateTime data1;
            if (DateTime.TryParse(Console.ReadLine(), out data1))
                r1.Data1 = data1;
            else
                r1.Data1 = DateTime.MinValue;

            Console.WriteLine("Пожалуйста введите Дату конца периода");
          
            if (DateTime.TryParse(Console.ReadLine(), out data1))
                r1.Data2 = data1;
            else
                r1.Data1 = DateTime.MinValue;

          return  RequesInput(r1);

        }
        public Response RequesInput(Request r1)
        {
            Response responce=null;
            switch (r1.Req)
            {
                case TypeRequest.none:
                    break;
                case TypeRequest.sales:
                    {
                        List<Sales> s = null;
                        responce= GetSalesReport(r1, out s);
                    }
                    break;
                case TypeRequest.salesims:
                    break;
                case TypeRequest.stored:
                    break;
                case TypeRequest.moving:
                    break;
                case TypeRequest.goods_receipt:
                    break;
                default:
                    break;
            }
            return responce;
        }

        public Response GetSalesReport(Request r, out List<Sales> SalesReport) {
            Response resp = new Response();
            SalesReport = new List<Sales>();


            SalesReport = getSalesData(r);

            if(SalesReport.Count <= 0)
            {
                resp.status = status.err;
                resp.Error = "Ошибка";
            }
            else
            {
                resp.status = status.ok;
            }

            return resp;
        } 

        private List<Sales> getSalesData(Request r)
        {
            List<Sales> saleses = new List<Sales>();

            for (int i = 0; i < (r.Data2 - r.Data1).TotalDays; i++)
            {
                Sales sales = new Sales();
                sales.Bstart = rnd.Next(0 , 1000);
                sales.Burks = "b" + rnd.Next(0, 20);
                sales.currency = (currency)rnd.Next(0, 3);
                sales.ID_OUT_DELIVERY_DATA = string.Format("{0:dd.mm.yy}", DateTime.Now.AddDays(rnd.Next(1,30000)));
                sales.Kunnr = "b" + rnd.Next(0, 20);
                sales.KunnrAdrUr = "b" + rnd.Next(0, 20);
                sales.KunnrArdDost = "b" + rnd.Next(0, 20);
                sales.KunnrBin = rnd.Next(11111111, 99999999);
                sales.KunnrTxt = "b" + rnd.Next(0, 20);
                sales.Lgort = "b" + rnd.Next(0, 20);
                sales.SalesChanelTxt = (SalesChanelTxt)rnd.Next(0,3);
                sales.Summ = rnd.Next();
                saleses.Add(sales);
            }

            return saleses;
        }

        private Random rnd = new Random(); 
    }
}
