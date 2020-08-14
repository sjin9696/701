namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1_code = new System.Windows.Forms.TextBox();
            this.textBox2_name = new System.Windows.Forms.TextBox();
            this.textBox3_cateforize = new System.Windows.Forms.TextBox();
            this.textBox4_type = new System.Windows.Forms.TextBox();
            this.textBox5_storage_location = new System.Windows.Forms.TextBox();
            this.textBox6_customer = new System.Windows.Forms.TextBox();
            this.textBox7_barcode = new System.Windows.Forms.TextBox();
            this.textBox8_delivery_date = new System.Windows.Forms.TextBox();
            this.textBox9_unit_sales = new System.Windows.Forms.TextBox();
            this.textBox10_money = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_data_input = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView_output = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_name_search = new System.Windows.Forms.Button();
            this.button_code_search = new System.Windows.Forms.Button();
            this.button_customer_search = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11_today = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox12_quantity = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storagelocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "납품처";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "보관위치";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "코드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "품명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "분류";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "규격";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "바코드";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "판매수량";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "금액";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "입고일";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkKhaki;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(957, 44);
            this.label11.TabIndex = 0;
            this.label11.Text = "출고 화면";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1_code
            // 
            this.textBox1_code.AllowDrop = true;
            this.textBox1_code.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_code.Location = new System.Drawing.Point(119, 133);
            this.textBox1_code.Multiline = true;
            this.textBox1_code.Name = "textBox1_code";
            this.textBox1_code.Size = new System.Drawing.Size(122, 29);
            this.textBox1_code.TabIndex = 1;
            // 
            // textBox2_name
            // 
            this.textBox2_name.AllowDrop = true;
            this.textBox2_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_name.Location = new System.Drawing.Point(119, 168);
            this.textBox2_name.Multiline = true;
            this.textBox2_name.Name = "textBox2_name";
            this.textBox2_name.Size = new System.Drawing.Size(122, 29);
            this.textBox2_name.TabIndex = 1;
            // 
            // textBox3_cateforize
            // 
            this.textBox3_cateforize.AllowDrop = true;
            this.textBox3_cateforize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_cateforize.Location = new System.Drawing.Point(119, 203);
            this.textBox3_cateforize.Multiline = true;
            this.textBox3_cateforize.Name = "textBox3_cateforize";
            this.textBox3_cateforize.Size = new System.Drawing.Size(122, 29);
            this.textBox3_cateforize.TabIndex = 1;
            // 
            // textBox4_type
            // 
            this.textBox4_type.AllowDrop = true;
            this.textBox4_type.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_type.Location = new System.Drawing.Point(120, 234);
            this.textBox4_type.Multiline = true;
            this.textBox4_type.Name = "textBox4_type";
            this.textBox4_type.Size = new System.Drawing.Size(122, 29);
            this.textBox4_type.TabIndex = 1;
            // 
            // textBox5_storage_location
            // 
            this.textBox5_storage_location.AllowDrop = true;
            this.textBox5_storage_location.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5_storage_location.Location = new System.Drawing.Point(120, 269);
            this.textBox5_storage_location.Multiline = true;
            this.textBox5_storage_location.Name = "textBox5_storage_location";
            this.textBox5_storage_location.Size = new System.Drawing.Size(122, 29);
            this.textBox5_storage_location.TabIndex = 1;
            // 
            // textBox6_customer
            // 
            this.textBox6_customer.AllowDrop = true;
            this.textBox6_customer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6_customer.Location = new System.Drawing.Point(120, 304);
            this.textBox6_customer.Multiline = true;
            this.textBox6_customer.Name = "textBox6_customer";
            this.textBox6_customer.Size = new System.Drawing.Size(122, 29);
            this.textBox6_customer.TabIndex = 1;
            // 
            // textBox7_barcode
            // 
            this.textBox7_barcode.AllowDrop = true;
            this.textBox7_barcode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7_barcode.Location = new System.Drawing.Point(120, 339);
            this.textBox7_barcode.Multiline = true;
            this.textBox7_barcode.Name = "textBox7_barcode";
            this.textBox7_barcode.Size = new System.Drawing.Size(122, 29);
            this.textBox7_barcode.TabIndex = 1;
            // 
            // textBox8_delivery_date
            // 
            this.textBox8_delivery_date.AllowDrop = true;
            this.textBox8_delivery_date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8_delivery_date.Location = new System.Drawing.Point(120, 372);
            this.textBox8_delivery_date.Multiline = true;
            this.textBox8_delivery_date.Name = "textBox8_delivery_date";
            this.textBox8_delivery_date.Size = new System.Drawing.Size(122, 29);
            this.textBox8_delivery_date.TabIndex = 1;
            // 
            // textBox9_unit_sales
            // 
            this.textBox9_unit_sales.AllowDrop = true;
            this.textBox9_unit_sales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9_unit_sales.Location = new System.Drawing.Point(120, 407);
            this.textBox9_unit_sales.Multiline = true;
            this.textBox9_unit_sales.Name = "textBox9_unit_sales";
            this.textBox9_unit_sales.Size = new System.Drawing.Size(122, 29);
            this.textBox9_unit_sales.TabIndex = 1;
            // 
            // textBox10_money
            // 
            this.textBox10_money.AllowDrop = true;
            this.textBox10_money.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10_money.Location = new System.Drawing.Point(120, 442);
            this.textBox10_money.Multiline = true;
            this.textBox10_money.Name = "textBox10_money";
            this.textBox10_money.Size = new System.Drawing.Size(122, 29);
            this.textBox10_money.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(961, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(820, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "반품/수정";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(820, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "입    고";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(820, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 57);
            this.button4.TabIndex = 2;
            this.button4.Text = "전체 재고";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button_data_input
            // 
            this.button_data_input.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_data_input.Location = new System.Drawing.Point(284, 468);
            this.button_data_input.Name = "button_data_input";
            this.button_data_input.Size = new System.Drawing.Size(83, 42);
            this.button_data_input.TabIndex = 3;
            this.button_data_input.Text = "입력";
            this.button_data_input.UseVisualStyleBackColor = true;
            this.button_data_input.Click += new System.EventHandler(this.button_data_input_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Location = new System.Drawing.Point(728, 468);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 47);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label12.Location = new System.Drawing.Point(252, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 29);
            this.label12.TabIndex = 4;
            this.label12.Text = "현재날짜";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_output
            // 
            this.dataGridView_output.AutoGenerateColumns = false;
            this.dataGridView_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_output.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.계정코드,
            this.계정명,
            this.Column1,
            this.관리번호,
            this.Column2,
            this.Column3,
            this.금액,
            this.입고일,
            this.납품처,
            this.보관위치,
            this.Column4,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categorizeDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.unitsalesDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn,
            this.deliverydateDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.storagelocationDataGridViewTextBoxColumn,
            this.todayDataGridViewTextBoxColumn,
            this.workerDataGridViewTextBoxColumn});
            this.dataGridView_output.DataSource = this.productsBindingSource;
            this.dataGridView_output.Location = new System.Drawing.Point(50, 521);
            this.dataGridView_output.Name = "dataGridView_output";
            this.dataGridView_output.RowTemplate.Height = 23;
            this.dataGridView_output.Size = new System.Drawing.Size(915, 316);
            this.dataGridView_output.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(803, 477);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "검색";
            // 
            // textBox12
            // 
            this.textBox12.AllowDrop = true;
            this.textBox12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(855, 477);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(110, 29);
            this.textBox12.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "KB Storage_brand_usage_#1_created_by_logaster (5).png");
            this.imageList1.Images.SetKeyName(1, "search_32px.png");
            // 
            // button_name_search
            // 
            this.button_name_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_name_search.BackgroundImage")));
            this.button_name_search.FlatAppearance.BorderSize = 0;
            this.button_name_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_name_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_name_search.Location = new System.Drawing.Point(262, 175);
            this.button_name_search.Name = "button_name_search";
            this.button_name_search.Size = new System.Drawing.Size(35, 29);
            this.button_name_search.TabIndex = 7;
            this.button_name_search.UseVisualStyleBackColor = true;
            this.button_name_search.Click += new System.EventHandler(this.button_name_search_Click);
            // 
            // button_code_search
            // 
            this.button_code_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_code_search.BackgroundImage")));
            this.button_code_search.FlatAppearance.BorderSize = 0;
            this.button_code_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_code_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_code_search.Location = new System.Drawing.Point(262, 133);
            this.button_code_search.Name = "button_code_search";
            this.button_code_search.Size = new System.Drawing.Size(35, 29);
            this.button_code_search.TabIndex = 7;
            this.button_code_search.UseVisualStyleBackColor = true;
            this.button_code_search.Click += new System.EventHandler(this.button_code_search_Click);
            // 
            // button_customer_search
            // 
            this.button_customer_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_customer_search.BackgroundImage")));
            this.button_customer_search.FlatAppearance.BorderSize = 0;
            this.button_customer_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customer_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_customer_search.Location = new System.Drawing.Point(262, 306);
            this.button_customer_search.Name = "button_customer_search";
            this.button_customer_search.Size = new System.Drawing.Size(35, 29);
            this.button_customer_search.TabIndex = 7;
            this.button_customer_search.UseVisualStyleBackColor = true;
            this.button_customer_search.Click += new System.EventHandler(this.button_customer_search_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(56, 484);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "날짜";
            // 
            // textBox11_today
            // 
            this.textBox11_today.AllowDrop = true;
            this.textBox11_today.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11_today.Location = new System.Drawing.Point(120, 477);
            this.textBox11_today.Multiline = true;
            this.textBox11_today.Name = "textBox11_today";
            this.textBox11_today.Size = new System.Drawing.Size(122, 29);
            this.textBox11_today.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(815, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 36);
            this.label15.TabIndex = 0;
            this.label15.Text = "로그인";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(757, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 22);
            this.label16.TabIndex = 0;
            this.label16.Text = "아이디";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(741, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 22);
            this.label17.TabIndex = 0;
            this.label17.Text = "비밀번호";
            // 
            // textBox13
            // 
            this.textBox13.AllowDrop = true;
            this.textBox13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(821, 122);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(122, 29);
            this.textBox13.TabIndex = 1;
            // 
            // textBox14
            // 
            this.textBox14.AllowDrop = true;
            this.textBox14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(821, 157);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(122, 29);
            this.textBox14.TabIndex = 1;
            // 
            // textBox12_quantity
            // 
            this.textBox12_quantity.AllowDrop = true;
            this.textBox12_quantity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12_quantity.Location = new System.Drawing.Point(338, 407);
            this.textBox12_quantity.Multiline = true;
            this.textBox12_quantity.Name = "textBox12_quantity";
            this.textBox12_quantity.Size = new System.Drawing.Size(122, 29);
            this.textBox12_quantity.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(258, 414);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 22);
            this.label18.TabIndex = 0;
            this.label18.Text = "재고수량";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 계정코드
            // 
            this.계정코드.DataPropertyName = "code";
            this.계정코드.HeaderText = "계정코드";
            this.계정코드.Name = "계정코드";
            // 
            // 계정명
            // 
            this.계정명.DataPropertyName = "name";
            this.계정명.HeaderText = "품명";
            this.계정명.Name = "계정명";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "type";
            this.Column1.HeaderText = "규격";
            this.Column1.Name = "Column1";
            // 
            // 관리번호
            // 
            this.관리번호.DataPropertyName = "categorize";
            this.관리번호.HeaderText = "분류";
            this.관리번호.Name = "관리번호";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "barcode";
            this.Column2.HeaderText = "바코드";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "unit_sales";
            this.Column3.HeaderText = "판매수량";
            this.Column3.Name = "Column3";
            // 
            // 금액
            // 
            this.금액.DataPropertyName = "money";
            this.금액.HeaderText = "금액";
            this.금액.Name = "금액";
            // 
            // 입고일
            // 
            this.입고일.DataPropertyName = "delivery_date";
            this.입고일.HeaderText = "입고일";
            this.입고일.Name = "입고일";
            // 
            // 납품처
            // 
            this.납품처.DataPropertyName = "customer";
            this.납품처.HeaderText = "납품처";
            this.납품처.Name = "납품처";
            // 
            // 보관위치
            // 
            this.보관위치.DataPropertyName = "storage_location";
            this.보관위치.HeaderText = "보관위치";
            this.보관위치.Name = "보관위치";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "today";
            this.Column4.HeaderText = "날짜 ";
            this.Column4.Name = "Column4";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // categorizeDataGridViewTextBoxColumn
            // 
            this.categorizeDataGridViewTextBoxColumn.DataPropertyName = "categorize";
            this.categorizeDataGridViewTextBoxColumn.HeaderText = "categorize";
            this.categorizeDataGridViewTextBoxColumn.Name = "categorizeDataGridViewTextBoxColumn";
            this.categorizeDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitsalesDataGridViewTextBoxColumn
            // 
            this.unitsalesDataGridViewTextBoxColumn.DataPropertyName = "unit_sales";
            this.unitsalesDataGridViewTextBoxColumn.HeaderText = "unit_sales";
            this.unitsalesDataGridViewTextBoxColumn.Name = "unitsalesDataGridViewTextBoxColumn";
            this.unitsalesDataGridViewTextBoxColumn.Visible = false;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "money";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.Visible = false;
            // 
            // deliverydateDataGridViewTextBoxColumn
            // 
            this.deliverydateDataGridViewTextBoxColumn.DataPropertyName = "delivery_date";
            this.deliverydateDataGridViewTextBoxColumn.HeaderText = "delivery_date";
            this.deliverydateDataGridViewTextBoxColumn.Name = "deliverydateDataGridViewTextBoxColumn";
            this.deliverydateDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Visible = false;
            // 
            // storagelocationDataGridViewTextBoxColumn
            // 
            this.storagelocationDataGridViewTextBoxColumn.DataPropertyName = "storage_location";
            this.storagelocationDataGridViewTextBoxColumn.HeaderText = "storage_location";
            this.storagelocationDataGridViewTextBoxColumn.Name = "storagelocationDataGridViewTextBoxColumn";
            this.storagelocationDataGridViewTextBoxColumn.Visible = false;
            // 
            // todayDataGridViewTextBoxColumn
            // 
            this.todayDataGridViewTextBoxColumn.DataPropertyName = "today";
            this.todayDataGridViewTextBoxColumn.HeaderText = "today";
            this.todayDataGridViewTextBoxColumn.Name = "todayDataGridViewTextBoxColumn";
            this.todayDataGridViewTextBoxColumn.Visible = false;
            // 
            // workerDataGridViewTextBoxColumn
            // 
            this.workerDataGridViewTextBoxColumn.DataPropertyName = "worker";
            this.workerDataGridViewTextBoxColumn.HeaderText = "worker";
            this.workerDataGridViewTextBoxColumn.Name = "workerDataGridViewTextBoxColumn";
            this.workerDataGridViewTextBoxColumn.Visible = false;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(WindowsFormsApp1.Products);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1053, 930);
            this.Controls.Add(this.button_code_search);
            this.Controls.Add(this.button_customer_search);
            this.Controls.Add(this.button_name_search);
            this.Controls.Add(this.dataGridView_output);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button_data_input);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox11_today);
            this.Controls.Add(this.textBox10_money);
            this.Controls.Add(this.textBox12_quantity);
            this.Controls.Add(this.textBox9_unit_sales);
            this.Controls.Add(this.textBox8_delivery_date);
            this.Controls.Add(this.textBox7_barcode);
            this.Controls.Add(this.textBox6_customer);
            this.Controls.Add(this.textBox5_storage_location);
            this.Controls.Add(this.textBox4_type);
            this.Controls.Add(this.textBox3_cateforize);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox2_name);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox1_code);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "창고관리시스템";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1_code;
        private System.Windows.Forms.TextBox textBox2_name;
        private System.Windows.Forms.TextBox textBox3_cateforize;
        private System.Windows.Forms.TextBox textBox4_type;
        private System.Windows.Forms.TextBox textBox5_storage_location;
        private System.Windows.Forms.TextBox textBox6_customer;
        private System.Windows.Forms.TextBox textBox7_barcode;
        private System.Windows.Forms.TextBox textBox8_delivery_date;
        private System.Windows.Forms.TextBox textBox9_unit_sales;
        private System.Windows.Forms.TextBox textBox10_money;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_data_input;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView_output;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button_name_search;
        private System.Windows.Forms.Button button_code_search;
        private System.Windows.Forms.Button button_customer_search;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox11_today;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox12_quantity;
        private System.Windows.Forms.Label label18;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storagelocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn todayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerDataGridViewTextBoxColumn;
    }
}

