namespace AdoDotNetProject_Ashraful
{
    partial class BookInformation
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
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookPublication = new System.Windows.Forms.TextBox();
            this.lblPublication = new System.Windows.Forms.Label();
            this.lblBookAuthorId = new System.Windows.Forms.Label();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.txtBookEdition = new System.Windows.Forms.TextBox();
            this.lblEdition = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelOp = new System.Windows.Forms.Button();
            this.dgViewBookInfo = new System.Windows.Forms.DataGridView();
            this.cmBoxAuthorID = new System.Windows.Forms.ComboBox();
            this.lblBid = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewBookInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(77, 38);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(63, 13);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Book Name";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(164, 32);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(190, 25);
            this.txtBookName.TabIndex = 1;
            // 
            // txtBookPublication
            // 
            this.txtBookPublication.Location = new System.Drawing.Point(519, 32);
            this.txtBookPublication.Multiline = true;
            this.txtBookPublication.Name = "txtBookPublication";
            this.txtBookPublication.Size = new System.Drawing.Size(190, 25);
            this.txtBookPublication.TabIndex = 3;
            // 
            // lblPublication
            // 
            this.lblPublication.AutoSize = true;
            this.lblPublication.Location = new System.Drawing.Point(432, 38);
            this.lblPublication.Name = "lblPublication";
            this.lblPublication.Size = new System.Drawing.Size(59, 13);
            this.lblPublication.TabIndex = 2;
            this.lblPublication.Text = "Publication";
            // 
            // lblBookAuthorId
            // 
            this.lblBookAuthorId.AutoSize = true;
            this.lblBookAuthorId.Location = new System.Drawing.Point(432, 86);
            this.lblBookAuthorId.Name = "lblBookAuthorId";
            this.lblBookAuthorId.Size = new System.Drawing.Size(52, 13);
            this.lblBookAuthorId.TabIndex = 6;
            this.lblBookAuthorId.Text = "Author ID";
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(164, 80);
            this.txtBookPrice.Multiline = true;
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(190, 25);
            this.txtBookPrice.TabIndex = 5;
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Location = new System.Drawing.Point(77, 86);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(59, 13);
            this.lblBookPrice.TabIndex = 4;
            this.lblBookPrice.Text = "Book Price";
            // 
            // txtBookEdition
            // 
            this.txtBookEdition.Location = new System.Drawing.Point(164, 134);
            this.txtBookEdition.Multiline = true;
            this.txtBookEdition.Name = "txtBookEdition";
            this.txtBookEdition.Size = new System.Drawing.Size(190, 25);
            this.txtBookEdition.TabIndex = 9;
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Location = new System.Drawing.Point(77, 140);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(39, 13);
            this.lblEdition.TabIndex = 8;
            this.lblEdition.Text = "Edition";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(435, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(533, 135);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(634, 135);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancelOp
            // 
            this.btnCancelOp.Location = new System.Drawing.Point(435, 177);
            this.btnCancelOp.Name = "btnCancelOp";
            this.btnCancelOp.Size = new System.Drawing.Size(274, 23);
            this.btnCancelOp.TabIndex = 13;
            this.btnCancelOp.Text = "Cancel Operation";
            this.btnCancelOp.UseVisualStyleBackColor = true;
            this.btnCancelOp.Click += new System.EventHandler(this.btnCancelOp_Click);
            // 
            // dgViewBookInfo
            // 
            this.dgViewBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewBookInfo.Location = new System.Drawing.Point(80, 225);
            this.dgViewBookInfo.Name = "dgViewBookInfo";
            this.dgViewBookInfo.Size = new System.Drawing.Size(629, 213);
            this.dgViewBookInfo.TabIndex = 14;
            this.dgViewBookInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewBookInfo_CellClick);
            // 
            // cmBoxAuthorID
            // 
            this.cmBoxAuthorID.FormattingEnabled = true;
            this.cmBoxAuthorID.Location = new System.Drawing.Point(519, 83);
            this.cmBoxAuthorID.Name = "cmBoxAuthorID";
            this.cmBoxAuthorID.Size = new System.Drawing.Size(190, 21);
            this.cmBoxAuthorID.TabIndex = 15;
            // 
            // lblBid
            // 
            this.lblBid.AutoSize = true;
            this.lblBid.Location = new System.Drawing.Point(12, 324);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(0, 13);
            this.lblBid.TabIndex = 16;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(716, 398);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 40);
            this.btnHome.TabIndex = 17;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // BookInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblBid);
            this.Controls.Add(this.cmBoxAuthorID);
            this.Controls.Add(this.dgViewBookInfo);
            this.Controls.Add(this.btnCancelOp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBookEdition);
            this.Controls.Add(this.lblEdition);
            this.Controls.Add(this.lblBookAuthorId);
            this.Controls.Add(this.txtBookPrice);
            this.Controls.Add(this.lblBookPrice);
            this.Controls.Add(this.txtBookPublication);
            this.Controls.Add(this.lblPublication);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblBookName);
            this.Name = "BookInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInformation";
            this.Load += new System.EventHandler(this.BookInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewBookInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookPublication;
        private System.Windows.Forms.Label lblPublication;
        private System.Windows.Forms.Label lblBookAuthorId;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.TextBox txtBookEdition;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancelOp;
        private System.Windows.Forms.DataGridView dgViewBookInfo;
        private System.Windows.Forms.ComboBox cmBoxAuthorID;
        private System.Windows.Forms.Label lblBid;
        private System.Windows.Forms.Button btnHome;
    }
}