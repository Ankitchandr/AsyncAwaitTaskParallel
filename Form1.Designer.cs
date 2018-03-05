namespace AsyncAwait1
{
    partial class Form1
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
            this.btnProcessesFile = new System.Windows.Forms.Button();
            this.lblcount = new System.Windows.Forms.Label();
            this.labmess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcessesFile
            // 
            this.btnProcessesFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessesFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnProcessesFile.Location = new System.Drawing.Point(72, 66);
            this.btnProcessesFile.Name = "btnProcessesFile";
            this.btnProcessesFile.Size = new System.Drawing.Size(145, 37);
            this.btnProcessesFile.TabIndex = 0;
            this.btnProcessesFile.Text = "processes File";
            this.btnProcessesFile.UseVisualStyleBackColor = true;
            this.btnProcessesFile.Click += new System.EventHandler(this.btnProcessesFile_Click);
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Location = new System.Drawing.Point(56, 104);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(0, 13);
            this.lblcount.TabIndex = 1;
            // 
            // labmess
            // 
            this.labmess.AutoSize = true;
            this.labmess.Location = new System.Drawing.Point(20, 43);
            this.labmess.Name = "labmess";
            this.labmess.Size = new System.Drawing.Size(0, 13);
            this.labmess.TabIndex = 2;
            this.labmess.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(319, 261);
            this.Controls.Add(this.labmess);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.btnProcessesFile);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.btnProcessesFile_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcessesFile;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Label labmess;
    }
}

