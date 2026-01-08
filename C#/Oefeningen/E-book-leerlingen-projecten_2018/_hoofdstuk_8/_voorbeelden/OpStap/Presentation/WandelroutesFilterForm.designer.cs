namespace Presentation
{
    partial class WandelroutesFilterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.provincieComboBox = new System.Windows.Forms.ComboBox();
            this.wandelroutesListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.provincieComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "filter op provincie:";
            // 
            // provincieComboBox
            // 
            this.provincieComboBox.FormattingEnabled = true;
            this.provincieComboBox.Items.AddRange(new object[] {
            "Antwerpen",
            "Henegouwen",
            "Limburg",
            "Luik",
            "Luxemburg",
            "Namen",
            "Oost-Vlaanderen",
            "Vlaams-Brabant",
            "Waals-Brabant",
            "West-Vlaanderen"});
            this.provincieComboBox.Location = new System.Drawing.Point(107, 6);
            this.provincieComboBox.Name = "provincieComboBox";
            this.provincieComboBox.Size = new System.Drawing.Size(121, 21);
            this.provincieComboBox.TabIndex = 3;
            // 
            // wandelroutesListBox
            // 
            this.wandelroutesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wandelroutesListBox.FormattingEnabled = true;
            this.wandelroutesListBox.Location = new System.Drawing.Point(0, 0);
            this.wandelroutesListBox.Name = "wandelroutesListBox";
            this.wandelroutesListBox.Size = new System.Drawing.Size(345, 216);
            this.wandelroutesListBox.TabIndex = 1;
            // 
            // WandelroutesFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 261);
            this.Controls.Add(this.wandelroutesListBox);
            this.Controls.Add(this.panel1);
            this.Name = "WandelroutesFilterForm";
            this.Text = "Wandelroutes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox wandelroutesListBox;
        private System.Windows.Forms.ComboBox provincieComboBox;
        private System.Windows.Forms.Label label1;
    }
}