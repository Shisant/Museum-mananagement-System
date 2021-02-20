namespace coursework
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
            this.Name1 = new System.Windows.Forms.Label();
            this.fNameTxt = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.Label();
            this.contactTxt = new System.Windows.Forms.TextBox();
            this.occupation = new System.Windows.Forms.Label();
            this.occupationTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.genderTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Location = new System.Drawing.Point(145, 48);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(76, 17);
            this.Name1.TabIndex = 4;
            this.Name1.Text = "First Name";
            // 
            // fNameTxt
            // 
            this.fNameTxt.Location = new System.Drawing.Point(289, 43);
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.Size = new System.Drawing.Size(212, 22);
            this.fNameTxt.TabIndex = 5;
            this.fNameTxt.TextChanged += new System.EventHandler(this.fNameTxt_TextChanged);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(145, 117);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(60, 17);
            this.email.TabIndex = 6;
            this.email.Text = "Address";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(289, 112);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(212, 22);
            this.addressTxt.TabIndex = 7;
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Location = new System.Drawing.Point(145, 181);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(110, 17);
            this.contact.TabIndex = 8;
            this.contact.Text = "Contact Number";
            // 
            // contactTxt
            // 
            this.contactTxt.Location = new System.Drawing.Point(289, 176);
            this.contactTxt.Name = "contactTxt";
            this.contactTxt.Size = new System.Drawing.Size(212, 22);
            this.contactTxt.TabIndex = 9;
            // 
            // occupation
            // 
            this.occupation.AutoSize = true;
            this.occupation.Location = new System.Drawing.Point(145, 247);
            this.occupation.Name = "occupation";
            this.occupation.Size = new System.Drawing.Size(80, 17);
            this.occupation.TabIndex = 10;
            this.occupation.Text = "Occupation";
            // 
            // occupationTxt
            // 
            this.occupationTxt.Location = new System.Drawing.Point(289, 242);
            this.occupationTxt.Name = "occupationTxt";
            this.occupationTxt.Size = new System.Drawing.Size(212, 22);
            this.occupationTxt.TabIndex = 11;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Tan;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(325, 416);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(176, 34);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save Visitor";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gender";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // genderTxt
            // 
            this.genderTxt.Location = new System.Drawing.Point(289, 302);
            this.genderTxt.Name = "genderTxt";
            this.genderTxt.Size = new System.Drawing.Size(212, 22);
            this.genderTxt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(148, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Entry Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(289, 354);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.genderTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.occupationTxt);
            this.panel1.Controls.Add(this.occupation);
            this.panel1.Controls.Add(this.contactTxt);
            this.panel1.Controls.Add(this.contact);
            this.panel1.Controls.Add(this.addressTxt);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.fNameTxt);
            this.panel1.Controls.Add(this.Name1);
            this.panel1.Location = new System.Drawing.Point(205, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 485);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Visitor Form";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(193, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 71);
            this.label3.TabIndex = 1;
            this.label3.Text = "GORKHA MUSEUM ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1042, 668);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Add Visitor Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.TextBox fNameTxt;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.TextBox contactTxt;
        private System.Windows.Forms.Label occupation;
        private System.Windows.Forms.TextBox occupationTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox genderTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

