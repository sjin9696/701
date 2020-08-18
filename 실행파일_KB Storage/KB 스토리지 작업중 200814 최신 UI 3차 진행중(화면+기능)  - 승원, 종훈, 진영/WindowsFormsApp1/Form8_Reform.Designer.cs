namespace xmlDataManager
{
    partial class Form8_Reform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8_Reform));
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
            this.button_search = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all_incentory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_all_incentory
            // 
            this.dataGridView_all_incentory.AllowDrop = true;
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
            this.dataGridView_all_incentory.Location = new System.Drawing.Point(24, 165);
            this.dataGridView_all_incentory.Name = "dataGridView_all_incentory";
            this.dataGridView_all_incentory.RowTemplate.Height = 23;
            this.dataGridView_all_incentory.Size = new System.Drawing.Size(951, 524);
            this.dataGridView_all_incentory.TabIndex = 93;
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
            // button_search
            // 
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(802, 123);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(56, 36);
            this.button_search.TabIndex = 92;
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.AllowDrop = true;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(631, 124);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 29);
            this.textBox3.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 90;
            this.label1.Text = "납품처";
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(350, 124);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 29);
            this.textBox2.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 88;
            this.label4.Text = "품명";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(93, 124);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 29);
            this.textBox1.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 86;
            this.label3.Text = "코드";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkKhaki;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(957, 44);
            this.label11.TabIndex = 85;
            this.label11.Text = "반  품/수  정 ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 708);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 40);
            this.button1.TabIndex = 94;
            this.button1.Text = "수 정";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(878, 709);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 39);
            this.button2.TabIndex = 95;
            this.button2.Text = "저 장";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form8_Reform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1031, 761);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_all_incentory);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Name = "Form8_Reform";
            this.Text = "Form8_Reform";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all_incentory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}