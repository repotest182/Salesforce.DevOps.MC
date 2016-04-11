namespace Salesforce.DevOps.MC
{
    partial class Form1
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
            this.groupBoxSFDC = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxActiveOrg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxGitHub = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxSFDC.SuspendLayout();
            this.groupBoxGitHub.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSFDC
            // 
            this.groupBoxSFDC.Controls.Add(this.label5);
            this.groupBoxSFDC.Controls.Add(this.textBox1);
            this.groupBoxSFDC.Controls.Add(this.button2);
            this.groupBoxSFDC.Controls.Add(this.label2);
            this.groupBoxSFDC.Controls.Add(this.comboBox1);
            this.groupBoxSFDC.Controls.Add(this.label1);
            this.groupBoxSFDC.Controls.Add(this.comboBoxActiveOrg);
            this.groupBoxSFDC.Controls.Add(this.button1);
            this.groupBoxSFDC.Location = new System.Drawing.Point(13, 13);
            this.groupBoxSFDC.Name = "groupBoxSFDC";
            this.groupBoxSFDC.Size = new System.Drawing.Size(375, 118);
            this.groupBoxSFDC.TabIndex = 0;
            this.groupBoxSFDC.TabStop = false;
            this.groupBoxSFDC.Text = "Salesforce session";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Preferences...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxActiveOrg
            // 
            this.comboBoxActiveOrg.FormattingEnabled = true;
            this.comboBoxActiveOrg.Items.AddRange(new object[] {
            "ggpdev",
            "ggfdev"});
            this.comboBoxActiveOrg.Location = new System.Drawing.Point(131, 21);
            this.comboBoxActiveOrg.Name = "comboBoxActiveOrg";
            this.comboBoxActiveOrg.Size = new System.Drawing.Size(121, 24);
            this.comboBoxActiveOrg.TabIndex = 1;
            this.comboBoxActiveOrg.Text = "ggpdev";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select SFDC Org:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "pankaj.hingane@business.org1",
            "william.mayfield@reisystems.com",
            "shahnavazk@reisystems.com"});
            this.comboBox1.Location = new System.Drawing.Point(131, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "pankaj.hingane@business.org1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Login User:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Connect...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gold;
            this.textBox1.Location = new System.Drawing.Point(240, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Disconnected";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxGitHub
            // 
            this.groupBoxGitHub.Controls.Add(this.textBox2);
            this.groupBoxGitHub.Controls.Add(this.label6);
            this.groupBoxGitHub.Controls.Add(this.textBox4);
            this.groupBoxGitHub.Controls.Add(this.textBox3);
            this.groupBoxGitHub.Controls.Add(this.label3);
            this.groupBoxGitHub.Controls.Add(this.label4);
            this.groupBoxGitHub.Location = new System.Drawing.Point(394, 13);
            this.groupBoxGitHub.Name = "groupBoxGitHub";
            this.groupBoxGitHub.Size = new System.Drawing.Size(477, 118);
            this.groupBoxGitHub.TabIndex = 7;
            this.groupBoxGitHub.TabStop = false;
            this.groupBoxGitHub.Text = "GitHub session";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "User:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Repo:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(255, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "REISystems-SAAS-Client-ggpdev";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(69, 51);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(255, 22);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "william.mayfield@reisystems.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Branch:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 22);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Client-ggpdev-ticket-24";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Connection Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 481);
            this.Controls.Add(this.groupBoxGitHub);
            this.Controls.Add(this.groupBoxSFDC);
            this.Name = "Form1";
            this.Text = "Salesforce DevOps Management Console";
            this.groupBoxSFDC.ResumeLayout(false);
            this.groupBoxSFDC.PerformLayout();
            this.groupBoxGitHub.ResumeLayout(false);
            this.groupBoxGitHub.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSFDC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxActiveOrg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxGitHub;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

