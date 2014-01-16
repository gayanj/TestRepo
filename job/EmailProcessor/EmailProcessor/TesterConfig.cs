using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace EmailProcessor
{
    public partial class TesterConfig : Form
    {
        private int x = 100;

        public TesterConfig()
        {
            InitializeComponent();
        }

        private void TesterConfig_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            //checkcode
            var message = new MailMessage();
            message.To.Add(textBox3.Text);

            message.Subject = "Test";
            message.From = new MailAddress(textBox1.Text);
            message.IsBodyHtml = true;
            message.Body = "This is a test";
            var smtp = new SmtpClient(textBox4.Text, 25);

            try
            {
                smtp.Send(message);
                textBox2.Text = "OK!";
            }

            catch (Exception ed)
            {
                textBox2.Text = ed.Message;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
