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

        private void button_data_input_Click(object sender, EventArgs e)
        {
            IScustomData();
        }
        public void IScustomData()
        {
            Products product = new Products();
            List<Products> productsList = new List<Products>();

            product.product_code_number = textBox1_product_code_number.Text;
            product.product_name = textBox2_product_name.Text;
            product.categorize_name = textBox3_categorize_name.Text;
            product.type_name = textBox4_type_name.Text;
            product.storage_name = textBox5_storage_name.Text;
            product.customer_name = textBox6_customer_name.Text;
            product.barcode_number = textBox7_barcode_number.Text;
            product.delivery_day = textBox8_delivery_day.Text;
            product.sales_number = textBox9_sales_number.Text;
            product.money_number = textBox10_money_number.Text;
            product.inventory_stock_number = textBox11_inventory_stock_number.Text;
            productsList.Add(product);
            Console.WriteLine(product.product_name + " product.name");

            dataGridView_outProduct.DataSource = null;
            dataGridView_outProduct.DataSource = productsList;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
