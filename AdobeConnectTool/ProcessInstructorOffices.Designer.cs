namespace AdobeConnectTool
{
    partial class ProcessInstructorOffices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessInstructorOffices));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.processInstructorOfficesBackBtn = new System.Windows.Forms.Button();
            this.processInstructorOfficesStartBtn = new System.Windows.Forms.Button();
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
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(25, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(297, 73);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Click the open button to upload your Excel file to add the instructor offices.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // processInstructorOfficesBackBtn
            // 
            this.processInstructorOfficesBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.processInstructorOfficesBackBtn.FlatAppearance.BorderSize = 0;
            this.processInstructorOfficesBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processInstructorOfficesBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processInstructorOfficesBackBtn.ForeColor = System.Drawing.Color.White;
            this.processInstructorOfficesBackBtn.Location = new System.Drawing.Point(25, 156);
            this.processInstructorOfficesBackBtn.Name = "processInstructorOfficesBackBtn";
            this.processInstructorOfficesBackBtn.Size = new System.Drawing.Size(149, 46);
            this.processInstructorOfficesBackBtn.TabIndex = 2;
            this.processInstructorOfficesBackBtn.Text = "Back";
            this.processInstructorOfficesBackBtn.UseVisualStyleBackColor = false;
            this.processInstructorOfficesBackBtn.Click += new System.EventHandler(this.processInstructorOfficesBackBtn_Click);
            // 
            // processInstructorOfficesStartBtn
            // 
            this.processInstructorOfficesStartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.processInstructorOfficesStartBtn.FlatAppearance.BorderSize = 0;
            this.processInstructorOfficesStartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processInstructorOfficesStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processInstructorOfficesStartBtn.ForeColor = System.Drawing.Color.White;
            this.processInstructorOfficesStartBtn.Location = new System.Drawing.Point(180, 156);
            this.processInstructorOfficesStartBtn.Name = "processInstructorOfficesStartBtn";
            this.processInstructorOfficesStartBtn.Size = new System.Drawing.Size(142, 46);
            this.processInstructorOfficesStartBtn.TabIndex = 4;
            this.processInstructorOfficesStartBtn.Text = "Open";
            this.processInstructorOfficesStartBtn.UseVisualStyleBackColor = false;
            this.processInstructorOfficesStartBtn.Click += new System.EventHandler(this.processInstructorOfficesStartBtn_Click);
            // 
            // ProcessInstructorOffices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(350, 231);
            this.Controls.Add(this.processInstructorOfficesStartBtn);
            this.Controls.Add(this.processInstructorOfficesBackBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessInstructorOffices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcessInstructorOffices";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button processInstructorOfficesBackBtn;
        private System.Windows.Forms.Button processInstructorOfficesStartBtn;
    }
}