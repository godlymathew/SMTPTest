using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTPTester
{
    public partial class FrmSMTPTest : Form
    {
        public FrmSMTPTest()
        {
            InitializeComponent();
        }

        private void btnTestMail_Click(object sender, EventArgs e)
        {
            btnTestMail.Text = "Please wait.....";
            PgBar.Visible = true;
            btnTestMail.Enabled = false;
            try
            {
                if (textTo.Text == "") { textTo.BackColor = Color.LightPink; return; }
                textTo.BackColor = Color.White;
                var client = new SmtpClient(textSMTP.Text, Int32.Parse(textPort.Text))
                {
                    Credentials = new NetworkCredential(textUserName.Text, textPassword.Text),
                    EnableSsl = checkBox1.Checked
                };

                MailMessage message = new MailMessage();
                message.To.Add(textTo.Text);
                message.From = new MailAddress(textUserName.Text, "Test Mail");
                message.Subject = "Email From App Test Tool";
                message.Body = "<h2>Hi, Greetings from ....</h2><br /> <div style=\"color:green\">{content}</div><hr />";
                message.IsBodyHtml = true;
                client.Send(message);
                MessageBox.Show("Mail Sent", "OASYS Says:)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                string error = "";
                if (ex.InnerException != null)
                {
                    error = ex.InnerException.Message;
                }
                MessageBox.Show("Mail not Sent!.\n" + ex.Message + "\n" + error, "OASYS Says :)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                btnTestMail.Enabled = true;
                btnTestMail.Text = "Check";
                PgBar.Visible = false;
            }
        }

        private void FrmSMTPTest_Load(object sender, EventArgs e)
        {
            PgBar.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Developed by : {}", "{}", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}