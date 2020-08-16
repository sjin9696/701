namespace xmlDataManager
{
    partial class Form4_all_inventory_screen
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
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView_all_incentory = new System.Windows.Forms.DataGridView();
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
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all_incentory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkKhaki;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(56, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(957, 44);
            this.label11.TabIndex = 22;
            this.label11.Text = "전체 재고리스트";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_all_incentory
            // 
            this.dataGridView_all_incentory.AllowDrop = true;
            this.dataGridView_all_incentory.AutoGenerateColumns = false;
            this.dataGridView_all_incentory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_all_incentory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView_all_incentory.DataSource = this.productBindingSource;
            this.dataGridView_all_incentory.Location = new System.Drawing.Point(62, 106);
            this.dataGridView_all_incentory.Name = "dataGridView_all_incentory";
            this.dataGridView_all_incentory.RowTemplate.Height = 23;
            this.dataGridView_all_incentory.Size = new System.Drawing.Size(951, 584);
            this.dataGridView_all_incentory.TabIndex = 48;
            this.dataGridView_all_incentory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_all_incentory_CellContentClick);
            this.dataGridView_all_incentory.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_all_incentory_ColumnHeaderMouseClick);
            this.dataGridView_all_incentory.ColumnSortModeChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView_all_incentory_ColumnSortModeChanged);
            // 
            // 계정코드
            // 
            this.계정코드.DataPropertyName = "product_code_number";
            this.계정코드.HeaderText = "코드";
            this.계정코드.Name = "계정코드";
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
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(xmlDataManager);
            // 
            // Form4_all_inventory_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1081, 745);
            this.Controls.Add(this.dataGridView_all_incentory);
            this.Controls.Add(this.label11);
            this.Name = "Form4_all_inventory_screen";
            this.Text = "창고관리프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all_incentory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView_all_incentory;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn moneynumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storagenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventorystocknumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}