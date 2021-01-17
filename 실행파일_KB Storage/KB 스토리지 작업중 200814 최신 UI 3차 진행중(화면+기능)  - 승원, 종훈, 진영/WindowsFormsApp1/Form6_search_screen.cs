using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Storagy
{
    public partial class Form6_search_screen : Form
    {
        public Form6_search_screen()
        {
            InitializeComponent();
            //dataGridView1.DataSource = new mssqlDataManager().ConnectDB().Tables[0];
            //dataGridView_all_incentory.DataSource = xmlDataManager.ProductsList;
            xmlDataManager.Load_File();
        }
        
        private void Form6_search_screen_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = "";
            dataGridView.DataSource = new mssqlDataManager().SelectDB("select " +
                "code, [name], categorize, type from dbo.storage_db;").Tables[0];
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Product.temporary_Product.code          = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            Product.temporary_Product.name          = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            Product.temporary_Product.categorize    = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            Product.temporary_Product.type          = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

            MessageBox.Show("데이터가 불러들여졌습니다.");
            Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            xmlDataManager.Load_File();
            List<Product> products_list = new List<Product>();
            products_list = xmlDataManager.ProductsList.FindAll(item =>
                (item.code == textBox1.Text) ||
                (item.name == textBox2.Text) ||
                (item.buy_date == textBox3.Text));

            //dataGridView_all_incentory.DataSource = products_list;
        }
    }
}
