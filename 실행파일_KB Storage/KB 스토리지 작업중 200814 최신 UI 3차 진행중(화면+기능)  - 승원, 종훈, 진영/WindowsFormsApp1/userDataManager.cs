using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace xmlDataManager
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
                    ID = item.Element("id_name").Value,
                    PW = item.Element("pw").Value,
                    Admin = item.Element("admin").Value
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
                    res = item.Admin;
                }
            }
            return res;
        }
    }
}
