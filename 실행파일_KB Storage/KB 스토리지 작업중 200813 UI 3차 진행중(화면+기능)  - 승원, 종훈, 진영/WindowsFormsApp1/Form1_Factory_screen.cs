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
    public partial class Form1_Factory_screen : Form
    {
        public Form1_Factory_screen()//첫실행 한번만
        {
            InitializeComponent();
            System.DateTime.Now.ToString("yyyy");
            label12.Text = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

        }

        private void label12_Click(object sender, EventArgs e)//라벨 클릭할때마다 
        {
           


        

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

        private void button2_Click(object sender, EventArgs e)
        {
            Form6_search_or_modify_screen form6_Search_Screen = new Form6_search_or_modify_screen();
            form6_Search_Screen.ShowDialog();
        }
    }
}
