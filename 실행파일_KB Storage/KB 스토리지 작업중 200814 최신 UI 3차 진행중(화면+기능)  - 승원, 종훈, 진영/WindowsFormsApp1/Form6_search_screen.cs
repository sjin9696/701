using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Storagy
{
    public partial class Form6_search_screen : Form
    {
        public Form6_search_screen(string q)
        {
            InitializeComponent();
            dataGridView.DataSource = "";
            dataGridView.DataSource = new mssqlDataManager().SelectDB("select DISTINCT " +
                q +
                " from dbo.storage_db;").Tables[0];
        }

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string s = dataGridView.Columns[e.ColumnIndex].Name;
            DataGridViewRow d = dataGridView.Rows[e.RowIndex];

            if (("code,name,categorize,type").Contains(s))
            {
                Product.temporary_Product.code       = d.Cells[0].Value.ToString();
                Product.temporary_Product.name       = d.Cells[1].Value.ToString();
                Product.temporary_Product.categorize = d.Cells[2].Value.ToString();
                Product.temporary_Product.type       = d.Cells[3].Value.ToString();
            }
            else if(("buy_company").Contains(s))
            {
                Product.temporary_Product.buy_company = d.Cells[s].Value.ToString();
            }
            else if (("storage_location").Contains(s))
            {
                Product.temporary_Product.storage_location = d.Cells[s].Value.ToString();
            }
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
             "SELECT DISTICNT code, [name], categorize, type FROM dbo.storage_db ";
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
