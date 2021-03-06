﻿using System;
using System.Windows.Forms;

namespace Storagy
{
    public partial class Form7_newmember : Form
    {
        public Form7_newmember()
        {
            InitializeComponent();
            newmember();

        }
        private void newmember()
        {
            userDataManager.Load_User_Data();
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = userDataManager.UserInfos;
        }

        private void button_xml_insert_Click(object sender, System.EventArgs e)
        {
            UserInfo userInfo = getByElement();

            foreach (var item in userDataManager.UserInfos)
            {
                if (item.ID.Contains(userInfo.ID))
                {
                    MessageBox.Show("입력 값이 부족합니다.\n중복된 아이디가 있습니다. \n다른 아이디로 등록해주세요."); 
                    return;
                }
            }
            userDataManager.UserInfos.Add(userInfo);
            MessageBox.Show("신규 추가 되었습니다.");
        }

        private UserInfo getByElement()
        {
            return new UserInfo()
            {
                ID = textBox1_id.Text,
                PW = textBox2_pw.Text,
                Name = textBox3_name.Text,
                Group = comboBox4_group.Text,
                PhoneNumber = textBox5_phone_number.Text
            };
        }

        private void button_info_update_Click(object sender, System.EventArgs e)
        {
            //수정하기
            int update_row_index = 0;

            UserInfo userInfo = getByElement();
            
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
        }
        private void button_info_delete_Click(object sender, System.EventArgs e)
        {
            //삭제하기
            int update_row_index = 0;

            UserInfo userInfo = getByElement();

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

            
        }
        private void button_close_notSave_Click(object sender, System.EventArgs e)
        {
            DialogResult res = MessageBox.Show(this, "저장하지 않고 바로 나갈까요?.", "저장하지 않고 닫기", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (res == DialogResult.OK)
            {
                MessageBox.Show("저장하지 않았습니다.");
                this.Close();
            }
        }

        private void button_close_save_Click(object sender, System.EventArgs e)
        {
            DialogResult res = MessageBox.Show(this, "저장할까요?.", "저장 후 닫기", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if(res==DialogResult.OK)
            {
                MessageBox.Show("저장 되었습니다.");
                userDataManager.Save_File(userDataManager.Read_Products());
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2_pw.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3_name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBox4_group.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox5_phone_number.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                System.Console.WriteLine(e.RowIndex);
                if (e.RowIndex is -1) return; //컬럼범위를 선택하였을때 처리.
            }
        }
        private void Form7_newmember_Activated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = userDataManager.UserInfos;
        }
    }
}
