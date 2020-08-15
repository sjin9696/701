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
        public static void Save_Products()
        {
            const string HEAD = "<Product>";
            const string NEWLINE = "\n";
            
            string productOutput = "";
            productOutput += HEAD + NEWLINE;

        }
    }

    
}
