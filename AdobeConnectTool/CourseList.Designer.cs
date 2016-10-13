namespace AdobeConnectTool
{
    partial class CourseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseList));
            this.courseListPanel = new System.Windows.Forms.Panel();
            this.courseListHomeBtn = new System.Windows.Forms.Button();
            this.courseListCloseBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ListOfCourses = new System.Windows.Forms.TextBox();
            this.courseListYesBtn = new System.Windows.Forms.Button();
            this.courseListNoBtn = new System.Windows.Forms.Button();
            this.courseListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseListPanel
            // 
            this.courseListPanel.BackColor = System.Drawing.Color.White;
            this.courseListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseListPanel.Controls.Add(this.courseListHomeBtn);
            this.courseListPanel.Controls.Add(this.courseListCloseBtn);
            this.courseListPanel.Location = new System.Drawing.Point(0, 0);
            this.courseListPanel.Name = "courseListPanel";
            this.courseListPanel.Size = new System.Drawing.Size(350, 40);
            this.courseListPanel.TabIndex = 0;
            this.courseListPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.courseListPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.courseListPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // courseListHomeBtn
            // 
            this.courseListHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseListHomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("courseListHomeBtn.Image")));
            this.courseListHomeBtn.Location = new System.Drawing.Point(250, -1);
            this.courseListHomeBtn.Name = "courseListHomeBtn";
            this.courseListHomeBtn.Size = new System.Drawing.Size(50, 41);
            this.courseListHomeBtn.TabIndex = 1;
            this.courseListHomeBtn.UseVisualStyleBackColor = true;
            this.courseListHomeBtn.Click += new System.EventHandler(this.courseListHomeBtn_Click);
            // 
            // courseListCloseBtn
            // 
            this.courseListCloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.courseListCloseBtn.FlatAppearance.BorderSize = 0;
            this.courseListCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseListCloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListCloseBtn.ForeColor = System.Drawing.Color.White;
            this.courseListCloseBtn.Location = new System.Drawing.Point(300, 0);
            this.courseListCloseBtn.Name = "courseListCloseBtn";
            this.courseListCloseBtn.Size = new System.Drawing.Size(50, 40);
            this.courseListCloseBtn.TabIndex = 0;
            this.courseListCloseBtn.Text = "X";
            this.courseListCloseBtn.UseVisualStyleBackColor = false;
            this.courseListCloseBtn.Click += new System.EventHandler(this.courseListCloseBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(28, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(293, 87);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Are the courses you want to create meetings for in the following list?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ListOfCourses
            // 
            this.ListOfCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfCourses.Location = new System.Drawing.Point(28, 153);
            this.ListOfCourses.Multiline = true;
            this.ListOfCourses.Name = "ListOfCourses";
            this.ListOfCourses.ReadOnly = true;
            this.ListOfCourses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListOfCourses.Size = new System.Drawing.Size(293, 400);
            this.ListOfCourses.TabIndex = 2;
            // 
            // courseListYesBtn
            // 
            this.courseListYesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.courseListYesBtn.FlatAppearance.BorderSize = 0;
            this.courseListYesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseListYesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListYesBtn.ForeColor = System.Drawing.Color.White;
            this.courseListYesBtn.Location = new System.Drawing.Point(28, 560);
            this.courseListYesBtn.Name = "courseListYesBtn";
            this.courseListYesBtn.Size = new System.Drawing.Size(143, 55);
            this.courseListYesBtn.TabIndex = 3;
            this.courseListYesBtn.Text = "Yes";
            this.courseListYesBtn.UseVisualStyleBackColor = false;
            this.courseListYesBtn.Click += new System.EventHandler(this.courseListYesBtn_Click);
            // 
            // courseListNoBtn
            // 
            this.courseListNoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.courseListNoBtn.FlatAppearance.BorderSize = 0;
            this.courseListNoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseListNoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListNoBtn.ForeColor = System.Drawing.Color.White;
            this.courseListNoBtn.Location = new System.Drawing.Point(178, 560);
            this.courseListNoBtn.Name = "courseListNoBtn";
            this.courseListNoBtn.Size = new System.Drawing.Size(143, 55);
            this.courseListNoBtn.TabIndex = 4;
            this.courseListNoBtn.Text = "No";
            this.courseListNoBtn.UseVisualStyleBackColor = false;
            this.courseListNoBtn.Click += new System.EventHandler(this.courseListNoBtn_Click);
            // 
            // CourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(350, 643);
            this.Controls.Add(this.courseListNoBtn);
            this.Controls.Add(this.courseListYesBtn);
            this.Controls.Add(this.ListOfCourses);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.courseListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseList";
            this.VisibleChanged += new System.EventHandler(this.CourseList_VisibleChanged);
            this.courseListPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel courseListPanel;
        private System.Windows.Forms.Button courseListCloseBtn;
        private System.Windows.Forms.Button courseListHomeBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ListOfCourses;
        private System.Windows.Forms.Button courseListYesBtn;
        private System.Windows.Forms.Button courseListNoBtn;
    }
}