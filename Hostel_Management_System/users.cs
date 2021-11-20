using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class users : Form
    {
        function fn = new function();
        String query;
        public users()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void users_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500, 200);
            getMaxID();
        }
        public void getMaxID()
        {
            query = "select max(uid) from userReg";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSet.Text = (num + 1).ToString();

            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtMobile.Text != "" && txtGender.Text !="" && txtEmail.Text != "" && txtPass.Text !="")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                //String username = txtUsername.Text;
                String pass = txtPass.Text;

                query = "insert into userReg (uname, mobile, gender, emailId, pass) values('"+name+"',"+mobile+",'"+gender+"','"+email+"','"+pass+"') ";
                fn.setData(query, "User Registered.");

                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("Fill all Fields.", "Warning...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            //txtUsername.Clear();
            txtPass.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                query = "select * from userReg ";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if(tabControl1.SelectedIndex == 2)
            {
                query = "select * from userReg ";
                DataSet ds = fn.getData(query);
                guna2DataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Are You Sure?", "Confirmation...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from userReg where uid=" + txtID.Text + "";
                    fn.setData(query, "Record Deleted.");
                    tabControl1_SelectedIndexChanged(this, null);
                }
            }
        }

        private void users_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
