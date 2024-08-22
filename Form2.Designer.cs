
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.mobile = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fname1 = new System.Windows.Forms.Label();
            this.lname2 = new System.Windows.Forms.Label();
            this.gender1 = new System.Windows.Forms.Label();
            this.email1 = new System.Windows.Forms.Label();
            this.city1 = new System.Windows.Forms.Label();
            this.state1 = new System.Windows.Forms.Label();
            this.mobile1 = new System.Windows.Forms.Label();
            this.vv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(371, 55);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(100, 20);
            this.fname.TabIndex = 0;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(371, 103);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(100, 20);
            this.lname.TabIndex = 1;
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(371, 145);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(100, 20);
            this.gender.TabIndex = 2;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(371, 209);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 3;
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(371, 321);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(100, 20);
            this.state.TabIndex = 4;
            // 
            // mobile
            // 
            this.mobile.Location = new System.Drawing.Point(371, 377);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(100, 20);
            this.mobile.TabIndex = 5;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(371, 265);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fname1
            // 
            this.fname1.AutoSize = true;
            this.fname1.Location = new System.Drawing.Point(595, 55);
            this.fname1.Name = "fname1";
            this.fname1.Size = new System.Drawing.Size(35, 13);
            this.fname1.TabIndex = 8;
            this.fname1.Text = "label1";
            this.fname1.Click += new System.EventHandler(this.fname1_Click);
            // 
            // lname2
            // 
            this.lname2.AutoSize = true;
            this.lname2.Location = new System.Drawing.Point(595, 103);
            this.lname2.Name = "lname2";
            this.lname2.Size = new System.Drawing.Size(35, 13);
            this.lname2.TabIndex = 9;
            this.lname2.Text = "label2";
            // 
            // gender1
            // 
            this.gender1.AutoSize = true;
            this.gender1.Location = new System.Drawing.Point(595, 148);
            this.gender1.Name = "gender1";
            this.gender1.Size = new System.Drawing.Size(35, 13);
            this.gender1.TabIndex = 10;
            this.gender1.Text = "label3";
            // 
            // email1
            // 
            this.email1.AutoSize = true;
            this.email1.Location = new System.Drawing.Point(595, 209);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(35, 13);
            this.email1.TabIndex = 11;
            this.email1.Text = "label4";
            // 
            // city1
            // 
            this.city1.AutoSize = true;
            this.city1.Location = new System.Drawing.Point(598, 265);
            this.city1.Name = "city1";
            this.city1.Size = new System.Drawing.Size(35, 13);
            this.city1.TabIndex = 12;
            this.city1.Text = "label5";
            // 
            // state1
            // 
            this.state1.AutoSize = true;
            this.state1.Location = new System.Drawing.Point(601, 321);
            this.state1.Name = "state1";
            this.state1.Size = new System.Drawing.Size(35, 13);
            this.state1.TabIndex = 13;
            this.state1.Text = "label6";
            // 
            // mobile1
            // 
            this.mobile1.AutoSize = true;
            this.mobile1.Location = new System.Drawing.Point(604, 377);
            this.mobile1.Name = "mobile1";
            this.mobile1.Size = new System.Drawing.Size(35, 13);
            this.mobile1.TabIndex = 14;
            this.mobile1.Text = "label7";
            // 
            // vv
            // 
            this.vv.AutoSize = true;
            this.vv.Location = new System.Drawing.Point(273, 58);
            this.vv.Name = "vv";
            this.vv.Size = new System.Drawing.Size(66, 13);
            this.vv.TabIndex = 15;
            this.vv.Text = "First Name : ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vv);
            this.Controls.Add(this.mobile1);
            this.Controls.Add(this.state1);
            this.Controls.Add(this.city1);
            this.Controls.Add(this.email1);
            this.Controls.Add(this.gender1);
            this.Controls.Add(this.lname2);
            this.Controls.Add(this.fname1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.city);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.state);
            this.Controls.Add(this.email);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label fname1;
        private System.Windows.Forms.Label lname2;
        private System.Windows.Forms.Label gender1;
        private System.Windows.Forms.Label email1;
        private System.Windows.Forms.Label city1;
        private System.Windows.Forms.Label state1;
        private System.Windows.Forms.Label mobile1;
        private System.Windows.Forms.Label vv;
    }
}