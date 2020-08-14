namespace WindowsFormsApp1
{
    partial class Form1_Factory_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Factory_screen));
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
            this.textBox1_product_code_number = new System.Windows.Forms.TextBox();
            this.textBox2_product_name = new System.Windows.Forms.TextBox();
            this.textBox3_categorize_name = new System.Windows.Forms.TextBox();
            this.textBox4_type_name = new System.Windows.Forms.TextBox();
            this.textBox5_storage_name = new System.Windows.Forms.TextBox();
            this.textBox6_customer_name = new System.Windows.Forms.TextBox();
            this.textBox7_barcode_number = new System.Windows.Forms.TextBox();
            this.textBox8_delivery_day = new System.Windows.Forms.TextBox();
            this.textBox9_sales_number = new System.Windows.Forms.TextBox();
            this.textBox10_money_number = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2_data_input = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.productcodenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorizenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverydayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storagenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1_search = new System.Windows.Forms.Button();
            this.textBox11_inventory_stock_number = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label1_login_worker_name = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "납품처";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "보관위치";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "코드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "품명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "분류";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "규격";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "바코드";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "판매수량";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "금액";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 27);
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
            // textBox1_product_code_number
            // 
            this.textBox1_product_code_number.AllowDrop = true;
            this.textBox1_product_code_number.Enabled = false;
            this.textBox1_product_code_number.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_product_code_number.Location = new System.Drawing.Point(155, 132);
            this.textBox1_product_code_number.Multiline = true;
            this.textBox1_product_code_number.Name = "textBox1_product_code_number";
            this.textBox1_product_code_number.Size = new System.Drawing.Size(122, 29);
            this.textBox1_product_code_number.TabIndex = 1;
            // 
            // textBox2_product_name
            // 
            this.textBox2_product_name.AllowDrop = true;
            this.textBox2_product_name.Enabled = false;
            this.textBox2_product_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_product_name.Location = new System.Drawing.Point(155, 167);
            this.textBox2_product_name.Multiline = true;
            this.textBox2_product_name.Name = "textBox2_product_name";
            this.textBox2_product_name.Size = new System.Drawing.Size(122, 29);
            this.textBox2_product_name.TabIndex = 1;
            // 
            // textBox3_categorize_name
            // 
            this.textBox3_categorize_name.AllowDrop = true;
            this.textBox3_categorize_name.Enabled = false;
            this.textBox3_categorize_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_categorize_name.Location = new System.Drawing.Point(155, 202);
            this.textBox3_categorize_name.Multiline = true;
            this.textBox3_categorize_name.Name = "textBox3_categorize_name";
            this.textBox3_categorize_name.Size = new System.Drawing.Size(122, 29);
            this.textBox3_categorize_name.TabIndex = 1;
            // 
            // textBox4_type_name
            // 
            this.textBox4_type_name.AllowDrop = true;
            this.textBox4_type_name.Enabled = false;
            this.textBox4_type_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_type_name.Location = new System.Drawing.Point(156, 233);
            this.textBox4_type_name.Multiline = true;
            this.textBox4_type_name.Name = "textBox4_type_name";
            this.textBox4_type_name.Size = new System.Drawing.Size(122, 29);
            this.textBox4_type_name.TabIndex = 1;
            // 
            // textBox5_storage_name
            // 
            this.textBox5_storage_name.AllowDrop = true;
            this.textBox5_storage_name.Enabled = false;
            this.textBox5_storage_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5_storage_name.Location = new System.Drawing.Point(156, 268);
            this.textBox5_storage_name.Multiline = true;
            this.textBox5_storage_name.Name = "textBox5_storage_name";
            this.textBox5_storage_name.Size = new System.Drawing.Size(122, 29);
            this.textBox5_storage_name.TabIndex = 1;
            // 
            // textBox6_customer_name
            // 
            this.textBox6_customer_name.AllowDrop = true;
            this.textBox6_customer_name.Enabled = false;
            this.textBox6_customer_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6_customer_name.Location = new System.Drawing.Point(156, 303);
            this.textBox6_customer_name.Multiline = true;
            this.textBox6_customer_name.Name = "textBox6_customer_name";
            this.textBox6_customer_name.Size = new System.Drawing.Size(122, 29);
            this.textBox6_customer_name.TabIndex = 1;
            // 
            // textBox7_barcode_number
            // 
            this.textBox7_barcode_number.AllowDrop = true;
            this.textBox7_barcode_number.Enabled = false;
            this.textBox7_barcode_number.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7_barcode_number.Location = new System.Drawing.Point(156, 338);
            this.textBox7_barcode_number.Multiline = true;
            this.textBox7_barcode_number.Name = "textBox7_barcode_number";
            this.textBox7_barcode_number.Size = new System.Drawing.Size(122, 29);
            this.textBox7_barcode_number.TabIndex = 1;
            // 
            // textBox8_delivery_day
            // 
            this.textBox8_delivery_day.AllowDrop = true;
            this.textBox8_delivery_day.Enabled = false;
            this.textBox8_delivery_day.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8_delivery_day.Location = new System.Drawing.Point(156, 371);
            this.textBox8_delivery_day.Multiline = true;
            this.textBox8_delivery_day.Name = "textBox8_delivery_day";
            this.textBox8_delivery_day.Size = new System.Drawing.Size(122, 29);
            this.textBox8_delivery_day.TabIndex = 1;
            // 
            // textBox9_sales_number
            // 
            this.textBox9_sales_number.AllowDrop = true;
            this.textBox9_sales_number.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9_sales_number.Location = new System.Drawing.Point(156, 406);
            this.textBox9_sales_number.Multiline = true;
            this.textBox9_sales_number.Name = "textBox9_sales_number";
            this.textBox9_sales_number.Size = new System.Drawing.Size(122, 29);
            this.textBox9_sales_number.TabIndex = 1;
            this.textBox9_sales_number.Text = "값을입력하시오";
            // 
            // textBox10_money_number
            // 
            this.textBox10_money_number.AllowDrop = true;
            this.textBox10_money_number.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10_money_number.Location = new System.Drawing.Point(156, 441);
            this.textBox10_money_number.Multiline = true;
            this.textBox10_money_number.Name = "textBox10_money_number";
            this.textBox10_money_number.Size = new System.Drawing.Size(122, 29);
            this.textBox10_money_number.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(820, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "반품/수정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(820, 311);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 57);
            this.button4.TabIndex = 2;
            this.button4.Text = "전체 재고";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2_data_input
            // 
            this.button2_data_input.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_data_input.Location = new System.Drawing.Point(381, 463);
            this.button2_data_input.Name = "button2_data_input";
            this.button2_data_input.Size = new System.Drawing.Size(83, 42);
            this.button2_data_input.TabIndex = 3;
            this.button2_data_input.Text = "입력";
            this.button2_data_input.UseVisualStyleBackColor = true;
            this.button2_data_input.Click += new System.EventHandler(this.button_data_input_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Location = new System.Drawing.Point(952, 444);
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
            this.label12.Location = new System.Drawing.Point(301, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 29);
            this.label12.TabIndex = 4;
            this.label12.Text = "현재날짜";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.productcodenumberDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.categorizenameDataGridViewTextBoxColumn,
            this.typenameDataGridViewTextBoxColumn,
            this.barcodenumberDataGridViewTextBoxColumn,
            this.salesnumberDataGridViewTextBoxColumn,
            this.costnumberDataGridViewTextBoxColumn,
            this.deliverydayDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.storagenameDataGridViewTextBoxColumn,
            this.workernameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(71, 516);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(930, 316);
            this.dataGridView2.TabIndex = 6;
            // 
            // 계정코드
            // 
            this.계정코드.HeaderText = "코드";
            this.계정코드.Name = "계정코드";
            // 
            // 계정명
            // 
            this.계정명.HeaderText = "품명";
            this.계정명.Name = "계정명";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "규격";
            this.Column1.Name = "Column1";
            // 
            // 관리번호
            // 
            this.관리번호.HeaderText = "분류";
            this.관리번호.Name = "관리번호";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "바코드";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "판매수량";
            this.Column3.Name = "Column3";
            // 
            // 금액
            // 
            this.금액.HeaderText = "금액";
            this.금액.Name = "금액";
            // 
            // 입고일
            // 
            this.입고일.HeaderText = "입고일";
            this.입고일.Name = "입고일";
            // 
            // 납품처
            // 
            this.납품처.HeaderText = "납품처";
            this.납품처.Name = "납품처";
            // 
            // 보관위치
            // 
            this.보관위치.HeaderText = "보관위치";
            this.보관위치.Name = "보관위치";
            // 
            // productcodenumberDataGridViewTextBoxColumn
            // 
            this.productcodenumberDataGridViewTextBoxColumn.DataPropertyName = "product_code_number";
            this.productcodenumberDataGridViewTextBoxColumn.HeaderText = "product_code_number";
            this.productcodenumberDataGridViewTextBoxColumn.Name = "productcodenumberDataGridViewTextBoxColumn";
            this.productcodenumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // categorizenameDataGridViewTextBoxColumn
            // 
            this.categorizenameDataGridViewTextBoxColumn.DataPropertyName = "categorize_name";
            this.categorizenameDataGridViewTextBoxColumn.HeaderText = "categorize_name";
            this.categorizenameDataGridViewTextBoxColumn.Name = "categorizenameDataGridViewTextBoxColumn";
            this.categorizenameDataGridViewTextBoxColumn.Visible = false;
            // 
            // typenameDataGridViewTextBoxColumn
            // 
            this.typenameDataGridViewTextBoxColumn.DataPropertyName = "type_name";
            this.typenameDataGridViewTextBoxColumn.HeaderText = "type_name";
            this.typenameDataGridViewTextBoxColumn.Name = "typenameDataGridViewTextBoxColumn";
            this.typenameDataGridViewTextBoxColumn.Visible = false;
            // 
            // barcodenumberDataGridViewTextBoxColumn
            // 
            this.barcodenumberDataGridViewTextBoxColumn.DataPropertyName = "barcode_number";
            this.barcodenumberDataGridViewTextBoxColumn.HeaderText = "barcode_number";
            this.barcodenumberDataGridViewTextBoxColumn.Name = "barcodenumberDataGridViewTextBoxColumn";
            this.barcodenumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // salesnumberDataGridViewTextBoxColumn
            // 
            this.salesnumberDataGridViewTextBoxColumn.DataPropertyName = "sales_number";
            this.salesnumberDataGridViewTextBoxColumn.HeaderText = "sales_number";
            this.salesnumberDataGridViewTextBoxColumn.Name = "salesnumberDataGridViewTextBoxColumn";
            this.salesnumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // costnumberDataGridViewTextBoxColumn
            // 
            this.costnumberDataGridViewTextBoxColumn.DataPropertyName = "cost_number";
            this.costnumberDataGridViewTextBoxColumn.HeaderText = "cost_number";
            this.costnumberDataGridViewTextBoxColumn.Name = "costnumberDataGridViewTextBoxColumn";
            this.costnumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // deliverydayDataGridViewTextBoxColumn
            // 
            this.deliverydayDataGridViewTextBoxColumn.DataPropertyName = "delivery_day";
            this.deliverydayDataGridViewTextBoxColumn.HeaderText = "delivery_day";
            this.deliverydayDataGridViewTextBoxColumn.Name = "deliverydayDataGridViewTextBoxColumn";
            this.deliverydayDataGridViewTextBoxColumn.Visible = false;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customer_name";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.Visible = false;
            // 
            // storagenameDataGridViewTextBoxColumn
            // 
            this.storagenameDataGridViewTextBoxColumn.DataPropertyName = "storage_name";
            this.storagenameDataGridViewTextBoxColumn.HeaderText = "storage_name";
            this.storagenameDataGridViewTextBoxColumn.Name = "storagenameDataGridViewTextBoxColumn";
            this.storagenameDataGridViewTextBoxColumn.Visible = false;
            // 
            // workernameDataGridViewTextBoxColumn
            // 
            this.workernameDataGridViewTextBoxColumn.DataPropertyName = "worker_name";
            this.workernameDataGridViewTextBoxColumn.HeaderText = "worker_name";
            this.workernameDataGridViewTextBoxColumn.Name = "workernameDataGridViewTextBoxColumn";
            this.workernameDataGridViewTextBoxColumn.Visible = false;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(WindowsFormsApp1.Products);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "KB Storage_brand_usage_#1_created_by_logaster (5).png");
            this.imageList1.Images.SetKeyName(1, "search_32px.png");
            this.imageList1.Images.SetKeyName(2, "로고.png");
            // 
            // button1_search
            // 
            this.button1_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1_search.BackgroundImage")));
            this.button1_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1_search.FlatAppearance.BorderSize = 0;
            this.button1_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1_search.Location = new System.Drawing.Point(192, 81);
            this.button1_search.Name = "button1_search";
            this.button1_search.Size = new System.Drawing.Size(47, 45);
            this.button1_search.TabIndex = 7;
            this.button1_search.UseVisualStyleBackColor = true;
            this.button1_search.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox11_inventory_stock_number
            // 
            this.textBox11_inventory_stock_number.AllowDrop = true;
            this.textBox11_inventory_stock_number.Enabled = false;
            this.textBox11_inventory_stock_number.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11_inventory_stock_number.Location = new System.Drawing.Point(381, 406);
            this.textBox11_inventory_stock_number.Multiline = true;
            this.textBox11_inventory_stock_number.Name = "textBox11_inventory_stock_number";
            this.textBox11_inventory_stock_number.Size = new System.Drawing.Size(122, 29);
            this.textBox11_inventory_stock_number.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(301, 407);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 22);
            this.label18.TabIndex = 0;
            this.label18.Text = "재고수량";
            // 
            // label1_login_worker_name
            // 
            this.label1_login_worker_name.AllowDrop = true;
            this.label1_login_worker_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_login_worker_name.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1_login_worker_name.Location = new System.Drawing.Point(791, 74);
            this.label1_login_worker_name.Name = "label1_login_worker_name";
            this.label1_login_worker_name.Size = new System.Drawing.Size(174, 36);
            this.label1_login_worker_name.TabIndex = 4;
            this.label1_login_worker_name.Text = "님이 로그인 되었습니다.";
            this.label1_login_worker_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1_login_worker_name.Click += new System.EventHandler(this.label12_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(130, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 27);
            this.label14.TabIndex = 20;
            this.label14.Text = "검색";
            // 
            // Form1_Factory_screen
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1053, 930);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1_search);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1_login_worker_name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2_data_input);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "Form1_Factory_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "창고관리프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.TextBox textBox2_product_name;
        private System.Windows.Forms.TextBox textBox3_categorize_name;
        private System.Windows.Forms.TextBox textBox4_type_name;
        private System.Windows.Forms.TextBox textBox5_storage_name;
        private System.Windows.Forms.TextBox textBox6_customer_name;
        private System.Windows.Forms.TextBox textBox7_barcode_number;
        private System.Windows.Forms.TextBox textBox8_delivery_day;
        private System.Windows.Forms.TextBox textBox9_sales_number;
        private System.Windows.Forms.TextBox textBox10_money_number;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2_data_input;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox textBox1_product_code_number;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1_search;
        private System.Windows.Forms.TextBox textBox11_inventory_stock_number;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1_login_worker_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource productsBindingSource;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn productcodenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorizenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storagenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workernameDataGridViewTextBoxColumn;
    }
}

