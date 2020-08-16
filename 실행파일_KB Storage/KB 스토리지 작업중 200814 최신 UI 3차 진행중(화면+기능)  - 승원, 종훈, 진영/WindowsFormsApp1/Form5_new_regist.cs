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
    public partial class Form5_new_regist : Form
    {
        public Form5_new_regist()
        {
            InitializeComponent();
            dataGridView_outProduct.DataSource = null;
            dataGridView_outProduct.DataSource = xmlDataManager.Products; //grid에 추가.
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            IScustomData();
        }
        public void IScustomData()
        {
            Product product = new Product();

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
            
            xmlDataManager.Products.Add(product); //리스트 추가

            dataGridView_outProduct.DataSource = null;
            dataGridView_outProduct.DataSource = xmlDataManager.Products; //grid에 추가.

            xmlDataManager.Save_File(xmlDataManager.Read_Products()); //파일로 내보내기.
            //Console.WriteLine("Products.Count " + xmlDataManager.Products.Count);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4_all_inventory_screen form4 = new Form4_all_inventory_screen();
            form4.ShowDialog();
        }
    }
}
