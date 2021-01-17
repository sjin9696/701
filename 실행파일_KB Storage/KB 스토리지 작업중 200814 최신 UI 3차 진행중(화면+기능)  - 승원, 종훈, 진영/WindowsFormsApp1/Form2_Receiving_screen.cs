using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Storagy
{
    public partial class Form2_Receiving_screen : Form
    {
        public Form2_Receiving_screen()
        {
            InitializeComponent();
            label12.AutoSize = true;
            /* ViewCustomTime();//시간표시 - 작업자 : 승원형 작업일시 : 200811
             * 내용 : 이동, 작업자 : 송진영, 작업일시 : 20200814 timer1_Tick함수로 이동함.*/

            dataGridView1.DataSource = new mssqlDataManager().SelectDB("" +
                "select code, [name], categorize, type, buy_company, buy_date, buy_money, storage_location, storage_quantity " +
                "from dbo.storage_db;").Tables[0];
            label15.Text = UserInfo.nowName + label15.Text;
            label15.AutoSize = true;
        }

        private void button_search_screen_Click(object sender, EventArgs e)
        {
            Form6_search_screen form6_Search_Screen = new Form6_search_screen();
            form6_Search_Screen.ShowDialog();
        }
        private void button_new_regist_Click(object sender, EventArgs e)
        {
            Form5_new_regist form5_New_Regist = new Form5_new_regist();
            form5_New_Regist.ShowDialog();
        }
        private void button_input_Click(object sender, EventArgs e)
        {
            IScustomData();
        }

        private void IScustomData() //그리드뷰 데이터 입력표시 함수
        {
            Console.WriteLine(textBox2_name.Text + " textBox2_product_name.Text");
            Product product = new Product();
            List<Product> productsList = new List<Product>();

            product.code = textBox1_code.Text;
            product.name = textBox2_name.Text;
            product.categorize = textBox3_categorize.Text;
            product.type = textBox4_type.Text;
            product.storage_quantity = textBox5_buy_company.Text;
            product.buy_date = textBox6_buy_date.Text;
         
            product.buy_money = textBox7_buy_money.Text;
            product.sales_dates = textBox8_storage_location.Text;
            product.sales_company = textBox9_storage_quantity.Text;
            productsList.Add(product);
            Console.WriteLine(product.name + " product.name");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productsList;
        }
        private void ViewCustomTime()//시간표시 - 작업자 : 승원형 작업일시 : 200811
        {
            label12.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH:mm:ss");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ViewCustomTime();//시간표시 - 작업자 : 승원형 작업일시 : 200811
        }

        private void button_reform_Click(object sender, EventArgs e)
        {
            Form8_Reform form8 = new Form8_Reform();
            form8.ShowDialog();
        }
        private void button_all_inventory_Click(object sender, EventArgs e)
        {
            Form4_all_inventory_screen form4 = new Form4_all_inventory_screen();
            form4.ShowDialog();
        }

        private void Form2_Receiving_screen_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Form1_Factory_screen_Activated 활성화 하였습니다.");
            if (Product.temporary_Product.code != null)
            {
                textBox1_code.Text          = Product.temporary_Product.code;
                textBox2_name.Text          = Product.temporary_Product.name;
                textBox3_categorize.Text    = Product.temporary_Product.categorize;
                textBox4_type.Text          = Product.temporary_Product.type;
            }
        }

        private void Form2_Receiving_screen_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
