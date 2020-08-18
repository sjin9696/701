using System;
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
            login_check();
        }

        private void button_admin_login_Click(object sender, EventArgs e)
        {
            Form7_newmember form7_Newmember = new Form7_newmember();
            form7_Newmember.ShowDialog();
            //user_management();
            Console.WriteLine("button_admin_login_Click : " +((Button)sender).ToString());
            if((Button)sender == button_admin_login)
            {
                Console.WriteLine("");
            }
        }

        private void textBox_login_id_Click(object sender, EventArgs e)
        {
            textBox_login_id.Text = "";
        }

        private void textBox_login_pw_Click(object sender, EventArgs e)
        {
            textBox_login_pw.Text = "";
        }
        
        private void login_check()
        {
            xmlDataManager.Load_File();
            string check = userDataManager.Login_Check(textBox_login_id.Text, textBox_login_pw.Text);
            Form1_Factory_screen Factory_screen = new Form1_Factory_screen();
            Form2_Receiving_screen Receiving_screen = new Form2_Receiving_screen();
            Receiving_screen.Enabled = true;
            Console.WriteLine("check : " + check);
            try
            {
                switch (check)
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
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                Console.WriteLine(exception.Message);
            }
        }
        private void user_management()
        {
            Form7_newmember form7_Newmember = new Form7_newmember();
            form7_Newmember.ShowDialog();

        }
    }
}
