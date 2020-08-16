using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xmlDataManager
{
    class userDataManager
    {
        public static List<UserInfo> UserInfos = new List<UserInfo>();
        public static void Save_User_Data()
        {
            
        }
        public static void Save_File(string contents)
        {
            //string fileName = @".ProductsList.xml";
            File.WriteAllText(@"./userinfo.xml", "save us");
        }
        public static string XML(string contents, string value)
        {
            return "<" + contents + ">" + value + "</" + contents + ">" + Environment.NewLine;
        }
        public static void Load_User_Data()
        {
            string file_name = "../../resouce/UserInfoDB.xml"; //파일 경로.
            string xml_datas = File.ReadAllText(file_name);
            XElement xElement = XElement.Parse(xml_datas);
            UserInfos.Clear();
            foreach (var item in xElement.Descendants("item"))
            {
                UserInfo userInfo = new UserInfo()
                {
                    ID = item.Element("id_name").Value,
                    PW = item.Element("pw").Value,
                    Admin = item.Element("admin").Value
                };

                UserInfos.Add(userInfo);
                Console.WriteLine("userInfo.ID :" + userInfo.ID);
                Console.WriteLine("userInfo.PW :" + userInfo.PW);
                Console.WriteLine("userInfo.Admin :" + userInfo.Admin);
                Console.WriteLine("foreach Products.Count" + UserInfos.Count);
            }
            Console.WriteLine("TOTAL_ Products.Count" + UserInfos.Count);
        }
        public static bool Login_Check(string textbox_id, string textbox_pw)
        {
            Load_User_Data();
            foreach(var item in UserInfos)
            {
                if(item.ID != textbox_id && item.PW != textbox_pw)
                {
                    Console.WriteLine("비밀번호가 맞지 않습니다." + item.ID);
                }
                else if(item.ID == textbox_id && item.PW == textbox_pw)
                {
                    Console.WriteLine("아이디 비밀번호가 맞습니다." + item.ID);
                    return true;
                }
            }
            return false;
        }
    }
}
