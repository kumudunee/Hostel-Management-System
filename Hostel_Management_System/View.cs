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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"data source = .; database = HostelManagementSystem; integrated security = True");
        private void fetchData()
        {
            con.Open();
            String query = "select * from newMember where mobile ="+txtMobile.Text+"";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                labelMobile.Text = dr["mobile"].ToString();
                labelName.Text = dr["name"].ToString();
                labelGender.Text = dr["gender"].ToString();
                labelGuardian.Text = dr["guardian"].ToString();
                labelPerAdd.Text = dr["permanentAdd"].ToString();
                labelId.Text = dr["idProof"].ToString();
                labelDate.Text = dr["date"].ToString();
                labelBed.Text = dr["bedNo"].ToString();
                labelProvince.Text = dr["province"].ToString();
                labelDistrict.Text = dr["district"].ToString();
                labelDivision.Text = dr["division"].ToString();
                labelGrama.Text = dr["grama"].ToString();
                labelNext.Text = dr["nextOfKin"].ToString();
                labelNextMobile.Text = dr["nextMobile"].ToString();
                
                labelAddress.Text = dr["nextAdd"].ToString();
                labelMedical.Text = dr["medical"].ToString();


                labelMobile.Visible = true;
                labelName.Visible = true;
                labelGender.Visible = true;
                labelGuardian.Visible = true;
                labelPerAdd.Visible = true;
                labelId.Visible = true;
                labelDate.Visible = true;
                labelBed.Visible = true;
                labelProvince.Visible = true;
                labelDistrict.Visible = true;
                labelDivision.Visible = true;
                labelGrama.Visible = true;
                labelNext.Visible = true;
                labelNextMobile.Visible = true;

                labelAddress.Visible = true;
                labelMedical.Visible = true;
            }
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void View_Load(object sender, EventArgs e)
        {
            this.Location = new Point(473, 175);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fetchData();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("====DUMBARA MICRO CREDIT====", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(150));
            e.Graphics.DrawString("Mobile No: "+labelMobile.Text+"\nName: "+labelName.Text+"\nGender: "+labelGender.Text+"\nGuardian: "+labelGuardian.Text+"\nAddress: "+labelPerAdd.Text+"ID: "+labelId.Text+"\nDate: "+labelDate.Text+"\nBed No: "+labelBed.Text+"\nProvince: "+labelProvince.Text+"\nDistrict: "+labelDistrict.Text+"\nDivision: "+labelDivision.Text+"\nGrama Niladhari Division: "+labelGrama.Text+"\n\nNext Of Kin: "+labelNext.Text+"\nMobile No: "+labelNextMobile.Text+"\nAddress: "+labelAddress.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(80, 100));

        }
    }
}
