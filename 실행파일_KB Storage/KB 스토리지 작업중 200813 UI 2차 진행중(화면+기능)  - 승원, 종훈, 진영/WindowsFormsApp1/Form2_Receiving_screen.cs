using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2_Receiving_screen : Form
    {
        public Form2_Receiving_screen()
        {
            InitializeComponent();
            label12.Text = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6_search_or_modify_screen form6_Search_Screen = new Form6_search_or_modify_screen();
            form6_Search_Screen.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5_new_regist form5_New_Regist = new Form5_new_regist();
            form5_New_Regist.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6_search_or_modify_screen form6_Search_Screen = new Form6_search_or_modify_screen();
            form6_Search_Screen.ShowDialog();
        }
    }
}
