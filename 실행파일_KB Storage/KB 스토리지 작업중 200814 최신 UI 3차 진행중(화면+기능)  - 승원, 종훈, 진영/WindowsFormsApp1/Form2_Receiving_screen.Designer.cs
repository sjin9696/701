namespace xmlDataManager
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
            this.dataGridView_outProduct = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.button_input = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox10_money_number = new System.Windows.Forms.TextBox();
            this.textBox11_inventory_stock_number = new System.Windows.Forms.TextBox();
            this.textBox9_sales_number = new System.Windows.Forms.TextBox();
            this.textBox8_delivery_day = new System.Windows.Forms.TextBox();
            this.textBox7_barcode_number = new System.Windows.Forms.TextBox();
            this.textBox6_customer_name = new System.Windows.Forms.TextBox();
            this.textBox5_storage_name = new System.Windows.Forms.TextBox();
            this.textBox4_type_name = new System.Windows.Forms.TextBox();
            this.textBox3_categorize_name = new System.Windows.Forms.TextBox();
            this.textBox2_product_name = new System.Windows.Forms.TextBox();
            this.textBox1_product_code_number = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.계정코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계정명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.관리번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.입고일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.납품처 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.보관위치 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_outProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(183, 95);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 29);
            this.button7.TabIndex = 50;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView_outProduct
            // 
            this.dataGridView_outProduct.AutoGenerateColumns = false;
            this.dataGridView_outProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_outProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.계정코드,
            this.계정명,
            this.Column1,
            this.관리번호,
            this.Column2,
            this.Column3,
            this.금액,
            this.입고일,
            this.납품처,
            this.보관위치});
            this.dataGridView_outProduct.DataSource = this.productsBindingSource;
            this.dataGridView_outProduct.Location = new System.Drawing.Point(76, 529);
            this.dataGridView_outProduct.Name = "dataGridView_outProduct";
            this.dataGridView_outProduct.RowHeadersWidth = 30;
            this.dataGridView_outProduct.RowTemplate.Height = 23;
            this.dataGridView_outProduct.Size = new System.Drawing.Size(915, 304);
            this.dataGridView_outProduct.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label12.Location = new System.Drawing.Point(286, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 29);
            this.label12.TabIndex = 46;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_input
            // 
            this.button_input.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_input.Location = new System.Drawing.Point(364, 485);
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
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox10_money_number
            // 
            this.textBox10_money_number.AllowDrop = true;
            this.textBox10_money_number.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10_money_number.Location = new System.Drawing.Point(149, 463);
            this.textBox10_money_number.Multiline = true;
            this.textBox10_money_number.Name = "textBox10_money_number";
            this.textBox10_money_number.Size = new System.Drawing.Size(122, 29);
            this.textBox10_money_number.TabIndex = 37;
            // 
            // textBox11_inventory_stock_number
            // 
            this.textBox11_inventory_stock_number.AllowDrop = true;
            this.textBox11_inventory_stock_number.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11_inventory_stock_number.Location = new System.Drawing.Point(364, 428);
            this.textBox11_inventory_stock_number.Multiline = true;
            this.textBox11_inventory_stock_number.Name = "textBox11_inventory_stock_number";
            this.textBox11_inventory_stock_number.Size = new System.Drawing.Size(122, 29);
            this.textBox11_inventory_stock_number.TabIndex = 36;
            // 
            // textBox9_sales_number
            // 
            this.textBox9_sales_number.AllowDrop = true;
            this.textBox9_sales_number.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9_sales_number.Location = new System.Drawing.Point(149, 428);
            this.textBox9_sales_number.Multiline = true;
            this.textBox9_sales_number.Name = "textBox9_sales_number";
            this.textBox9_sales_number.Size = new System.Drawing.Size(122, 29);
            this.textBox9_sales_number.TabIndex = 35;
            // 
            // textBox8_delivery_day
            // 
            this.textBox8_delivery_day.AllowDrop = true;
            this.textBox8_delivery_day.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8_delivery_day.Location = new System.Drawing.Point(149, 393);
            this.textBox8_delivery_day.Multiline = true;
            this.textBox8_delivery_day.Name = "textBox8_delivery_day";
            this.textBox8_delivery_day.Size = new System.Drawing.Size(122, 29);
            this.textBox8_delivery_day.TabIndex = 34;
            // 
            // textBox7_barcode_number
            // 
            this.textBox7_barcode_number.AllowDrop = true;
            this.textBox7_barcode_number.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7_barcode_number.Location = new System.Drawing.Point(149, 360);
            this.textBox7_barcode_number.Multiline = true;
            this.textBox7_barcode_number.Name = "textBox7_barcode_number";
            this.textBox7_barcode_number.Size = new System.Drawing.Size(122, 29);
            this.textBox7_barcode_number.TabIndex = 33;
            // 
            // textBox6_customer_name
            // 
            this.textBox6_customer_name.AllowDrop = true;
            this.textBox6_customer_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6_customer_name.Location = new System.Drawing.Point(149, 325);
            this.textBox6_customer_name.Multiline = true;
            this.textBox6_customer_name.Name = "textBox6_customer_name";
            this.textBox6_customer_name.Size = new System.Drawing.Size(122, 29);
            this.textBox6_customer_name.TabIndex = 32;
            // 
            // textBox5_storage_name
            // 
            this.textBox5_storage_name.AllowDrop = true;
            this.textBox5_storage_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5_storage_name.Location = new System.Drawing.Point(149, 290);
            this.textBox5_storage_name.Multiline = true;
            this.textBox5_storage_name.Name = "textBox5_storage_name";
            this.textBox5_storage_name.Size = new System.Drawing.Size(122, 29);
            this.textBox5_storage_name.TabIndex = 31;
            // 
            // textBox4_type_name
            // 
            this.textBox4_type_name.AllowDrop = true;
            this.textBox4_type_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_type_name.Location = new System.Drawing.Point(149, 255);
            this.textBox4_type_name.Multiline = true;
            this.textBox4_type_name.Name = "textBox4_type_name";
            this.textBox4_type_name.Size = new System.Drawing.Size(122, 29);
            this.textBox4_type_name.TabIndex = 30;
            // 
            // textBox3_categorize_name
            // 
            this.textBox3_categorize_name.AllowDrop = true;
            this.textBox3_categorize_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_categorize_name.Location = new System.Drawing.Point(148, 224);
            this.textBox3_categorize_name.Multiline = true;
            this.textBox3_categorize_name.Name = "textBox3_categorize_name";
            this.textBox3_categorize_name.Size = new System.Drawing.Size(122, 29);
            this.textBox3_categorize_name.TabIndex = 39;
            // 
            // textBox2_product_name
            // 
            this.textBox2_product_name.AllowDrop = true;
            this.textBox2_product_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_product_name.Location = new System.Drawing.Point(148, 189);
            this.textBox2_product_name.Multiline = true;
            this.textBox2_product_name.Name = "textBox2_product_name";
            this.textBox2_product_name.Size = new System.Drawing.Size(122, 29);
            this.textBox2_product_name.TabIndex = 25;
            // 
            // textBox1_product_code_number
            // 
            this.textBox1_product_code_number.AllowDrop = true;
            this.textBox1_product_code_number.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_product_code_number.Location = new System.Drawing.Point(149, 154);
            this.textBox1_product_code_number.Multiline = true;
            this.textBox1_product_code_number.Name = "textBox1_product_code_number";
            this.textBox1_product_code_number.Size = new System.Drawing.Size(122, 29);
            this.textBox1_product_code_number.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 27);
            this.label10.TabIndex = 9;
            this.label10.Text = "입고일";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 27);
            this.label9.TabIndex = 10;
            this.label9.Text = "금액";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(286, 434);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 22);
            this.label18.TabIndex = 11;
            this.label18.Text = "재고수량";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "입고수량";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "바코드";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 27);
            this.label6.TabIndex = 16;
            this.label6.Text = "규격";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "분류";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "품명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "코드";
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
            this.label2.Location = new System.Drawing.Point(55, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "보관위치";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "납품처";
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
            this.label14.Location = new System.Drawing.Point(135, 101);
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
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(xmlDataManager);
            // 
            // 계정코드
            // 
            this.계정코드.DataPropertyName = "product_code_number";
            this.계정코드.HeaderText = "코드";
            this.계정코드.Name = "계정코드";
            this.계정코드.Width = 70;
            // 
            // 계정명
            // 
            this.계정명.DataPropertyName = "product_name";
            this.계정명.HeaderText = "품명";
            this.계정명.Name = "계정명";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "categorize_name";
            this.Column1.HeaderText = "규격";
            this.Column1.Name = "Column1";
            // 
            // 관리번호
            // 
            this.관리번호.DataPropertyName = "type_name";
            this.관리번호.HeaderText = "분류";
            this.관리번호.Name = "관리번호";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "barcode_number";
            this.Column2.HeaderText = "바코드";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sales_number";
            this.Column3.HeaderText = "판매수량";
            this.Column3.Name = "Column3";
            // 
            // 금액
            // 
            this.금액.DataPropertyName = "money_number";
            this.금액.HeaderText = "금액";
            this.금액.Name = "금액";
            // 
            // 입고일
            // 
            this.입고일.DataPropertyName = "delivery_day";
            this.입고일.HeaderText = "입고일";
            this.입고일.Name = "입고일";
            // 
            // 납품처
            // 
            this.납품처.DataPropertyName = "customer_name";
            this.납품처.HeaderText = "납품처";
            this.납품처.Name = "납품처";
            // 
            // 보관위치
            // 
            this.보관위치.DataPropertyName = "storage_name";
            this.보관위치.HeaderText = "보관위치";
            this.보관위치.Name = "보관위치";
            // 
            // Form2_Receiving_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1095, 877);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView_outProduct);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox10_money_number);
            this.Controls.Add(this.textBox11_inventory_stock_number);
            this.Controls.Add(this.textBox9_sales_number);
            this.Controls.Add(this.textBox8_delivery_day);
            this.Controls.Add(this.textBox7_barcode_number);
            this.Controls.Add(this.textBox6_customer_name);
            this.Controls.Add(this.textBox5_storage_name);
            this.Controls.Add(this.textBox4_type_name);
            this.Controls.Add(this.textBox3_categorize_name);
            this.Controls.Add(this.textBox2_product_name);
            this.Controls.Add(this.textBox1_product_code_number);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2_Receiving_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "창고관리프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_outProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView_outProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox10_money_number;
        private System.Windows.Forms.TextBox textBox11_inventory_stock_number;
        private System.Windows.Forms.TextBox textBox9_sales_number;
        private System.Windows.Forms.TextBox textBox8_delivery_day;
        private System.Windows.Forms.TextBox textBox7_barcode_number;
        private System.Windows.Forms.TextBox textBox6_customer_name;
        private System.Windows.Forms.TextBox textBox5_storage_name;
        private System.Windows.Forms.TextBox textBox4_type_name;
        private System.Windows.Forms.TextBox textBox3_categorize_name;
        private System.Windows.Forms.TextBox textBox2_product_name;
        public System.Windows.Forms.TextBox textBox1_product_code_number;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn productcodenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorizenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneynumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storagenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventorystocknumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계정코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계정명;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관리번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 금액;
        private System.Windows.Forms.DataGridViewTextBoxColumn 입고일;
        private System.Windows.Forms.DataGridViewTextBoxColumn 납품처;
        private System.Windows.Forms.DataGridViewTextBoxColumn 보관위치;
    }
}