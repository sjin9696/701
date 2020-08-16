using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xmlDataManager
{
    class xmlDataManager
    {
        public static List<Product> Products = new List<Product>();
        public static List<UserInfo> userInfos = new List<UserInfo>();

        public static void Load_File()
        {
            string file_name = "./ProductsList.xml"; //파일 경로.
            string xml_datas = File.ReadAllText(file_name);
            XElement xElement = XElement.Parse(xml_datas);
            
            foreach (var item in xElement.Descendants("item"))
            {
                Product product = new Product()
                {
                    product_code_number = item.Element("code").Value,
                    product_name = item.Element("name").Value,
                    categorize_name = item.Element("categorize").Value,
                    type_name = item.Element("type").Value,
                    barcode_number = item.Element("barcode").Value,
                    sales_number = item.Element("sales").Value,
                    money_number = item.Element("money").Value,
                    delivery_day = item.Element("delivery").Value,
                    customer_name = item.Element("customer").Value,
                    storage_name = item.Element("storage").Value,
                    inventory_stock_number = item.Element("inventory_stock").Value,
                    worker_name = item.Element("worker").Value
                };
                
                Products.Add(product);
                Console.WriteLine("foreach Products.Count" + Products.Count);
            }
            Console.WriteLine("TOTAL_ Products.Count" + Products.Count);
        }
        public static void Save_File(string contents)
        {
            //string fileName = @".ProductsList.xml";
            File.WriteAllText(@"./ProductsList.xml", contents);
        }
        //기능 만들기
        //XML로 출력하기.
        public static string XML(string contents, string value)
        {
            return "<" + contents + ">" + value + "</" + contents + ">" + Environment.NewLine;
        }
        public static string Read_Products()
        {
            //Read_Products() 호출될때 마다. 파일을 완전 덮어씌워서 작성함...
            //추가가 아님. 나중에 방안을 찾아보자.
            Save_File("");//파일 초기화.
            Console.WriteLine("public static string Read_Products()>>>>");
            string productOutput = "";
            
            foreach (var item in Products)
            {
                string element = "";
                element += XML("code", item.product_code_number);
                element += XML("name", item.product_name);
                element += XML("categorize", item.categorize_name);
                element += XML("type", item.type_name);
                element += XML("barcode", item.barcode_number);
                element += XML("sales", item.sales_number);
                element += XML("money", item.money_number);
                element += XML("delivery", item.delivery_day);
                element += XML("customer", item.customer_name);
                element += XML("storage", item.storage_name);
                element += XML("inventory_stock", item.inventory_stock_number);
                element += XML("worker", item.worker_name);

                productOutput += XML("item", element);
            }
            productOutput = XML("product", productOutput); //마지막으로 닫기 위해서.
            
            Console.WriteLine("public static string Read_Products()" + productOutput);
            Console.WriteLine("Products.Count" + Products.Count);
            return productOutput;
        }
    }
}
