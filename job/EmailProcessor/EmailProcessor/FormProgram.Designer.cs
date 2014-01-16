namespace EmailProcessor
{
    partial class FormProgram
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxJobs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBoxePort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxeServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxePwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxeUserName = new System.Windows.Forms.TextBox();
            this.TextBoxeFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start Processing";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Status : Off";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(172, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Stop Processing";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBoxJobs);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // TextBoxJobs
            // 
            this.TextBoxJobs.Enabled = false;
            this.TextBoxJobs.Location = new System.Drawing.Point(132, 13);
            this.TextBoxJobs.Name = "TextBoxJobs";
            this.TextBoxJobs.Size = new System.Drawing.Size(42, 20);
            this.TextBoxJobs.TabIndex = 5;
            this.TextBoxJobs.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Jobs to Display in Email:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBoxePort);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TextBoxeServer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TextBoxePwd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TextBoxeUserName);
            this.groupBox2.Controls.Add(this.TextBoxeFrom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 118);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email Setup";
            // 
            // TextBoxePort
            // 
            this.TextBoxePort.Location = new System.Drawing.Point(285, 92);
            this.TextBoxePort.Name = "TextBoxePort";
            this.TextBoxePort.Size = new System.Drawing.Size(42, 20);
            this.TextBoxePort.TabIndex = 4;
            this.TextBoxePort.Text = "25";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Port:";
            // 
            // TextBoxeServer
            // 
            this.TextBoxeServer.Location = new System.Drawing.Point(100, 92);
            this.TextBoxeServer.Name = "TextBoxeServer";
            this.TextBoxeServer.Size = new System.Drawing.Size(144, 20);
            this.TextBoxeServer.TabIndex = 3;
            this.TextBoxeServer.Text = "w1.cloudapp.net";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email Server:";
            // 
            // TextBoxePwd
            // 
            this.TextBoxePwd.Location = new System.Drawing.Point(100, 66);
            this.TextBoxePwd.Name = "TextBoxePwd";
            this.TextBoxePwd.PasswordChar = 'x';
            this.TextBoxePwd.Size = new System.Drawing.Size(227, 20);
            this.TextBoxePwd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email Password:";
            // 
            // TextBoxeUserName
            // 
            this.TextBoxeUserName.Location = new System.Drawing.Point(100, 40);
            this.TextBoxeUserName.Name = "TextBoxeUserName";
            this.TextBoxeUserName.Size = new System.Drawing.Size(227, 20);
            this.TextBoxeUserName.TabIndex = 1;
            // 
            // TextBoxeFrom
            // 
            this.TextBoxeFrom.Location = new System.Drawing.Point(100, 14);
            this.TextBoxeFrom.Name = "TextBoxeFrom";
            this.TextBoxeFrom.Size = new System.Drawing.Size(227, 20);
            this.TextBoxeFrom.TabIndex = 0;
            this.TextBoxeFrom.Text = "fashion.jobs@fashionquadrant.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email From:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Response";
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(15, 245);
            this.Status.Multiline = true;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(330, 63);
            this.Status.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(15, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(332, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Exit App";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormProgram
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(359, 389);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormProgram";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Processor";
            this.Load += new System.EventHandler(this.FormProgram_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxeFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxeUserName;
        private System.Windows.Forms.TextBox TextBoxePwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxeServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxePort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxJobs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Button button4;
    }
}

