using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmailProcessor
{
    public partial class FormPassword : Form
    {
        int trycounter = 0;

        public FormPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (trycounter != 5)
            {
                /* ClProcessor clp = new ClProcessor();
                 bool flagcon = false;

                 flagcon = clp.connectionset(textBox1.Text, textBox2.Text);
                 string sb = "Server=localhost; Database=fashionquadrant;";
                 sb = sb + " UserId=" + textBox1.Text + "; Password=" + textBox2.Text;
                 */

                var flagcon = false;

                if (textBox1.Text == "moeen" && textBox2.Text == "!Strongpkwd64")
                {
                    flagcon = true;
                }

                if (flagcon == true)
                {
                    //add connection string here
                    ClVariables clv = new ClVariables();
                    //clv.constring = sb;

                    this.Visible = false;
                    FormProgram f1 = new FormProgram();
                    f1.Visible = true;
                }

                else
                {
                    label3.Text = "Unkown User/Password!!!";
                    label3.Visible = true;
                    trycounter += 1;
                }
            }

            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;

                label3.Text = "Too Many Tries App Locked!";
                label3.Visible = true;
            }

            GC.Collect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Application.Exit();
        }
    }
}
