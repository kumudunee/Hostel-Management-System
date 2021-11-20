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
    public partial class employeeFees : Form
    {
        function fn = new function();
        String query;
        public employeeFees()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeeFees_Load(object sender, EventArgs e)
        {
            this.Location = new Point(530, 200);
            txtDate.Format = DateTimePickerFormat.Custom;
            txtDate.CustomFormat = "MMMM yyyy";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtMobile.Text != "")
            {
                query = "select ename,egender,ePermanentAdd,eIdProof,edate from newEmployee where emobile="+txtMobile.Text+" ";
                DataSet ds = fn.getData(query);

                if(ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtId.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtPermanentAdd.Text = ds.Tables[0].Rows[0][2].ToString();
                    setDataGrid(Int64.Parse(txtMobile.Text));
                }
                else
                {
                    MessageBox.Show("No Record Exit.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Enter Some Data.","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }
        public void setDataGrid(Int64 mobile)
        {
            query = "select * from employeeSalary where mobileNo="+txtMobile.Text+" ";
            DataSet ds2 = fn.getData(query);
            guna2DataGridView1.DataSource = ds2.Tables[0];

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(txtMobile.Text !="" && txtPermanentAdd.Text !="")
            {
                query = "select * from employeeSalary where mobileNo ="+txtMobile.Text+" and fmonth ='"+txtDate.Text+"' ";
                DataSet ds = fn.getData(query);

                if(ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(txtMobile.Text);
                    String month = txtDate.Text;
                    Int64 amount = Int64.Parse(txtPay.Text);

                    query = "insert into employeeSalary values ("+mobile+",'"+month+"',"+amount+")";
                    fn.setData(query, "Salary for month " +txtDate.Text+" paid.");
                }
                else
                {
                    MessageBox.Show("Payment of " + txtPay.Text + " Done. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtPermanentAdd.Clear();
            txtId.Clear();
            txtPay.Clear();
            guna2DataGridView1.DataSource = 0;

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
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
            e.Graphics.DrawString("Mobile No: " + txtMobile.Text + "\nName: " + txtName.Text + "\nPermanent Address: " + txtPermanentAdd.Text + "\nID: " + txtId.Text + "\nMonth: " + txtDate.Text + "\n Payment Amount: " + txtPay.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(80, 180));
        }
    }
}
