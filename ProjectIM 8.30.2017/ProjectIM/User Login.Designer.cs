namespace ProjectIM
{
    partial class User_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Login));
            this.txt_uname = new MetroFramework.Controls.MetroTextBox();
            this.txt_pword = new MetroFramework.Controls.MetroTextBox();
            this.lbl_ex_health_certific_no = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.errorpro_login = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorpro_login)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_uname
            // 
            this.txt_uname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_uname.Location = new System.Drawing.Point(134, 98);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(143, 29);
            this.txt_uname.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_uname.TabIndex = 2;
            this.txt_uname.UseStyleColors = true;
            // 
            // txt_pword
            // 
            this.txt_pword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_pword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_pword.Location = new System.Drawing.Point(134, 172);
            this.txt_pword.Name = "txt_pword";
            this.txt_pword.PasswordChar = '●';
            this.txt_pword.Size = new System.Drawing.Size(143, 29);
            this.txt_pword.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_pword.TabIndex = 3;
            this.txt_pword.UseStyleColors = true;
            this.txt_pword.UseSystemPasswordChar = true;
            // 
            // lbl_ex_health_certific_no
            // 
            this.lbl_ex_health_certific_no.AutoSize = true;
            this.lbl_ex_health_certific_no.Location = new System.Drawing.Point(23, 103);
            this.lbl_ex_health_certific_no.Name = "lbl_ex_health_certific_no";
            this.lbl_ex_health_certific_no.Size = new System.Drawing.Size(75, 19);
            this.lbl_ex_health_certific_no.TabIndex = 5;
            this.lbl_ex_health_certific_no.Text = "User Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 178);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.Highlight = true;
            this.btn_login.Location = new System.Drawing.Point(194, 236);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(83, 29);
            this.btn_login.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_login.TabIndex = 34;
            this.btn_login.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // errorpro_login
            // 
            this.errorpro_login.ContainerControl = this;
            this.errorpro_login.Icon = ((System.Drawing.Icon)(resources.GetObject("errorpro_login.Icon")));
            // 
            // User_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lbl_ex_health_certific_no);
            this.Controls.Add(this.txt_pword);
            this.Controls.Add(this.txt_uname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "User_Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "User Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorpro_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_uname;
        private MetroFramework.Controls.MetroTextBox txt_pword;
        private MetroFramework.Controls.MetroLabel lbl_ex_health_certific_no;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_login;
        private System.Windows.Forms.ErrorProvider errorpro_login;
    }
}