namespace AdoDotNetProject_Ashraful
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnBookInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(55, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(342, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome To Book Store Management";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(178, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAuthor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAuthor.Location = new System.Drawing.Point(55, 136);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(164, 39);
            this.btnAuthor.TabIndex = 2;
            this.btnAuthor.Text = "Author Information";
            this.btnAuthor.UseVisualStyleBackColor = false;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnBookInformation
            // 
            this.btnBookInformation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBookInformation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBookInformation.Location = new System.Drawing.Point(228, 136);
            this.btnBookInformation.Name = "btnBookInformation";
            this.btnBookInformation.Size = new System.Drawing.Size(164, 39);
            this.btnBookInformation.TabIndex = 3;
            this.btnBookInformation.Text = "Book Information";
            this.btnBookInformation.UseVisualStyleBackColor = false;
            this.btnBookInformation.Click += new System.EventHandler(this.btnBookInformation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 324);
            this.Controls.Add(this.btnBookInformation);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnBookInformation;
    }
}

