using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xmlDataManager
{
    public partial class Form3_Login : Form
    {
        public Form3_Login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            xmlDataManager.Load_File();
            Form1_Factory_screen Factory_screen = new Form1_Factory_screen();
            Form2_Receiving_screen Receiving_screen = new Form2_Receiving_screen();

            string check = userDataManager.Login_Check(textBox_login_id.Text, textBox_login_pw.Text);
            Console.WriteLine("check : "+check);
            switch(check)
            {
                case "관리자":
                    Factory_screen.ShowDialog();
                    break;
                case "입고담당자":
                    Receiving_screen.ShowDialog();
                    break;
                default:
                    MessageBox.Show("아이디 비밀번호를 확인하세요!");
                    Console.WriteLine(">>>>>>>>check : " + check);
                    break;
            }
        }

        private void button_admin_login_Click(object sender, EventArgs e)
        {
            xmlDataManager.Load_File();
            userDataManager.Load_User_Data();
            Form1_Factory_screen form1 = new Form1_Factory_screen();
            form1.ShowDialog();
        }

        private void textBox_login_id_Click(object sender, EventArgs e)
        {
            textBox_login_id.Text = "";
        }

        private void textBox_login_pw_Click(object sender, EventArgs e)
        {
            textBox_login_pw.Text = "";
        }


    }
}
