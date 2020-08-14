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
    public partial class Form1 : Form
    {
        string Define_str정의 = " ";//값을 입력해주세요.
        public Form1()//첫실행 한번만
        {
            InitializeComponent();

            //화면 구성 속성 !! 나중에 디자인으로 옮길것!
            InitializeViewType();

        }

        private void InitializeViewType()
        {
            label12.AutoSize = true;
            textBox8_delivery_date.AutoSize = true;
        }
        private String SetNowTimeView(string get)
        {
            //인자get 표시형식 "yyyy-MM-dd HH:mm:ss"
            return DateTime.Now.ToString(get);
        } 
        private void timer1_Tick(object sender, EventArgs e)
        {
            //1000ms 마다 실행 interval
            label12.Text = SetNowTimeView("yyyy-MM-dd HH:mm:ss");
        }
        private void button_data_input_Click(object sender, EventArgs e)
        {
            
            if(textBox9_unit_sales.Text.Trim() == "")
            {
                MessageBox.Show("판매수량을 입력하세요!!","입력 할 수 없습니다.");
            }
            else //if(textBox9_unit_sales.Text.Trim() != "")
            {
                IScustomData(); // 그리드뷰 데이터 입력하기. - 작업자 :송진영 작업일시 :200812
            }
            
        }
        private void IScustomData()
        {
            Products product = new Products();
            List<Products> productsList = new List<Products>();
            product.code =          textBox1_code.Text;
            product.name =          textBox2_name.Text;
            product.categorize =    textBox3_cateforize.Text;
            product.type =          textBox4_type.Text;
            product.storage_location = textBox5_storage_location.Text;
            product.customer =      textBox6_customer.Text;
            product.barcode =       textBox7_barcode.Text;
            product.delivery_date = textBox8_delivery_date.Text;
            product.unit_sales =    textBox9_unit_sales.Text;
            product.money =         textBox10_money.Text;
            product.today =         textBox11_today.Text;
            product.quantity =      textBox12_quantity.Text;
            productsList.Add(product);
            Console.WriteLine(product.name + " product.name");
            
            //dataGridView_output.DataSource = null;
            dataGridView_output.DataSource = productsList;
        }

        private void button_code_search_Click(object sender, EventArgs e)
        {
            string text = textBox1_code.Text;
            textBox2_name.Text = text;
            textBox3_cateforize.Text = text;
            textBox4_type.Text = text;
            textBox5_storage_location.Text = text;
            textBox6_customer.Text = text;
            textBox7_barcode.Text = text;
            textBox8_delivery_date.Text = text;
            textBox9_unit_sales.Text = Define_str정의;
            textBox10_money.Text = text;
            textBox11_today.Text = textBox8_delivery_date.Text;
            textBox12_quantity.Text = text+" EA(임시수량)";
        }

        private void button_name_search_Click(object sender, EventArgs e)
        {
            string text = textBox2_name.Text;
            textBox1_code.Text = text;
            //textBox2_name.Text = text;
            textBox3_cateforize.Text = text;
            textBox4_type.Text = text;
            textBox5_storage_location.Text = text;
            textBox6_customer.Text = text;
            textBox7_barcode.Text = text;
            //textBox8_delivery_date.Text = text;
            textBox9_unit_sales.Text = Define_str정의;
            textBox10_money.Text = text;
            textBox11_today.Text = textBox8_delivery_date.Text;
            textBox12_quantity.Text = text + " EA(임시수량)";
        }

        private void button_customer_search_Click(object sender, EventArgs e)
        {
            string text = textBox2_name.Text;
            textBox1_code.Text = text;
            //textBox2_name.Text = text;
            textBox3_cateforize.Text = text;
            textBox4_type.Text = text;
            textBox5_storage_location.Text = text;
            textBox6_customer.Text = text;
            textBox7_barcode.Text = text;
            //textBox8_delivery_date.Text = text;
            textBox9_unit_sales.Text = Define_str정의;
            textBox10_money.Text = text;
            textBox11_today.Text = textBox8_delivery_date.Text;
            textBox12_quantity.Text = text + " EA(임시수량)";
        }
    }
}
