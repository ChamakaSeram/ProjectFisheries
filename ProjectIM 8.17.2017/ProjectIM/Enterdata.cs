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
    public partial class Enterdata : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        int vari_ex_health_qty = 0;
        Boolean vari_btn_ex_health_adddatahealth_clicked;

        /// <summary>
        /// /Codes for methods.....................
        /// </summary>
        /// 


        public Enterdata()
        {
            InitializeComponent();
            this.StyleManager = stym;
        }

        //load combobox values when load screen
        private void cmddat_loaddef()
        {

            db.load_cmb("SELECT region_organ FROM [Export Details] WHERE (region_organ  IS NOT NULL)");
            while (db.dr.Read())
            {
                cmb_ex_reg_of_organ.Items.Add(db.dr[0]);

            }
            db.cmddis();
            db.closeCon();

            db.load_cmb("SELECT arival_port FROM [Export Details] WHERE (arival_port IS NOT NULL)");
            while (db.dr.Read())
            {
                cmb_ex_catch_arival_port.Items.Add(db.dr[0]);

            }
            db.cmddis();
            db.closeCon();

            db.load_cmb("SELECT species FROM [Export Details] WHERE (species IS NOT NULL)");
            while (db.dr.Read())
            {
                cmb_ex_health_species.Items.Add(db.dr[0]);

            }
            db.cmddis();
            db.closeCon();

            db.load_cmb("SELECT species FROM [Export Details] WHERE (species IS NOT NULL)");
            while (db.dr.Read())
            {
                cmb_ex_catch_catchspices.Items.Add(db.dr[0]);

            }
            db.cmddis();
            db.closeCon();

            db.load_cmb("SELECT arival_port FROM [Export Details] WHERE (arival_port IS NOT NULL)");
            while (db.dr.Read())
            {
                cmb_ex_catch_arival_port.Items.Add(db.dr[0]);
            }
            db.cmddis();
            db.closeCon();

            db.load_cmb("SELECT methodof_verifi FROM [Export Details] WHERE (methodof_verifi IS NOT NULL)");
            while (db.dr.Read())
            {
                cmb_ex_catch_method_of_verify.Items.Add(db.dr[0]);
            }
            db.cmddis();
            db.closeCon();

        }

        //load combo box values according to eu type
        private void cmbty_load()
        {
           
            if (cmb_ex_eutype.SelectedIndex == 0)
            {
                cmb_ex_company_name.Items.Clear();
                cmb_ex_company_name.Items.Add("Please select value");
                cmb_ex_company_name.SelectedIndex = 0;
                cmb_ex_country_name.Items.Clear();
                cmb_ex_country_name.Items.Add("Please select value");
                cmb_ex_country_name.SelectedIndex = 0;
            }


            if (cmb_ex_eutype.SelectedIndex == 1)
            {
                cmb_ex_company_name.Items.Clear();
                cmb_ex_country_name.Items.Clear();

                db.load_cmb("SELECT catch_process_estab_eu FROM [Export Details] WHERE (catch_process_estab_eu  IS NOT NULL)");
                while (db.dr.Read())
                {
                    cmb_ex_company_name.Items.Add(db.dr[0]);
                }
                db.cmddis();
                db.closeCon();

                db.load_cmb("SELECT country_eu FROM [Export Details] WHERE (country_eu IS NOT NULL)");
                while (db.dr.Read())
                {
                    cmb_ex_country_name.Items.Add(db.dr[0]);
                }
                db.cmddis();
                db.closeCon();

                cmb_ex_company_name.SelectedIndex = 0;
                cmb_ex_country_name.SelectedIndex = 0;
            }
            if (cmb_ex_eutype.SelectedIndex == 2)
            {
                cmb_ex_company_name.Items.Clear();
                cmb_ex_company_name.SelectedValue = 0;
                db.load_cmb("SELECT catch_process_establish_non_eu FROM [Export Details] WHERE (catch_process_establish_non_eu  IS NOT NULL)");
                while (db.dr.Read())
                {
                    cmb_ex_company_name.Items.Add(db.dr[0]);
                }
                db.cmddis();
                db.closeCon();

                cmb_ex_country_name.Items.Clear();
                cmb_ex_country_name.SelectedValue = 0;
                db.load_cmb("SELECT country_non_eu FROM [Export Details] WHERE (country_non_eu IS NOT NULL)");
                while (db.dr.Read())
                {
                    cmb_ex_country_name.Items.Add(db.dr[0]);
                }
                db.cmddis();
                db.closeCon();

                cmb_ex_company_name.SelectedIndex = 0;
                cmb_ex_country_name.SelectedIndex = 0;

            }
        }

        //code for change element colours when select scs or Rcs(for easy identify)
        public void coluchange()
        {
            if (cmb_ex_catch_typ.SelectedIndex == 1)
            {

                txt_ex_catch_fishing_olicence.Enabled = false;
                cmb_ex_catch_method_of_verify.Enabled = false;
                cmb_ex_catch_catchspices.Enabled = false;
                txt_ex_catch_log_book_no.Enabled = false;
                txt_ex_catch_log_book_pno.Enabled = false;
                cmb_ex_catch_arival_port.Enabled = false;
                dtp_ex_catch_arivdate.Enabled = false;
                cmb_ex_catch_gear_type.Enabled = false;
                txt_ex_catch_remark.Enabled = false;
                txt_ex_catch_log_book_qty.Enabled = false;
                btn_ex_catch_search.Enabled = false;

                txt_ex_catch_certific_no.Theme = MetroFramework.MetroThemeStyle.Dark;
                txt_ex_catch_qty.Theme = MetroFramework.MetroThemeStyle.Dark;
                txt_ex_catch__no_of_catch.Theme = MetroFramework.MetroThemeStyle.Dark;
                txt_ex_catch_boat_reg_no.Theme = MetroFramework.MetroThemeStyle.Dark;
               

                //lbl_ex_catch_certificate_no.Theme = MetroFramework.MetroThemeStyle.Dark;
                //lbl_ex_quantity.Theme = MetroFramework.MetroThemeStyle.Dark;
                //lbl_ex_log_bqty.Theme = MetroFramework.MetroThemeStyle.Dark;
                //lbl_Ex_no_catch_doc.Theme = MetroFramework.MetroThemeStyle.Dark;
                //lbl_ex_bregistration_no.Theme = MetroFramework.MetroThemeStyle.Dark;

                btn_ex_catch_add.Theme = MetroFramework.MetroThemeStyle.Dark;


            }
            if (cmb_ex_catch_typ.SelectedIndex == 0 || cmb_ex_catch_typ.SelectedIndex == 2)
            {

                txt_ex_catch_certific_no.Enabled = true;
                txt_ex_catch_fishing_olicence.Enabled = true;
                cmb_ex_catch_method_of_verify.Enabled = true;
                cmb_ex_catch_catchspices.Enabled = true;
                txt_ex_catch_log_book_no.Enabled = true;
                txt_ex_catch_log_book_pno.Enabled = true;
                cmb_ex_catch_arival_port.Enabled = true;
                dtp_ex_catch_arivdate.Enabled = true;
                cmb_ex_catch_gear_type.Enabled = true;
                txt_ex_catch_remark.Enabled = true;
                txt_ex_catch_log_book_qty.Enabled = true;
                btn_ex_catch_search.Enabled = true;

                txt_ex_catch_certific_no.Theme = MetroFramework.MetroThemeStyle.Default;
                txt_ex_catch_qty.Theme = MetroFramework.MetroThemeStyle.Default;
                txt_ex_catch__no_of_catch.Theme = MetroFramework.MetroThemeStyle.Default;
                txt_ex_catch_boat_reg_no.Theme = MetroFramework.MetroThemeStyle.Default;
                

                //lbl_ex_catch_certificate_no.Theme = MetroFramework.MetroThemeStyle.Default;
                //lbl_ex_quantity.Theme = MetroFramework.MetroThemeStyle.Default;
                //lbl_ex_log_bqty.Theme = MetroFramework.MetroThemeStyle.Default;
                //lbl_Ex_no_catch_doc.Theme = MetroFramework.MetroThemeStyle.Default;
                //lbl_ex_bregistration_no.Theme = MetroFramework.MetroThemeStyle.Default;
                btn_ex_catch_add.Theme = MetroFramework.MetroThemeStyle.Default;
            }
        }

        //code for add data to Health_certi_spic_details table
        public void btn_ex_health_add_Health_dataenter()
        {
            int i;
            int corqty;

            if (vari_btn_ex_health_adddatahealth_clicked == false)
                MessageBox.Show("Please enter Health certificate details first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (cmb_ex_typ_of_process.SelectedIndex == 0)
            {
                erro_pro_healt.SetIconPadding(cmb_ex_typ_of_process, 4);
                erro_pro_healt.SetError(cmb_ex_typ_of_process, "Please select a type of Process");
            }
            else
                erro_pro_healt.SetError(cmb_ex_typ_of_process, "");
            if (cmb_ex_typ_of_product.SelectedIndex == 0)
            {
                erro_pro_healt.SetIconPadding(cmb_ex_typ_of_product, 4);
                erro_pro_healt.SetError(cmb_ex_typ_of_product, "Please select type of Product");
            }
            else
                erro_pro_healt.SetError(cmb_ex_typ_of_product, "");
            if (cmb_ex_reg_of_organ.SelectedIndex == 0)
            {
                erro_pro_healt.SetIconPadding(cmb_ex_reg_of_organ, 4);
                erro_pro_healt.SetError(cmb_ex_reg_of_organ, "Please select Organ");
            }
            else
                erro_pro_healt.SetError(cmb_ex_reg_of_organ, "");
            if (cmb_ex_health_species.SelectedIndex == 0)
            {
                erro_pro_healt.SetIconPadding(cmb_ex_health_species, 4);
                erro_pro_healt.SetError(cmb_ex_health_species, "Please select Species");
            }
            else
                erro_pro_healt.SetError(cmb_ex_health_species, "");
            if (!int.TryParse(txt_ex_qty_mqty.Text, out i))
            {
                erro_pro_healt.SetIconPadding(txt_ex_qty_mqty, 4);
                erro_pro_healt.SetError(txt_ex_qty_mqty, "Please only enter numbers");
            }
            else
                erro_pro_healt.SetError(txt_ex_qty_mqty, "");
            if (vari_btn_ex_health_adddatahealth_clicked == true && int.TryParse(txt_ex_qty_mqty.Text, out corqty) && !string.IsNullOrWhiteSpace(txt_ex_helthno.Text) && cmb_ex_typ_of_process.SelectedIndex != 0 && cmb_ex_typ_of_product.SelectedIndex != 0 && cmb_ex_reg_of_organ.SelectedIndex != 0 && cmb_ex_health_species.SelectedIndex != 0)
            {
                string com = "Insert into Health_certi_spic_details(Health_certi_no,Health_spices,Health_spi_qty,typ_of_process,typ_of_product,reg_of_organ) Values('" + txt_ex_helthno.Text + "', '" + cmb_ex_health_species.SelectedItem + "','" + Convert.ToInt32(txt_ex_qty_mqty.Text) + "','" + cmb_ex_typ_of_process.SelectedItem + "','" + cmb_ex_typ_of_product.SelectedItem + "','" + cmb_ex_reg_of_organ.SelectedItem + "')";
                db.Save_Del_Update(com);
                MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                vari_ex_health_qty = vari_ex_health_qty + corqty;
                txt_ex_health_totqty.Text = vari_ex_health_qty.ToString();
            }
        }

        //code for add data to Health_Export_main table
        public void btn_ex_health_adddatahealth_enterdata()
        {
            if (string.IsNullOrWhiteSpace(txt_ex_helthno.Text))
            {
                erro_pro.SetIconPadding(txt_ex_helthno, 4);
                erro_pro.SetError(txt_ex_helthno, "Enter Health certificate no");
            }
            else
                erro_pro.SetError(txt_ex_helthno, "");
            if (cmb_ex_eutype.SelectedIndex == 0)
            {
                erro_pro.SetIconPadding(cmb_ex_eutype, 4);
                erro_pro.SetError(cmb_ex_eutype, "Please select a type");
            }
            else
                erro_pro.SetError(cmb_ex_eutype, "");
            if (cmb_ex_company_name.SelectedIndex == 0)
            {
                erro_pro.SetIconPadding(cmb_ex_company_name, 4);
                erro_pro.SetError(cmb_ex_company_name, "Please select company name");
            }
            else
                erro_pro.SetError(cmb_ex_company_name, "");
            if (cmb_ex_country_name.SelectedIndex == 0)
            {
                erro_pro.SetIconPadding(cmb_ex_country_name, 4);
                erro_pro.SetError(cmb_ex_country_name, "Please select country name");
            }
            else
                erro_pro.SetError(cmb_ex_country_name, "");
            if (!string.IsNullOrWhiteSpace(txt_ex_helthno.Text) && cmb_ex_eutype.SelectedIndex != 0 && cmb_ex_company_name.SelectedIndex != 0 && cmb_ex_country_name.SelectedIndex != 0)
            {
                string com = "Insert into Health_Export_main Values('" + txt_ex_helthno.Text + "', '" + cmb_ex_company_name.SelectedItem + "','" + cmb_ex_country_name.SelectedItem + "','" + dtp_ex_health_dateofship.Value.ToString() + "')";
                db.Save_Del_Update(com);
                MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                txt_ex_helthno.Enabled = false;
                cmb_ex_eutype.Enabled = false;
                cmb_ex_company_name.Enabled = false;
                cmb_ex_country_name.Enabled = false;
                dtp_ex_health_dateofship.Enabled = false;
                btn_ex_health_adddatahealth.Enabled = false;

                vari_btn_ex_health_adddatahealth_clicked = true;
            }
        }

        public void resetfields()
        {
            txt_ex_helthno.Enabled = true;
            cmb_ex_eutype.Enabled = true;
            cmb_ex_company_name.Enabled = true;
            cmb_ex_country_name.Enabled = true;
            dtp_ex_health_dateofship.Enabled = true;
            btn_ex_health_adddatahealth.Enabled = true;

            txt_ex_helthno.Text = "";
            txt_ex_health_totqty.Text = "";
            txt_ex_catch_certific_no.Text = "";
            txt_ex_catch_boat_reg_no.Text = "";
            txt_ex_catch_fishing_olicence.Text = "";
            txt_ex_catch_qty.Text = "";
            txt_ex_catch_log_book_no.Text = "";
            txt_ex_catch_log_book_pno.Text = "";
            txt_ex_catch_log_book_qty.Text = "";
            txt_ex_catch_remaqty.Text = "";
            txt_ex_catch_remark.Text = "";
            txt_ex_catch__no_of_catch.Text = "";
            txt_ex_health_totqty.Text = "";
            txt_ex_qty_mqty.Text = "";

            cmb_ex_eutype.SelectedItem = "Please select value";
            cmb_ex_typ_of_process.SelectedItem = "Please select value";
            cmb_ex_typ_of_product.SelectedItem = "Please select value";
            cmb_ex_reg_of_organ.SelectedItem = "Please select value";
            cmb_ex_catch_typ.SelectedItem = "Please select value";
            cmb_ex_catch_gear_type.SelectedItem = "Please select value";
            cmb_ex_health_species.SelectedItem = "Please select value";
        }

        public void catch_cetif_check()
        {
            int i, k,t;

            if (vari_btn_ex_health_adddatahealth_clicked == false)
                MessageBox.Show("Please enter Health certificate details first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (cmb_ex_catch_typ.SelectedIndex == 0)
            {
                erro_pro_catch.SetIconPadding(cmb_ex_catch_typ, 4);
                erro_pro_catch.SetError(cmb_ex_catch_typ, "Please select catch type first");
            }
            else
                erro_pro_catch.SetError(cmb_ex_catch_typ, "");
            if (string.IsNullOrWhiteSpace(txt_ex_catch_certific_no.Text))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_certific_no, 4);
                erro_pro_catch.SetError(txt_ex_catch_certific_no, "Please enter catch certificate no");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_certific_no, "");
            if (string.IsNullOrWhiteSpace(txt_ex_catch_boat_reg_no.Text))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_boat_reg_no, 4);
                erro_pro_catch.SetError(txt_ex_catch_boat_reg_no, "Please enter boat registration no");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_boat_reg_no, "");
            if (string.IsNullOrWhiteSpace(txt_ex_catch_fishing_olicence.Text))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_fishing_olicence, 4);
                erro_pro_catch.SetError(txt_ex_catch_fishing_olicence, "Please enter fishing operation no");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_fishing_olicence, "");
            if (cmb_ex_catch_method_of_verify.SelectedIndex == 0)
            {
                erro_pro_catch.SetIconPadding(cmb_ex_catch_method_of_verify, 4);
                erro_pro_catch.SetError(cmb_ex_catch_method_of_verify, "Please select catch method");
            }
            else
                erro_pro_catch.SetError(cmb_ex_catch_method_of_verify, "");
            if (cmb_ex_catch_catchspices.SelectedIndex == 0)
            {
                erro_pro_catch.SetIconPadding(cmb_ex_catch_catchspices, 4);
                erro_pro_catch.SetError(cmb_ex_catch_catchspices, "Please select species");
            }
            else
                erro_pro_catch.SetError(cmb_ex_catch_catchspices, "");
            if (!int.TryParse(txt_ex_catch_qty.Text,out t))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_qty, 4);
                erro_pro_catch.SetError(txt_ex_catch_qty, "Please enter catch qty");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_qty, "");
            if (string.IsNullOrWhiteSpace(txt_ex_catch_log_book_no.Text))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_log_book_no, 4);
                erro_pro_catch.SetError(txt_ex_catch_log_book_no, "Please enter logbook no");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_log_book_no, "");
            if (!int.TryParse(txt_ex_catch_log_book_pno.Text, out i))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_log_book_pno, 4);
                erro_pro_catch.SetError(txt_ex_catch_log_book_pno, "Please enter logbook page no");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_log_book_pno, "");
            if (cmb_ex_catch_arival_port.SelectedIndex == 0)
            {
                erro_pro_catch.SetIconPadding(cmb_ex_catch_arival_port, 4);
                erro_pro_catch.SetError(cmb_ex_catch_arival_port, "Please select arrival port");
            }
            else
                erro_pro_catch.SetError(cmb_ex_catch_arival_port, "");
            if (!int.TryParse(txt_ex_catch_log_book_qty.Text, out k))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_log_book_qty, 4);
                erro_pro_catch.SetError(txt_ex_catch_log_book_qty, "Please enter logbook quantity");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_log_book_qty, "");
            if (cmb_ex_catch_gear_type.SelectedIndex == 0)
            {
                erro_pro_catch.SetIconPadding(cmb_ex_catch_gear_type, 4);
                erro_pro_catch.SetError(cmb_ex_catch_gear_type, "Please select gear type");
            }
            else
                erro_pro_catch.SetError(cmb_ex_catch_gear_type, "");
        }

        public void btn_ex_catch_add_enterdata_RCS()
        {
            catch_cetif_check();
        }

        public void btn_ex_catch_add_enterdata_SCS()
        {
            int t;

            if (string.IsNullOrWhiteSpace(txt_ex_catch_certific_no.Text))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_certific_no, 4);
                erro_pro_catch.SetError(txt_ex_catch_certific_no, "Please enter catch certificate no");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_certific_no, "");
            if (string.IsNullOrWhiteSpace(txt_ex_catch_boat_reg_no.Text))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_boat_reg_no, 4);
                erro_pro_catch.SetError(txt_ex_catch_boat_reg_no, "Please enter boat registration no");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_boat_reg_no, "");
            if (!int.TryParse(txt_ex_catch_qty.Text, out t))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_qty, 4);
                erro_pro_catch.SetError(txt_ex_catch_qty, "Please enter catch qty");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_qty, "");
            if (!string.IsNullOrWhiteSpace(txt_ex_catch_certific_no.Text) && !string.IsNullOrWhiteSpace(txt_ex_catch_boat_reg_no.Text) && int.TryParse(txt_ex_catch_qty.Text, out t) )
            {
                string com = "Insert into Catch_Export_SCS Values('" + txt_ex_catch_certific_no.Text + "', '" + txt_ex_catch_boat_reg_no.Text + "','" + txt_ex_helthno.Text + "','" + txt_ex_catch_qty.Text + "')";
                db.Save_Del_Update(com);

                MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }




        /// <summary>
        /// /Codes for elements.....................
        /// </summary>



        private void Enterdata_Load(object sender, EventArgs e)
        {
            cmddat_loaddef();

            cmb_ex_eutype.SelectedItem = "Please select value";
            cmb_ex_typ_of_process.SelectedItem = "Please select value";
            cmb_ex_typ_of_product.SelectedItem = "Please select value";
            cmb_ex_reg_of_organ.SelectedItem = "Please select value";
            cmb_ex_catch_typ.SelectedItem = "Please select value";
            cmb_ex_catch_gear_type.SelectedItem = "Please select value";
            cmb_ex_reg_of_organ.SelectedItem = "Please select value";
            cmb_ex_health_species.SelectedItem = "Please select value";
            cmb_ex_catch_method_of_verify.SelectedItem = "Please select value";
            cmb_ex_catch_catchspices.SelectedItem = "Please select value";
            cmb_ex_catch_arival_port.SelectedItem = "Please select value";

        }

        //exit message
        private void Enterdata_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you want to exit?", "Exit Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        //back button
        private void mtile_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        //add button
        private void btn_ex_health_add_Health_Click(object sender, EventArgs e)
        {
            btn_ex_health_add_Health_dataenter();
        }

        //check eu type
        private void cmb_ex_eutype_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbty_load();
        }


        //button for change element colours when select scs or Rcs(for easy identify)
        private void cmb_ex_catch_typ_SelectedIndexChanged(object sender, EventArgs e)
        {
            coluchange();
        }
        

        //add data button click
        private void btn_ex_health_adddatahealth_Click(object sender, EventArgs e)
        {
            btn_ex_health_adddatahealth_enterdata();
        }

        //code for clear button
        private void btn_ex_health_newreport_Click(object sender, EventArgs e)
        {

            resetfields();
            dtp_ex_health_dateofship.Value = DateTime.Today;
            dtp_ex_catch_arivdate.Value = DateTime.Today;
            vari_btn_ex_health_adddatahealth_clicked = false;

        }

        //code for add button catch
        private void btn_ex_catch_add_Click(object sender, EventArgs e)
        {
            if(cmb_ex_catch_typ.SelectedIndex == 0)
            {
                erro_pro_catch.Clear();
                catch_cetif_check();
            }
            if(cmb_ex_catch_typ.SelectedIndex == 1)
            {
                erro_pro_catch.Clear();
                btn_ex_catch_add_enterdata_SCS();
            }
            if(cmb_ex_catch_typ.SelectedIndex == 2)
            {
                erro_pro_catch.Clear();
                btn_ex_catch_add_enterdata_RCS();
            }
        }

        private void btn_ex_catch_search_Click(object sender, EventArgs e)
        {
            
        }
    }
}