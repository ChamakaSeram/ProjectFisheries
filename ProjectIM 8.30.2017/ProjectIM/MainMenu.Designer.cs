namespace ProjectIM
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mtile_time = new MetroFramework.Controls.MetroTile();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.mtile_anf = new MetroFramework.Controls.MetroTile();
            this.mtile_sdata = new MetroFramework.Controls.MetroTile();
            this.mtile_edata = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mtile_time
            // 
            this.mtile_time.Location = new System.Drawing.Point(23, 315);
            this.mtile_time.Name = "mtile_time";
            this.mtile_time.Size = new System.Drawing.Size(568, 49);
            this.mtile_time.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtile_time.TabIndex = 3;
            this.mtile_time.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtile_time.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtile_time.Click += new System.EventHandler(this.mtile_time_Click);
            // 
            // mtile_anf
            // 
            this.mtile_anf.Location = new System.Drawing.Point(406, 90);
            this.mtile_anf.Name = "mtile_anf";
            this.mtile_anf.Size = new System.Drawing.Size(185, 185);
            this.mtile_anf.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtile_anf.TabIndex = 2;
            this.mtile_anf.Text = "ADD NEW FIELDS";
            this.mtile_anf.TileImage = global::ProjectIM.Properties.Resources.rsz_admin_512dp;
            this.mtile_anf.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtile_anf.Click += new System.EventHandler(this.mtile_anf_Click);
            // 
            // mtile_sdata
            // 
            this.mtile_sdata.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mtile_sdata.Location = new System.Drawing.Point(215, 90);
            this.mtile_sdata.Name = "mtile_sdata";
            this.mtile_sdata.Size = new System.Drawing.Size(185, 185);
            this.mtile_sdata.Style = MetroFramework.MetroColorStyle.Green;
            this.mtile_sdata.TabIndex = 1;
            this.mtile_sdata.Text = "SAVE DATABASE";
            this.mtile_sdata.TileImage = global::ProjectIM.Properties.Resources.rsz_unnamed3ia8k3cu;
            this.mtile_sdata.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtile_sdata.Click += new System.EventHandler(this.mtile_sdata_Click);
            // 
            // mtile_edata
            // 
            this.mtile_edata.Location = new System.Drawing.Point(23, 90);
            this.mtile_edata.Name = "mtile_edata";
            this.mtile_edata.Size = new System.Drawing.Size(185, 185);
            this.mtile_edata.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtile_edata.TabIndex = 0;
            this.mtile_edata.Text = "ENTER DATA";
            this.mtile_edata.TileImage = global::ProjectIM.Properties.Resources.rsz_untitlednew;
            this.mtile_edata.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtile_edata.Click += new System.EventHandler(this.mtile_edata_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(614, 367);
            this.Controls.Add(this.mtile_time);
            this.Controls.Add(this.mtile_anf);
            this.Controls.Add(this.mtile_sdata);
            this.Controls.Add(this.mtile_edata);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Resizable = false;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtile_edata;
        private MetroFramework.Controls.MetroTile mtile_sdata;
        private MetroFramework.Controls.MetroTile mtile_anf;
        private System.Windows.Forms.Timer timer1;
        public MetroFramework.Controls.MetroTile mtile_time;
        private System.Windows.Forms.ToolTip toolTip1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}

