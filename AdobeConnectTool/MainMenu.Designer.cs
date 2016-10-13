namespace AdobeConnectTool
{
    partial class MainMenu
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
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.mainMenuCloseBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.createMeetingsBtn = new System.Windows.Forms.Button();
            this.createOfficesBtn = new System.Windows.Forms.Button();
            this.mainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BackColor = System.Drawing.Color.White;
            this.mainMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainMenuPanel.Controls.Add(this.mainMenuCloseBtn);
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(350, 40);
            this.mainMenuPanel.TabIndex = 0;
            this.mainMenuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.mainMenuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.mainMenuPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // mainMenuCloseBtn
            // 
            this.mainMenuCloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.mainMenuCloseBtn.FlatAppearance.BorderSize = 0;
            this.mainMenuCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuCloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuCloseBtn.ForeColor = System.Drawing.Color.White;
            this.mainMenuCloseBtn.Location = new System.Drawing.Point(300, 0);
            this.mainMenuCloseBtn.Name = "mainMenuCloseBtn";
            this.mainMenuCloseBtn.Size = new System.Drawing.Size(50, 40);
            this.mainMenuCloseBtn.TabIndex = 0;
            this.mainMenuCloseBtn.Text = "X";
            this.mainMenuCloseBtn.UseVisualStyleBackColor = false;
            this.mainMenuCloseBtn.Click += new System.EventHandler(this.mainMenuCloseBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(32, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(279, 58);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "What process will you be \r\ncompleting today?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // createMeetingsBtn
            // 
            this.createMeetingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.createMeetingsBtn.FlatAppearance.BorderSize = 0;
            this.createMeetingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMeetingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMeetingsBtn.ForeColor = System.Drawing.Color.White;
            this.createMeetingsBtn.Location = new System.Drawing.Point(32, 135);
            this.createMeetingsBtn.Name = "createMeetingsBtn";
            this.createMeetingsBtn.Size = new System.Drawing.Size(279, 70);
            this.createMeetingsBtn.TabIndex = 2;
            this.createMeetingsBtn.Text = "Create Meetings for Sections in Courses";
            this.createMeetingsBtn.UseVisualStyleBackColor = false;
            this.createMeetingsBtn.Click += new System.EventHandler(this.createMeetingsBtn_Click);
            // 
            // createOfficesBtn
            // 
            this.createOfficesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.createOfficesBtn.FlatAppearance.BorderSize = 0;
            this.createOfficesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createOfficesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createOfficesBtn.ForeColor = System.Drawing.Color.White;
            this.createOfficesBtn.Location = new System.Drawing.Point(32, 210);
            this.createOfficesBtn.Name = "createOfficesBtn";
            this.createOfficesBtn.Size = new System.Drawing.Size(279, 70);
            this.createOfficesBtn.TabIndex = 3;
            this.createOfficesBtn.Text = "Create Accounts and Offices for New Instructors";
            this.createOfficesBtn.UseVisualStyleBackColor = false;
            this.createOfficesBtn.Click += new System.EventHandler(this.createOfficesBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(350, 301);
            this.Controls.Add(this.createOfficesBtn);
            this.Controls.Add(this.createMeetingsBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mainMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.mainMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Button mainMenuCloseBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button createMeetingsBtn;
        private System.Windows.Forms.Button createOfficesBtn;
    }
}