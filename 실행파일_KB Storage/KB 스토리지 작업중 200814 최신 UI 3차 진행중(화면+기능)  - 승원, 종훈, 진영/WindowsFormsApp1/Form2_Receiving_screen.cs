using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
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

           /* dataGridView1.DataSource = new mssqlDataManager().SelectDB("" +
                "select code, [name], categorize, type, buy_company, buy_date, buy_money, storage_location, storage_quantity " +
                "from dbo.storage_db;").Tables[0];*/
            label15.Text = UserInfo.nowName + label15.Text;
            label15.AutoSize = true;
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
        private Product getByElement()
        {
            return new Product()
            {
                code = textBox1_code.Text,
                name = textBox2_name.Text,
                categorize = textBox3_categorize.Text,
                type = textBox4_type.Text,
                buy_company = textBox5_buy_company.Text,
                buy_date = dateTimePick6_buy_date.Text,
                buy_money = textBox7_buy_money.Text,
                storage_location = textBox8_storage_location.Text,
                storage_quantity = textBox9_storage_quantity.Text
            };
        }
        private void IScustomData() //그리드뷰 데이터 입력표시 함수
        {
            Product product = getByElement();
                        
            if(textBox1_code.Text == "")
            {
                MessageBox.Show("값을 입력하세요.");
                return;
            }

            foreach (Product p in Product.productsList)
            {
                if (product.Equal(p) && Product.productsList.Count != 0)
                {
                    MessageBox.Show("중복 입력입니다.");
                    return;
                }
            }

            Product.productsList.Add(product);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Product.productsList;
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
            Console.WriteLine(Product.temporary_Product.buy_company);
            textBox1_code.Text          = Product.temporary_Product.code;
            textBox2_name.Text          = Product.temporary_Product.name;
            textBox3_categorize.Text    = Product.temporary_Product.categorize;
            textBox4_type.Text          = Product.temporary_Product.type;
            textBox5_buy_company.Text   = Product.temporary_Product.buy_company;
            //dateTimePick6_buy_date.Text   = Product.temporary_Product.buy_date;
            //textBox7_buy_money.Text   = Product.temporary_Product.buy_money;
            textBox8_storage_location.Text   = Product.temporary_Product.storage_location;
            //textBox9_storage_quantity.Text   = Product.temporary_Product.storage_quantity;
        }

        #region 검색 버튼 이벤트 code, buy,storage
        private void button1_search_code_Click(object sender, EventArgs e)
        {
            Form6_search_screen form6_Search_Screen = new Form6_search_screen("code, [name], categorize, type");
            form6_Search_Screen.ShowDialog();
        }

        private void button2_search_buy_com_Click(object sender, EventArgs e)
        {
            Form6_search_screen form6_Search_Screen = new Form6_search_screen("buy_company");
            form6_Search_Screen.ShowDialog();
        }

        private void button3_search_storage_Click(object sender, EventArgs e)
        {
            Form6_search_screen form6_Search_Screen = new Form6_search_screen("storage_location");
            form6_Search_Screen.ShowDialog();
        }
        #endregion

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(dateTimePick6_buy_date.Value.ToString("yyyy-MM-d"));
        }

        private void textBox7_buy_money_TextChanged(object sender, EventArgs e)
        { 
            if(Regex.IsMatch(textBox7_buy_money.Text,"[^0-9.,]"))
            {
                MessageBox.Show("숫자[0-9].,만입력가능합니다.");
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Product p = Product.productsList[e.RowIndex];

            textBox1_code.Text = p.code;
            textBox2_name.Text = p.name;
            textBox3_categorize.Text = p.categorize;
            textBox4_type.Text = p.type;
            textBox5_buy_company.Text = p.buy_company;
            dateTimePick6_buy_date.Text = p.buy_date;
            textBox7_buy_money.Text = p.buy_money;
            textBox8_storage_location.Text = p.storage_location;
            textBox9_storage_quantity.Text = p.storage_quantity;
        }

        private void button_delete_all_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
                return;
            DialogResult res = MessageBox.Show(this, "정말 모두 삭제할까요?.", "모두 삭제", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (res == DialogResult.OK)
            {
                MessageBox.Show("모두 삭제 되었습니다.");
                Product.productsList.Clear();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Product.productsList;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
                return;
            DialogResult res = MessageBox.Show(this, "정말 삭제할까요?.", "선택 삭제", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            if (res == DialogResult.OK)
            {
                MessageBox.Show("선택 삭제 되었습니다.");
                Product.productsList.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Product.productsList;
            }
        }

        private void button_modified_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
                return;

            //수정하기
            int ri = dataGridView1.SelectedCells[0].RowIndex;

            Product product = getByElement();

            foreach (Product p in Product.productsList)
            {
                if (product.Equal(p) && Product.productsList.Count != 0)
                {
                    MessageBox.Show("기존 입력 값 중에서 중복되는 값이 있습니다.");
                    return;
                }
            }
            if (ri < Product.productsList.Count)
            {
                Product.productsList.RemoveAt(ri);
                Product.productsList.Insert(ri, product);
                MessageBox.Show(product.code + "가 수정되었습니다.");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Product.productsList;
            }
               
        }

        private void button_insert_db_Click(object sender, EventArgs e)
        {
            mssqlDataManager ms = new mssqlDataManager();
            string cmdText = "insert into dbo.storage_db ";
            string c = "(";
            string a = "";
            string r = "\n VALUES \n";
            
            foreach (DataGridViewTextBoxColumn item in dataGridView1.Columns)
                c += $"[{item.Name}],";

            c = c.Remove(c.Length - 1);
            c += ")";
            
            foreach (DataGridViewRow jtem in dataGridView1.Rows)
            {
                a += string.Format("({0},'{1}','{2}','{3}'" + ",'{4}','{5}',{6}," + "'{7}',{8}," + "{9},'{10}','{11}'),\n"
                    , jtem.Cells["code"].Value.ToString() , jtem.Cells["name"].Value.ToString() , jtem.Cells["categorize"].Value.ToString()
                    , jtem.Cells["type"].Value.ToString() , jtem.Cells["buy_company"].Value.ToString()
                    , "2021-01-18 09:17:00"
                    //, jtem.Cells["buy_date"].Value.ToString()
                    , jtem.Cells["buy_money"].Value.ToString()
                    , jtem.Cells["storage_location"].Value.ToString()
                    , jtem.Cells["storage_quantity"].Value.ToString()
                    ,"0"
                    ,"2021-01-18 09:17:00"
                    ,"a"
                    //Console.WriteLine( jtem.Cells["sales_money"].Value.ToString());
                    //Console.WriteLine( jtem.Cells["sales_dates"].Value.ToString());
                    //Console.WriteLine( jtem.Cells["sales_company"].Value.ToString());
                    );
            }
            a = a.Remove(a.Length-2);
            Console.WriteLine(cmdText+c+r+a);
            string q = cmdText + c + r + a;
            ms.InsertDB(q);
        }
    }
}
