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
        float vari_ex_health_qty = 0;
        Boolean vari_btn_ex_health_adddatahealth_clicked;
        Boolean vari_btn_im_health_adddatahealth_clicked;
        public string username_enterdata;

        /// <summary>
        /// /Codes for export tab methods.....................
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

            db.load_cmb("SELECT region_organ FROM [Export Details] WHERE (region_organ  IS NOT NULL) And (region_organ != '"+""+"')");
            while (db.dr.Read())
            {
                cmb_ex_reg_of_organ.Items.Add(db.dr[0]);

            }
            db.cmddis();
            db.closeCon();

            db.load_cmb("SELECT arival_port FROM [Export Details] WHERE (arival_port IS NOT NULL) And (arival_port != '" + "" + "')");
            while (db.dr.Read())
            {
                cmb_ex_catch_arival_port.Items.Add(db.dr[0]);

            }
            db.cmddis();
            db.closeCon();

            db.load_cmb("SELECT species FROM [Export Details] WHERE (species IS NOT NULL) And (species != '" + "" + "')");
            while (db.dr.Read())
            {
                cmb_ex_health_species.Items.Add(db.dr[0]);

            }
            db.cmddis();
            db.closeCon();

            db.load_cmb("SELECT species FROM [Export Details] WHERE (species IS NOT NULL) And (species != '" + "" + "')");
            while (db.dr.Read())
            {
                cmb_ex_catch_catchspices.Items.Add(db.dr[0]);

            }
            db.cmddis();
            db.closeCon();

            db.load_cmb("SELECT arival_port FROM [Export Details] WHERE (arival_port IS NOT NULL) And (arival_port != '" + "" + "')");
            while (db.dr.Read())
            {
                cmb_ex_catch_arival_port.Items.Add(db.dr[0]);
            }
            db.cmddis();
            db.closeCon();

            db.load_cmb("SELECT methodof_verifi FROM [Export Details] WHERE (methodof_verifi IS NOT NULL) And (methodof_verifi != '" + "" + "')");
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
                groupbox_catchcertifidata.Enabled = true;
                cmb_ex_company_name.Items.Clear();
                cmb_ex_company_name.Items.Add("Please select value");
                cmb_ex_company_name.SelectedIndex = 0;
                cmb_ex_country_name.Items.Clear();
                cmb_ex_country_name.Items.Add("Please select value");
                cmb_ex_country_name.SelectedIndex = 0;
            }


            if (cmb_ex_eutype.SelectedIndex == 1)
            {
                groupbox_catchcertifidata.Enabled = true;
                cmb_ex_company_name.Items.Clear();
                cmb_ex_country_name.Items.Clear();

                db.load_cmb("SELECT catch_process_estab_eu FROM [Export Details] WHERE (catch_process_estab_eu  IS NOT NULL) And (catch_process_estab_eu != '" + "" + "')");
                while (db.dr.Read())
                {
                    cmb_ex_company_name.Items.Add(db.dr[0]);
                }
                db.cmddis();
                db.closeCon();

                db.load_cmb("SELECT country_eu FROM [Export Details] WHERE (country_eu IS NOT NULL) And (country_eu != '" + "" + "')");
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
                groupbox_catchcertifidata.Enabled = false;

                cmb_ex_company_name.Items.Clear();
                cmb_ex_company_name.SelectedValue = 0;
                db.load_cmb("SELECT catch_process_establish_non_eu FROM [Export Details] WHERE (catch_process_establish_non_eu  IS NOT NULL) And (catch_process_establish_non_eu != '" + "" + "')");
                while (db.dr.Read())
                {
                    cmb_ex_company_name.Items.Add(db.dr[0]);
                }
                db.cmddis();
                db.closeCon();

                cmb_ex_country_name.Items.Clear();
                cmb_ex_country_name.SelectedValue = 0;
                db.load_cmb("SELECT country_non_eu FROM [Export Details] WHERE (country_non_eu IS NOT NULL) And (country_non_eu != '" + "" + "')");
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

        //update
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
                btn_ex_catch_add.Theme = MetroFramework.MetroThemeStyle.Dark;


            }
            //updated
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
                //txt_ex_catch_log_book_qty.Enabled = true;
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
        //updated
        public void btn_ex_health_add_Health_dataenter()
        {
            float i, corqty;

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
            if (!float.TryParse(txt_ex_qty_mqty.Text, out i))
            {
                erro_pro_healt.SetIconPadding(txt_ex_qty_mqty, 4);
                erro_pro_healt.SetError(txt_ex_qty_mqty, "Please only enter numbers");
            }
            else
                erro_pro_healt.SetError(txt_ex_qty_mqty, "");
            if (vari_btn_ex_health_adddatahealth_clicked == true && float.TryParse(txt_ex_qty_mqty.Text, out corqty) && !string.IsNullOrWhiteSpace(txt_ex_helthno.Text) && cmb_ex_typ_of_process.SelectedIndex != 0 && cmb_ex_typ_of_product.SelectedIndex != 0 && cmb_ex_reg_of_organ.SelectedIndex != 0 && cmb_ex_health_species.SelectedIndex != 0)
            {
                

                string com = "Insert into Health_certi_spic_details(Health_certi_no,Health_spices,Health_spi_qty,typ_of_process,typ_of_product,reg_of_organ) Values('" + txt_ex_helthno.Text + "', '" + cmb_ex_health_species.SelectedItem + "','" + Convert.ToDouble(txt_ex_qty_mqty.Text) + "','" + cmb_ex_typ_of_process.SelectedItem + "','" + cmb_ex_typ_of_product.SelectedItem + "','" + cmb_ex_reg_of_organ.SelectedItem + "')";
                try
                {
                    int j = db.Save_Del_Update(com);
                    if (j == 1)
                    {
                        MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vari_ex_health_qty = vari_ex_health_qty + corqty;
                        txt_ex_health_totqty.Text = vari_ex_health_qty.ToString();

                        cmb_ex_typ_of_process.SelectedIndex = 0;
                        cmb_ex_typ_of_product.SelectedIndex = 0;
                        cmb_ex_reg_of_organ.SelectedIndex = 0;
                        cmb_ex_health_species.SelectedIndex = 0;
                        txt_ex_qty_mqty.Text = "0";
                    }
                    else
                        MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.closeCon();
                }
                catch(Exception)
                {
                    MessageBox.Show("Cannot enter duplicate items","Error!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
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
                string com = "Insert into Health_Export_main Values('" + txt_ex_helthno.Text + "', '" + cmb_ex_company_name.SelectedItem + "','" + cmb_ex_country_name.SelectedItem + "','" + dtp_ex_health_dateofship.Value.ToString() + "','"+username_enterdata+"','"+"Export"+"')";
                try
                {
                    int i = db.Save_Del_Update(com);
                    if (i == 1)
                        MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.closeCon();

                    txt_ex_helthno.Enabled = false;
                    cmb_ex_eutype.Enabled = false;
                    cmb_ex_company_name.Enabled = false;
                    cmb_ex_country_name.Enabled = false;
                    dtp_ex_health_dateofship.Enabled = false;
                    btn_ex_health_adddatahealth.Enabled = false;

                    vari_btn_ex_health_adddatahealth_clicked = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //MessageBox.Show("Cannot enter duplicate items", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        public void resetfields()
        {
            erro_pro.Clear();
            erro_pro_catch.Clear();
            erro_pro_healt.Clear();

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
            float i, k, t;

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
            if (!float.TryParse(txt_ex_catch_qty.Text, out t))
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
            if (!float.TryParse(txt_ex_catch_log_book_pno.Text, out i))
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
            if(!float.TryParse(txt_ex_catch_log_book_qty.Text,out k))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_log_book_qty, 4);
                erro_pro_catch.SetError(txt_ex_catch_log_book_qty, "Please get log book qty");
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

        //updated
        public void btn_ex_catch_add_enterdata_RCS()
        {
            float i, k;
            int y;
            

            catch_cetif_check();

            if(!float.TryParse(txt_ex_catch_log_book_qty.Text,out k) && !float.TryParse(txt_ex_catch_remaqty.Text,out i))
            {
                MessageBox.Show("Please get log book data first","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (vari_btn_ex_health_adddatahealth_clicked == true && cmb_ex_catch_typ.SelectedIndex != 0 && !string.IsNullOrWhiteSpace(txt_ex_catch_certific_no.Text) && !string.IsNullOrWhiteSpace(txt_ex_catch_boat_reg_no.Text) && !string.IsNullOrWhiteSpace(txt_ex_catch_fishing_olicence.Text) && cmb_ex_catch_method_of_verify.SelectedIndex != 0 && cmb_ex_catch_catchspices.SelectedIndex != 0 && !string.IsNullOrWhiteSpace(txt_ex_catch_log_book_no.Text) && int.TryParse(txt_ex_catch_log_book_pno.Text, out y) && cmb_ex_catch_arival_port.SelectedIndex != 0 && float.TryParse(txt_ex_catch_log_book_qty.Text, out k) && cmb_ex_catch_gear_type.SelectedIndex != 0 && float.TryParse(txt_ex_catch_qty.Text, out k))
            {
                double totqty = Convert.ToDouble(txt_ex_catch_remaqty.Text);
                double spqty = Convert.ToDouble(txt_ex_catch_qty.Text);
                double reqty = totqty - spqty;

                string logbokqty = txt_ex_catch_log_book_qty.Text;
                string logbokno = txt_ex_catch_log_book_no.Text;
                string logbokpagno = txt_ex_catch_log_book_pno.Text;

                if (reqty > 0)
                {
                    string logcon = "UPDATE Export_catch_logbook_detailsRCS SET Log_qty = '" + logbokqty + "', Log_book_no = '" + logbokno + "', Log_book_pageno = '" + logbokpagno + "', remaing_qty = '" + reqty.ToString() + "' WHERE Log_book_no = '" + txt_ex_catch_log_book_no.Text + "' AND Log_book_pageno = '" + txt_ex_catch_log_book_pno.Text + "'";
                    int l = db.Save_Del_Update(logcon);
                    db.closeCon();
                    
                    try
                    {
                        string con = "INSERT INTO Catch_Export_RCS VALUES ('" + txt_ex_catch_certific_no.Text + "','" + txt_ex_helthno.Text + "','" + txt_ex_catch_boat_reg_no.Text + "','" + txt_ex_catch_fishing_olicence.Text + "','" + cmb_ex_catch_method_of_verify.SelectedItem + "','" + cmb_ex_catch_catchspices.SelectedItem + "','" + dtp_ex_catch_arivdate.Value.ToString() + "','" + cmb_ex_catch_arival_port.SelectedItem + "','" + cmb_ex_catch_gear_type.SelectedItem + "','" + txt_ex_catch_remark.Text + "','" + txt_ex_catch_qty.Text + "','"+ logbokno + "','"+ logbokpagno + "')";
                        int o = db.Save_Del_Update(con);

                        if (l == 1 && o == 1)
                        {
                            MessageBox.Show("Data Insert Success", "Sucessfull!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_ex_catch_remaqty.Text = reqty.ToString();
                        }
                        db.closeCon();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot enter duplicate items", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                if(reqty <= 0)
                    MessageBox.Show("Log book qty exceeded!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btn_ex_catch_add_enterdata_SCS()
        {
            float t;

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
            if (!float.TryParse(txt_ex_catch_qty.Text, out t))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_qty, 4);
                erro_pro_catch.SetError(txt_ex_catch_qty, "Please enter catch qty");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_qty, "");
            
            //updated
            if (!string.IsNullOrWhiteSpace(txt_ex_catch_certific_no.Text) && !string.IsNullOrWhiteSpace(txt_ex_catch_boat_reg_no.Text) && float.TryParse(txt_ex_catch_qty.Text, out t))
            {
                try
                {
                    string com = "Insert into Catch_Export_SCS Values('" + txt_ex_catch_certific_no.Text + "', '" + txt_ex_catch_boat_reg_no.Text + "','" + txt_ex_helthno.Text + "','" + txt_ex_catch_qty.Text + "')";
                    int i = db.Save_Del_Update(com);
                    if (i == 1)
                        MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.closeCon();
                }
                catch(Exception)
                {
                    MessageBox.Show("Cannot enter duplicate items", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        //updated
        public void searchbtn()
        {
            int n;
            if (string.IsNullOrWhiteSpace(txt_ex_catch_log_book_no.Text))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_log_book_no, 4);
                erro_pro_catch.SetError(txt_ex_catch_log_book_no, "Please enter Log Book no no");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_log_book_no, "");
            if (!int.TryParse(txt_ex_catch_log_book_pno.Text, out n))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_log_book_pno, 4);
                erro_pro_catch.SetError(txt_ex_catch_log_book_pno, "Please enter Log Book page no");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_log_book_pno, "");
            if (!string.IsNullOrWhiteSpace(txt_ex_catch_log_book_no.Text) && int.TryParse(txt_ex_catch_log_book_pno.Text, out n))
            {
                string con = "SELECT* FROM Export_catch_logbook_detailsRCS WHERE  Log_book_no = '" + txt_ex_catch_log_book_no.Text + "' AND Log_book_pageno = '" + txt_ex_catch_log_book_pno.Text + "'";
                db.scsqty(con);
                if (db.resbol == false)
                {
                    txt_ex_catch_log_book_qty.Text = "0";
                    txt_ex_catch_remaqty.Text = "NO DATA";
                    MessageBox.Show("No Log book pages found!!! Add new record", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_ex_catch_addnewrecord.Enabled = true;
                    txt_ex_catch_log_book_qty.Enabled = true;
                }
                if (db.resbol == true)
                {                    
                    txt_ex_catch_log_book_qty.Text = db.logqty.ToString();
                    txt_ex_catch_remaqty.Text = db.reqty.ToString();
                }
                db.closeCon();
            }

        }

        //updated
        public void addnewrecord()
        {
            int n;
            float m;
            if (string.IsNullOrWhiteSpace(txt_ex_catch_log_book_no.Text))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_log_book_no, 4);
                erro_pro_catch.SetError(txt_ex_catch_log_book_no, "Please enter Log Book no");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_log_book_no, "");
            if (!int.TryParse(txt_ex_catch_log_book_pno.Text, out n))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_log_book_pno, 4);
                erro_pro_catch.SetError(txt_ex_catch_log_book_pno, "Please enter Log Book page no");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_log_book_pno, "");
            if (!float.TryParse(txt_ex_catch_log_book_qty.Text, out m))
            {
                erro_pro_catch.SetIconPadding(txt_ex_catch_log_book_qty, 4);
                erro_pro_catch.SetError(txt_ex_catch_log_book_qty, "Please enter Log Book Qty");
            }
            else
                erro_pro_catch.SetError(txt_ex_catch_log_book_qty, "");
            if (int.TryParse(txt_ex_catch_log_book_pno.Text, out n) && float.TryParse(txt_ex_catch_log_book_qty.Text, out m))
            {
                try
                {
                    string com = "Insert into Export_catch_logbook_detailsRCS Values('" +Convert.ToDouble(txt_ex_catch_log_book_qty.Text)+ "','" + txt_ex_catch_log_book_no.Text + "', '" + txt_ex_catch_log_book_pno.Text + "','" + Convert.ToDouble(txt_ex_catch_log_book_qty.Text) + "')";
                    int i = db.Save_Del_Update(com);
                    if (i == 1)
                    {
                        MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_ex_catch_remaqty.Text = txt_ex_catch_log_book_qty.Text;
                        btn_ex_catch_addnewrecord.Enabled = false;
                        txt_ex_catch_log_book_qty.Enabled = false;
                    }

                    else
                        MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.closeCon();
                }
                catch(Exception ex)
                {
                    
                    MessageBox.Show("Cannot enter duplicate items", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       





        /// <summary>
        /// /Codes for export tab elements.....................
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
            if (cmb_ex_catch_typ.SelectedIndex == 0)
            {
                erro_pro_catch.Clear();
                catch_cetif_check();
            }
            if (cmb_ex_catch_typ.SelectedIndex == 1)
            {
                erro_pro_catch.Clear();
                btn_ex_catch_add_enterdata_SCS();
            }
            if (cmb_ex_catch_typ.SelectedIndex == 2)
            {
                erro_pro_catch.Clear();
                btn_ex_catch_add_enterdata_RCS();
            }
        }

        //updated
        private void btn_ex_catch_search_Click(object sender, EventArgs e)
        {
            searchbtn();
        }

        private void btn_ex_catch_addnewrecord_Click(object sender, EventArgs e)
        {
            addnewrecord();
        }




        /// <summary>
        ///                        Import data*********************
        /// </summary>



        /// <summary>
        ///                        methods for import tab *******************
        /// </summary>

        private void btn_im_health_adddatatomain()
        {
            if (string.IsNullOrWhiteSpace(txt_im_helthno.Text))
            {
                erro_pro.SetIconPadding(txt_im_helthno, 4);
                erro_pro.SetError(txt_im_helthno, "Enter Health certificate no");
            }
            else
                erro_pro.SetError(txt_im_helthno, "");
            if (cmb_im_company_name.SelectedIndex == 0)
            {
                erro_pro.SetIconPadding(cmb_im_company_name, 4);
                erro_pro.SetError(cmb_im_company_name, "Please select company name");
            }
            else
                erro_pro.SetError(cmb_im_company_name, "");
            if (cmb_im_country_name.SelectedIndex == 0)
            {
                erro_pro.SetIconPadding(cmb_im_country_name, 4);
                erro_pro.SetError(cmb_im_country_name, "Please select country name");
            }
            else
                erro_pro.SetError(cmb_im_country_name, "");
            if (!string.IsNullOrWhiteSpace(txt_im_helthno.Text) && cmb_im_company_name.SelectedIndex != 0 && cmb_im_country_name.SelectedIndex != 0)
            {
                string com = "Insert into Health_Export_main Values('" + txt_im_helthno.Text + "', '" + cmb_im_company_name.SelectedItem + "','" + cmb_im_country_name.SelectedItem + "','" + dtp_im_health_dateofship.Value.ToString() + "','" + username_enterdata + "','" + "Import" + "')";
                try
                {
                    int i = db.Save_Del_Update(com);
                    if (i == 1)
                        MessageBox.Show("Data Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.closeCon();

                    txt_im_helthno.Enabled = false;
                    cmb_im_company_name.Enabled = false;
                    cmb_im_country_name.Enabled = false;
                    dtp_im_health_dateofship.Enabled = false;
                    btn_im_health_adddatahealth.Enabled = false;

                    vari_btn_im_health_adddatahealth_clicked = true;
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.Message);
                    MessageBox.Show("Cannot enter duplicate items", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        /// <summary>
        ///                       codes for import tab Controlers*******************
        /// </summary>


        private void btn_im_health_adddatahealth_Click(object sender, EventArgs e)
        {
            btn_im_health_adddatatomain();
        }
    }
}