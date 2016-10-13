namespace AdobeConnectTool
{
    partial class CourseGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseGroups));
            this.courseGroupsPanel = new System.Windows.Forms.Panel();
            this.courseGroupsHomeBtn = new System.Windows.Forms.Button();
            this.courseGroupsCloseBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.courseGroupsYesBtn = new System.Windows.Forms.Button();
            this.courseGroupsNoBtn = new System.Windows.Forms.Button();
            this.courseGroupsBackBtn = new System.Windows.Forms.Button();
            this.courseGroupsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseGroupsPanel
            // 
            this.courseGroupsPanel.BackColor = System.Drawing.Color.White;
            this.courseGroupsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseGroupsPanel.Controls.Add(this.courseGroupsHomeBtn);
            this.courseGroupsPanel.Controls.Add(this.courseGroupsCloseBtn);
            this.courseGroupsPanel.Location = new System.Drawing.Point(0, 0);
            this.courseGroupsPanel.Name = "courseGroupsPanel";
            this.courseGroupsPanel.Size = new System.Drawing.Size(350, 40);
            this.courseGroupsPanel.TabIndex = 0;
            this.courseGroupsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.courseGroupsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.courseGroupsPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // courseGroupsHomeBtn
            // 
            this.courseGroupsHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseGroupsHomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("courseGroupsHomeBtn.Image")));
            this.courseGroupsHomeBtn.Location = new System.Drawing.Point(250, -1);
            this.courseGroupsHomeBtn.Name = "courseGroupsHomeBtn";
            this.courseGroupsHomeBtn.Size = new System.Drawing.Size(50, 41);
            this.courseGroupsHomeBtn.TabIndex = 1;
            this.courseGroupsHomeBtn.UseVisualStyleBackColor = true;
            this.courseGroupsHomeBtn.Click += new System.EventHandler(this.courseGroupsHomeBtn_Click);
            // 
            // courseGroupsCloseBtn
            // 
            this.courseGroupsCloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.courseGroupsCloseBtn.FlatAppearance.BorderSize = 0;
            this.courseGroupsCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseGroupsCloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseGroupsCloseBtn.ForeColor = System.Drawing.Color.White;
            this.courseGroupsCloseBtn.Location = new System.Drawing.Point(300, 0);
            this.courseGroupsCloseBtn.Name = "courseGroupsCloseBtn";
            this.courseGroupsCloseBtn.Size = new System.Drawing.Size(50, 40);
            this.courseGroupsCloseBtn.TabIndex = 0;
            this.courseGroupsCloseBtn.Text = "X";
            this.courseGroupsCloseBtn.UseVisualStyleBackColor = false;
            this.courseGroupsCloseBtn.Click += new System.EventHandler(this.courseGroupsCloseBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(326, 114);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // courseGroupsYesBtn
            // 
            this.courseGroupsYesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.courseGroupsYesBtn.FlatAppearance.BorderSize = 0;
            this.courseGroupsYesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseGroupsYesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseGroupsYesBtn.ForeColor = System.Drawing.Color.White;
            this.courseGroupsYesBtn.Location = new System.Drawing.Point(12, 167);
            this.courseGroupsYesBtn.Name = "courseGroupsYesBtn";
            this.courseGroupsYesBtn.Size = new System.Drawing.Size(104, 40);
            this.courseGroupsYesBtn.TabIndex = 2;
            this.courseGroupsYesBtn.Text = "Yes";
            this.courseGroupsYesBtn.UseVisualStyleBackColor = false;
            this.courseGroupsYesBtn.Click += new System.EventHandler(this.courseGroupsYesBtn_Click);
            // 
            // courseGroupsNoBtn
            // 
            this.courseGroupsNoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.courseGroupsNoBtn.FlatAppearance.BorderSize = 0;
            this.courseGroupsNoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseGroupsNoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseGroupsNoBtn.ForeColor = System.Drawing.Color.White;
            this.courseGroupsNoBtn.Location = new System.Drawing.Point(122, 167);
            this.courseGroupsNoBtn.Name = "courseGroupsNoBtn";
            this.courseGroupsNoBtn.Size = new System.Drawing.Size(104, 40);
            this.courseGroupsNoBtn.TabIndex = 3;
            this.courseGroupsNoBtn.Text = "No";
            this.courseGroupsNoBtn.UseVisualStyleBackColor = false;
            this.courseGroupsNoBtn.Click += new System.EventHandler(this.courseGroupsNoBtn_Click);
            // 
            // courseGroupsBackBtn
            // 
            this.courseGroupsBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.courseGroupsBackBtn.FlatAppearance.BorderSize = 0;
            this.courseGroupsBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseGroupsBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseGroupsBackBtn.ForeColor = System.Drawing.Color.White;
            this.courseGroupsBackBtn.Location = new System.Drawing.Point(232, 167);
            this.courseGroupsBackBtn.Name = "courseGroupsBackBtn";
            this.courseGroupsBackBtn.Size = new System.Drawing.Size(104, 40);
            this.courseGroupsBackBtn.TabIndex = 4;
            this.courseGroupsBackBtn.Text = "Back";
            this.courseGroupsBackBtn.UseVisualStyleBackColor = false;
            this.courseGroupsBackBtn.Click += new System.EventHandler(this.courseGroupsBackBtn_Click);
            // 
            // CourseGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(350, 238);
            this.Controls.Add(this.courseGroupsBackBtn);
            this.Controls.Add(this.courseGroupsNoBtn);
            this.Controls.Add(this.courseGroupsYesBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.courseGroupsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseGroups";
            this.courseGroupsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel courseGroupsPanel;
        private System.Windows.Forms.Button courseGroupsHomeBtn;
        private System.Windows.Forms.Button courseGroupsCloseBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button courseGroupsYesBtn;
        private System.Windows.Forms.Button courseGroupsNoBtn;
        private System.Windows.Forms.Button courseGroupsBackBtn;
    }
}