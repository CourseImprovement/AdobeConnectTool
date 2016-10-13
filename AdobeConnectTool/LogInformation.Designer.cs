namespace AdobeConnectTool
{
    partial class LogInformation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.logInformationDownloadBtn = new System.Windows.Forms.Button();
            this.logInformationContinueBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(549, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(13, 47);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(575, 379);
            this.treeView1.TabIndex = 1;
            // 
            // logInformationDownloadBtn
            // 
            this.logInformationDownloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.logInformationDownloadBtn.FlatAppearance.BorderSize = 0;
            this.logInformationDownloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInformationDownloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInformationDownloadBtn.ForeColor = System.Drawing.Color.White;
            this.logInformationDownloadBtn.Location = new System.Drawing.Point(251, 432);
            this.logInformationDownloadBtn.Name = "logInformationDownloadBtn";
            this.logInformationDownloadBtn.Size = new System.Drawing.Size(171, 45);
            this.logInformationDownloadBtn.TabIndex = 3;
            this.logInformationDownloadBtn.Text = "Save to Desktop";
            this.logInformationDownloadBtn.UseVisualStyleBackColor = false;
            this.logInformationDownloadBtn.Click += new System.EventHandler(this.logInformationDownloadBtn_Click);
            // 
            // logInformationContinueBtn
            // 
            this.logInformationContinueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(131)))), ((int)(((byte)(221)))));
            this.logInformationContinueBtn.FlatAppearance.BorderSize = 0;
            this.logInformationContinueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInformationContinueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInformationContinueBtn.ForeColor = System.Drawing.Color.White;
            this.logInformationContinueBtn.Location = new System.Drawing.Point(428, 432);
            this.logInformationContinueBtn.Name = "logInformationContinueBtn";
            this.logInformationContinueBtn.Size = new System.Drawing.Size(160, 45);
            this.logInformationContinueBtn.TabIndex = 4;
            this.logInformationContinueBtn.Text = "Continue";
            this.logInformationContinueBtn.UseVisualStyleBackColor = false;
            this.logInformationContinueBtn.Click += new System.EventHandler(this.logInformationContinueBtn_Click);
            // 
            // LogInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(600, 486);
            this.Controls.Add(this.logInformationContinueBtn);
            this.Controls.Add(this.logInformationDownloadBtn);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInformation";
            this.Text = "LogInformation";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button logInformationDownloadBtn;
        private System.Windows.Forms.Button logInformationContinueBtn;
    }
}