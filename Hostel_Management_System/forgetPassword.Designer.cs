namespace Hostel_Management_System
{
    partial class forgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgetPassword));
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtVerify = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.btnVerifyCode = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(297, 141);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(505, 30);
            this.txtEmail.TabIndex = 9;
            // 
            // txtVerify
            // 
            this.txtVerify.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVerify.DefaultText = "";
            this.txtVerify.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVerify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVerify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVerify.DisabledState.Parent = this.txtVerify;
            this.txtVerify.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVerify.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVerify.FocusedState.Parent = this.txtVerify;
            this.txtVerify.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtVerify.ForeColor = System.Drawing.Color.Black;
            this.txtVerify.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVerify.HoverState.Parent = this.txtVerify;
            this.txtVerify.Location = new System.Drawing.Point(297, 290);
            this.txtVerify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.PasswordChar = '\0';
            this.txtVerify.PlaceholderText = "";
            this.txtVerify.SelectedText = "";
            this.txtVerify.ShadowDecoration.Parent = this.txtVerify;
            this.txtVerify.Size = new System.Drawing.Size(505, 30);
            this.txtVerify.TabIndex = 10;
            // 
            // btnSend
            // 
            this.btnSend.BorderRadius = 19;
            this.btnSend.CheckedState.Parent = this.btnSend;
            this.btnSend.CustomImages.Parent = this.btnSend;
            this.btnSend.FillColor = System.Drawing.Color.Yellow;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.HoverState.Parent = this.btnSend;
            this.btnSend.Location = new System.Drawing.Point(669, 206);
            this.btnSend.Name = "btnSend";
            this.btnSend.ShadowDecoration.Parent = this.btnSend;
            this.btnSend.Size = new System.Drawing.Size(133, 40);
            this.btnSend.TabIndex = 30;
            this.btnSend.Text = "Send OTP";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnVerifyCode
            // 
            this.btnVerifyCode.BorderRadius = 19;
            this.btnVerifyCode.CheckedState.Parent = this.btnVerifyCode;
            this.btnVerifyCode.CustomImages.Parent = this.btnVerifyCode;
            this.btnVerifyCode.FillColor = System.Drawing.Color.Yellow;
            this.btnVerifyCode.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyCode.ForeColor = System.Drawing.Color.Black;
            this.btnVerifyCode.HoverState.Parent = this.btnVerifyCode;
            this.btnVerifyCode.Location = new System.Drawing.Point(669, 351);
            this.btnVerifyCode.Name = "btnVerifyCode";
            this.btnVerifyCode.ShadowDecoration.Parent = this.btnVerifyCode;
            this.btnVerifyCode.Size = new System.Drawing.Size(133, 40);
            this.btnVerifyCode.TabIndex = 31;
            this.btnVerifyCode.Text = "Verify OTP";
            this.btnVerifyCode.Click += new System.EventHandler(this.btnVerifyCode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Enter User Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Verify Code";
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
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(822, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(53, 56);
            this.btnExit.TabIndex = 36;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // forgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(875, 521);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerifyCode);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtVerify);
            this.Controls.Add(this.txtEmail);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "forgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtVerify;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2Button btnVerifyCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
    }
}