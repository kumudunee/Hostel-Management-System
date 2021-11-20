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
    public partial class updateAndDeleteEmployee : Form
    {
        function fn = new function();
        String query;
        public updateAndDeleteEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateAndDeleteEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(530, 230);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from newEmployee where emobile="+txtMobile.Text+" " ;
            DataSet ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtGender.Text = ds.Tables[0].Rows[0][3].ToString();
                txtPermanentAdd.Text = ds.Tables[0].Rows[0][4].ToString();
                txtId.Text = ds.Tables[0].Rows[0][5].ToString();
                txtDate.Text = ds.Tables[0].Rows[0][6].ToString();
                txtWorking.Text = ds.Tables[0].Rows[0][7].ToString();
            }
            else
            {
                MessageBox.Show("No Record Exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String name = txtName.Text;
            String gender = txtGender.Text;
            String address = txtPermanentAdd.Text;
            String id = txtId.Text;
            String date = txtDate.Text;
            String working = txtWorking.Text;

            query = "update newEmployee set  ename='"+name+ "',egender='"+gender+"',ePermanentAdd='"+address+ "',eIdProof='"+id+ "',edate='"+date+ "',working='"+working+"' where emobile = "+mobile+"";
            fn.setData(query, "Data Updated.");
            clearAll();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                query = "delete from newEmployee where emobile="+txtMobile.Text+"";
                fn.setData(query, "Employee Record Deleted.");
                clearAll();
            }
        }
        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtGender.SelectedIndex = -1;
            txtPermanentAdd.Clear();
            txtId.Clear();
            txtWorking.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
