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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            GetData();
        }
        SqlConnection con = new SqlConnection(@"data source = .; database = HostelManagementSystem; integrated security = True");
        private void GetData()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select  Count(*) from beds where Booked='"+"No"+ "' and bedStatus = '"+"Yes"+"'  ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            bedLable.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("select  Count(*) from beds where Booked='" + "Yes" + "'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            userLabel.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select  Count(*) from newEmployee where working='" + "Yes" + "'", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            empLable.Text = dt2.Rows[0][0].ToString();
            con.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Location = new Point(530, 230);
            
        }
    }
}
