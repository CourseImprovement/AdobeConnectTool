namespace AdobeConnectTool
{
    partial class ReplaceCourseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceCourseList));
            this.replaceCourseListPanel = new System.Windows.Forms.Panel();
            this.replaceCourseListHomeBtn = new System.Windows.Forms.Button();
            this.replaceCourseListCloseBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.replaceCourseListYesBtn = new System.Windows.Forms.Button();
            this.replaceCourseListNoBtn = new System.Windows.Forms.Button();
            this.replaceCourseListBackBtn = new System.Windows.Forms.Button();
            this.replaceCourseListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // replaceCourseListPanel
            // 
            this.replaceCourseListPanel.BackColor = System.Drawing.Color.White;
            this.replaceCourseListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.replaceCourseListPanel.Controls.Add(this.replaceCourseListHomeBtn);
            this.replaceCourseListPanel.Controls.Add(this.replaceCourseListCloseBtn);
            this.replaceCourseListPanel.Location = new System.Drawing.Point(0, 0);
            this.replaceCourseListPanel.Name = "replaceCourseListPanel";
            this.replaceCourseListPanel.Size = new System.Drawing.Size(350, 40);
            this.replaceCourseListPanel.TabIndex = 0;
            this.replaceCourseListPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.replaceCourseListPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.replaceCourseListPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // replaceCourseListHomeBtn
            // 
            this.replaceCourseListHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replaceCourseListHomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("replaceCourseListHomeBtn.Image")));
            this.replaceCourseListHomeBtn.Location = new System.Drawing.Point(250, -1);
            this.replaceCourseListHomeBtn.Name = "replaceCourseListHomeBtn";
            this.replaceCourseListHomeBtn.Size = new System.Drawing.Size(50, 41);
            this.replaceCourseListHomeBtn.TabIndex = 1;
            this.replaceCourseListHomeBtn.UseVisualStyleBackColor = true;
            this.replaceCourseListHomeBtn.Click += new System.EventHandler(this.replaceCourseListHomeBtn_Click);
            // 
            // replaceCourseListCloseBtn
            // 
            this.replaceCourseListCloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.replaceCourseListCloseBtn.FlatAppearance.BorderSize = 0;
            this.replaceCourseListCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replaceCourseListCloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceCourseListCloseBtn.ForeColor = System.Drawing.Color.White;
            this.replaceCourseListCloseBtn.Location = new System.Drawing.Point(300, 0);
            this.replaceCourseListCloseBtn.Name = "replaceCourseListCloseBtn";
            this.replaceCourseListCloseBtn.Size = new System.Drawing.Size(50, 40);
            this.replaceCourseListCloseBtn.TabIndex = 0;
            this.replaceCourseListCloseBtn.Text = "X";
            this.replaceCourseListCloseBtn.UseVisualStyleBackColor = false;
            this.replaceCourseListCloseBtn.Click += new System.EventHandler(this.replaceCourseListCloseBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(326, 107);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Do you have an Excel file to replace the current list of courses? This file will " +
    "have the following columns: \r\nCourse Name | Number of Meetings";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // replaceCourseListYesBtn
            // 
            this.replaceCourseListYesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.replaceCourseListYesBtn.FlatAppearance.BorderSize = 0;
            this.replaceCourseListYesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replaceCourseListYesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceCourseListYesBtn.ForeColor = System.Drawing.Color.White;
            this.replaceCourseListYesBtn.Location = new System.Drawing.Point(12, 173);
            this.replaceCourseListYesBtn.Name = "replaceCourseListYesBtn";
            this.replaceCourseListYesBtn.Size = new System.Drawing.Size(105, 45);
            this.replaceCourseListYesBtn.TabIndex = 2;
            this.replaceCourseListYesBtn.Text = "Yes";
            this.replaceCourseListYesBtn.UseVisualStyleBackColor = false;
            this.replaceCourseListYesBtn.Click += new System.EventHandler(this.replaceCourseListYesBtn_Click);
            // 
            // replaceCourseListNoBtn
            // 
            this.replaceCourseListNoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.replaceCourseListNoBtn.FlatAppearance.BorderSize = 0;
            this.replaceCourseListNoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replaceCourseListNoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceCourseListNoBtn.ForeColor = System.Drawing.Color.White;
            this.replaceCourseListNoBtn.Location = new System.Drawing.Point(123, 173);
            this.replaceCourseListNoBtn.Name = "replaceCourseListNoBtn";
            this.replaceCourseListNoBtn.Size = new System.Drawing.Size(104, 45);
            this.replaceCourseListNoBtn.TabIndex = 3;
            this.replaceCourseListNoBtn.Text = "No";
            this.replaceCourseListNoBtn.UseVisualStyleBackColor = false;
            this.replaceCourseListNoBtn.Click += new System.EventHandler(this.replaceCourseListNoBtn_Click);
            // 
            // replaceCourseListBackBtn
            // 
            this.replaceCourseListBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.replaceCourseListBackBtn.FlatAppearance.BorderSize = 0;
            this.replaceCourseListBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replaceCourseListBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceCourseListBackBtn.ForeColor = System.Drawing.Color.White;
            this.replaceCourseListBackBtn.Location = new System.Drawing.Point(233, 173);
            this.replaceCourseListBackBtn.Name = "replaceCourseListBackBtn";
            this.replaceCourseListBackBtn.Size = new System.Drawing.Size(105, 45);
            this.replaceCourseListBackBtn.TabIndex = 4;
            this.replaceCourseListBackBtn.Text = "Back";
            this.replaceCourseListBackBtn.UseVisualStyleBackColor = false;
            this.replaceCourseListBackBtn.Click += new System.EventHandler(this.replaceCourseListBackBtn_Click);
            // 
            // ReplaceCourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(350, 240);
            this.Controls.Add(this.replaceCourseListBackBtn);
            this.Controls.Add(this.replaceCourseListNoBtn);
            this.Controls.Add(this.replaceCourseListYesBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.replaceCourseListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReplaceCourseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReplaceCourseList";
            this.replaceCourseListPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel replaceCourseListPanel;
        private System.Windows.Forms.Button replaceCourseListCloseBtn;
        private System.Windows.Forms.Button replaceCourseListHomeBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button replaceCourseListYesBtn;
        private System.Windows.Forms.Button replaceCourseListNoBtn;
        private System.Windows.Forms.Button replaceCourseListBackBtn;
    }
}