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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            newEmployee ne = new newEmployee();
            ne.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Boolean labelVisible = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(labelVisible == true)
            {
                DumbaraLabel.Visible = true;
                labelVisible = false;
            }
            else
            {
                DumbaraLabel.Visible = false;
                labelVisible = true;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void btnManageBeds_Click(object sender, EventArgs e)
        {
            AddNewBed anb = new AddNewBed();
            anb.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            newMember nm = new newMember();
            nm.Show();
        }

        private void btnUpdateDelete_Click(object sender, EventArgs e)
        {
            updateAndDelete uad = new updateAndDelete();
            uad.Show();
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            fees fe = new fees();
            fe.Show();
        }

        private void btnMembersLiving_Click(object sender, EventArgs e)
        {
            membersLiving ml = new membersLiving();
            ml.Show();
        }

        private void btnLeavedMembers_Click(object sender, EventArgs e)
        {
            membersLeaved lm = new membersLeaved();
            lm.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            View v = new View();
            v.Show();
        }

        private void updateDeleteEmployee_Click(object sender, EventArgs e)
        {
            updateAndDeleteEmployee uade = new updateAndDeleteEmployee();
            uade.Show();
        }

        private void txtEmployeePayment_Click(object sender, EventArgs e)
        {
            employeeFees ef = new employeeFees();
            ef.Show();
        }

        private void txtAllEmployeeWorking_Click(object sender, EventArgs e)
        {
            allEmployeeWorking aew = new allEmployeeWorking();
            aew.Show();
        }

        private void btnLeavedEmployee_Click(object sender, EventArgs e)
        {
            leavedEmployee le = new leavedEmployee();
            le.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            users use = new users();
            use.Show();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
