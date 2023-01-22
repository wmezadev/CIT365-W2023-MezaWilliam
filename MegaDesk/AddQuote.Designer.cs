namespace MegaDesk
{
    partial class AddQuote
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
            this.newQuoteLabelTitle = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.labelDeskWidth = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownDepth = new System.Windows.Forms.NumericUpDown();
            this.labelDrawers = new System.Windows.Forms.Label();
            this.numericUpDownDrawers = new System.Windows.Forms.NumericUpDown();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.labelRush = new System.Windows.Forms.Label();
            this.comboBoxRush = new System.Windows.Forms.ComboBox();
            this.buttonSaveQuote = new System.Windows.Forms.Button();
            this.buttonCancelQuote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // newQuoteLabelTitle
            // 
            this.newQuoteLabelTitle.AutoSize = true;
            this.newQuoteLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuoteLabelTitle.Location = new System.Drawing.Point(292, 38);
            this.newQuoteLabelTitle.Name = "newQuoteLabelTitle";
            this.newQuoteLabelTitle.Size = new System.Drawing.Size(196, 24);
            this.newQuoteLabelTitle.TabIndex = 0;
            this.newQuoteLabelTitle.Text = "Add New Quote Form";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(110, 136);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(82, 13);
            this.labelCustomer.TabIndex = 1;
            this.labelCustomer.Text = "Customer Name";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(216, 133);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(172, 20);
            this.textBoxCustomer.TabIndex = 2;
            // 
            // labelDeskWidth
            // 
            this.labelDeskWidth.AutoSize = true;
            this.labelDeskWidth.Location = new System.Drawing.Point(110, 182);
            this.labelDeskWidth.Name = "labelDeskWidth";
            this.labelDeskWidth.Size = new System.Drawing.Size(100, 13);
            this.labelDeskWidth.TabIndex = 3;
            this.labelDeskWidth.Text = "Desk width (inches)";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(216, 180);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownWidth.TabIndex = 4;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Desk depth (inches)";
            // 
            // numericUpDownDepth
            // 
            this.numericUpDownDepth.Location = new System.Drawing.Point(216, 228);
            this.numericUpDownDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDownDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownDepth.Name = "numericUpDownDepth";
            this.numericUpDownDepth.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownDepth.TabIndex = 6;
            this.numericUpDownDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // labelDrawers
            // 
            this.labelDrawers.AutoSize = true;
            this.labelDrawers.Location = new System.Drawing.Point(422, 136);
            this.labelDrawers.Name = "labelDrawers";
            this.labelDrawers.Size = new System.Drawing.Size(103, 13);
            this.labelDrawers.TabIndex = 7;
            this.labelDrawers.Text = "Numbers of Drawers";
            // 
            // numericUpDownDrawers
            // 
            this.numericUpDownDrawers.Location = new System.Drawing.Point(531, 134);
            this.numericUpDownDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownDrawers.Name = "numericUpDownDrawers";
            this.numericUpDownDrawers.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDrawers.TabIndex = 8;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(425, 181);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(84, 13);
            this.labelMaterial.TabIndex = 9;
            this.labelMaterial.Text = "Surface Material";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "rosewood",
            "veneer",
            "pine"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(530, 178);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterial.TabIndex = 10;
            // 
            // labelRush
            // 
            this.labelRush.AutoSize = true;
            this.labelRush.Location = new System.Drawing.Point(428, 229);
            this.labelRush.Name = "labelRush";
            this.labelRush.Size = new System.Drawing.Size(57, 13);
            this.labelRush.TabIndex = 11;
            this.labelRush.Text = "Rush days";
            // 
            // comboBoxRush
            // 
            this.comboBoxRush.FormattingEnabled = true;
            this.comboBoxRush.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.comboBoxRush.Location = new System.Drawing.Point(530, 228);
            this.comboBoxRush.Name = "comboBoxRush";
            this.comboBoxRush.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRush.TabIndex = 12;
            // 
            // buttonSaveQuote
            // 
            this.buttonSaveQuote.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSaveQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveQuote.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveQuote.Location = new System.Drawing.Point(404, 354);
            this.buttonSaveQuote.Name = "buttonSaveQuote";
            this.buttonSaveQuote.Size = new System.Drawing.Size(121, 23);
            this.buttonSaveQuote.TabIndex = 13;
            this.buttonSaveQuote.Text = "Save Quote";
            this.buttonSaveQuote.UseVisualStyleBackColor = false;
            // 
            // buttonCancelQuote
            // 
            this.buttonCancelQuote.Location = new System.Drawing.Point(258, 354);
            this.buttonCancelQuote.Name = "buttonCancelQuote";
            this.buttonCancelQuote.Size = new System.Drawing.Size(109, 23);
            this.buttonCancelQuote.TabIndex = 14;
            this.buttonCancelQuote.Text = "Cancel Quote";
            this.buttonCancelQuote.UseVisualStyleBackColor = true;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelQuote);
            this.Controls.Add(this.buttonSaveQuote);
            this.Controls.Add(this.comboBoxRush);
            this.Controls.Add(this.labelRush);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.numericUpDownDrawers);
            this.Controls.Add(this.labelDrawers);
            this.Controls.Add(this.numericUpDownDepth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.labelDeskWidth);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.newQuoteLabelTitle);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newQuoteLabelTitle;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Label labelDeskWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownDepth;
        private System.Windows.Forms.Label labelDrawers;
        private System.Windows.Forms.NumericUpDown numericUpDownDrawers;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label labelRush;
        private System.Windows.Forms.ComboBox comboBoxRush;
        private System.Windows.Forms.Button buttonSaveQuote;
        private System.Windows.Forms.Button buttonCancelQuote;
    }
}