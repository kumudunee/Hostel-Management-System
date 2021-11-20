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
    public partial class newEmployee : Form
    {
        function fn = new function();
        String query;
        public newEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(530, 230);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtName.Text != "")
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtName.Text;
                String gender = txtGender.Text;
                String perAdd = txtPermanentAdd.Text;
                String id = txtId.Text;
                String date = txtDate.Text;

                query = "insert into newEmployee (emobile,ename ,egender ,ePermanentAdd ,eIdProof ,edate ) values (" + mobile + ",'" + name + "','" + gender + "','" + perAdd + "','" + id + "','" + date + "')";
                fn.setData(query, "Employee Registered.");
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill all Required Feilds.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtGender.SelectedIndex = -1;
            txtPermanentAdd.Clear();
            txtId.Clear();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
