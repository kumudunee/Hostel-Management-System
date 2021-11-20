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
    public partial class allEmployeeWorking : Form
    {
        function fn = new function();
        String query;
        public allEmployeeWorking()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allEmployeeWorking_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 200);
            query = "select * from newEmployee where working ='Yes'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
