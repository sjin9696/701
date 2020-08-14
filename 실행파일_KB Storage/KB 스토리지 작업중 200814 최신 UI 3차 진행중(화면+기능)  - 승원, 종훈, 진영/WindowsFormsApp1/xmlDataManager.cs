using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlDataManager
{
    class xmlDataManager
    {
        public static List<Product> Products = new List<Product>();
        public static List<UserInfo> userInfos = new List<UserInfo>();

        public static void Save_File(string contents)
        {
            //string fileName = @".ProductsList.xml";
            File.WriteAllText(@"./ProductsList.xml", contents);
        }
    }
}
