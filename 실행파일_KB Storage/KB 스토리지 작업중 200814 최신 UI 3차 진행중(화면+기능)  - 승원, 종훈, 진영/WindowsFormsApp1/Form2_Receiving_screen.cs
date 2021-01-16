﻿using System;
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
            dataGridView1.DataSource = new mssqlDataManager().ConnectDB().Tables[0];
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
        private void button_input_Click_1(object sender, EventArgs e)
        {
            IScustomData();
        }

        private void IScustomData() //그리드뷰 데이터 입력표시 함수
        {
            Console.WriteLine(textBox2_product_name.Text + " textBox2_product_name.Text");
            Product product = new Product();
            List<Product> productsList = new List<Product>();

            product.product_code_number = textBox1_product_code_number.Text;
            product.product_name = textBox2_product_name.Text;
            product.categorize_name = textBox3_categorize_name.Text;
            product.type_name = textBox4_type_name.Text;
            product.storage_name = textBox5_storage_name.Text;
            product.customer_name = textBox6_customer_name.Text;
         
            product.delivery_dates = textBox8_delivery_day.Text;
            product.sales_dates = textBox9_sales_number.Text;
            product.sales_money_number = textBox10_money_number.Text;
            product.storage_inventoy_number = textBox11_inventory_stock_number.Text;
            productsList.Add(product);
            Console.WriteLine(product.product_name + " product.name");

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
    }
}
