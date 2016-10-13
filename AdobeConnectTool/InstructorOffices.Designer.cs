namespace AdobeConnectTool
{
    partial class InstructorOffices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorOffices));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.instructorOfficesNoBtn = new System.Windows.Forms.Button();
            this.instructorOfficesYesBtn = new System.Windows.Forms.Button();
            this.instructorOfficesBackBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(250, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 40);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(299, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(13, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(325, 106);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Do you have an Excel file for creating instructor offices? This file should have " +
    "the following columns: \r\nFirst Name | Last Name | Email";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // instructorOfficesNoBtn
            // 
            this.instructorOfficesNoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.instructorOfficesNoBtn.FlatAppearance.BorderSize = 0;
            this.instructorOfficesNoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructorOfficesNoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorOfficesNoBtn.ForeColor = System.Drawing.Color.White;
            this.instructorOfficesNoBtn.Location = new System.Drawing.Point(131, 158);
            this.instructorOfficesNoBtn.Name = "instructorOfficesNoBtn";
            this.instructorOfficesNoBtn.Size = new System.Drawing.Size(100, 40);
            this.instructorOfficesNoBtn.TabIndex = 7;
            this.instructorOfficesNoBtn.Text = "No";
            this.instructorOfficesNoBtn.UseVisualStyleBackColor = false;
            this.instructorOfficesNoBtn.Click += new System.EventHandler(this.instructorOfficesNoBtn_Click);
            // 
            // instructorOfficesYesBtn
            // 
            this.instructorOfficesYesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.instructorOfficesYesBtn.FlatAppearance.BorderSize = 0;
            this.instructorOfficesYesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructorOfficesYesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorOfficesYesBtn.ForeColor = System.Drawing.Color.White;
            this.instructorOfficesYesBtn.Location = new System.Drawing.Point(12, 158);
            this.instructorOfficesYesBtn.Name = "instructorOfficesYesBtn";
            this.instructorOfficesYesBtn.Size = new System.Drawing.Size(113, 40);
            this.instructorOfficesYesBtn.TabIndex = 6;
            this.instructorOfficesYesBtn.Text = "Yes";
            this.instructorOfficesYesBtn.UseVisualStyleBackColor = false;
            this.instructorOfficesYesBtn.Click += new System.EventHandler(this.instructorOfficesYesBtn_Click);
            // 
            // instructorOfficesBackBtn
            // 
            this.instructorOfficesBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.instructorOfficesBackBtn.FlatAppearance.BorderSize = 0;
            this.instructorOfficesBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructorOfficesBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorOfficesBackBtn.ForeColor = System.Drawing.Color.White;
            this.instructorOfficesBackBtn.Location = new System.Drawing.Point(238, 158);
            this.instructorOfficesBackBtn.Name = "instructorOfficesBackBtn";
            this.instructorOfficesBackBtn.Size = new System.Drawing.Size(100, 40);
            this.instructorOfficesBackBtn.TabIndex = 5;
            this.instructorOfficesBackBtn.Text = "Back";
            this.instructorOfficesBackBtn.UseVisualStyleBackColor = false;
            this.instructorOfficesBackBtn.Click += new System.EventHandler(this.instructorOfficesBackBtn_Click);
            // 
            // InstructorOffices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(350, 231);
            this.Controls.Add(this.instructorOfficesNoBtn);
            this.Controls.Add(this.instructorOfficesYesBtn);
            this.Controls.Add(this.instructorOfficesBackBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstructorOffices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstructorOffices";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button instructorOfficesNoBtn;
        private System.Windows.Forms.Button instructorOfficesYesBtn;
        private System.Windows.Forms.Button instructorOfficesBackBtn;
    }
}