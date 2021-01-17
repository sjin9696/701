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
        }
        
        private void Form6_search_screen_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = "";
            dataGridView.DataSource = new mssqlDataManager().SelectDB("select " +
                "code, [name], categorize, type from dbo.storage_db;").Tables[0];
        }

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Product.temporary_Product.code = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            Product.temporary_Product.name = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            Product.temporary_Product.categorize = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            Product.temporary_Product.type = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("데이터가 불러들여졌습니다.");
            Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string select =
            #region MS-SQL 쿼리문  /// IF NOT EXISTS 사용 조회시 NULL값이라면 전체값 표시
             "SELECT code, [name], categorize, type FROM dbo.storage_db ";
            string where =  "WHERE name ='"         + textBox2_name.Text +
                            "' OR categorize = '"   + textBox3_categorize.Text +
                            "' OR type = '"         + textBox4_type.Text + "' ";
            string query = "IF NOT EXISTS(" + select + where + ")BEGIN " + select +"END " 
                + "ELSE BEGIN " + select + where + "END ";
            #endregion

            dataGridView.DataSource = "";
            dataGridView.DataSource = new mssqlDataManager().SelectDB(query).Tables[0];
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("데이터가 불러들여졌습니다.");
            Close();
        }
        
    }
}
