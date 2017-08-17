using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectIM
{
    public partial class User_Login : MetroFramework.Forms.MetroForm
    {
        public User_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_uname.Text) && string.IsNullOrWhiteSpace(txt_pword.Text))
            {
                errorProvider1.SetIconPadding(txt_uname, 4);
                errorProvider1.SetError(txt_uname, "Please enter User name");
                errorProvider1.SetIconPadding(txt_pword, 4);
                errorProvider1.SetError(txt_pword, "Please enter Password");
                return;
            }
            else
            {
                try
                {
                    SqlConnection UGIcon = new SqlConnection();
                    UGIcon.ConnectionString = "Data Source=DELL-04;Initial Catalog=Project;Integrated Security=True";
                    UGIcon.Open();
                    //string userText = txt_uname.Text;
                    //string passText = txt_pword.Text;
                    SqlCommand cmd = new SqlCommand("SELECT UserName,Password FROM tba_user_Login WHERE UserName='" + txt_uname.Text + "' and Password='" + txt_pword.Text + "'", UGIcon);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable(); da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        
                        cmd = new SqlCommand("SELECT Type from tba_user_Login where UserName='"+txt_uname.Text+"'", UGIcon);
                        //cmd.Parameters.AddWithValue("@Username", userText);
                        string role = cmd.ExecuteScalar().ToString();
                        string a = "Admin";
                        string b = "User ";
                        if (role == a)
                        {
                            MessageBox.Show("Login Sucess!", "Welcome Mr " + txt_uname.Text);
                            MainMenu mm = new MainMenu();
                            this.Hide();
                            mm.Show();
                            UGIcon.Close();

                            
                        }
                        if (role == b)
                        {
                            MessageBox.Show("Login Sucess!", "Welcome Mr " + txt_uname.Text);
                        }
                    
                    }
                    else
                    {
                        MessageBox.Show("Access Denied!!");
                        UGIcon.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
 }

