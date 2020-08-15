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
            string productOutput = "";
            
            productOutput = XML("product", productOutput);
            
            foreach (var item in Products)
            {
                productOutput += XML("code",item.product_code_number);
                productOutput += XML("name",item.product_name);
                productOutput += XML("categorize",item.categorize_name);
                productOutput += XML("type",item.type_name);
                productOutput += XML("barcode",item.barcode_number);
                productOutput += XML("sales",item.sales_number);
                productOutput += XML("money",item.money_number);
                productOutput += XML("delivery",item.delivery_day);
                productOutput += XML("customer",item.customer_name);
                productOutput += XML("storage",item.storage_name);
                productOutput += XML("inventory_stock",item.inventory_stock_number);
                productOutput += XML("worker",item.worker_name);

                productOutput = XML("item", productOutput);
            }
            
            Console.WriteLine("public static string Read_Products()" + productOutput);
            Console.WriteLine("Products.Count" + Products.Count);
            return productOutput;
        }
    }

    
}
