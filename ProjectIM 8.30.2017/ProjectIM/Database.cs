using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectIM
{
    class Database
    {
        public SqlDataReader dr;
        private SqlConnection con;
        private SqlCommand cmd;
        public double logqty,reqty;//update
        public bool resbol;//update

        //CONSTRUCTOR
        public Database()
        {
            con = new SqlConnection("Data Source=DELL-04;Initial Catalog=Project;Integrated Security=True");
        }

        //OPEN CONNECTION
        public void opencon()
        {
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //CLOSE CONNECTION
        public void closeCon()
        {
            con.Close();
        }

        //CODE FOR SAVE/DELETE/UPDATE
        public int Save_Del_Update(String a)
        {  
            try
            {
                opencon();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd = new SqlCommand(a, con);
            int i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            closeCon();
            return i;

        }

        //CODE FOR LOAD DATA FROM DATABASE
        public void load_cmb(String a)
        {
            try
            {
                opencon();
               
            }

            catch (SqlException)
            {
                MessageBox.Show("Database errors");
                
            }
            
            cmd = new SqlCommand(a, con);
            dr = cmd.ExecuteReader();

        }

        //updated
        public void scsqty(string b)
        {

            try
            {
                opencon();
                cmd = new SqlCommand(b, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    resbol = true;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    logqty = Convert.ToDouble(dr["Log_qty"]);
                    reqty = Convert.ToDouble(dr["remaing_qty"]);
                }
                else
                {
                    resbol = false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            closeCon();
        }

        //CODE FOR COMMAND DISPOSE
        public void cmddis()
        {
            cmd.Dispose();
        }
    }
}
//helllooooooooooo