namespace Presentation
{
    partial class WandelroutesFilter1Form
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
            this.wandelroutesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxKmTextBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wandelroutesListBox
            // 
            this.wandelroutesListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.wandelroutesListBox.FormattingEnabled = true;
            this.wandelroutesListBox.Location = new System.Drawing.Point(0, 0);
            this.wandelroutesListBox.Name = "wandelroutesListBox";
            this.wandelroutesListBox.Size = new System.Drawing.Size(345, 108);
            this.wandelroutesListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "filter op max. aantal km:";
            // 
            // maxKmTextBox
            // 
            this.maxKmTextBox.Location = new System.Drawing.Point(15, 154);
            this.maxKmTextBox.Name = "maxKmTextBox";
            this.maxKmTextBox.Size = new System.Drawing.Size(46, 20);
            this.maxKmTextBox.TabIndex = 2;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(67, 154);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 3;
            this.filterButton.Text = "filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // WandelroutesFilter1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 193);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.maxKmTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wandelroutesListBox);
            this.Name = "WandelroutesFilter1Form";
            this.Text = "WandelroutesFilter1Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wandelroutesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxKmTextBox;
        private System.Windows.Forms.Button filterButton;
    }
}