namespace Hospital_Reception_Management_System
{
    partial class ForgortPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgortPassword));
            this.panelUsername = new System.Windows.Forms.Panel();
            this.btnConfirmName = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnCross = new System.Windows.Forms.Button();
            this.panelUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUsername
            // 
            this.panelUsername.Controls.Add(this.btnConfirmName);
            this.panelUsername.Controls.Add(this.tbEmail);
            this.panelUsername.Controls.Add(this.lblUsername);
            this.panelUsername.Location = new System.Drawing.Point(187, 109);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(498, 106);
            this.panelUsername.TabIndex = 37;
            // 
            // btnConfirmName
            // 
            this.btnConfirmName.BackColor = System.Drawing.Color.Teal;
            this.btnConfirmName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmName.ForeColor = System.Drawing.Color.White;
            this.btnConfirmName.Location = new System.Drawing.Point(188, 68);
            this.btnConfirmName.Name = "btnConfirmName";
            this.btnConfirmName.Size = new System.Drawing.Size(125, 35);
            this.btnConfirmName.TabIndex = 35;
            this.btnConfirmName.Text = "Confirm";
            this.btnConfirmName.UseVisualStyleBackColor = false;
            this.btnConfirmName.Click += new System.EventHandler(this.btnConfirmName_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(125, 22);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(344, 22);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(9, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(101, 19);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Enter Email :";
            // 
            // btnCross
            // 
            this.btnCross.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCross.BackgroundImage")));
            this.btnCross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCross.FlatAppearance.BorderSize = 0;
            this.btnCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCross.Location = new System.Drawing.Point(891, 1);
            this.btnCross.Name = "btnCross";
            this.btnCross.Size = new System.Drawing.Size(33, 34);
            this.btnCross.TabIndex = 38;
            this.btnCross.UseVisualStyleBackColor = true;
            this.btnCross.Click += new System.EventHandler(this.btnCross_Click);
            // 
            // ForgortPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(922, 336);
            this.Controls.Add(this.btnCross);
            this.Controls.Add(this.panelUsername);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ForgortPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgortPassword";
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Button btnConfirmName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnCross;
    }
}