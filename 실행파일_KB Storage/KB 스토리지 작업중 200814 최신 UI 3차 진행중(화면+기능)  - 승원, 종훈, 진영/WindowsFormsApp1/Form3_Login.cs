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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2_Receiving_screen form2 = new Form2_Receiving_screen();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1_Factory_screen form1 = new Form1_Factory_screen();
            form1.ShowDialog();
        }
    }
}
