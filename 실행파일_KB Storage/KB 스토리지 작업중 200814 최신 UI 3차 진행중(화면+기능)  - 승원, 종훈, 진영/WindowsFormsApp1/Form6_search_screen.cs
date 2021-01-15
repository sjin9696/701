using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace xmlDataManager
{
    public partial class Form6_search_screen : Form
    {
        public Form6_search_screen()
        {
            InitializeComponent();
            dataGridView_all_incentory.DataSource = xmlDataManager.ProductsList;
            xmlDataManager.Load_File();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            xmlDataManager.Load_File();
            List<Product> products_list = new List<Product>();
            products_list = xmlDataManager.ProductsList.FindAll(item =>
                (item.product_code_number == textBox1.Text) ||
                (item.product_name == textBox2.Text) ||
                (item.customer_name == textBox3.Text));

            dataGridView_all_incentory.DataSource = products_list;
        }

        private void dataGridView_all_incentory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xmlDataManager.temp_Product = xmlDataManager.ProductsList[e.RowIndex];
            MessageBox.Show("데이터가 불러들여졌습니다.");
            Close();
        }
    }
}
