using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectIM
{
    public partial class SaveDatabase : MetroFramework.Forms.MetroForm
    {
        public SqlConnection con;

        public SaveDatabase()
        {
            InitializeComponent();
        }

        private void SaveDatabase_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=DELL-04;Initial Catalog='Main Database';Integrated Security=True";
        }

        private void btn_bro_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dg = new FolderBrowserDialog();
            if(dg.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = dg.SelectedPath;
                btn_back.Enabled = true;
            }

            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            try
            {
                if (txt_path.Text == string.Empty)
                {
                    MessageBox.Show("please enter backup file location");
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + txt_path.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("database backup done successefully");
                        btn_back.Enabled = false;
                    }
                }

            }

            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }
    }
}
