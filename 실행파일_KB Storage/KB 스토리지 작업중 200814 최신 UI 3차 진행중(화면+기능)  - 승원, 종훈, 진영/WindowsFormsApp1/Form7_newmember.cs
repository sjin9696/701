using System.Collections.Generic;
using System.Windows.Forms;

namespace xmlDataManager
{
    public partial class Form7_newmember : Form
    {
        public Form7_newmember()
        {
            InitializeComponent();
            userDataManager.Load_User_Data();
            newmember();
            System.Console.WriteLine("Form7_newmember");
        }
        private void newmember()
        {
            System.Console.WriteLine(userDataManager.UserInfos[0].ID);
            foreach(var item in userDataManager.UserInfos)
            {
                System.Console.WriteLine(item.ID);
                System.Console.WriteLine(item.PW);
            }
            dataGridView1.DataSource = userDataManager.UserInfos;
        }

        private void button_xml_insert_Click(object sender, System.EventArgs e)
        {
            //추가 후 저장.
            UserInfo userInfo = new UserInfo()
            {
                ID = textBox1_id.Text,
                PW = textBox2_pw.Text,
                Admin = textBox3_name.Text
            };
            //기존 리스트 ID 중복검사.
            foreach (var item in userDataManager.UserInfos)
            {
                if (item.ID.Contains(userInfo.ID))
                {
                    MessageBox.Show("입력 값이 부족합니다.\n" +
                        "중복된 아이디가 있습니다. \n" +
                        "다른 아이디로 등록해주세요."); 
                    return;
                }
            }
            //없으면 리스트,그리드뷰에 추가.
            userDataManager.UserInfos.Add(userInfo);
            MessageBox.Show("신규 추가 되었습니다.");
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = userDataManager.UserInfos;
        }

        private void button_info_update_Click(object sender, System.EventArgs e)
        {
            //수정하기
            int update_row_index = 0;

            UserInfo userInfo = new UserInfo()
            {
                ID = textBox1_id.Text,
                PW = textBox2_pw.Text,
                Admin = textBox3_name.Text
            };
            //기존 리스트 ID 중복검사.
            foreach (var item in userDataManager.UserInfos)
            {
                if (item.ID.Contains(userInfo.ID))  
                    break;
                update_row_index++;
            }

            if(update_row_index < userDataManager.UserInfos.Count)
            {
                userDataManager.UserInfos.RemoveAt(update_row_index);
                userDataManager.UserInfos.Insert(update_row_index,userInfo);
                MessageBox.Show(userInfo.ID+"가 수정되었습니다.");
            }
            else
                MessageBox.Show("수정하려는 ID가 없습니다.\n" +
                    "신규 추가를 하시려면 신규추가를 눌러주세요.");

            dataGridView1.DataSource = "";
            dataGridView1.DataSource = userDataManager.UserInfos;
        }

        private void button_info_delete_Click(object sender, System.EventArgs e)
        {
            //삭제하기
            int update_row_index = 0;

            UserInfo userInfo = new UserInfo()
            {
                ID = textBox1_id.Text,
                PW = textBox2_pw.Text,
                Admin = textBox3_name.Text
            };
            //기존 리스트 ID 중복검사.
            foreach (var item in userDataManager.UserInfos)
            {
                if (item.ID.Contains(userInfo.ID))
                    break;
                update_row_index++;
            }

            if (update_row_index < userDataManager.UserInfos.Count)
            {
                userDataManager.UserInfos.RemoveAt(update_row_index);
                MessageBox.Show(userInfo.ID + "가 삭제되었습니다.");
            }
            else
                MessageBox.Show("삭제하려는 ID가 없습니다.\n" +
                    "삭제하려면 ID를 정확히 맞춰주세요.\n" +
                    "신규 추가를 하시려면 신규추가를 눌러주세요.");

            dataGridView1.DataSource = "";
            dataGridView1.DataSource = userDataManager.UserInfos;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2_pw.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3_name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
