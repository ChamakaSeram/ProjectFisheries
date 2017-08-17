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
        public void Save_Del_Update(String a)
        {
            try
            {
                opencon();
                cmd = new SqlCommand(a, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                closeCon();

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        //CODE FOR COMMAND DISPOSE
        public void cmddis()
        {
            cmd.Dispose();
        }
    }
}
