namespace Presentation
{
    partial class CopierForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.paginasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kopiesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inWachtrijButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wachtrijListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.tellerTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.paginasNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kopiesNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "pagina\'s in origineel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "aantal te printen exemplaren";
            // 
            // paginasNumericUpDown
            // 
            this.paginasNumericUpDown.Location = new System.Drawing.Point(158, 12);
            this.paginasNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.paginasNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.paginasNumericUpDown.Name = "paginasNumericUpDown";
            this.paginasNumericUpDown.Size = new System.Drawing.Size(82, 20);
            this.paginasNumericUpDown.TabIndex = 2;
            this.paginasNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kopiesNumericUpDown
            // 
            this.kopiesNumericUpDown.Location = new System.Drawing.Point(158, 38);
            this.kopiesNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kopiesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kopiesNumericUpDown.Name = "kopiesNumericUpDown";
            this.kopiesNumericUpDown.Size = new System.Drawing.Size(82, 20);
            this.kopiesNumericUpDown.TabIndex = 3;
            this.kopiesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // inWachtrijButton
            // 
            this.inWachtrijButton.Location = new System.Drawing.Point(13, 64);
            this.inWachtrijButton.Name = "inWachtrijButton";
            this.inWachtrijButton.Size = new System.Drawing.Size(227, 23);
            this.inWachtrijButton.TabIndex = 5;
            this.inWachtrijButton.Text = "Zet in wachtrij";
            this.inWachtrijButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.kopiesNumericUpDown);
            this.panel1.Controls.Add(this.inWachtrijButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.paginasNumericUpDown);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 102);
            this.panel1.TabIndex = 6;
            // 
            // wachtrijListBox
            // 
            this.wachtrijListBox.FormattingEnabled = true;
            this.wachtrijListBox.Location = new System.Drawing.Point(13, 130);
            this.wachtrijListBox.Name = "wachtrijListBox";
            this.wachtrijListBox.Size = new System.Drawing.Size(256, 108);
            this.wachtrijListBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "teller";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(13, 254);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(256, 23);
            this.printButton.TabIndex = 10;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // tellerTextBox
            // 
            this.tellerTextBox.Location = new System.Drawing.Point(45, 296);
            this.tellerTextBox.Name = "tellerTextBox";
            this.tellerTextBox.Size = new System.Drawing.Size(58, 20);
            this.tellerTextBox.TabIndex = 11;
            // 
            // CopierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 328);
            this.Controls.Add(this.tellerTextBox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wachtrijListBox);
            this.Controls.Add(this.panel1);
            this.Name = "CopierForm";
            this.Text = "CopierForm";
            ((System.ComponentModel.ISupportInitialize)(this.paginasNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kopiesNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown paginasNumericUpDown;
        private System.Windows.Forms.NumericUpDown kopiesNumericUpDown;
        private System.Windows.Forms.Button inWachtrijButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox wachtrijListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TextBox tellerTextBox;
    }
}