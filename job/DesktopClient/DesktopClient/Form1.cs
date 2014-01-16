using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;

namespace DesktopClient
{
    public partial class Form1 : Form
    {
        //private const string weburl = "http://v1.gqjobs.com";
        //possibly an internet check could be made if data is not displayed, didn't have time for that so left it
        //as it is

        public Form1()
        {
            InitializeComponent();
        }

        private void Processxml()
        {
            #region xmlreader

            panel2.Controls.Clear();
            panel1.Controls.Clear();

            string myIp = string.Empty;

            try
            {
                string myHost = System.Net.Dns.GetHostName();
                myIp = System.Net.Dns.GetHostEntry(myHost).AddressList[0].ToString();
            }
            catch { }

            var wbfet = new WebFetch();
            var rd = new XmlTextReader(wbfet.Gettexts("http://proto.fashionquadrant.com/v1/jobxout.aspx?id=dt&ipaddress=" + myIp)) { WhitespaceHandling = WhitespaceHandling.None };

            int jobflag = 0;
            int ht = 0;

            var alist = new ArrayList();

            while (rd.Read())
            {
                if (rd.HasAttributes)
                {
                    Console.Write(rd.GetAttribute("id"));
                    alist.Add(rd.GetAttribute("id"));
                }

                switch (rd.Name.ToString(CultureInfo.InvariantCulture))
                {
                    case "title":
                        {
                            var lbl1 = new Label
                                           {
                                               Location = new Point(0, ht),
                                               Text = rd.ReadElementContentAsString(),
                                               ForeColor = Color.FromArgb(255, 191, 0),
                                               Width = 240,
                                               Height = 13,
                                               AutoSize = false,
                                               AutoEllipsis = false,
                                               Font = new System.Drawing.Font("Tahoma", 8)
                                           };
                            //__lbl1.Dock = DockStyle.Top;
                            //__lbl1.Font = new Font(this.Font, FontStyle.Bold);
                            //__lbl1.BringToFront();

                            if (jobflag == 0)
                            {
                                lbl1.ForeColor = Color.Black;
                                panel2.Controls.Add(lbl1);
                            }

                            else
                            {
                                lbl1.ForeColor = Color.Black;
                                this.panel1.Controls.Add(lbl1);
                            }
                        }
                        break;
                }

                switch (rd.Name.ToString(CultureInfo.InvariantCulture))
                {
                    case "shortdescription":
                        {
                            var lbl2 = new Label
                                           {
                                               Location = new Point(0, ht + 14),
                                               Text = rd.ReadElementContentAsString(),
                                               Font = new System.Drawing.Font("Tahoma", 8),
                                               ForeColor = Color.White,
                                               Width = 240,
                                               Height = 30,
                                               AutoSize = false,
                                               AutoEllipsis = false
                                           };
                            //__lbl2.Dock = DockStyle.Top;

                            if (jobflag == 0)
                            {
                                lbl2.ForeColor = Color.Gray;
                                panel2.Controls.Add(lbl2);
                            }

                            else
                            {
                                lbl2.ForeColor = Color.Gray;
                                this.panel1.Controls.Add(lbl2);
                            }
                        }
                        break;
                }

                switch (rd.Name.ToString(CultureInfo.InvariantCulture))
                {
                    case "hlink":
                        {
                            var lnk1 = new Label
                                           {
                                               Location = new Point(0, ht + 41),
                                               Name = rd.ReadElementContentAsString(),
                                               Width = 200,
                                               Height = 24,
                                               AutoSize = false,
                                               AutoEllipsis = false,
                                               Font = new System.Drawing.Font("Tahoma", 8)
                                           };
                            //__lnk1.Dock = DockStyle.Top;
                            lnk1.Click += new EventHandler(movetonewpage);
                            lnk1.MouseEnter += new EventHandler(linkmover);
                            lnk1.MouseLeave += new EventHandler(linkmleave);

                            if (jobflag == 0)
                            {
                                lnk1.Text = "Go to advert";
                                lnk1.ForeColor = Color.SteelBlue;
                                panel2.Controls.Add(lnk1);
                            }

                            else
                            {
                                lnk1.Text = "Apply";
                                lnk1.ForeColor = Color.SteelBlue;
                                this.panel1.Controls.Add(lnk1);
                                ht += 66;
                            }

                            jobflag++;
                        }
                        break;
                }
            }

            rd.Close();
            //GC.Collect();

            #endregion xmlreader
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            int nTaskBarHeight = Screen.PrimaryScreen.Bounds.Bottom - Screen.PrimaryScreen.WorkingArea.Bottom;
            int xbound = Screen.PrimaryScreen.Bounds.Width;
            int ybound = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(xbound - 290, ybound - (nTaskBarHeight + 355));

            try
            {
                Processxml();
            }
            catch { }

            this.Visible = true;
            this.Refresh();

            var r1 = new Random();
            int calc = r1.Next(0, 100000);

            timer1.Interval = (calc + 900000);
            timer1.Start();
        }

        private void movetonewpage(object sender, EventArgs e)
        {
            var lbl3 = (Label)sender;
            System.Diagnostics.Process.Start("iexplore", lbl3.Name);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Processxml();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //panel1.Visible = false;
            //panel2.Visible = false;
            //panel3.Visible = false;
            panel1.AutoScroll = false;

            for (int wi = 300; wi >= 0; wi -= 4)
            {
                this.Width = wi;
            }

            Application.Exit();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.DimGray;
        }

        private void linkmover(object sender, EventArgs e)
        {
            var lb = (Label)sender;
            //__lb.Text = "Apply >>";
            lb.Font = new Font("Tahoma", 8, FontStyle.Underline);
            lb.Cursor = Cursors.Hand;
        }

        private void linkmleave(object sender, EventArgs e)
        {
            var lb = (Label)sender;
            //__lb.Text = "Apply";
            lb.Font = new Font("Tahoma", 8);
            lb.Cursor = Cursors.Default;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
            label7.Cursor = Cursors.Hand;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.DimGray;
            label7.Cursor = Cursors.Default;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    this.MinimizeBox = false;
                    this.WindowState = FormWindowState.Minimized;
                    break;
                default:
                    this.WindowState = FormWindowState.Maximized;
                    break;
            }
        }
    }
}