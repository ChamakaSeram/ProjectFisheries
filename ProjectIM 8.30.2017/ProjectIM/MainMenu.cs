using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace ProjectIM
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {

        public string username;

        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            

            // Set up the delays for the ToolTip.
            metroToolTip1.AutoPopDelay = 5000;
            metroToolTip1.InitialDelay = 1000;
            metroToolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            metroToolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            metroToolTip1.SetToolTip(this.mtile_edata, "Enter Data");
            metroToolTip1.SetToolTip(this.mtile_sdata, "Save Database");
            metroToolTip1.SetToolTip(this.mtile_anf, "Add new fields");


            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mtile_time.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss");
        }

       

        private void mtile_sdata_Click(object sender, EventArgs e)
        {
            SaveDatabase Sd = new SaveDatabase();
            Sd.Visible = true;
        }

        private void mtile_edata_Click(object sender, EventArgs e)
        {
            this.Hide();

            Enterdata ed = new Enterdata();
            ed.Visible = true;
            ed.username_enterdata = username;

        }

        private void mtile_time_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void mtile_anf_Click(object sender, EventArgs e)
        {
            AddnewFields adne = new AddnewFields();
            adne.Show();
        }
    }
}
