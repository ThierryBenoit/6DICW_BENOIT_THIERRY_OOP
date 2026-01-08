namespace Presentation
{
    partial class WandelroutesFilter2Form
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
            this.filterButton = new System.Windows.Forms.Button();
            this.maxKmTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wandelroutesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minKmTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(258, 161);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 7;
            this.filterButton.Text = "filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // maxKmTextBox
            // 
            this.maxKmTextBox.Location = new System.Drawing.Point(193, 161);
            this.maxKmTextBox.Name = "maxKmTextBox";
            this.maxKmTextBox.Size = new System.Drawing.Size(46, 20);
            this.maxKmTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "filter op routes met een afstand tussen:";
            // 
            // wandelroutesListBox
            // 
            this.wandelroutesListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.wandelroutesListBox.FormattingEnabled = true;
            this.wandelroutesListBox.Location = new System.Drawing.Point(0, 0);
            this.wandelroutesListBox.Name = "wandelroutesListBox";
            this.wandelroutesListBox.Size = new System.Drawing.Size(345, 108);
            this.wandelroutesListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "minimum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "maximum:";
            // 
            // minKmTextBox
            // 
            this.minKmTextBox.Location = new System.Drawing.Point(68, 161);
            this.minKmTextBox.Name = "minKmTextBox";
            this.minKmTextBox.Size = new System.Drawing.Size(46, 20);
            this.minKmTextBox.TabIndex = 6;
            // 
            // WandelroutesFilter2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 197);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.minKmTextBox);
            this.Controls.Add(this.maxKmTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wandelroutesListBox);
            this.Name = "WandelroutesFilter2Form";
            this.Text = "WandelroutesFilter2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox maxKmTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox wandelroutesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minKmTextBox;
    }
}