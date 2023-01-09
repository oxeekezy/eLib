namespace eLibrary.Forms
{
    partial class AddBook
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
            this.bookNameBox = new System.Windows.Forms.RichTextBox();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.conditionBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.authorFNBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.authorMNBox = new System.Windows.Forms.RichTextBox();
            this.authorLNBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookNameBox
            // 
            this.bookNameBox.Location = new System.Drawing.Point(6, 19);
            this.bookNameBox.Name = "bookNameBox";
            this.bookNameBox.Size = new System.Drawing.Size(172, 25);
            this.bookNameBox.TabIndex = 1;
            this.bookNameBox.Text = "";
            // 
            // yearUpDown
            // 
            this.yearUpDown.Location = new System.Drawing.Point(6, 19);
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.Size = new System.Drawing.Size(172, 20);
            this.yearUpDown.TabIndex = 3;
            // 
            // conditionBox
            // 
            this.conditionBox.FormattingEnabled = true;
            this.conditionBox.Location = new System.Drawing.Point(5, 19);
            this.conditionBox.Name = "conditionBox";
            this.conditionBox.Size = new System.Drawing.Size(172, 21);
            this.conditionBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bookNameBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 51);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.authorLNBox);
            this.groupBox2.Controls.Add(this.authorMNBox);
            this.groupBox2.Controls.Add(this.authorFNBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 158);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Author";
            // 
            // authorFNBox
            // 
            this.authorFNBox.Location = new System.Drawing.Point(6, 31);
            this.authorFNBox.Name = "authorFNBox";
            this.authorFNBox.Size = new System.Drawing.Size(172, 25);
            this.authorFNBox.TabIndex = 1;
            this.authorFNBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.yearUpDown);
            this.groupBox3.Location = new System.Drawing.Point(12, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 51);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Year";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.conditionBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 51);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Condition";
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(12, 347);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(75, 23);
            this.addBookBtn.TabIndex = 9;
            this.addBookBtn.Text = "Add this";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // authorMNBox
            // 
            this.authorMNBox.Location = new System.Drawing.Point(5, 78);
            this.authorMNBox.Name = "authorMNBox";
            this.authorMNBox.Size = new System.Drawing.Size(172, 25);
            this.authorMNBox.TabIndex = 2;
            this.authorMNBox.Text = "";
            // 
            // authorLNBox
            // 
            this.authorLNBox.Location = new System.Drawing.Point(5, 125);
            this.authorLNBox.Name = "authorLNBox";
            this.authorLNBox.Size = new System.Drawing.Size(172, 25);
            this.authorLNBox.TabIndex = 3;
            this.authorLNBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Middle name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last name";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 382);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox bookNameBox;
        private System.Windows.Forms.NumericUpDown yearUpDown;
        private System.Windows.Forms.ComboBox conditionBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox authorFNBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox authorLNBox;
        private System.Windows.Forms.RichTextBox authorMNBox;
    }
}