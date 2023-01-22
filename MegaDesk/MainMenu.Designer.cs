namespace MegaDesk
{
    partial class MainMenu
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
            this.AddNewQuoteNav = new System.Windows.Forms.Button();
            this.ViewNewQuoteNav = new System.Windows.Forms.Button();
            this.SearchQuotesNav = new System.Windows.Forms.Button();
            this.ExitNav = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewQuoteNav
            // 
            this.AddNewQuoteNav.Location = new System.Drawing.Point(76, 61);
            this.AddNewQuoteNav.Name = "AddNewQuoteNav";
            this.AddNewQuoteNav.Size = new System.Drawing.Size(117, 27);
            this.AddNewQuoteNav.TabIndex = 0;
            this.AddNewQuoteNav.Text = "Add New Quote";
            this.AddNewQuoteNav.UseVisualStyleBackColor = true;
            this.AddNewQuoteNav.Click += new System.EventHandler(this.AddNewQuoteNav_Click);
            // 
            // ViewNewQuoteNav
            // 
            this.ViewNewQuoteNav.Location = new System.Drawing.Point(76, 113);
            this.ViewNewQuoteNav.Name = "ViewNewQuoteNav";
            this.ViewNewQuoteNav.Size = new System.Drawing.Size(117, 23);
            this.ViewNewQuoteNav.TabIndex = 1;
            this.ViewNewQuoteNav.Text = "View New Quote";
            this.ViewNewQuoteNav.UseVisualStyleBackColor = true;
            // 
            // SearchQuotesNav
            // 
            this.SearchQuotesNav.Location = new System.Drawing.Point(76, 160);
            this.SearchQuotesNav.Name = "SearchQuotesNav";
            this.SearchQuotesNav.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchQuotesNav.Size = new System.Drawing.Size(117, 23);
            this.SearchQuotesNav.TabIndex = 2;
            this.SearchQuotesNav.Text = "Search Quotes";
            this.SearchQuotesNav.UseVisualStyleBackColor = true;
            // 
            // ExitNav
            // 
            this.ExitNav.Location = new System.Drawing.Point(76, 206);
            this.ExitNav.Name = "ExitNav";
            this.ExitNav.Size = new System.Drawing.Size(117, 23);
            this.ExitNav.TabIndex = 3;
            this.ExitNav.Text = "Exit";
            this.ExitNav.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 299);
            this.Controls.Add(this.ExitNav);
            this.Controls.Add(this.SearchQuotesNav);
            this.Controls.Add(this.ViewNewQuoteNav);
            this.Controls.Add(this.AddNewQuoteNav);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewQuoteNav;
        private System.Windows.Forms.Button ViewNewQuoteNav;
        private System.Windows.Forms.Button SearchQuotesNav;
        private System.Windows.Forms.Button ExitNav;
    }
}

