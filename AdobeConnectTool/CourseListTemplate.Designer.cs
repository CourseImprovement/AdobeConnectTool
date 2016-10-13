namespace AdobeConnectTool
{
    partial class CourseListTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseListTemplate));
            this.CourseListTemplatePanel = new System.Windows.Forms.Panel();
            this.courseListTemplateHomeBtn = new System.Windows.Forms.Button();
            this.courseListTemplateCloseBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.courseListTemplateBackBtn = new System.Windows.Forms.Button();
            this.courseListTemplateDownloadBtn = new System.Windows.Forms.Button();
            this.CourseListTemplatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseListTemplatePanel
            // 
            this.CourseListTemplatePanel.BackColor = System.Drawing.Color.White;
            this.CourseListTemplatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CourseListTemplatePanel.Controls.Add(this.courseListTemplateHomeBtn);
            this.CourseListTemplatePanel.Controls.Add(this.courseListTemplateCloseBtn);
            this.CourseListTemplatePanel.Location = new System.Drawing.Point(0, 0);
            this.CourseListTemplatePanel.Name = "CourseListTemplatePanel";
            this.CourseListTemplatePanel.Size = new System.Drawing.Size(350, 40);
            this.CourseListTemplatePanel.TabIndex = 0;
            this.CourseListTemplatePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.CourseListTemplatePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.CourseListTemplatePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // courseListTemplateHomeBtn
            // 
            this.courseListTemplateHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseListTemplateHomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("courseListTemplateHomeBtn.Image")));
            this.courseListTemplateHomeBtn.Location = new System.Drawing.Point(250, -1);
            this.courseListTemplateHomeBtn.Name = "courseListTemplateHomeBtn";
            this.courseListTemplateHomeBtn.Size = new System.Drawing.Size(50, 41);
            this.courseListTemplateHomeBtn.TabIndex = 1;
            this.courseListTemplateHomeBtn.UseVisualStyleBackColor = true;
            this.courseListTemplateHomeBtn.Click += new System.EventHandler(this.courseListTemplateHomeBtn_Click);
            // 
            // courseListTemplateCloseBtn
            // 
            this.courseListTemplateCloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.courseListTemplateCloseBtn.FlatAppearance.BorderSize = 0;
            this.courseListTemplateCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseListTemplateCloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListTemplateCloseBtn.ForeColor = System.Drawing.Color.White;
            this.courseListTemplateCloseBtn.Location = new System.Drawing.Point(299, 0);
            this.courseListTemplateCloseBtn.Name = "courseListTemplateCloseBtn";
            this.courseListTemplateCloseBtn.Size = new System.Drawing.Size(50, 40);
            this.courseListTemplateCloseBtn.TabIndex = 0;
            this.courseListTemplateCloseBtn.Text = "X";
            this.courseListTemplateCloseBtn.UseVisualStyleBackColor = false;
            this.courseListTemplateCloseBtn.Click += new System.EventHandler(this.courseListTemplateCloseBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(39, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(271, 89);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Download and edit an Excel file that gives an example of replacing the list of co" +
    "urses.";
            // 
            // courseListTemplateBackBtn
            // 
            this.courseListTemplateBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.courseListTemplateBackBtn.FlatAppearance.BorderSize = 0;
            this.courseListTemplateBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseListTemplateBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListTemplateBackBtn.ForeColor = System.Drawing.Color.White;
            this.courseListTemplateBackBtn.Location = new System.Drawing.Point(39, 162);
            this.courseListTemplateBackBtn.Name = "courseListTemplateBackBtn";
            this.courseListTemplateBackBtn.Size = new System.Drawing.Size(126, 46);
            this.courseListTemplateBackBtn.TabIndex = 2;
            this.courseListTemplateBackBtn.Text = "Back";
            this.courseListTemplateBackBtn.UseVisualStyleBackColor = false;
            this.courseListTemplateBackBtn.Click += new System.EventHandler(this.courseListTemplateBackBtn_Click);
            // 
            // courseListTemplateDownloadBtn
            // 
            this.courseListTemplateDownloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.courseListTemplateDownloadBtn.FlatAppearance.BorderSize = 0;
            this.courseListTemplateDownloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseListTemplateDownloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListTemplateDownloadBtn.ForeColor = System.Drawing.Color.White;
            this.courseListTemplateDownloadBtn.Location = new System.Drawing.Point(171, 162);
            this.courseListTemplateDownloadBtn.Name = "courseListTemplateDownloadBtn";
            this.courseListTemplateDownloadBtn.Size = new System.Drawing.Size(128, 46);
            this.courseListTemplateDownloadBtn.TabIndex = 3;
            this.courseListTemplateDownloadBtn.Text = "Download";
            this.courseListTemplateDownloadBtn.UseVisualStyleBackColor = false;
            this.courseListTemplateDownloadBtn.Click += new System.EventHandler(this.courseListTemplateDownloadBtn_Click);
            // 
            // CourseListTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(350, 241);
            this.Controls.Add(this.courseListTemplateDownloadBtn);
            this.Controls.Add(this.courseListTemplateBackBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CourseListTemplatePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseListTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseListTemplate";
            this.CourseListTemplatePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CourseListTemplatePanel;
        private System.Windows.Forms.Button courseListTemplateCloseBtn;
        private System.Windows.Forms.Button courseListTemplateHomeBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button courseListTemplateBackBtn;
        private System.Windows.Forms.Button courseListTemplateDownloadBtn;
    }
}