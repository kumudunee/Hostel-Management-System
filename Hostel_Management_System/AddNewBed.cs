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
    public partial class AddNewBed : Form
    {
        function fn = new function();
        String query;
        public AddNewBed()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewBed_Load(object sender, EventArgs e)
        {
            this.Location = new Point(530, 230);
            labelBed.Visible = false;
            labelBedExist.Visible = false;

            query = "select * from beds";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddBed_Click(object sender, EventArgs e)
        {
            query = "select * from beds where bedNo="+txtBedNo1.Text+"";
            DataSet ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count == 0)
            {
                String status;

                if(checkBox1.Checked)
                    {
                        status = "Yes";
                    }
                else
                {
                    status = "No";
                }
                labelBedExist.Visible = false;
                query = "insert into beds (bedNo,bedStatus) values("+txtBedNo1.Text+",'"+status+"')";
                fn.setData(query,"Added");
                AddNewBed_Load(this, null);
            }
            else
            {
                labelBedExist.Text = "Bed Already Exist.";
                labelBedExist.Visible = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from beds where bedNo=" + txtBedNo2.Text + "";
            DataSet ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count==0)
            {
                labelBed.Text = "No Bed Exist.";
                labelBed.Visible = true;
                checkBox2.Checked = false;
            }
            else
            {
                labelBed.Text = "Bed Found.";
                labelBed.Visible = true;
                if (ds.Tables[0].Rows[0][1].ToString() == "Yes")
                {
                    checkBox2.Checked = true;

                }
                else
                {
                    checkBox2.Checked = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String status;
            if(checkBox2.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            query = "update beds set bedStatus='" + status + "' where bedNo = "+txtBedNo2.Text+"";
            fn.setData(query,"Details Updated.");
            AddNewBed_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(labelBed.Text== "Bed Found.")
            {
                query = "delete from beds where bedNo="+txtBedNo2.Text+"";
                fn.setData(query, "Details Deleted");
                AddNewBed_Load(this, null);
            }
            else
            {
                MessageBox.Show("Trying to delete which doesn't Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
