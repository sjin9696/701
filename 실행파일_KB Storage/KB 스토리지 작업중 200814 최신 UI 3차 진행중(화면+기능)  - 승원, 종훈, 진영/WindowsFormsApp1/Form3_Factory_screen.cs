﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Storagy
{
    public partial class Form3_Factory_screen : Form
    {
        public Form3_Factory_screen()//첫실행 한번만
        {
            InitializeComponent();
            label_who_login.Text = userDataManager.UserInfos[0].ID + label_who_login.Text;
            label_who_login.AutoSize = true;

            label_nowTime.Text = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Form6_search_screen form6_Search_Screen = new Form6_search_screen();
            form6_Search_Screen.ShowDialog();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            IScustomData();
        }

        public void IScustomData()
        {
            List<Product> productsList = new List<Product>();
            Product product = new Product();

            product.product_code_number = textBox1_product_code_number.Text;
            product.product_name = textBox2_product_name.Text;
            product.categorize_name = textBox3_categorize_name.Text;
            product.type_name = textBox4_type_name.Text;
            product.storage_name = textBox5_storage_name.Text;
            product.customer_name = textBox6_customer_name.Text;
            product.delivery_dates = textBox8_delivery_day.Text;
            product.sales_dates = textBox9_sales_number.Text;
            product.money_number = textBox10_money_number.Text;
            product.storage_inventoy_number = textBox11_inventory_stock_number.Text;
            productsList.Add(product);
            Console.WriteLine(product.product_name + " product.name");

            dataGridView_outProduct.DataSource = null;
            dataGridView_outProduct.DataSource = productsList;
        }

        private void button_reform_Click(object sender, EventArgs e)
        {
            Form8_Reform form8 = new Form8_Reform();
            form8.ShowDialog();
        }

        private void button_all_inventory_Click(object sender, EventArgs e)
        {
            Form4_all_inventory_screen form4_all_inventory = new Form4_all_inventory_screen();
            form4_all_inventory.ShowDialog();
        }
        private void Form1_Factory_screen_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Form1_Factory_screen_Activated 활성화 하였습니다.");
            if(xmlDataManager.temp_Product != null)
            {
                textBox1_product_code_number.Text = xmlDataManager.temp_Product.product_code_number;
                textBox2_product_name.Text = xmlDataManager.temp_Product.product_name;
                textBox3_categorize_name.Text = xmlDataManager.temp_Product.categorize_name;
                textBox4_type_name.Text = xmlDataManager.temp_Product.type_name;
                textBox5_storage_name.Text = xmlDataManager.temp_Product.storage_name;
                textBox6_customer_name.Text = xmlDataManager.temp_Product.customer_name;
                textBox11_inventory_stock_number.Text = xmlDataManager.temp_Product.storage_inventoy_number;
                textBox8_delivery_day.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            }
        }
    }
}
