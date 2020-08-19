namespace xmlDataManager
{
    partial class Form6_search_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6_search_screen));
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_all_incentory = new System.Windows.Forms.DataGridView();
            this.코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.분류 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.규격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.납품처 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.납품일자 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.보관위치 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.재고수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.판매수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.판매일자 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all_incentory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkKhaki;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(957, 44);
            this.label11.TabIndex = 49;
            this.label11.Text = "검  색";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(124, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 29);
            this.textBox1.TabIndex = 69;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 68;
            this.label3.Text = "코드";
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(381, 130);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 29);
            this.textBox2.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 70;
            this.label4.Text = "품명";
            // 
            // textBox3
            // 
            this.textBox3.AllowDrop = true;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(662, 130);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 29);
            this.textBox3.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 72;
            this.label1.Text = "납품처";
            // 
            // button_search
            // 
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(834, 123);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(56, 36);
            this.button_search.TabIndex = 83;
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(905, 701);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 38);
            this.button2.TabIndex = 83;
            this.button2.Text = "선택";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_all_incentory
            // 
            this.dataGridView_all_incentory.AllowDrop = true;
            this.dataGridView_all_incentory.AutoGenerateColumns = false;
            this.dataGridView_all_incentory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_all_incentory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.코드,
            this.품명,
            this.분류,
            this.규격,
            this.납품처,
            this.납품일자,
            this.금액,
            this.보관위치,
            this.재고수량,
            this.판매수량,
            this.판매일자});
            this.dataGridView_all_incentory.DataSource = this.productBindingSource1;
            this.dataGridView_all_incentory.Location = new System.Drawing.Point(55, 171);
            this.dataGridView_all_incentory.Name = "dataGridView_all_incentory";
            this.dataGridView_all_incentory.RowTemplate.Height = 23;
            this.dataGridView_all_incentory.Size = new System.Drawing.Size(951, 524);
            this.dataGridView_all_incentory.TabIndex = 84;
            this.dataGridView_all_incentory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_all_incentory_CellDoubleClick);
            // 
            // 코드
            // 
            this.코드.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.코드.DataPropertyName = "product_code_number";
            this.코드.HeaderText = "코드";
            this.코드.Name = "코드";
            this.코드.ReadOnly = true;
            this.코드.Width = 54;
            // 
            // 품명
            // 
            this.품명.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.품명.DataPropertyName = "product_name";
            this.품명.HeaderText = "품명";
            this.품명.Name = "품명";
            this.품명.ReadOnly = true;
            this.품명.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.품명.Width = 54;
            // 
            // 분류
            // 
            this.분류.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.분류.DataPropertyName = "categorize_name";
            this.분류.HeaderText = "분류";
            this.분류.Name = "분류";
            this.분류.ReadOnly = true;
            this.분류.Width = 54;
            // 
            // 규격
            // 
            this.규격.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.규격.DataPropertyName = "type_name";
            this.규격.HeaderText = "규격";
            this.규격.Name = "규격";
            this.규격.ReadOnly = true;
            this.규격.Width = 54;
            // 
            // 납품처
            // 
            this.납품처.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.납품처.DataPropertyName = "customer_name";
            this.납품처.HeaderText = "납품처";
            this.납품처.Name = "납품처";
            this.납품처.ReadOnly = true;
            this.납품처.Width = 66;
            // 
            // 납품일자
            // 
            this.납품일자.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.납품일자.DataPropertyName = "delivery_dates";
            this.납품일자.HeaderText = "납품일자";
            this.납품일자.Name = "납품일자";
            this.납품일자.ReadOnly = true;
            this.납품일자.Width = 78;
            // 
            // 금액
            // 
            this.금액.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.금액.DataPropertyName = "money_number";
            this.금액.HeaderText = "금액";
            this.금액.Name = "금액";
            this.금액.ReadOnly = true;
            this.금액.Width = 54;
            // 
            // 보관위치
            // 
            this.보관위치.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.보관위치.DataPropertyName = "storage_name";
            this.보관위치.HeaderText = "보관위치";
            this.보관위치.Name = "보관위치";
            this.보관위치.ReadOnly = true;
            this.보관위치.Width = 78;
            // 
            // 재고수량
            // 
            this.재고수량.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.재고수량.DataPropertyName = "storage_inventoy_number";
            this.재고수량.HeaderText = "재고수량";
            this.재고수량.Name = "재고수량";
            this.재고수량.ReadOnly = true;
            this.재고수량.Width = 78;
            // 
            // 판매수량
            // 
            this.판매수량.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.판매수량.DataPropertyName = "sales_money_number";
            this.판매수량.HeaderText = "판매수량";
            this.판매수량.Name = "판매수량";
            this.판매수량.ReadOnly = true;
            this.판매수량.Width = 78;
            // 
            // 판매일자
            // 
            this.판매일자.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.판매일자.DataPropertyName = "sales_dates";
            this.판매일자.HeaderText = "판매일자";
            this.판매일자.Name = "판매일자";
            this.판매일자.ReadOnly = true;
            this.판매일자.Width = 78;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(xmlDataManager);
            // 
            // Form6_search_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1066, 770);
            this.Controls.Add(this.dataGridView_all_incentory);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Name = "Form6_search_screen";
            this.Text = "창고관리프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all_incentory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_all_incentory;
        private System.Windows.Forms.DataGridViewTextBoxColumn 코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 분류;
        private System.Windows.Forms.DataGridViewTextBoxColumn 규격;
        private System.Windows.Forms.DataGridViewTextBoxColumn 납품처;
        private System.Windows.Forms.DataGridViewTextBoxColumn 납품일자;
        private System.Windows.Forms.DataGridViewTextBoxColumn 금액;
        private System.Windows.Forms.DataGridViewTextBoxColumn 보관위치;
        private System.Windows.Forms.DataGridViewTextBoxColumn 재고수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 판매수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 판매일자;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageinventoynumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesmoneynumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesdatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource1;
    }
}