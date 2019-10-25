namespace W02_BibliotecaWinformUI
{
    partial class AuthorsForm
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
            this.titleForm = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.listAuthors = new System.Windows.Forms.Label();
            this.listBoxAuthor = new System.Windows.Forms.ListBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleForm
            // 
            this.titleForm.AutoSize = true;
            this.titleForm.Location = new System.Drawing.Point(362, 51);
            this.titleForm.Name = "titleForm";
            this.titleForm.Size = new System.Drawing.Size(176, 13);
            this.titleForm.TabIndex = 0;
            this.titleForm.Text = "CIFP PAUCASESNOVES AUTHOR";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(167, 141);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(247, 20);
            this.searchBox.TabIndex = 1;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(420, 137);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // listAuthors
            // 
            this.listAuthors.AutoSize = true;
            this.listAuthors.Location = new System.Drawing.Point(167, 221);
            this.listAuthors.Name = "listAuthors";
            this.listAuthors.Size = new System.Drawing.Size(62, 13);
            this.listAuthors.TabIndex = 3;
            this.listAuthors.Text = "List Authors";
            // 
            // listBoxAuthor
            // 
            this.listBoxAuthor.FormattingEnabled = true;
            this.listBoxAuthor.Location = new System.Drawing.Point(167, 259);
            this.listBoxAuthor.Name = "listBoxAuthor";
            this.listBoxAuthor.Size = new System.Drawing.Size(328, 95);
            this.listBoxAuthor.TabIndex = 4;
            this.listBoxAuthor.DoubleClick += new System.EventHandler(this.listBoxAuthor_DoubleClick);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(167, 102);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(75, 13);
            this.labelSearch.TabIndex = 5;
            this.labelSearch.Text = "Search Author";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.listBoxAuthor);
            this.Controls.Add(this.listAuthors);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.titleForm);
            this.Name = "AuthorsForm";
            this.Text = "AuthorsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleForm;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label listAuthors;
        private System.Windows.Forms.ListBox listBoxAuthor;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button button1;
    }
}