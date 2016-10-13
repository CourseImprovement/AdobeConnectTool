namespace AdobeConnectTool
{
    partial class ProcessCourseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessCourseList));
            this.processCourseListPanel = new System.Windows.Forms.Panel();
            this.processCoruseListHomeBtn = new System.Windows.Forms.Button();
            this.processCourseListCloseBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.processCourseListBackBtn = new System.Windows.Forms.Button();
            this.processCourseListStartBtn = new System.Windows.Forms.Button();
            this.processCourseListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // processCourseListPanel
            // 
            this.processCourseListPanel.BackColor = System.Drawing.Color.White;
            this.processCourseListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processCourseListPanel.Controls.Add(this.processCoruseListHomeBtn);
            this.processCourseListPanel.Controls.Add(this.processCourseListCloseBtn);
            this.processCourseListPanel.Location = new System.Drawing.Point(0, 0);
            this.processCourseListPanel.Name = "processCourseListPanel";
            this.processCourseListPanel.Size = new System.Drawing.Size(350, 40);
            this.processCourseListPanel.TabIndex = 0;
            this.processCourseListPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.processCourseListPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.processCourseListPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // processCoruseListHomeBtn
            // 
            this.processCoruseListHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processCoruseListHomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("processCoruseListHomeBtn.Image")));
            this.processCoruseListHomeBtn.Location = new System.Drawing.Point(250, -1);
            this.processCoruseListHomeBtn.Name = "processCoruseListHomeBtn";
            this.processCoruseListHomeBtn.Size = new System.Drawing.Size(50, 41);
            this.processCoruseListHomeBtn.TabIndex = 1;
            this.processCoruseListHomeBtn.UseVisualStyleBackColor = true;
            this.processCoruseListHomeBtn.Click += new System.EventHandler(this.processCoruseListHomeBtn_Click);
            // 
            // processCourseListCloseBtn
            // 
            this.processCourseListCloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.processCourseListCloseBtn.FlatAppearance.BorderSize = 0;
            this.processCourseListCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processCourseListCloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processCourseListCloseBtn.ForeColor = System.Drawing.Color.White;
            this.processCourseListCloseBtn.Location = new System.Drawing.Point(300, 0);
            this.processCourseListCloseBtn.Name = "processCourseListCloseBtn";
            this.processCourseListCloseBtn.Size = new System.Drawing.Size(50, 40);
            this.processCourseListCloseBtn.TabIndex = 0;
            this.processCourseListCloseBtn.Text = "X";
            this.processCourseListCloseBtn.UseVisualStyleBackColor = false;
            this.processCourseListCloseBtn.Click += new System.EventHandler(this.processCourseListCloseBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(23, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(303, 90);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Click the open button to upload your course list Excel file and then wait for the" +
    " changes to complete.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // processCourseListBackBtn
            // 
            this.processCourseListBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.processCourseListBackBtn.FlatAppearance.BorderSize = 0;
            this.processCourseListBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processCourseListBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processCourseListBackBtn.ForeColor = System.Drawing.Color.White;
            this.processCourseListBackBtn.Location = new System.Drawing.Point(23, 164);
            this.processCourseListBackBtn.Name = "processCourseListBackBtn";
            this.processCourseListBackBtn.Size = new System.Drawing.Size(148, 46);
            this.processCourseListBackBtn.TabIndex = 2;
            this.processCourseListBackBtn.Text = "Back";
            this.processCourseListBackBtn.UseVisualStyleBackColor = false;
            this.processCourseListBackBtn.Click += new System.EventHandler(this.processCourseListBackBtn_Click);
            // 
            // processCourseListStartBtn
            // 
            this.processCourseListStartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.processCourseListStartBtn.FlatAppearance.BorderSize = 0;
            this.processCourseListStartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processCourseListStartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processCourseListStartBtn.ForeColor = System.Drawing.Color.White;
            this.processCourseListStartBtn.Location = new System.Drawing.Point(177, 164);
            this.processCourseListStartBtn.Name = "processCourseListStartBtn";
            this.processCourseListStartBtn.Size = new System.Drawing.Size(149, 46);
            this.processCourseListStartBtn.TabIndex = 3;
            this.processCourseListStartBtn.Text = "Open";
            this.processCourseListStartBtn.UseVisualStyleBackColor = false;
            this.processCourseListStartBtn.Click += new System.EventHandler(this.processCourseListStartBtn_Click);
            // 
            // ProcessCourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(350, 244);
            this.Controls.Add(this.processCourseListStartBtn);
            this.Controls.Add(this.processCourseListBackBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.processCourseListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessCourseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcessCourseList";
            this.processCourseListPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel processCourseListPanel;
        private System.Windows.Forms.Button processCourseListCloseBtn;
        private System.Windows.Forms.Button processCoruseListHomeBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button processCourseListBackBtn;
        private System.Windows.Forms.Button processCourseListStartBtn;
    }
}