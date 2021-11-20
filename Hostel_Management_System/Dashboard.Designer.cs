namespace Hostel_Management_System
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.DumbaraLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnView = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewMember = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeavedEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.txtAllEmployeeWorking = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeavedMembers = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.updateDeleteEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmployeePayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnFees = new Guna.UI2.WinForms.Guna2Button();
            this.btnMembersLiving = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageBeds = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DumbaraLabel
            // 
            this.DumbaraLabel.AutoSize = true;
            this.DumbaraLabel.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DumbaraLabel.ForeColor = System.Drawing.Color.White;
            this.DumbaraLabel.Location = new System.Drawing.Point(539, 8);
            this.DumbaraLabel.Name = "DumbaraLabel";
            this.DumbaraLabel.Size = new System.Drawing.Size(512, 69);
            this.DumbaraLabel.TabIndex = 1;
            this.DumbaraLabel.Text = "Hostel Management System";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnMin
            // 
            this.btnMin.CheckedState.Parent = this.btnMin;
            this.btnMin.CustomImages.Parent = this.btnMin;
            this.btnMin.FillColor = System.Drawing.Color.Green;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.HoverState.Parent = this.btnMin;
            this.btnMin.Image = global::Hostel_Management_System.Properties.Resources.minimize;
            this.btnMin.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMin.Location = new System.Drawing.Point(1276, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMin.ShadowDecoration.Parent = this.btnMin;
            this.btnMin.Size = new System.Drawing.Size(53, 56);
            this.btnMin.TabIndex = 18;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnView
            // 
            this.btnView.BorderRadius = 19;
            this.btnView.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnView.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnView.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.btnView.CheckedState.Parent = this.btnView;
            this.btnView.CustomImages.Parent = this.btnView;
            this.btnView.FillColor = System.Drawing.Color.Green;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.HoverState.Parent = this.btnView;
            this.btnView.Image = global::Hostel_Management_System.Properties.Resources.search12;
            this.btnView.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnView.ImageSize = new System.Drawing.Size(30, 30);
            this.btnView.Location = new System.Drawing.Point(12, 841);
            this.btnView.Name = "btnView";
            this.btnView.ShadowDecoration.Parent = this.btnView;
            this.btnView.Size = new System.Drawing.Size(229, 40);
            this.btnView.TabIndex = 17;
            this.btnView.Text = "View";
            this.btnView.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 22;
            this.guna2PictureBox1.Image = global::Hostel_Management_System.Properties.Resources.logo_26;
            this.guna2PictureBox1.Location = new System.Drawing.Point(282, 81);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1096, 789);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Green;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = global::Hostel_Management_System.Properties.Resources.close1;
            this.btnExit.ImageSize = new System.Drawing.Size(27, 27);
            this.btnExit.Location = new System.Drawing.Point(1325, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(53, 56);
            this.btnExit.TabIndex = 15;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Green;
            this.btnLogOut.BorderColor = System.Drawing.Color.White;
            this.btnLogOut.BorderRadius = 22;
            this.btnLogOut.BorderThickness = 1;
            this.btnLogOut.CheckedState.Parent = this.btnLogOut;
            this.btnLogOut.CustomImages.Parent = this.btnLogOut;
            this.btnLogOut.FillColor = System.Drawing.Color.Green;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.btnLogOut.HoverState.Parent = this.btnLogOut;
            this.btnLogOut.Image = global::Hostel_Management_System.Properties.Resources.logout2;
            this.btnLogOut.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLogOut.Location = new System.Drawing.Point(1113, 23);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ShadowDecoration.Parent = this.btnLogOut;
            this.btnLogOut.Size = new System.Drawing.Size(157, 45);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnNewMember
            // 
            this.btnNewMember.BorderRadius = 19;
            this.btnNewMember.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNewMember.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNewMember.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.btnNewMember.CheckedState.Parent = this.btnNewMember;
            this.btnNewMember.CustomImages.Parent = this.btnNewMember;
            this.btnNewMember.FillColor = System.Drawing.Color.Green;
            this.btnNewMember.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMember.ForeColor = System.Drawing.Color.White;
            this.btnNewMember.HoverState.Parent = this.btnNewMember;
            this.btnNewMember.Image = global::Hostel_Management_System.Properties.Resources.new_member;
            this.btnNewMember.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewMember.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNewMember.Location = new System.Drawing.Point(12, 163);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.ShadowDecoration.Parent = this.btnNewMember;
            this.btnNewMember.Size = new System.Drawing.Size(229, 40);
            this.btnNewMember.TabIndex = 7;
            this.btnNewMember.Text = "New Member";
            this.btnNewMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 19;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Green;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Hostel_Management_System.Properties.Resources.home;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(12, 37);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(157, 40);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Dashboard";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnLeavedEmployee
            // 
            this.btnLeavedEmployee.BorderRadius = 19;
            this.btnLeavedEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLeavedEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLeavedEmployee.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.btnLeavedEmployee.CheckedState.Parent = this.btnLeavedEmployee;
            this.btnLeavedEmployee.CustomImages.Parent = this.btnLeavedEmployee;
            this.btnLeavedEmployee.FillColor = System.Drawing.Color.Green;
            this.btnLeavedEmployee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeavedEmployee.ForeColor = System.Drawing.Color.White;
            this.btnLeavedEmployee.HoverState.Parent = this.btnLeavedEmployee;
            this.btnLeavedEmployee.Image = global::Hostel_Management_System.Properties.Resources.check_out1;
            this.btnLeavedEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLeavedEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLeavedEmployee.Location = new System.Drawing.Point(12, 722);
            this.btnLeavedEmployee.Name = "btnLeavedEmployee";
            this.btnLeavedEmployee.ShadowDecoration.Parent = this.btnLeavedEmployee;
            this.btnLeavedEmployee.Size = new System.Drawing.Size(229, 40);
            this.btnLeavedEmployee.TabIndex = 13;
            this.btnLeavedEmployee.Text = "Leaved Employee";
            this.btnLeavedEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLeavedEmployee.Click += new System.EventHandler(this.btnLeavedEmployee_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BorderRadius = 19;
            this.btnUsers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUsers.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUsers.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.btnUsers.CheckedState.Parent = this.btnUsers;
            this.btnUsers.CustomImages.Parent = this.btnUsers;
            this.btnUsers.FillColor = System.Drawing.Color.Green;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.HoverState.Parent = this.btnUsers;
            this.btnUsers.Image = global::Hostel_Management_System.Properties.Resources.users;
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUsers.Location = new System.Drawing.Point(12, 783);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ShadowDecoration.Parent = this.btnUsers;
            this.btnUsers.Size = new System.Drawing.Size(229, 40);
            this.btnUsers.TabIndex = 12;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // txtAllEmployeeWorking
            // 
            this.txtAllEmployeeWorking.BorderRadius = 19;
            this.txtAllEmployeeWorking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.txtAllEmployeeWorking.CheckedState.FillColor = System.Drawing.Color.White;
            this.txtAllEmployeeWorking.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.txtAllEmployeeWorking.CheckedState.Parent = this.txtAllEmployeeWorking;
            this.txtAllEmployeeWorking.CustomImages.Parent = this.txtAllEmployeeWorking;
            this.txtAllEmployeeWorking.FillColor = System.Drawing.Color.Green;
            this.txtAllEmployeeWorking.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllEmployeeWorking.ForeColor = System.Drawing.Color.White;
            this.txtAllEmployeeWorking.HoverState.Parent = this.txtAllEmployeeWorking;
            this.txtAllEmployeeWorking.Image = global::Hostel_Management_System.Properties.Resources.living_members1;
            this.txtAllEmployeeWorking.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAllEmployeeWorking.Location = new System.Drawing.Point(12, 664);
            this.txtAllEmployeeWorking.Name = "txtAllEmployeeWorking";
            this.txtAllEmployeeWorking.ShadowDecoration.Parent = this.txtAllEmployeeWorking;
            this.txtAllEmployeeWorking.Size = new System.Drawing.Size(229, 40);
            this.txtAllEmployeeWorking.TabIndex = 3;
            this.txtAllEmployeeWorking.Text = "All Employee Working";
            this.txtAllEmployeeWorking.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAllEmployeeWorking.Click += new System.EventHandler(this.txtAllEmployeeWorking_Click);
            // 
            // btnLeavedMembers
            // 
            this.btnLeavedMembers.BorderRadius = 19;
            this.btnLeavedMembers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLeavedMembers.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLeavedMembers.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.btnLeavedMembers.CheckedState.Parent = this.btnLeavedMembers;
            this.btnLeavedMembers.CustomImages.Parent = this.btnLeavedMembers;
            this.btnLeavedMembers.FillColor = System.Drawing.Color.Green;
            this.btnLeavedMembers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeavedMembers.ForeColor = System.Drawing.Color.White;
            this.btnLeavedMembers.HoverState.Parent = this.btnLeavedMembers;
            this.btnLeavedMembers.Image = global::Hostel_Management_System.Properties.Resources.check_out;
            this.btnLeavedMembers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLeavedMembers.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLeavedMembers.Location = new System.Drawing.Point(-2, 411);
            this.btnLeavedMembers.Name = "btnLeavedMembers";
            this.btnLeavedMembers.ShadowDecoration.Parent = this.btnLeavedMembers;
            this.btnLeavedMembers.Size = new System.Drawing.Size(229, 40);
            this.btnLeavedMembers.TabIndex = 10;
            this.btnLeavedMembers.Text = "Leaved Members";
            this.btnLeavedMembers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLeavedMembers.Click += new System.EventHandler(this.btnLeavedMembers_Click);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.BorderRadius = 19;
            this.btnNewEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNewEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNewEmployee.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.btnNewEmployee.CheckedState.Parent = this.btnNewEmployee;
            this.btnNewEmployee.CustomImages.Parent = this.btnNewEmployee;
            this.btnNewEmployee.FillColor = System.Drawing.Color.Green;
            this.btnNewEmployee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEmployee.ForeColor = System.Drawing.Color.White;
            this.btnNewEmployee.HoverState.Parent = this.btnNewEmployee;
            this.btnNewEmployee.Image = global::Hostel_Management_System.Properties.Resources.new_member1;
            this.btnNewEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNewEmployee.Location = new System.Drawing.Point(12, 477);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.ShadowDecoration.Parent = this.btnNewEmployee;
            this.btnNewEmployee.Size = new System.Drawing.Size(229, 40);
            this.btnNewEmployee.TabIndex = 9;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewEmployee.Click += new System.EventHandler(this.guna2Button9_Click);
            // 
            // updateDeleteEmployee
            // 
            this.updateDeleteEmployee.BorderRadius = 19;
            this.updateDeleteEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.updateDeleteEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.updateDeleteEmployee.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.updateDeleteEmployee.CheckedState.Parent = this.updateDeleteEmployee;
            this.updateDeleteEmployee.CustomImages.Parent = this.updateDeleteEmployee;
            this.updateDeleteEmployee.FillColor = System.Drawing.Color.Green;
            this.updateDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.updateDeleteEmployee.HoverState.Parent = this.updateDeleteEmployee;
            this.updateDeleteEmployee.Image = global::Hostel_Management_System.Properties.Resources.update1;
            this.updateDeleteEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.updateDeleteEmployee.Location = new System.Drawing.Point(-2, 546);
            this.updateDeleteEmployee.Name = "updateDeleteEmployee";
            this.updateDeleteEmployee.ShadowDecoration.Parent = this.updateDeleteEmployee;
            this.updateDeleteEmployee.Size = new System.Drawing.Size(278, 40);
            this.updateDeleteEmployee.TabIndex = 8;
            this.updateDeleteEmployee.Text = "Update & Delete Employee";
            this.updateDeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.updateDeleteEmployee.Click += new System.EventHandler(this.updateDeleteEmployee_Click);
            // 
            // txtEmployeePayment
            // 
            this.txtEmployeePayment.BorderRadius = 19;
            this.txtEmployeePayment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.txtEmployeePayment.CheckedState.FillColor = System.Drawing.Color.White;
            this.txtEmployeePayment.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.txtEmployeePayment.CheckedState.Parent = this.txtEmployeePayment;
            this.txtEmployeePayment.CustomImages.Parent = this.txtEmployeePayment;
            this.txtEmployeePayment.FillColor = System.Drawing.Color.Green;
            this.txtEmployeePayment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePayment.ForeColor = System.Drawing.Color.White;
            this.txtEmployeePayment.HoverState.Parent = this.txtEmployeePayment;
            this.txtEmployeePayment.Image = global::Hostel_Management_System.Properties.Resources.fees1;
            this.txtEmployeePayment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeePayment.ImageSize = new System.Drawing.Size(30, 30);
            this.txtEmployeePayment.Location = new System.Drawing.Point(12, 604);
            this.txtEmployeePayment.Name = "txtEmployeePayment";
            this.txtEmployeePayment.ShadowDecoration.Parent = this.txtEmployeePayment;
            this.txtEmployeePayment.Size = new System.Drawing.Size(229, 40);
            this.txtEmployeePayment.TabIndex = 7;
            this.txtEmployeePayment.Text = "Employee Payment";
            this.txtEmployeePayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeePayment.Click += new System.EventHandler(this.txtEmployeePayment_Click);
            // 
            // btnUpdateDelete
            // 
            this.btnUpdateDelete.BorderRadius = 19;
            this.btnUpdateDelete.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateDelete.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateDelete.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.btnUpdateDelete.CheckedState.Parent = this.btnUpdateDelete;
            this.btnUpdateDelete.CustomImages.Parent = this.btnUpdateDelete;
            this.btnUpdateDelete.FillColor = System.Drawing.Color.Green;
            this.btnUpdateDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDelete.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDelete.HoverState.Parent = this.btnUpdateDelete;
            this.btnUpdateDelete.Image = global::Hostel_Management_System.Properties.Resources.update;
            this.btnUpdateDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateDelete.Location = new System.Drawing.Point(-2, 226);
            this.btnUpdateDelete.Name = "btnUpdateDelete";
            this.btnUpdateDelete.ShadowDecoration.Parent = this.btnUpdateDelete;
            this.btnUpdateDelete.Size = new System.Drawing.Size(268, 40);
            this.btnUpdateDelete.TabIndex = 6;
            this.btnUpdateDelete.Text = "Update & Delete Members";
            this.btnUpdateDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateDelete.Click += new System.EventHandler(this.btnUpdateDelete_Click);
            // 
            // btnFees
            // 
            this.btnFees.BorderRadius = 19;
            this.btnFees.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFees.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnFees.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.btnFees.CheckedState.Parent = this.btnFees;
            this.btnFees.CustomImages.Parent = this.btnFees;
            this.btnFees.FillColor = System.Drawing.Color.Green;
            this.btnFees.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFees.ForeColor = System.Drawing.Color.White;
            this.btnFees.HoverState.Parent = this.btnFees;
            this.btnFees.Image = global::Hostel_Management_System.Properties.Resources.fees;
            this.btnFees.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFees.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFees.Location = new System.Drawing.Point(12, 286);
            this.btnFees.Name = "btnFees";
            this.btnFees.ShadowDecoration.Parent = this.btnFees;
            this.btnFees.Size = new System.Drawing.Size(229, 40);
            this.btnFees.TabIndex = 5;
            this.btnFees.Text = "Fees";
            this.btnFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFees.Click += new System.EventHandler(this.btnFees_Click);
            // 
            // btnMembersLiving
            // 
            this.btnMembersLiving.BorderRadius = 19;
            this.btnMembersLiving.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMembersLiving.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMembersLiving.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.btnMembersLiving.CheckedState.Parent = this.btnMembersLiving;
            this.btnMembersLiving.CustomImages.Parent = this.btnMembersLiving;
            this.btnMembersLiving.FillColor = System.Drawing.Color.Green;
            this.btnMembersLiving.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembersLiving.ForeColor = System.Drawing.Color.White;
            this.btnMembersLiving.HoverState.Parent = this.btnMembersLiving;
            this.btnMembersLiving.Image = global::Hostel_Management_System.Properties.Resources.living_members;
            this.btnMembersLiving.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMembersLiving.Location = new System.Drawing.Point(12, 345);
            this.btnMembersLiving.Name = "btnMembersLiving";
            this.btnMembersLiving.ShadowDecoration.Parent = this.btnMembersLiving;
            this.btnMembersLiving.Size = new System.Drawing.Size(229, 40);
            this.btnMembersLiving.TabIndex = 4;
            this.btnMembersLiving.Text = "All Member Living";
            this.btnMembersLiving.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMembersLiving.Click += new System.EventHandler(this.btnMembersLiving_Click);
            // 
            // btnManageBeds
            // 
            this.btnManageBeds.BorderRadius = 19;
            this.btnManageBeds.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnManageBeds.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnManageBeds.CheckedState.ForeColor = System.Drawing.Color.Green;
            this.btnManageBeds.CheckedState.Parent = this.btnManageBeds;
            this.btnManageBeds.CustomImages.Parent = this.btnManageBeds;
            this.btnManageBeds.FillColor = System.Drawing.Color.Green;
            this.btnManageBeds.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBeds.ForeColor = System.Drawing.Color.White;
            this.btnManageBeds.HoverState.Parent = this.btnManageBeds;
            this.btnManageBeds.Image = global::Hostel_Management_System.Properties.Resources.manage_rooms;
            this.btnManageBeds.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageBeds.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManageBeds.Location = new System.Drawing.Point(12, 96);
            this.btnManageBeds.Name = "btnManageBeds";
            this.btnManageBeds.ShadowDecoration.Parent = this.btnManageBeds;
            this.btnManageBeds.Size = new System.Drawing.Size(229, 40);
            this.btnManageBeds.TabIndex = 3;
            this.btnManageBeds.Text = "Manage Beds";
            this.btnManageBeds.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageBeds.Click += new System.EventHandler(this.btnManageBeds_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1410, 941);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnNewMember);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnLeavedEmployee);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.txtAllEmployeeWorking);
            this.Controls.Add(this.btnLeavedMembers);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.updateDeleteEmployee);
            this.Controls.Add(this.txtEmployeePayment);
            this.Controls.Add(this.btnUpdateDelete);
            this.Controls.Add(this.btnFees);
            this.Controls.Add(this.btnMembersLiving);
            this.Controls.Add(this.btnManageBeds);
            this.Controls.Add(this.DumbaraLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DumbaraLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnManageBeds;
        private Guna.UI2.WinForms.Guna2Button btnMembersLiving;
        private Guna.UI2.WinForms.Guna2Button btnFees;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDelete;
        private Guna.UI2.WinForms.Guna2Button txtEmployeePayment;
        private Guna.UI2.WinForms.Guna2Button updateDeleteEmployee;
        private Guna.UI2.WinForms.Guna2Button txtAllEmployeeWorking;
        private Guna.UI2.WinForms.Guna2Button btnNewEmployee;
        private Guna.UI2.WinForms.Guna2Button btnLeavedMembers;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnLeavedEmployee;
        private Guna.UI2.WinForms.Guna2Button btnNewMember;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnView;
        private Guna.UI2.WinForms.Guna2CircleButton btnMin;
    }
}