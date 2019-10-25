namespace W02_BibliotecaWinformUI
{
    partial class BibliotecaMainForm
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.bookList = new System.Windows.Forms.ListBox();
            this.bookListLabel = new System.Windows.Forms.Label();
            this.goAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIFP PAU CASESNOVES LIBRARY";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(56, 88);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(376, 20);
            this.searchBox.TabIndex = 6;
            // 
            // searchTextBox
            // 
            this.searchTextBox.AutoSize = true;
            this.searchTextBox.Location = new System.Drawing.Point(56, 69);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(44, 13);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.Text = "Search ";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(438, 88);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // bookList
            // 
            this.bookList.FormattingEnabled = true;
            this.bookList.Location = new System.Drawing.Point(56, 153);
            this.bookList.Name = "bookList";
            this.bookList.Size = new System.Drawing.Size(457, 95);
            this.bookList.TabIndex = 4;
            this.bookList.DoubleClick += new System.EventHandler(this.bookList_DoubleClick);
            // 
            // bookListLabel
            // 
            this.bookListLabel.AutoSize = true;
            this.bookListLabel.Location = new System.Drawing.Point(56, 134);
            this.bookListLabel.Name = "bookListLabel";
            this.bookListLabel.Size = new System.Drawing.Size(51, 13);
            this.bookListLabel.TabIndex = 5;
            this.bookListLabel.Text = "Book List";
            // 
            // goAuthor
            // 
            this.goAuthor.Location = new System.Drawing.Point(519, 225);
            this.goAuthor.Name = "goAuthor";
            this.goAuthor.Size = new System.Drawing.Size(75, 23);
            this.goAuthor.TabIndex = 7;
            this.goAuthor.Text = "go Author";
            this.goAuthor.UseVisualStyleBackColor = true;
            this.goAuthor.Click += new System.EventHandler(this.goAuthor_Click);
            // 
            // BibliotecaMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(597, 275);
            this.Controls.Add(this.goAuthor);
            this.Controls.Add(this.bookListLabel);
            this.Controls.Add(this.bookList);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Name = "BibliotecaMainForm";
            this.Text = "Biblioteca - Cavern Times";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ListBox bookList;
        private System.Windows.Forms.Label bookListLabel;
        private System.Windows.Forms.Button goAuthor;
    }
}

