namespace AdobeConnectTool
{
    partial class Process
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
            this.processPanel = new System.Windows.Forms.Panel();
            this.processCloseBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.processPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // processPanel
            // 
            this.processPanel.BackColor = System.Drawing.Color.White;
            this.processPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processPanel.Controls.Add(this.processCloseBtn);
            this.processPanel.Location = new System.Drawing.Point(0, 0);
            this.processPanel.Name = "processPanel";
            this.processPanel.Size = new System.Drawing.Size(350, 40);
            this.processPanel.TabIndex = 0;
            this.processPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.processPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.processPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // processCloseBtn
            // 
            this.processCloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
            this.processCloseBtn.FlatAppearance.BorderSize = 0;
            this.processCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processCloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processCloseBtn.ForeColor = System.Drawing.Color.White;
            this.processCloseBtn.Location = new System.Drawing.Point(300, 0);
            this.processCloseBtn.Name = "processCloseBtn";
            this.processCloseBtn.Size = new System.Drawing.Size(50, 40);
            this.processCloseBtn.TabIndex = 0;
            this.processCloseBtn.Text = "X";
            this.processCloseBtn.UseVisualStyleBackColor = false;
            this.processCloseBtn.Click += new System.EventHandler(this.processCloseBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(34, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(280, 88);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Please wait while your information is being added to Adobe Connect.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(34, 165);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(280, 23);
            this.progressBar.TabIndex = 2;
            // 
            // Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(350, 214);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.processPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Process";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process";
            this.processPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel processPanel;
        private System.Windows.Forms.Button processCloseBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}