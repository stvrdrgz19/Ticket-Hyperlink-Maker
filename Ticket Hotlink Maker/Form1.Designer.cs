namespace Ticket_Hotlink_Maker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbText);
            this.groupBox1.Controls.Add(this.btnProcess);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text To Process";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(7, 20);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(553, 148);
            this.tbText.TabIndex = 0;
            // 
            // btnProcess
            // 
            this.btnProcess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProcess.Location = new System.Drawing.Point(7, 174);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(553, 23);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbResult);
            this.groupBox2.Controls.Add(this.btnCopy);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(4, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(7, 19);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(553, 148);
            this.tbResult.TabIndex = 2;
            // 
            // btnCopy
            // 
            this.btnCopy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCopy.Location = new System.Drawing.Point(7, 173);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(553, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ticket Hyperlink Maker (THM)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnCopy;
    }
}

