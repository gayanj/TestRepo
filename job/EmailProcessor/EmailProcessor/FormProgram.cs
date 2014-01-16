using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Net.Mail;

namespace EmailProcessor
{
    public partial class FormProgram : Form
    {
        private int x = 215;

        public FormProgram()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = "Current Status : Processing...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "Current Status : Off";
        }

        private void FormProgram_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Tester t = new Tester();

            string em = t.emails(x);

            Status.Text += "> " + t.SendEmail(TextBoxeFrom.Text, em.Replace("\\", "").Replace("\r", "").Replace("\n", ""), x, TextBoxeServer.Text, TextBoxeUserName.Text, TextBoxePwd.Text, 25);

            x++;

            Status.Text += ">> Sent -- " + x + " at " + DateTime.Now + Environment.NewLine;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
