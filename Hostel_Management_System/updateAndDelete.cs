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

namespace Hostel_Management_System
{
    public partial class updateAndDelete : Form
    {
        SqlConnection con = new SqlConnection(@"data source = .; database = HostelManagementSystem; integrated security = True");
        int provinceid, districtid, divisionid;
        function fn = new function();
        String query;
        public updateAndDelete()
        {
            InitializeComponent();
            refreshprovince();
        }
        public void refreshprovince()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from province", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            comboProvince.DisplayMember = "provincename";
            comboProvince.ValueMember = "provinceid";
            comboProvince.DataSource = dt;

        }

        private void comboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProvince.SelectedValue.ToString() != null)
            {
                provinceid = Convert.ToInt32(comboProvince.SelectedValue.ToString());
                refreshdistrict(provinceid);
            }
        }
        private void refreshdistrict(int provinceid)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from district where proId=@provinceid", con);
            cmd.Parameters.AddWithValue("provinceid", provinceid);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            comboDistrict.DisplayMember = "districtname";
            comboDistrict.ValueMember = "districtid";
            comboDistrict.DataSource = dt;
        }

        private void comboDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDistrict.SelectedValue.ToString() != null)
            {
                districtid = Convert.ToInt32(comboDistrict.SelectedValue.ToString());
                refreshDivision(districtid);
            }
        }
        private void refreshDivision(int districtid)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from division where disId=@districtid", con);
            cmd.Parameters.AddWithValue("districtid", districtid);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            comboDivision.DisplayMember = "divisionname";
            comboDivision.ValueMember = "divisionid";
            comboDivision.DataSource = dt;
        }

        private void comboDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDivision.SelectedValue.ToString() != null)
            {
                divisionid = Convert.ToInt32(comboDivision.SelectedValue.ToString());
                refreshGrama(divisionid);
            }
        }
        private void refreshGrama(int divisionid)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from grama where divId=@divisionid", con);
            cmd.Parameters.AddWithValue("divisionid", divisionid);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            comboGrama.DisplayMember = "gramaname";
            comboGrama.ValueMember = "gramaid";
            comboGrama.DataSource = dt;
        }
        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtGender.SelectedIndex = -1;
            txtGuardian.Clear();
            txtPermanentAdd.Clear();
            txtId.Clear();
            txtBed.Clear();
            //comboProvince.SelectedIndex = -1;
            //comboDistrict.SelectedIndex = -1;
            //comboDivision.SelectedIndex = -1;
            //comboGrama.SelectedIndex = -1;
            //txtCompanyName.Clear();
            //txtCompanyAdd.Clear();
            txtLiving.SelectedIndex = -1;
            txtNextOfKin.Clear();
            txtNextMobile.Clear();
            txtNextAdd.Clear();
            txtMedical.Clear();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from newMember where mobile="+txtMobile.Text+"";
            DataSet ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtGender.Text = ds.Tables[0].Rows[0][3].ToString();
                txtGuardian.Text = ds.Tables[0].Rows[0][4].ToString();
                txtPermanentAdd.Text = ds.Tables[0].Rows[0][5].ToString();
                txtId.Text = ds.Tables[0].Rows[0][6].ToString();
                txtDate.Text = ds.Tables[0].Rows[0][7].ToString();
                txtBed.Text = ds.Tables[0].Rows[0][8].ToString();
                comboProvince.Text = ds.Tables[0].Rows[0][9].ToString();
                comboDistrict.Text = ds.Tables[0].Rows[0][10].ToString();
                comboDivision.Text = ds.Tables[0].Rows[0][11].ToString();
                comboGrama.Text = ds.Tables[0].Rows[0][12].ToString();
                txtLiving.Text = ds.Tables[0].Rows[0][17].ToString();
                txtNextOfKin.Text = ds.Tables[0].Rows[0][13].ToString();
                txtNextMobile.Text = ds.Tables[0].Rows[0][14].ToString();
                txtNextAdd.Text = ds.Tables[0].Rows[0][15].ToString();
                txtMedical.Text = ds.Tables[0].Rows[0][16].ToString();
            }
            else
            {
                clearAll();
                MessageBox.Show("No Record with this Mobile Number.", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String name = txtName.Text;
            String gender = txtGender.Text;
            String guardian = txtGuardian.Text;
            String permanetAdd = txtPermanentAdd.Text;
            String idProof = txtId.Text;
            String date = txtDate.Text;
            String bedNo = txtBed.Text;
            String province = comboProvince.Text;
            String district = comboDistrict.Text;
            String division = comboDivision.Text;
            String grama = comboGrama.Text;
            String living = txtLiving.Text;
            String nextOfSkin = txtNextOfKin.Text;
            String mobileNo = txtNextMobile.Text;
            String address = txtNextAdd.Text;
            String medical = txtMedical.Text;

            query = "update newMember set mobile = "+mobile+", name ='"+name+ "', gender ='"+gender+ "',guardian ='"+guardian+ "',permanentAdd ='"+permanetAdd+ "',idProof ='"+idProof+ "',date ='"+date+ "',bedNo ="+bedNo+ ",province ='"+province+ "',district ='"+district+ "',division ='"+division+ "',grama ='"+grama+ "',living ='"+living+"',nextOfKin ='" + nextOfSkin+ "',nextMobile ="+mobileNo+ ",nextAdd ='"+address+ "',medical ='"+medical+"' where mobile = "+mobile+" update beds set Booked ='"+living+"' where bedNo="+bedNo+"";
            fn.setData(query, "Data Successfully Updated.");
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {

                query = "delete from newMember where mobile=" + txtMobile.Text + "";
                fn.setData(query, "Record Deleted.");
                clearAll();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateAndDelete_Load(object sender, EventArgs e)
        {
            this.Location = new Point(230, 78);
        }
    }
}
