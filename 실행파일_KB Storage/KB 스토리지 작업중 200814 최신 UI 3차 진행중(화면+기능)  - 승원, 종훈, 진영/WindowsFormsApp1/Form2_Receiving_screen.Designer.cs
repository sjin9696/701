﻿namespace Storagy
{
    partial class Form2_Receiving_screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_Receiving_screen));
            this.button7 = new System.Windows.Forms.Button();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.button_input = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox9_storage_quantity = new System.Windows.Forms.TextBox();
            this.textBox8_storage_location = new System.Windows.Forms.TextBox();
            this.textBox7_buy_money = new System.Windows.Forms.TextBox();
            this.textBox6_buy_date = new System.Windows.Forms.TextBox();
            this.textBox5_buy_company = new System.Windows.Forms.TextBox();
            this.textBox4_type = new System.Windows.Forms.TextBox();
            this.textBox3_categorize = new System.Windows.Forms.TextBox();
            this.textBox2_name = new System.Windows.Forms.TextBox();
            this.textBox1_code = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(235, 111);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 29);
            this.button7.TabIndex = 50;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_search_screen_Click);
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label12.Location = new System.Drawing.Point(286, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 29);
            this.label12.TabIndex = 46;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_input
            // 
            this.button_input.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_input.Location = new System.Drawing.Point(364, 477);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(83, 42);
            this.button_input.TabIndex = 45;
            this.button_input.Text = "입력";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click_1);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Location = new System.Drawing.Point(930, 472);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 47);
            this.button6.TabIndex = 40;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(825, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 57);
            this.button4.TabIndex = 41;
            this.button4.Text = "전체 재고";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_all_inventory_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(825, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 53);
            this.button3.TabIndex = 44;
            this.button3.Text = "신규등록";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_new_regist_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(825, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 51);
            this.button2.TabIndex = 42;
            this.button2.Text = "반품/수정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_reform_Click);
            // 
            // textBox9_storage_quantity
            // 
            this.textBox9_storage_quantity.AllowDrop = true;
            this.textBox9_storage_quantity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9_storage_quantity.Location = new System.Drawing.Point(149, 433);
            this.textBox9_storage_quantity.Multiline = true;
            this.textBox9_storage_quantity.Name = "textBox9_storage_quantity";
            this.textBox9_storage_quantity.Size = new System.Drawing.Size(122, 29);
            this.textBox9_storage_quantity.TabIndex = 37;
            // 
            // textBox8_storage_location
            // 
            this.textBox8_storage_location.AllowDrop = true;
            this.textBox8_storage_location.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8_storage_location.Location = new System.Drawing.Point(149, 399);
            this.textBox8_storage_location.Multiline = true;
            this.textBox8_storage_location.Name = "textBox8_storage_location";
            this.textBox8_storage_location.Size = new System.Drawing.Size(122, 29);
            this.textBox8_storage_location.TabIndex = 35;
            // 
            // textBox7_buy_money
            // 
            this.textBox7_buy_money.AllowDrop = true;
            this.textBox7_buy_money.Enabled = false;
            this.textBox7_buy_money.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7_buy_money.Location = new System.Drawing.Point(149, 365);
            this.textBox7_buy_money.Multiline = true;
            this.textBox7_buy_money.Name = "textBox7_buy_money";
            this.textBox7_buy_money.Size = new System.Drawing.Size(122, 29);
            this.textBox7_buy_money.TabIndex = 34;
            // 
            // textBox6_buy_date
            // 
            this.textBox6_buy_date.AllowDrop = true;
            this.textBox6_buy_date.Enabled = false;
            this.textBox6_buy_date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6_buy_date.Location = new System.Drawing.Point(149, 331);
            this.textBox6_buy_date.Multiline = true;
            this.textBox6_buy_date.Name = "textBox6_buy_date";
            this.textBox6_buy_date.Size = new System.Drawing.Size(122, 29);
            this.textBox6_buy_date.TabIndex = 32;
            // 
            // textBox5_buy_company
            // 
            this.textBox5_buy_company.AllowDrop = true;
            this.textBox5_buy_company.Enabled = false;
            this.textBox5_buy_company.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5_buy_company.Location = new System.Drawing.Point(149, 297);
            this.textBox5_buy_company.Multiline = true;
            this.textBox5_buy_company.Name = "textBox5_buy_company";
            this.textBox5_buy_company.Size = new System.Drawing.Size(122, 29);
            this.textBox5_buy_company.TabIndex = 31;
            // 
            // textBox4_type
            // 
            this.textBox4_type.AllowDrop = true;
            this.textBox4_type.Enabled = false;
            this.textBox4_type.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_type.Location = new System.Drawing.Point(149, 263);
            this.textBox4_type.Multiline = true;
            this.textBox4_type.Name = "textBox4_type";
            this.textBox4_type.Size = new System.Drawing.Size(122, 29);
            this.textBox4_type.TabIndex = 30;
            // 
            // textBox3_categorize
            // 
            this.textBox3_categorize.AllowDrop = true;
            this.textBox3_categorize.Enabled = false;
            this.textBox3_categorize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_categorize.Location = new System.Drawing.Point(149, 229);
            this.textBox3_categorize.Multiline = true;
            this.textBox3_categorize.Name = "textBox3_categorize";
            this.textBox3_categorize.Size = new System.Drawing.Size(122, 29);
            this.textBox3_categorize.TabIndex = 39;
            // 
            // textBox2_name
            // 
            this.textBox2_name.AllowDrop = true;
            this.textBox2_name.Enabled = false;
            this.textBox2_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_name.Location = new System.Drawing.Point(149, 195);
            this.textBox2_name.Multiline = true;
            this.textBox2_name.Name = "textBox2_name";
            this.textBox2_name.Size = new System.Drawing.Size(122, 29);
            this.textBox2_name.TabIndex = 25;
            // 
            // textBox1_code
            // 
            this.textBox1_code.AllowDrop = true;
            this.textBox1_code.Enabled = false;
            this.textBox1_code.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_code.Location = new System.Drawing.Point(149, 161);
            this.textBox1_code.Multiline = true;
            this.textBox1_code.Name = "textBox1_code";
            this.textBox1_code.Size = new System.Drawing.Size(122, 29);
            this.textBox1_code.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 27);
            this.label10.TabIndex = 9;
            this.label10.Text = "입고가격";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 27);
            this.label9.TabIndex = 10;
            this.label9.Text = "보관수량";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "보관위치";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 27);
            this.label6.TabIndex = 16;
            this.label6.Text = "규격";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "분류";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "품명";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "코드";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkKhaki;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(957, 44);
            this.label11.TabIndex = 21;
            this.label11.Text = "입고 화면";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "입고업체";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "입고일자";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "그림2.jpg");
            this.imageList1.Images.SetKeyName(1, "그림1.jpg");
            // 
            // label15
            // 
            this.label15.AllowDrop = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label15.Location = new System.Drawing.Point(796, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(174, 36);
            this.label15.TabIndex = 51;
            this.label15.Text = "님이 로그인 되었습니다.";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(187, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 22);
            this.label14.TabIndex = 19;
            this.label14.Text = "검색";
            this.label14.UseMnemonic = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(332, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(414, 239);
            this.button1.TabIndex = 52;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 540);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(951, 293);
            this.dataGridView1.TabIndex = 81;
            // 
            // Form2_Receiving_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1095, 877);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox9_storage_quantity);
            this.Controls.Add(this.textBox8_storage_location);
            this.Controls.Add(this.textBox7_buy_money);
            this.Controls.Add(this.textBox6_buy_date);
            this.Controls.Add(this.textBox5_buy_company);
            this.Controls.Add(this.textBox4_type);
            this.Controls.Add(this.textBox3_categorize);
            this.Controls.Add(this.textBox2_name);
            this.Controls.Add(this.textBox1_code);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Enabled = false;
            this.Name = "Form2_Receiving_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "창고관리프로그램";
            this.Activated += new System.EventHandler(this.Form2_Receiving_screen_Activated);
            this.Load += new System.EventHandler(this.Form2_Receiving_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox9_storage_quantity;
        private System.Windows.Forms.TextBox textBox8_storage_location;
        private System.Windows.Forms.TextBox textBox7_buy_money;
        private System.Windows.Forms.TextBox textBox6_buy_date;
        private System.Windows.Forms.TextBox textBox5_buy_company;
        private System.Windows.Forms.TextBox textBox4_type;
        private System.Windows.Forms.TextBox textBox3_categorize;
        private System.Windows.Forms.TextBox textBox2_name;
        public System.Windows.Forms.TextBox textBox1_code;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}