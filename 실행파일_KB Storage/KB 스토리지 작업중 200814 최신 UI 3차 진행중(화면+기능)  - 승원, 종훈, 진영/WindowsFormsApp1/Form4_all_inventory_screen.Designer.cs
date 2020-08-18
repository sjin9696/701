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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4_all_inventory_screen));
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView_all_incentory = new System.Windows.Forms.DataGridView();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.계정코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계정명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.관리번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.납품처 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivery_dates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.보관위치 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.재고수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_money_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_dates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all_incentory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
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
            this.관리번호,
            this.Column1,
            this.납품처,
            this.delivery_dates,
            this.Column3,
            this.보관위치,
            this.재고수량,
            this.sales_money_number,
            this.sales_dates});
            this.dataGridView_all_incentory.DataSource = this.productBindingSource1;
            this.dataGridView_all_incentory.Location = new System.Drawing.Point(62, 122);
            this.dataGridView_all_incentory.Name = "dataGridView_all_incentory";
            this.dataGridView_all_incentory.RowTemplate.Height = 23;
            this.dataGridView_all_incentory.Size = new System.Drawing.Size(951, 568);
            this.dataGridView_all_incentory.TabIndex = 48;
            this.dataGridView_all_incentory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_all_incentory_CellContentClick);
            this.dataGridView_all_incentory.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_all_incentory_ColumnHeaderMouseClick);
            this.dataGridView_all_incentory.ColumnSortModeChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView_all_incentory_ColumnSortModeChanged);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(xmlDataManager);
            this.productBindingSource1.CurrentChanged += new System.EventHandler(this.productBindingSource1_CurrentChanged);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Location = new System.Drawing.Point(964, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 47);
            this.button6.TabIndex = 79;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // 계정코드
            // 
            this.계정코드.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.계정코드.DataPropertyName = "product_code_number";
            this.계정코드.HeaderText = "코드";
            this.계정코드.Name = "계정코드";
            this.계정코드.ReadOnly = true;
            this.계정코드.Width = 54;
            // 
            // 계정명
            // 
            this.계정명.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.계정명.DataPropertyName = "product_name";
            this.계정명.HeaderText = "품명";
            this.계정명.Name = "계정명";
            this.계정명.ReadOnly = true;
            this.계정명.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.계정명.Width = 54;
            // 
            // 관리번호
            // 
            this.관리번호.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.관리번호.DataPropertyName = "categorize_name";
            this.관리번호.HeaderText = "분류";
            this.관리번호.Name = "관리번호";
            this.관리번호.ReadOnly = true;
            this.관리번호.Width = 54;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "type_name";
            this.Column1.HeaderText = "규격";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 54;
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
            // delivery_dates
            // 
            this.delivery_dates.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delivery_dates.DataPropertyName = "delivery_dates";
            this.delivery_dates.HeaderText = "납품일자";
            this.delivery_dates.Name = "delivery_dates";
            this.delivery_dates.ReadOnly = true;
            this.delivery_dates.Width = 78;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "money_number";
            this.Column3.HeaderText = "금액";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 54;
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
            // sales_money_number
            // 
            this.sales_money_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sales_money_number.DataPropertyName = "sales_money_number";
            this.sales_money_number.HeaderText = "판매수량";
            this.sales_money_number.Name = "sales_money_number";
            this.sales_money_number.ReadOnly = true;
            this.sales_money_number.Width = 78;
            // 
            // sales_dates
            // 
            this.sales_dates.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sales_dates.DataPropertyName = "sales_dates";
            this.sales_dates.HeaderText = "판매일자";
            this.sales_dates.Name = "sales_dates";
            this.sales_dates.ReadOnly = true;
            this.sales_dates.Width = 78;
            // 
            // Form4_all_inventory_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1081, 745);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView_all_incentory);
            this.Controls.Add(this.label11);
            this.Name = "Form4_all_inventory_screen";
            this.Text = "창고관리프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all_incentory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView_all_incentory;
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource productBindingSource1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn 계정코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계정명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관리번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 납품처;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivery_dates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 보관위치;
        private System.Windows.Forms.DataGridViewTextBoxColumn 재고수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_money_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_dates;
    }
}