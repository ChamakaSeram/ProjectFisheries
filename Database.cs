using System;
using System.Data.SqlClient;


public class Database
{
    private SqlConnection con;
    private SqlCommand cmd;

    public Database()
    {
        con = new SqlConnection("Data Source=B\\SQLEXPRESS;Initial Catalog=Example;Integrated Security=True");
    }

    public void openCon()
    {
        con.Open();
    }

    public void closeCon()
    {
        con.Close();
    }

    public int save_delete(string edta)
    {
        int rows;

        try
        {
            openCon();
        }
        catch(SqlException)
        {
            MessageBox.Show("Database Erro!!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        cmd = new SqlCommand(dta, con);
        rows = cmd.ExecuteNonQuery();
        closeCon();
        return rows;
    }

    public DataTable getdata(string gdta)
    {

    }


}
