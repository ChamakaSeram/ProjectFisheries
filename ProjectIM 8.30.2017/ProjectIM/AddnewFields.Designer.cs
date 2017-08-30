namespace ProjectIM
{
    partial class AddnewFields
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddnewFields));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_fileldname = new MetroFramework.Controls.MetroTextBox();
            this.cmb_addnewfi = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_addnew = new MetroFramework.Controls.MetroButton();
            this.erropro_addnewfi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erropro_addnewfi)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Select field";
            // 
            // txt_fileldname
            // 
            this.txt_fileldname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_fileldname.Location = new System.Drawing.Point(136, 174);
            this.txt_fileldname.Name = "txt_fileldname";
            this.txt_fileldname.Size = new System.Drawing.Size(180, 29);
            this.txt_fileldname.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_fileldname.TabIndex = 3;
            this.txt_fileldname.UseStyleColors = true;
            // 
            // cmb_addnewfi
            // 
            this.cmb_addnewfi.FormattingEnabled = true;
            this.cmb_addnewfi.ItemHeight = 23;
            this.cmb_addnewfi.Items.AddRange(new object[] {
            "Please Select Value",
            "EU Processing Establishments",
            "Non EU Processing Establishments",
            "EU Countries",
            "Non Eu Countries",
            "Region of Organ",
            "Species",
            "Arrival port",
            "Gear Type"});
            this.cmb_addnewfi.Location = new System.Drawing.Point(136, 105);
            this.cmb_addnewfi.Name = "cmb_addnewfi";
            this.cmb_addnewfi.Size = new System.Drawing.Size(180, 29);
            this.cmb_addnewfi.TabIndex = 32;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 180);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 33;
            this.metroLabel2.Text = "Field name";
            // 
            // btn_addnew
            // 
            this.btn_addnew.Highlight = true;
            this.btn_addnew.Location = new System.Drawing.Point(233, 248);
            this.btn_addnew.Name = "btn_addnew";
            this.btn_addnew.Size = new System.Drawing.Size(83, 29);
            this.btn_addnew.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btn_addnew.TabIndex = 35;
            this.btn_addnew.Text = "Add";
            this.btn_addnew.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // erropro_addnewfi
            // 
            this.erropro_addnewfi.ContainerControl = this;
            this.erropro_addnewfi.Icon = ((System.Drawing.Icon)(resources.GetObject("erropro_addnewfi.Icon")));
            // 
            // AddnewFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(340, 337);
            this.Controls.Add(this.btn_addnew);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmb_addnewfi);
            this.Controls.Add(this.txt_fileldname);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "AddnewFields";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Add New Fields";
            this.Load += new System.EventHandler(this.AddnewFields_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erropro_addnewfi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_fileldname;
        private MetroFramework.Controls.MetroComboBox cmb_addnewfi;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btn_addnew;
        private System.Windows.Forms.ErrorProvider erropro_addnewfi;
    }
}