namespace xmlDataManager
{
    partial class Form3_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_Login));
            this.textBox_login_id = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_login_pw = new System.Windows.Forms.TextBox();
            this.button_admin_login = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // textBox_login_id
            // 
            this.textBox_login_id.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login_id.Location = new System.Drawing.Point(86, 220);
            this.textBox_login_id.Name = "textBox_login_id";
            this.textBox_login_id.Size = new System.Drawing.Size(308, 26);
            this.textBox_login_id.TabIndex = 1;
            this.textBox_login_id.Text = "아이디";
            this.textBox_login_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_login_id.Click += new System.EventHandler(this.textBox_login_id_Click);
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_login.Location = new System.Drawing.Point(68, 325);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(339, 44);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "로그인하기";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_login_pw
            // 
            this.textBox_login_pw.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login_pw.Location = new System.Drawing.Point(86, 272);
            this.textBox_login_pw.Name = "textBox_login_pw";
            this.textBox_login_pw.PasswordChar = '*';
            this.textBox_login_pw.Size = new System.Drawing.Size(308, 26);
            this.textBox_login_pw.TabIndex = 2;
            this.textBox_login_pw.Text = "비밀번호";
            this.textBox_login_pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_login_pw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_login_pw_KeyDown);
           
            // 
            // button_admin_login
            // 
            this.button_admin_login.FlatAppearance.BorderSize = 0;
            this.button_admin_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_admin_login.Image = ((System.Drawing.Image)(resources.GetObject("button_admin_login.Image")));
            this.button_admin_login.Location = new System.Drawing.Point(436, 12);
            this.button_admin_login.Name = "button_admin_login";
            this.button_admin_login.Size = new System.Drawing.Size(57, 57);
            this.button_admin_login.TabIndex = 4;
            this.button_admin_login.UseVisualStyleBackColor = true;
            this.button_admin_login.Click += new System.EventHandler(this.button_admin_login_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(86, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(308, 145);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "로고회전 작은거v.png");
            // 
            // Form3_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(505, 443);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_admin_login);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_login_pw);
            this.Controls.Add(this.textBox_login_id);
            this.Name = "Form3_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "창고관리프로그램";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_login_id;
        private System.Windows.Forms.Button button_login;
        public System.Windows.Forms.TextBox textBox_login_pw;
        private System.Windows.Forms.Button button_admin_login;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
    }
}