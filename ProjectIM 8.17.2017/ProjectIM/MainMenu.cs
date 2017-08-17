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

       

        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
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
    }
}
