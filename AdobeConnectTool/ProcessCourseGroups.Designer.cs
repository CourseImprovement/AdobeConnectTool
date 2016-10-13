namespace AdobeConnectTool
{
    partial class ProcessCourseGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessCourseGroups));
            this.processCourseGroupsPanel = new System.Windows.Forms.Panel();
            this.processCourseGroupsHomeBtn = new System.Windows.Forms.Button();
            this.processCourseGroupsCloseBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.processCourseGroupsBackBtn = new System.Windows.Forms.Button();
            this.processCourseGroupsStartBtn = new System.Windows.Forms.Button();
            this.processCourseGroupsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // processCourseGroupsPanel
            // 
            this.processCourseGroupsPanel.BackColor = System.Drawing.Color.White;
            this.processCourseGroupsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processCourseGroupsPanel.Controls.Add(this.processCourseGroupsHomeBtn);
            this.processCourseGroupsPanel.Controls.Add(this.processCourseGroupsCloseBtn);
            this.processCourseGroupsPanel.Location = new System.Drawing.Point(0, 0);
            this.processCourseGroupsPanel.Name = "processCourseGroupsPanel";
            this.processCourseGroupsPanel.Size = new System.Drawing.Size(350, 40);
            this.processCourseGroupsPanel.TabIndex = 0;
            this.processCourseGroupsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.processCourseGroupsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.processCourseGroupsPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // processCourseGroupsHomeBtn
            // 
            this.processCourseGroupsHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processCourseGroupsHomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("processCourseGroupsHomeBtn.Image")));
            this.processCourseGroupsHomeBtn.Location = new System.Drawing.Point(250, -1);
            this.processCourseGroupsHomeBtn.Name = "processCourseGroupsHomeBtn";
            this.processCourseGroupsHomeBtn.Size = new System.Drawing.Size(50, 41);
            this.processCourseGroupsHomeBtn.TabIndex = 1;
            this.processCourseGroupsHomeBtn.UseVisualStyleBackColor = true;
            this.processCourseGroupsHomeBtn.Click += new System.EventHandler(this.processCourseGroupsHomeBtn_Click);
            // 
            // processCourseGroupsCloseBtn
            // 
            this.processCourseGroupsCloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.processCourseGroupsCloseBtn.FlatAppearance.BorderSize = 0;
            this.processCourseGroupsCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processCourseGroupsCloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processCourseGroupsCloseBtn.ForeColor = System.Drawing.Color.White;
            this.processCourseGroupsCloseBtn.Location = new System.Drawing.Point(300, 0);
            this.processCourseGroupsCloseBtn.Name = "processCourseGroupsCloseBtn";
            this.processCourseGroupsCloseBtn.Size = new System.Drawing.Size(50, 40);
            this.processCourseGroupsCloseBtn.TabIndex = 0;
            this.processCourseGroupsCloseBtn.Text = "X";
            this.processCourseGroupsCloseBtn.UseVisualStyleBackColor = false;
            this.processCourseGroupsCloseBtn.Click += new System.EventHandler(this.processCourseGroupsCloseBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(26, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(296, 102);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Click the open button to upload your excel file which will create meetings in the" +
    " sections and courses chosen.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // processCourseGroupsBackBtn
            // 
            this.processCourseGroupsBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.processCourseGroupsBackBtn.FlatAppearance.BorderSize = 0;
            this.processCourseGroupsBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processCourseGroupsBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processCourseGroupsBackBtn.ForeColor = System.Drawing.Color.White;
            this.processCourseGroupsBackBtn.Location = new System.Drawing.Point(26, 187);
            this.processCourseGroupsBackBtn.Name = "processCourseGroupsBackBtn";
            this.processCourseGroupsBackBtn.Size = new System.Drawing.Size(145, 40);
            this.processCourseGroupsBackBtn.TabIndex = 2;
            this.processCourseGroupsBackBtn.Text = "Back";
            this.processCourseGroupsBackBtn.UseVisualStyleBackColor = false;
            this.processCourseGroupsBackBtn.Click += new System.EventHandler(this.processCourseGroupsBackBtn_Click);
            // 
            // processCourseGroupsStartBtn
            // 
            this.processCourseGroupsStartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.processCourseGroupsStartBtn.FlatAppearance.BorderSize = 0;
            this.processCourseGroupsStartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processCourseGroupsStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processCourseGroupsStartBtn.ForeColor = System.Drawing.Color.White;
            this.processCourseGroupsStartBtn.Location = new System.Drawing.Point(177, 187);
            this.processCourseGroupsStartBtn.Name = "processCourseGroupsStartBtn";
            this.processCourseGroupsStartBtn.Size = new System.Drawing.Size(145, 40);
            this.processCourseGroupsStartBtn.TabIndex = 3;
            this.processCourseGroupsStartBtn.Text = "Open";
            this.processCourseGroupsStartBtn.UseVisualStyleBackColor = false;
            this.processCourseGroupsStartBtn.Click += new System.EventHandler(this.processCourseGroupsStartBtn_Click);
            // 
            // ProcessCourseGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(350, 260);
            this.Controls.Add(this.processCourseGroupsStartBtn);
            this.Controls.Add(this.processCourseGroupsBackBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.processCourseGroupsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessCourseGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcessCourseGroups";
            this.processCourseGroupsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel processCourseGroupsPanel;
        private System.Windows.Forms.Button processCourseGroupsCloseBtn;
        private System.Windows.Forms.Button processCourseGroupsHomeBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button processCourseGroupsBackBtn;
        private System.Windows.Forms.Button processCourseGroupsStartBtn;
    }
}