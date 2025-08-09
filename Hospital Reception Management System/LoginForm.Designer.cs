namespace Hospital_Reception_Management_System
{
    partial class Loginfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginfrm));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.cbPassword = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCross = new System.Windows.Forms.Button();
            this.picHospital = new System.Windows.Forms.PictureBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUserId = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserId)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.lblSignUp);
            this.pnlLogin.Controls.Add(this.lblText);
            this.pnlLogin.Controls.Add(this.cbPassword);
            this.pnlLogin.Controls.Add(this.tbPassword);
            this.pnlLogin.Controls.Add(this.picPassword);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.tbUserId);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.picUserId);
            this.pnlLogin.Controls.Add(this.lblUserId);
            this.pnlLogin.Location = new System.Drawing.Point(686, 94);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(486, 450);
            this.pnlLogin.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(181, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Forgot Password?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 10;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.Blue;
            this.lblSignUp.Location = new System.Drawing.Point(283, 383);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(84, 17);
            this.lblSignUp.TabIndex = 9;
            this.lblSignUp.Text = "SignUp Here";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(108, 383);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(160, 16);
            this.lblText.TabIndex = 8;
            this.lblText.Text = "Don\'t have an account?";
            // 
            // cbPassword
            // 
            this.cbPassword.AutoSize = true;
            this.cbPassword.Location = new System.Drawing.Point(73, 239);
            this.cbPassword.Name = "cbPassword";
            this.cbPassword.Size = new System.Drawing.Size(110, 20);
            this.cbPassword.TabIndex = 7;
            this.cbPassword.Text = "Show Password";
            this.cbPassword.UseVisualStyleBackColor = true;
            this.cbPassword.CheckedChanged += new System.EventHandler(this.cbPassword_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(55, 212);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(376, 21);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(95, 190);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password :";
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(55, 130);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(376, 21);
            this.tbUserId.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Teal;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(133, 286);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(215, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(95, 108);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(63, 19);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "UserID :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCross);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 31);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hospital Reception Management System";
            // 
            // btnCross
            // 
            this.btnCross.BackgroundImage = global::Hospital_Reception_Management_System.Properties.Resources.Cross_Mark_Button;
            this.btnCross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCross.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCross.FlatAppearance.BorderSize = 0;
            this.btnCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCross.Location = new System.Drawing.Point(1148, 0);
            this.btnCross.Name = "btnCross";
            this.btnCross.Size = new System.Drawing.Size(30, 31);
            this.btnCross.TabIndex = 15;
            this.btnCross.UseVisualStyleBackColor = true;
            this.btnCross.Click += new System.EventHandler(this.btnCross_Click);
            // 
            // picHospital
            // 
            this.picHospital.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHospital.BackgroundImage")));
            this.picHospital.Location = new System.Drawing.Point(9, 94);
            this.picHospital.Name = "picHospital";
            this.picHospital.Size = new System.Drawing.Size(661, 450);
            this.picHospital.TabIndex = 1;
            this.picHospital.TabStop = false;
            // 
            // picPassword
            // 
            this.picPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPassword.BackgroundImage")));
            this.picPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPassword.Location = new System.Drawing.Point(55, 187);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(34, 27);
            this.picPassword.TabIndex = 5;
            this.picPassword.TabStop = false;
            // 
            // picUserId
            // 
            this.picUserId.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picUserId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUserId.BackgroundImage")));
            this.picUserId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUserId.Location = new System.Drawing.Point(55, 104);
            this.picUserId.Name = "picUserId";
            this.picUserId.Size = new System.Drawing.Size(34, 27);
            this.picUserId.TabIndex = 1;
            this.picUserId.TabStop = false;
            // 
            // Loginfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picHospital);
            this.Controls.Add(this.pnlLogin);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loginfrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox picUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.CheckBox cbPassword;
        private System.Windows.Forms.PictureBox picHospital;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCross;
    }
}

