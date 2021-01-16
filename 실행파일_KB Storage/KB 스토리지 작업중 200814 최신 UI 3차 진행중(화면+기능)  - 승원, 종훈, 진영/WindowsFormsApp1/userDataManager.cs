using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace Storagy
{
    class userDataManager
    {
        public static List<UserInfo> UserInfos = new List<UserInfo>();
        public static void Load_User_Data()
        {
            string file_name = "../../resouce/UserInfoDB.xml"; //파일 경로.
            XElement xElement = XElement.Parse(File.ReadAllText(file_name));
            UserInfos.Clear();
            foreach (var item in xElement.Descendants("item"))
            {
                UserInfo userInfo = new UserInfo()
                {
                    ID = item.Element("id").Value,
                    PW = item.Element("pw").Value,
                    Name = item.Element("name").Value,
                    Group = item.Element("group").Value,
                    PhoneNumber = item.Element("phonenumber").Value
                };
                UserInfos.Add(userInfo);
            }
        }
        public static string Login_Check(string textbox_id, string textbox_pw)
        {
            Load_User_Data();
            string res = "NotThing";
            foreach(var item in UserInfos)
            {
                if (textbox_id == item.ID && textbox_pw == item.PW)
                {
                    Console.WriteLine("아이디 비밀번호가 맞습니다." + item.ID);
                    res = item.Group;
                }
            }
            return res;
        }
        public static bool UserListAdd(List<UserInfo> userinfo)
        {
            foreach (var item in userinfo)
            {
                UserInfos.Add(item);
            }
            return true;
        }

        public static void Save_File(string contents)
        {
            //string fileName = @".ProductsList.xml";
            File.WriteAllText(@"../../resouce/UserInfoDB.xml", contents);
        }
        public static string XML(string contents, string value)
        {
            return "<" + contents + ">" + value + "</" + contents + ">" + Environment.NewLine;
        }
        public static string Read_Products()
        {
            //Read_Products() 호출될때 마다. 파일을 완전 덮어씌워서 작성함...
            //추가가 아님. 나중에 방안을 찾아보자.
            //Save_File("");//파일 초기화.
            Console.WriteLine("public static string Read_Products()>>>>");
            string productOutput = "";

            foreach (var item in UserInfos)
            {
                string element = " ";
                element += XML("id", item.ID);
                element += XML("pw", item.PW);
                element += XML("name", item.Name);
                element += XML("group", item.Group);
                element += XML("phonenumber", item.PhoneNumber);

                productOutput += XML("item", element);
            }
            productOutput = XML("userinfo", productOutput); //마지막으로 닫기 위해서.

            Console.WriteLine("public static string Read_Products()" + productOutput);
            Console.WriteLine("Products.Count" + UserInfos.Count);
            return productOutput;
        }
    }
}
