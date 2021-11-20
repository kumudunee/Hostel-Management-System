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
    
    public partial class fees : Form
    {
        function fn = new function();
        String query;
        public fees()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fees_Load(object sender, EventArgs e)
        {
            this.Location = new Point(530, 230);
            txtDate.Format = DateTimePickerFormat.Custom;
            txtDate.CustomFormat = "MMMM yyyy";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtMobile.Text != "")
            {
                query = "select name,idProof, bedNo from newMember where mobile = " + txtMobile.Text + "";
                DataSet ds = fn.getData(query);

                if(ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtId.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtBed.Text = ds.Tables[0].Rows[0][2].ToString();
                    setDataGrid(Int64.Parse(txtMobile.Text));
                    
                }
                else
                {
                    MessageBox.Show("No Record Exist","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }

        }
        public void setDataGrid(Int64 mobile)
        {
            query = "select * from fees where mobileNo = " + txtMobile.Text + "";
            DataSet ds2 = fn.getData(query);
            guna2DataGridView1.DataSource = ds2.Tables[0];
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(txtMobile.Text != "" && txtAmount.Text != "")
            {
                query = "select * from fees where mobileNo = "+Int64.Parse(txtMobile.Text)+" and fmonth = '"+txtDate.Text+"'";
                DataSet ds = fn.getData(query);
                if(ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(txtMobile.Text);
                    String month = txtDate.Text;
                    Int64 amount = Int64.Parse(txtAmount.Text);
                    query = "insert into fees values(" + mobile + ",'" + month + "'," + amount + ")";
                    fn.setData(query, "Fees Paid.");
                    clearAll();
                }
                else
                {
                    MessageBox.Show("No Dues of " + txtDate.Text + " Left.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            txtAmount.Clear();
            txtBed.Clear();
            txtId.Clear();
            guna2DataGridView1.DataSource = 0;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("====DUMBARA MICRO CREDIT====", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(150));
            e.Graphics.DrawString("Mobile No: " + txtMobile.Text+"\nName: "+txtName.Text+"\nID: "+txtId.Text+"\nBed No: "+txtBed.Text+"\nMonth: "+txtDate.Text+"\n Due Amount: "+txtAmount.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(80,180));
        }
    }
}
