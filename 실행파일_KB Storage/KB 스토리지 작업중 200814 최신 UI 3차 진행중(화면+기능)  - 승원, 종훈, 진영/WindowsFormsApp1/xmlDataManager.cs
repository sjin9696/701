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
        public static List<Product> ProductsList = new List<Product>();

        public static void Load_File()
        {
            string file_name = "../../resouce/ProductsList.xml"; //파일 경로.
            try
            {
                string xml_datas = File.ReadAllText(file_name);
                Console.WriteLine(xml_datas);
                XElement xElement = XElement.Parse(xml_datas);
                ProductsList.Clear();
                foreach (var item in xElement.Descendants("item"))
                {
                    Product product = new Product()
                    {
                        product_code_number = item.Element("code").Value,
                        product_name = item.Element("name").Value,
                        categorize_name = item.Element("categorize").Value,
                        type_name = item.Element("type").Value,
                       // worker_name = item.Element("worker").Value,
                        customer_name = item.Element("customer").Value,
                        delivery_dates = item.Element("delivery").Value,
                        money_number = item.Element("money").Value,
                        storage_name = item.Element("storage").Value,
                        storage_inventoy_number = item.Element("storage_inventoy").Value,
                        sales_money_number = item.Element("sales_money").Value,
                        sales_dates = item.Element("sales_dates").Value
                    };
                    ProductsList.Add(product);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            Console.WriteLine("TOTAL_ Products.Count" + ProductsList.Count);
        }
        public static void Save_File(string contents)
        {
            //string fileName = @".ProductsList.xml";
            File.WriteAllText(@"../../resouce/ProductsList.xml", contents);
        }
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
            
            foreach (var item in ProductsList)
            {
                string element = "";
                element += XML("code", item.product_code_number);
                element += XML("name", item.product_name);
                element += XML("categorize", item.categorize_name);
                element += XML("type", item.type_name);
               // element += XML("worker", item.worker_name);
                element += XML("customer", item.customer_name);
                element += XML("delivery", item.delivery_dates);
                element += XML("money", item.money_number);
                element += XML("storage", item.storage_name);
                element += XML("storage_inventoy", item.storage_inventoy_number);
                element += XML("sales_money", item.sales_money_number);
                element += XML("sales_dates", item.sales_dates);
                
                productOutput += XML("item", element);
            }
            productOutput = XML("product", productOutput); //마지막으로 닫기 위해서.
            
            Console.WriteLine("public static string Read_Products()" + productOutput);
            Console.WriteLine("Products.Count" + ProductsList.Count);
            return productOutput;
        }
    }
}
