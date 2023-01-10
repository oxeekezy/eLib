namespace eLibrary.Forms
{
    partial class Library
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
            this.label1 = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.youLibrary = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.libraryTbx = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.ForeColor = System.Drawing.Color.Green;
            this.userLbl.Location = new System.Drawing.Point(70, 9);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(55, 13);
            this.userLbl.TabIndex = 1;
            this.userLbl.Text = "Username";
            this.userLbl.DoubleClick += new System.EventHandler(this.userLbl_DoubleClick);
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(12, 427);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(91, 23);
            this.AddBookBtn.TabIndex = 2;
            this.AddBookBtn.Text = "Add your book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // youLibrary
            // 
            this.youLibrary.Location = new System.Drawing.Point(12, 65);
            this.youLibrary.Name = "youLibrary";
            this.youLibrary.Size = new System.Drawing.Size(328, 356);
            this.youLibrary.TabIndex = 3;
            this.youLibrary.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "My books";
            // 
            // libraryTbx
            // 
            this.libraryTbx.Location = new System.Drawing.Point(392, 65);
            this.libraryTbx.Name = "libraryTbx";
            this.libraryTbx.Size = new System.Drawing.Size(340, 356);
            this.libraryTbx.TabIndex = 5;
            this.libraryTbx.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Library";
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.libraryTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.youLibrary);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.label1);
            this.Name = "Library";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Library_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.RichTextBox youLibrary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox libraryTbx;
        private System.Windows.Forms.Label label3;
    }
}