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
            Form2_Receiving_screen form2 = new Form2_Receiving_screen();

            bool check = userDataManager.Login_Check(textBox_login_id.Text, textBox_login_pw.Text);
            Console.WriteLine("check : "+check);
            if(check)
            {
                Console.WriteLine(">>>>>>>>check : " + check);
                form2.ShowDialog();
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
