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
    public partial class Form6_search_or_modify_screen : Form
    {
        public Form6_search_or_modify_screen()
        {
            InitializeComponent();
            dataGridView_all_incentory.DataSource = xmlDataManager.Products;
            xmlDataManager.Load_File();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("textBox1_TextChanged");
        }

        private void button_serch_Click(object sender, EventArgs e)
        {
            xmlDataManager.Load_File();
            List<Product> products_list = new List<Product>();
            products_list = xmlDataManager.Products.FindAll(item =>
                (item.product_code_number == textBox1.Text) ||
                (item.product_name == textBox2.Text) ||
                (item.customer_name == textBox3.Text));

            dataGridView_all_incentory.DataSource = products_list;

        }
    }
}
