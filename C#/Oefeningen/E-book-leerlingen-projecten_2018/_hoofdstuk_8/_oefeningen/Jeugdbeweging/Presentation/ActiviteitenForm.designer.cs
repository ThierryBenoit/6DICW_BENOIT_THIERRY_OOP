namespace Presentation
{
    partial class ActiviteitenForm
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
            this.activiteitenListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // activiteitenListBox
            // 
            this.activiteitenListBox.FormattingEnabled = true;
            this.activiteitenListBox.Location = new System.Drawing.Point(17, 19);
            this.activiteitenListBox.Name = "activiteitenListBox";
            this.activiteitenListBox.Size = new System.Drawing.Size(247, 173);
            this.activiteitenListBox.TabIndex = 0;
            // 
            // ActiviteitenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.activiteitenListBox);
            this.Name = "ActiviteitenForm";
            this.Text = "Overzicht activiteiten";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox activiteitenListBox;
    }
}

