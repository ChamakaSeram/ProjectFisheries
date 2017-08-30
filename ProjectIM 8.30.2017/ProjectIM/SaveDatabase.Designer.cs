namespace ProjectIM
{
    partial class SaveDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveDatabase));
            this.txt_path = new MetroFramework.Controls.MetroTextBox();
            this.btn_bro = new MetroFramework.Controls.MetroButton();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(24, 82);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(166, 23);
            this.txt_path.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_path.TabIndex = 0;
            this.txt_path.UseStyleColors = true;
            // 
            // btn_bro
            // 
            this.btn_bro.Highlight = true;
            this.btn_bro.Location = new System.Drawing.Point(196, 82);
            this.btn_bro.Name = "btn_bro";
            this.btn_bro.Size = new System.Drawing.Size(75, 23);
            this.btn_bro.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_bro.TabIndex = 1;
            this.btn_bro.Text = "Browse";
            this.btn_bro.Click += new System.EventHandler(this.btn_bro_Click);
            // 
            // btn_back
            // 
            this.btn_back.Enabled = false;
            this.btn_back.Highlight = true;
            this.btn_back.Location = new System.Drawing.Point(196, 111);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Backup";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SaveDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_bro);
            this.Controls.Add(this.txt_path);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SaveDatabase";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Save Database";
            this.Load += new System.EventHandler(this.SaveDatabase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_path;
        private MetroFramework.Controls.MetroButton btn_bro;
        private MetroFramework.Controls.MetroButton btn_back;
    }
}