namespace Hospital_Reception_Management_System
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlManage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReception = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnNurse = new System.Windows.Forms.Button();
            this.lblText2 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCross = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCross);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 31);
            this.panel1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hospital Reception Management System";
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.MintCream;
            this.pnlDashboard.Controls.Add(this.panel2);
            this.pnlDashboard.Controls.Add(this.pictureBox1);
            this.pnlDashboard.Controls.Add(this.pnlManage);
            this.pnlDashboard.Controls.Add(this.lblText2);
            this.pnlDashboard.Location = new System.Drawing.Point(58, 60);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1074, 529);
            this.pnlDashboard.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 37);
            this.panel2.TabIndex = 20;
            // 
            // pnlManage
            // 
            this.pnlManage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlManage.Controls.Add(this.btnAdmin);
            this.pnlManage.Controls.Add(this.label1);
            this.pnlManage.Controls.Add(this.btnReception);
            this.pnlManage.Controls.Add(this.btnDoctor);
            this.pnlManage.Controls.Add(this.btnNurse);
            this.pnlManage.Location = new System.Drawing.Point(3, 62);
            this.pnlManage.Name = "pnlManage";
            this.pnlManage.Size = new System.Drawing.Size(353, 425);
            this.pnlManage.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Manage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReception
            // 
            this.btnReception.BackColor = System.Drawing.Color.Teal;
            this.btnReception.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReception.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReception.ForeColor = System.Drawing.Color.White;
            this.btnReception.Location = new System.Drawing.Point(75, 89);
            this.btnReception.Name = "btnReception";
            this.btnReception.Size = new System.Drawing.Size(203, 35);
            this.btnReception.TabIndex = 15;
            this.btnReception.Text = "Receptionists";
            this.btnReception.UseVisualStyleBackColor = false;
            this.btnReception.Click += new System.EventHandler(this.btnReception_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.BackColor = System.Drawing.Color.Teal;
            this.btnDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.ForeColor = System.Drawing.Color.White;
            this.btnDoctor.Location = new System.Drawing.Point(75, 251);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(203, 35);
            this.btnDoctor.TabIndex = 17;
            this.btnDoctor.Text = "Doctors";
            this.btnDoctor.UseVisualStyleBackColor = false;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnNurse
            // 
            this.btnNurse.BackColor = System.Drawing.Color.Teal;
            this.btnNurse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNurse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNurse.ForeColor = System.Drawing.Color.White;
            this.btnNurse.Location = new System.Drawing.Point(75, 171);
            this.btnNurse.Name = "btnNurse";
            this.btnNurse.Size = new System.Drawing.Size(203, 35);
            this.btnNurse.TabIndex = 16;
            this.btnNurse.Text = "Nurses";
            this.btnNurse.UseVisualStyleBackColor = false;
            this.btnNurse.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblText2
            // 
            this.lblText2.BackColor = System.Drawing.Color.Teal;
            this.lblText2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblText2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblText2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2.ForeColor = System.Drawing.Color.White;
            this.lblText2.Location = new System.Drawing.Point(400, 0);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(262, 25);
            this.lblText2.TabIndex = 14;
            this.lblText2.Text = "Admin Home";
            this.lblText2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Teal;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(75, 332);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(203, 35);
            this.btnAdmin.TabIndex = 22;
            this.btnAdmin.Text = "Admins";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.White;
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(42, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(43, 37);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::Hospital_Reception_Management_System.Properties.Resources.Logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(43, 37);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Hospital_Reception_Management_System.Properties.Resources.Admin_bro;
            this.pictureBox1.Location = new System.Drawing.Point(459, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnCross
            // 
            this.btnCross.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCross.BackgroundImage")));
            this.btnCross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCross.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCross.FlatAppearance.BorderSize = 0;
            this.btnCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCross.Location = new System.Drawing.Point(1145, 0);
            this.btnCross.Name = "btnCross";
            this.btnCross.Size = new System.Drawing.Size(33, 31);
            this.btnCross.TabIndex = 16;
            this.btnCross.UseVisualStyleBackColor = true;
            this.btnCross.Click += new System.EventHandler(this.btnCross_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCross;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Button btnReception;
        private System.Windows.Forms.Panel pnlManage;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnNurse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdmin;
    }
}