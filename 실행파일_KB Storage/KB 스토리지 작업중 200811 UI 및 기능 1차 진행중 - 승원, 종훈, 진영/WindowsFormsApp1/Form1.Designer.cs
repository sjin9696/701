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
            this.textBox5_barcode = new System.Windows.Forms.TextBox();
            this.textBox6_unit_sales = new System.Windows.Forms.TextBox();
            this.textBox7_money = new System.Windows.Forms.TextBox();
            this.textBox8_delivery_date = new System.Windows.Forms.TextBox();
            this.textBox9_customer = new System.Windows.Forms.TextBox();
            this.textBox10_storage_location = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_input = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11_worker = new System.Windows.Forms.TextBox();
            this.dataGridView_st = new System.Windows.Forms.DataGridView();
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
            this.workerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_st)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "납품처";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "보관위치";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "코드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "품명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "분류";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "규격";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "바코드";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "판매수량";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(91, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "금액";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(83, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "입고일";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(478, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 36);
            this.label11.TabIndex = 0;
            this.label11.Text = "출고 화면";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1_code
            // 
            this.textBox1_code.AllowDrop = true;
            this.textBox1_code.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_code.Location = new System.Drawing.Point(186, 18);
            this.textBox1_code.Multiline = true;
            this.textBox1_code.Name = "textBox1_code";
            this.textBox1_code.Size = new System.Drawing.Size(122, 29);
            this.textBox1_code.TabIndex = 1;
            // 
            // textBox2_name
            // 
            this.textBox2_name.AllowDrop = true;
            this.textBox2_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_name.Location = new System.Drawing.Point(186, 65);
            this.textBox2_name.Multiline = true;
            this.textBox2_name.Name = "textBox2_name";
            this.textBox2_name.Size = new System.Drawing.Size(122, 29);
            this.textBox2_name.TabIndex = 1;
            // 
            // textBox3_cateforize
            // 
            this.textBox3_cateforize.AllowDrop = true;
            this.textBox3_cateforize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_cateforize.Location = new System.Drawing.Point(186, 107);
            this.textBox3_cateforize.Multiline = true;
            this.textBox3_cateforize.Name = "textBox3_cateforize";
            this.textBox3_cateforize.Size = new System.Drawing.Size(122, 29);
            this.textBox3_cateforize.TabIndex = 1;
            // 
            // textBox4_type
            // 
            this.textBox4_type.AllowDrop = true;
            this.textBox4_type.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_type.Location = new System.Drawing.Point(186, 158);
            this.textBox4_type.Multiline = true;
            this.textBox4_type.Name = "textBox4_type";
            this.textBox4_type.Size = new System.Drawing.Size(122, 29);
            this.textBox4_type.TabIndex = 1;
            // 
            // textBox5_barcode
            // 
            this.textBox5_barcode.AllowDrop = true;
            this.textBox5_barcode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5_barcode.Location = new System.Drawing.Point(186, 205);
            this.textBox5_barcode.Multiline = true;
            this.textBox5_barcode.Name = "textBox5_barcode";
            this.textBox5_barcode.Size = new System.Drawing.Size(122, 29);
            this.textBox5_barcode.TabIndex = 1;
            // 
            // textBox6_unit_sales
            // 
            this.textBox6_unit_sales.AllowDrop = true;
            this.textBox6_unit_sales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6_unit_sales.Location = new System.Drawing.Point(186, 248);
            this.textBox6_unit_sales.Multiline = true;
            this.textBox6_unit_sales.Name = "textBox6_unit_sales";
            this.textBox6_unit_sales.Size = new System.Drawing.Size(122, 29);
            this.textBox6_unit_sales.TabIndex = 1;
            // 
            // textBox7_money
            // 
            this.textBox7_money.AllowDrop = true;
            this.textBox7_money.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7_money.Location = new System.Drawing.Point(186, 293);
            this.textBox7_money.Multiline = true;
            this.textBox7_money.Name = "textBox7_money";
            this.textBox7_money.Size = new System.Drawing.Size(122, 29);
            this.textBox7_money.TabIndex = 1;
            // 
            // textBox8_delivery_date
            // 
            this.textBox8_delivery_date.AllowDrop = true;
            this.textBox8_delivery_date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8_delivery_date.Location = new System.Drawing.Point(186, 341);
            this.textBox8_delivery_date.Multiline = true;
            this.textBox8_delivery_date.Name = "textBox8_delivery_date";
            this.textBox8_delivery_date.Size = new System.Drawing.Size(122, 29);
            this.textBox8_delivery_date.TabIndex = 1;
            // 
            // textBox9_customer
            // 
            this.textBox9_customer.AllowDrop = true;
            this.textBox9_customer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9_customer.Location = new System.Drawing.Point(186, 380);
            this.textBox9_customer.Multiline = true;
            this.textBox9_customer.Name = "textBox9_customer";
            this.textBox9_customer.Size = new System.Drawing.Size(122, 29);
            this.textBox9_customer.TabIndex = 1;
            // 
            // textBox10_storage_location
            // 
            this.textBox10_storage_location.AllowDrop = true;
            this.textBox10_storage_location.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10_storage_location.Location = new System.Drawing.Point(186, 425);
            this.textBox10_storage_location.Multiline = true;
            this.textBox10_storage_location.Name = "textBox10_storage_location";
            this.textBox10_storage_location.Size = new System.Drawing.Size(122, 29);
            this.textBox10_storage_location.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(752, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "재고수량조회";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(752, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "반품/수정";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(752, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "입    고";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(752, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 51);
            this.button4.TabIndex = 2;
            this.button4.Text = "전체 재고";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button_input
            // 
            this.button_input.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_input.Location = new System.Drawing.Point(924, 174);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(62, 95);
            this.button_input.TabIndex = 3;
            this.button_input.Text = "입력";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Location = new System.Drawing.Point(631, 462);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 47);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(728, 469);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 30);
            this.label12.TabIndex = 4;
            this.label12.Text = "현재날짜";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 470);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "작업자";
            // 
            // textBox11_worker
            // 
            this.textBox11_worker.AllowDrop = true;
            this.textBox11_worker.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11_worker.Location = new System.Drawing.Point(186, 470);
            this.textBox11_worker.Multiline = true;
            this.textBox11_worker.Name = "textBox11_worker";
            this.textBox11_worker.Size = new System.Drawing.Size(122, 29);
            this.textBox11_worker.TabIndex = 1;
            // 
            // dataGridView_st
            // 
            this.dataGridView_st.AutoGenerateColumns = false;
            this.dataGridView_st.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_st.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.workerDataGridViewTextBoxColumn});
            this.dataGridView_st.DataSource = this.productsBindingSource;
            this.dataGridView_st.Location = new System.Drawing.Point(71, 510);
            this.dataGridView_st.Name = "dataGridView_st";
            this.dataGridView_st.RowTemplate.Height = 23;
            this.dataGridView_st.Size = new System.Drawing.Size(915, 210);
            this.dataGridView_st.TabIndex = 6;
            // 
            // 계정코드
            // 
            this.계정코드.HeaderText = "계정코드";
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
            // Column4
            // 
            this.Column4.HeaderText = "작업자";
            this.Column4.Name = "Column4";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categorizeDataGridViewTextBoxColumn
            // 
            this.categorizeDataGridViewTextBoxColumn.DataPropertyName = "categorize";
            this.categorizeDataGridViewTextBoxColumn.HeaderText = "categorize";
            this.categorizeDataGridViewTextBoxColumn.Name = "categorizeDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // unitsalesDataGridViewTextBoxColumn
            // 
            this.unitsalesDataGridViewTextBoxColumn.DataPropertyName = "unit_sales";
            this.unitsalesDataGridViewTextBoxColumn.HeaderText = "unit_sales";
            this.unitsalesDataGridViewTextBoxColumn.Name = "unitsalesDataGridViewTextBoxColumn";
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "money";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            // 
            // deliverydateDataGridViewTextBoxColumn
            // 
            this.deliverydateDataGridViewTextBoxColumn.DataPropertyName = "delivery_date";
            this.deliverydateDataGridViewTextBoxColumn.HeaderText = "delivery_date";
            this.deliverydateDataGridViewTextBoxColumn.Name = "deliverydateDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // storagelocationDataGridViewTextBoxColumn
            // 
            this.storagelocationDataGridViewTextBoxColumn.DataPropertyName = "storage_location";
            this.storagelocationDataGridViewTextBoxColumn.HeaderText = "storage_location";
            this.storagelocationDataGridViewTextBoxColumn.Name = "storagelocationDataGridViewTextBoxColumn";
            // 
            // workerDataGridViewTextBoxColumn
            // 
            this.workerDataGridViewTextBoxColumn.DataPropertyName = "worker";
            this.workerDataGridViewTextBoxColumn.HeaderText = "worker";
            this.workerDataGridViewTextBoxColumn.Name = "workerDataGridViewTextBoxColumn";
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
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1053, 787);
            this.Controls.Add(this.dataGridView_st);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox11_worker);
            this.Controls.Add(this.textBox10_storage_location);
            this.Controls.Add(this.textBox9_customer);
            this.Controls.Add(this.textBox8_delivery_date);
            this.Controls.Add(this.textBox7_money);
            this.Controls.Add(this.textBox6_unit_sales);
            this.Controls.Add(this.textBox5_barcode);
            this.Controls.Add(this.textBox4_type);
            this.Controls.Add(this.textBox3_cateforize);
            this.Controls.Add(this.textBox2_name);
            this.Controls.Add(this.textBox1_code);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "창고관리시스템";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_st)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox textBox1_code;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView_st;
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
        public System.Windows.Forms.TextBox textBox2_name;
        public System.Windows.Forms.TextBox textBox3_cateforize;
        public System.Windows.Forms.TextBox textBox4_type;
        public System.Windows.Forms.TextBox textBox5_barcode;
        public System.Windows.Forms.TextBox textBox6_unit_sales;
        public System.Windows.Forms.TextBox textBox7_money;
        public System.Windows.Forms.TextBox textBox8_delivery_date;
        public System.Windows.Forms.TextBox textBox9_customer;
        public System.Windows.Forms.TextBox textBox10_storage_location;
        public System.Windows.Forms.Button button_input;
        public System.Windows.Forms.TextBox textBox11_worker;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn workerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productsBindingSource;
    }
}

