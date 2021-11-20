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
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        public Form1()
        {
            InitializeComponent();
            Init_Data();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "select emailId, pass from userReg where emailId='"+txtUsername.Text+"'and pass='"+txtPassword.Text+"'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                Save_Data();
                this.Hide();
                Dashboard ds1 = new Dashboard();
                ds1.Show();
            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            forgetPassword fp = new forgetPassword();
            this.Hide();
            fp.Show();
        }
        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName != String.Empty)
            {
                if (Properties.Settings.Default.Remme == "Yes")
                {
                    txtUsername.Text = Properties.Settings.Default.UserName;
                    txtPassword.Text = Properties.Settings.Default.Password;
                    checkRem.Checked = true;
                }
                else
                {
                    txtUsername.Text = Properties.Settings.Default.UserName;
                }
            }
        }
        private void Save_Data()
        {
            if (checkRem.Checked)
            {
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Remme = "Yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remme = "No";
                Properties.Settings.Default.Save();
            }
        }
    }
}
