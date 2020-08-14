﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()//첫실행 한번만
        {
            InitializeComponent();
            ViewCustomTime();//시간표시 - 작업자 : 승원형 작업일시 : 200811

        }

        private void label12_Click(object sender, EventArgs e)//라벨 클릭할때마다 
        {

        }

        private void button_input_Click(object sender, EventArgs e)
        {
            IScustomData(); // 그리드뷰 데이터 초기화 - 작업자 :송진영 작업일시 :200812
        }
        private void IScustomData()
        {
            Products product = new Products();
            List<Products> productsList = new List<Products>();
            product.name = textBox2_name.Text;
            product.categorize = textBox3_cateforize.Text;
            product.type = textBox4_type.Text;
            product.barcode = textBox5_barcode.Text;
            product.unit_sales = textBox6_unit_sales.Text;
            product.money = textBox7_money.Text;
            product.delivery_date = textBox8_delivery_date.Text;
            product.customer = textBox8_delivery_date.Text;
            product.storage_location = textBox10_storage_location.Text;
            product.worker = textBox11_worker.Text;
            productsList.Add(product);
            Console.WriteLine(product.name + " product.name");

            productsList.Add(product);
            dataGridView_st.DataSource = null;
            dataGridView_st.DataSource = productsList;
        }
        private void ViewCustomTime()
        {
            System.DateTime.Now.ToString("yyyy");
            // Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));
            label12.Text = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        }
    }
}
