using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Storagy
{
    public partial class Form5_new_regist : Form
    {
        public Form5_new_regist()
        {
            InitializeComponent();
            //xmlDataManager.Load_File();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button_input_Click");
            IS_Add_Grid();
        }
       

        private void button_all_inventory_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button_all_inventory_Click");
            Form4_all_inventory_screen form4 = new Form4_all_inventory_screen();
            form4.ShowDialog();
        }

        private void button_temp_List_add_list_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button_temp_List_add_list_Click");
            ISaddProductList();
        }
        
        private readonly List<Product> productslist = new List<Product>();
        private void IS_Add_Grid()
        {
            Console.WriteLine("IS_Add_Grid");
            Product product = new Product();

            product.code = textBox1_product_code_number.Text;
            product.name = textBox2_product_name.Text;
            product.categorize = textBox3_categorize_name.Text;
            product.type = textBox4_type_name.Text;
            product.storage_quantity = textBox5_storage_name.Text;
            product.buy_date = textBox6_customer_name.Text;
            
            product.buy_money = textBox8_delivery_day.Text;
            product.sales_company = textBox9_sales_number.Text;
      
            productslist.Add(product);

            dataGridView_outProduct.DataSource = null;
            dataGridView_outProduct.DataSource = productslist;
        }

        public void ISaddProductList()
        {
            Console.WriteLine("ISaddProductList");
           
            //기존에 있는 리스트 뒤에 추가는 아니다.
           // xmlDataManager.Products.Add(product); //리스트 추가

            //임시 리스트에 넣은 후 기존 큰 리스트에 입력을 한다.
            xmlDataManager.ProductsList.AddRange(productslist);

            //입력 창이니 만큼 새로운 리스트를 추가해서 보여주도록 하자.
            dataGridView_outProduct.DataSource = null;

            //dataGridView_outProduct.DataSource = null;
            //dataGridView_outProduct.DataSource = xmlDataManager.Products; //grid에 표시

            xmlDataManager.Save_File(xmlDataManager.Read_Products()); //파일로 내보내기.
            //Console.WriteLine("Products.Count " + xmlDataManager.Products.Count);

        }
    }
}
