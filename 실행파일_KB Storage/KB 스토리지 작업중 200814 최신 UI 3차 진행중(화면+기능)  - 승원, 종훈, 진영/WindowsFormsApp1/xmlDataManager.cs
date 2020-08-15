using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace xmlDataManager
{
    static class tag
    {
        public const string HEAD = "<HEAD>";
    }
   
    class xmlDataManager
    {
        

        public static List<Product> Products = new List<Product>();
        public static List<UserInfo> userInfos = new List<UserInfo>();

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
            
            productOutput = XML("product", productOutput);
            
            Console.WriteLine("public static string Read_Products()" + productOutput);
            Console.WriteLine("Products.Count" + Products.Count);
            return productOutput;
        }
    }

    
}
