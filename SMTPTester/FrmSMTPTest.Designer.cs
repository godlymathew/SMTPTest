namespace SMTPTester
{
    partial class FrmSMTPTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSMTPTest));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTestMail = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textTo = new System.Windows.Forms.TextBox();
            this.textSMTP = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PgBar = new System.Windows.Forms.ProgressBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "SMTP ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "User Name";
            // 
            // btnTestMail
            // 
            this.btnTestMail.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTestMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTestMail.Location = new System.Drawing.Point(95, 176);
            this.btnTestMail.Name = "btnTestMail";
            this.btnTestMail.Size = new System.Drawing.Size(254, 37);
            this.btnTestMail.TabIndex = 33;
            this.btnTestMail.Text = "Check";
            this.btnTestMail.UseVisualStyleBackColor = false;
            this.btnTestMail.Click += new System.EventHandler(this.btnTestMail_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(95, 147);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "SSL Enabled";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(95, 118);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(254, 20);
            this.textTo.TabIndex = 5;
            // 
            // textSMTP
            // 
            this.textSMTP.Location = new System.Drawing.Point(95, 66);
            this.textSMTP.Name = "textSMTP";
            this.textSMTP.Size = new System.Drawing.Size(254, 20);
            this.textSMTP.TabIndex = 3;
            // 
            // textPort
            // 
            this.textPort.BackColor = System.Drawing.Color.Bisque;
            this.textPort.Location = new System.Drawing.Point(95, 92);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(54, 20);
            this.textPort.TabIndex = 4;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(95, 40);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(254, 20);
            this.textPassword.TabIndex = 2;
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(95, 13);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(254, 20);
            this.textUserName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "To Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(251, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "Copy Rights @ {}";
            // 
            // PgBar
            // 
            this.PgBar.ForeColor = System.Drawing.Color.DarkGreen;
            this.PgBar.Location = new System.Drawing.Point(12, 227);
            this.PgBar.MarqueeAnimationSpeed = 50;
            this.PgBar.Name = "PgBar";
            this.PgBar.Size = new System.Drawing.Size(366, 13);
            this.PgBar.Step = 20;
            this.PgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.PgBar.TabIndex = 40;
            this.PgBar.Value = 100;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(12, 249);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 41;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmSMTPTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 270);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.PgBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTestMail);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.textSMTP);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSMTPTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Godly\'s SMTP Checker";
            this.Load += new System.EventHandler(this.FrmSMTPTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTestMail;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textTo;
        private System.Windows.Forms.TextBox textSMTP;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar PgBar;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}