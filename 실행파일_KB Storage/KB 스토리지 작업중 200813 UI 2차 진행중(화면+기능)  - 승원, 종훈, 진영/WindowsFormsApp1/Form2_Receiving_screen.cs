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
            label12.AutoSize = true;
            /* ViewCustomTime();//시간표시 - 작업자 : 승원형 작업일시 : 200811
             * 내용 : 이동, 작업자 : 송진영, 작업일시 : 20200814 timer1_Tick함수로 이동함.*/
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

        private void button_input_Click(object sender, EventArgs e)
        {
            IScustomData();
        }
        private void IScustomData() //그리드뷰 데이터 입력표시 함수
        {
            Console.WriteLine(textBox2_product_name.Text + " textBox2_product_name.Text");
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

        private void ViewCustomTime()//시간표시 - 작업자 : 승원형 작업일시 : 200811
        {
            label12.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ViewCustomTime();//시간표시 - 작업자 : 승원형 작업일시 : 200811
        }
    }
}
