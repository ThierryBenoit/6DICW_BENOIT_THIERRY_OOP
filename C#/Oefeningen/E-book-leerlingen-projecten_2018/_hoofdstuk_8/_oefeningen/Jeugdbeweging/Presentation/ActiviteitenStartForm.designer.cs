namespace Presentation
{
    partial class ActiviteitenStartForm
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
            this.activiteitenBekijkenButton = new System.Windows.Forms.Button();
            this.activiteitToevoegenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activiteitenBekijkenButton
            // 
            this.activiteitenBekijkenButton.Location = new System.Drawing.Point(13, 13);
            this.activiteitenBekijkenButton.Name = "activiteitenBekijkenButton";
            this.activiteitenBekijkenButton.Size = new System.Drawing.Size(259, 23);
            this.activiteitenBekijkenButton.TabIndex = 0;
            this.activiteitenBekijkenButton.Text = "Bekijk de activiteiten";
            this.activiteitenBekijkenButton.UseVisualStyleBackColor = true;
            this.activiteitenBekijkenButton.Click += new System.EventHandler(this.activiteitenBekijkenButton_Click);
            // 
            // activiteitToevoegenButton
            // 
            this.activiteitToevoegenButton.Location = new System.Drawing.Point(13, 43);
            this.activiteitToevoegenButton.Name = "activiteitToevoegenButton";
            this.activiteitToevoegenButton.Size = new System.Drawing.Size(259, 23);
            this.activiteitToevoegenButton.TabIndex = 1;
            this.activiteitToevoegenButton.Text = "Activiteiten toevoegen";
            this.activiteitToevoegenButton.UseVisualStyleBackColor = true;
            this.activiteitToevoegenButton.Click += new System.EventHandler(this.activiteitToevoegenButton_Click);
            // 
            // ActiviteitenStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.activiteitToevoegenButton);
            this.Controls.Add(this.activiteitenBekijkenButton);
            this.Name = "ActiviteitenStartForm";
            this.Text = "Startformuliertje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button activiteitenBekijkenButton;
        private System.Windows.Forms.Button activiteitToevoegenButton;
    }
}