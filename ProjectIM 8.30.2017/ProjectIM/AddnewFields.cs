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
    public partial class AddnewFields : MetroFramework.Forms.MetroForm
    {
        
        public AddnewFields()
        {
            InitializeComponent();
        }

        private void AddnewFields_Load(object sender, EventArgs e)
        {
            cmb_addnewfi.SelectedIndex = 0;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(cmb_addnewfi.SelectedIndex == 0)
            {
                erropro_addnewfi.SetIconPadding(cmb_addnewfi, 4);
                erropro_addnewfi.SetError(cmb_addnewfi,"Please select field");
            }
            if(string.IsNullOrWhiteSpace(txt_fileldname.Text))
            {
                erropro_addnewfi.SetIconPadding(txt_fileldname, 4);
                erropro_addnewfi.SetError(txt_fileldname, "Please enter value");
            }
            if(cmb_addnewfi.SelectedIndex != 0 && !string.IsNullOrWhiteSpace(txt_fileldname.Text))
            {
                if(cmb_addnewfi.SelectedIndex == 1)
                {
                    Database db = new Database();

                    try
                    {
                        string con = "Insert into [Export Details] Values('" + txt_fileldname.Text + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "')";
                        int i = db.Save_Del_Update(con);
                        if (i == 1)
                            MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.closeCon();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (cmb_addnewfi.SelectedIndex == 2)
                {
                    Database db = new Database();

                    try
                    {
                        string con = "Insert into [Export Details] Values('" +""+ "','" + txt_fileldname.Text + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "')";
                        int i = db.Save_Del_Update(con);
                        if (i == 1)
                            MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.closeCon();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (cmb_addnewfi.SelectedIndex == 3)
                {
                    Database db = new Database();

                    try
                    {
                        string con = "Insert into [Export Details] Values('" + "" + "','" + "" + "','" + txt_fileldname.Text + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "')";
                        int i = db.Save_Del_Update(con);
                        if (i == 1)
                            MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.closeCon();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (cmb_addnewfi.SelectedIndex == 4)
                {
                    Database db = new Database();

                    try
                    {
                        string con = "Insert into [Export Details] Values('" + "" + "','" + "" + "','" + "" + "','" + txt_fileldname.Text + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "')";
                        int i = db.Save_Del_Update(con);
                        if (i == 1)
                            MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.closeCon();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (cmb_addnewfi.SelectedIndex == 5)
                {
                    Database db = new Database();

                    try
                    {
                        string con = "Insert into [Export Details] Values('" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + txt_fileldname.Text + "')";
                        int i = db.Save_Del_Update(con);
                        if (i == 1)
                            MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.closeCon();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (cmb_addnewfi.SelectedIndex == 6)
                {
                    Database db = new Database();

                    try
                    {
                        string con = "Insert into [Export Details] Values('" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + txt_fileldname.Text + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "')";
                        int i = db.Save_Del_Update(con);
                        if (i == 1)
                            MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.closeCon();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (cmb_addnewfi.SelectedIndex == 7)
                {
                    Database db = new Database();

                    try
                    {
                        string con = "Insert into [Export Details] Values('" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + txt_fileldname.Text + "','" + "" + "','" + "" + "')";
                        int i = db.Save_Del_Update(con);
                        if (i == 1)
                            MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.closeCon();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (cmb_addnewfi.SelectedIndex == 8)
                {
                    Database db = new Database();

                    try
                    {
                        string con = "Insert into [Export Details] Values('" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + txt_fileldname.Text + "','" + "" + "')";
                        int i = db.Save_Del_Update(con);
                        if (i == 1)
                            MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.closeCon();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }
    }
}
