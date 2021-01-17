using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace Storagy
{
    class xmlDataManager
    {
        public static List<Product> ProductsList = new List<Product>();
        public static Product temp_Product = new Product();
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
                        code = item.Element("code").Value,
                        name = item.Element("name").Value,
                        categorize = item.Element("categorize").Value,
                        type = item.Element("type").Value,
                        buy_date = item.Element("buy_company").Value,//구매처
                        buy_money = item.Element("buy_date").Value, //구매일자 
                        storage_location = item.Element("buy_money").Value, //구매금액
                        storage_quantity = item.Element("storage_location").Value,//위치
                        sales_money = item.Element("storage_quantity").Value,//재고수량
                        sales_company = item.Element("sales_money").Value,//판매금액
                        sales_dates = item.Element("sales_dates").Value,//판매일자
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
                element += XML("code", item.code);
                element += XML("name", item.name);
                element += XML("categorize", item.categorize);
                element += XML("type", item.type);
                element += XML("customer", item.buy_date);
                element += XML("delivery", item.buy_money);
                element += XML("money", item.storage_location);
                element += XML("storage", item.storage_quantity);
                element += XML("storage_inventoy", item.sales_money);
                element += XML("sales_money", item.sales_company);
                element += XML("sales_dates", item.sales_dates);
                
                productOutput += XML("item", element);
            }
            productOutput = XML("product", productOutput); //마지막으로 닫기 위해서.
            
            Console.WriteLine("public static string Read_Products()" + productOutput);
            Console.WriteLine("Products.Count" + ProductsList.Count);
            return productOutput;
        }

        internal class UserInfo
        {
        }
    }
}
