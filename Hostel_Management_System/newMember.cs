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

namespace Hostel_Management_System
{
    public partial class newMember : Form
    {
        SqlConnection con = new SqlConnection(@"data source = .; database = HostelManagementSystem; integrated security = True");
        int provinceid, districtid, divisionid;
        function fn = new function();
        String query;
        public newMember()
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newMember_Load(object sender, EventArgs e)
        {
            this.Location = new Point(230, 78);
            query = "select bedNo from beds where bedStatus = 'Yes' and Booked = 'No'";
            DataSet ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count;i++)
            {
                Int64 bed = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                comboBedNo.Items.Add(bed);
            }
        }

        private void comboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboProvince.SelectedValue.ToString()!=null)
            {
                provinceid =Convert.ToInt32 (comboProvince.SelectedValue.ToString());
                refreshdistrict(provinceid);
            }
        }
        private void refreshdistrict(int provinceid )
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

        private void comboDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDivision.SelectedValue.ToString() != null)
            {
                divisionid = Convert.ToInt32(comboDivision.SelectedValue.ToString());
                refreshGrama(divisionid);
            }
        }

        
        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtGender.SelectedIndex = -1;
            txtGuardian.Clear();
            txtPermanentAdd.Clear();
            txtId.Clear();
            comboBedNo.SelectedIndex = -1;
            //comboProvince.SelectedIndex = -1;
            //comboDistrict.SelectedIndex = -1;
            //comboDivision.SelectedIndex = -1;
            //comboGrama.SelectedIndex = -1;
            //txtCompanyName.Clear();
            //txtCompanyAdd.Clear();
            txtNextOfKin.Clear();
            txtNextMobile.Clear();
            txtNextAdd.Clear();
            txtMedical.Clear();
            
        }

        
            

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtMobile.Text != "")
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                string name = txtName.Text;
                String gender = txtGender.Text;
                String guardian = txtGuardian.Text;
                String permanentAdd = txtPermanentAdd.Text;
                String idProof = txtId.Text;
                String date = txtDate.Text;
                Int64 bedNo = Int64.Parse(comboBedNo.Text);
                String province = comboProvince.Text;
                String district = comboDistrict.Text;
                String division = comboDivision.Text;
                String grama = comboGrama.Text;
                //String companyName = txtCompanyName.Text;
                //String companyAdd = txtCompanyAdd.Text;
                String nextOfKin = txtNextOfKin.Text;
                Int64 nextMobile = Int64.Parse(txtNextMobile.Text);
                String nextAdd = txtNextAdd.Text;
                String medical = txtMedical.Text;

                query = "insert into newMember (mobile, name, gender, guardian, permanentAdd, idProof,date, bedNo, province, district,division, grama,nextOfKin,nextMobile,nextAdd,medical) values (" + mobile + ",'" + name + "','" + gender + "','" + guardian + "','" + permanentAdd + "','" + idProof + "','" + date + "'," + bedNo + ",'" + province + "','" + district + "','" + division + "','" + grama + "','" + nextOfKin + "'," + nextMobile + ",'" + nextAdd + "','" + medical + "') update beds set Booked = 'Yes' where bedNo =" + bedNo + " ";
                fn.setData(query, "Registration Successful.");
                clearAll();
            }
            else
            {
                MessageBox.Show("Enter the Mobile Number.", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clearAll();
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
    }
}
