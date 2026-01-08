namespace Presentation
{
    partial class VerwijderWandelroutesGemeenteForm
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
            this.verwijderButton = new System.Windows.Forms.Button();
            this.gemeenteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // verwijderButton
            // 
            this.verwijderButton.Location = new System.Drawing.Point(140, 46);
            this.verwijderButton.Name = "verwijderButton";
            this.verwijderButton.Size = new System.Drawing.Size(75, 23);
            this.verwijderButton.TabIndex = 6;
            this.verwijderButton.Text = "verwijderen";
            this.verwijderButton.UseVisualStyleBackColor = true;
            this.verwijderButton.Click += new System.EventHandler(this.verwijderButton_Click);
            // 
            // gemeenteTextBox
            // 
            this.gemeenteTextBox.Location = new System.Drawing.Point(18, 46);
            this.gemeenteTextBox.Name = "gemeenteTextBox";
            this.gemeenteTextBox.Size = new System.Drawing.Size(116, 20);
            this.gemeenteTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "verwijder alle wandelroutes uit de gemeente:";
            // 
            // VerwijderWandelroutesGemeenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 87);
            this.Controls.Add(this.verwijderButton);
            this.Controls.Add(this.gemeenteTextBox);
            this.Controls.Add(this.label1);
            this.Name = "VerwijderWandelroutesGemeenteForm";
            this.Text = "VerwijderWandelroutesGemeenteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verwijderButton;
        private System.Windows.Forms.TextBox gemeenteTextBox;
        private System.Windows.Forms.Label label1;
    }
}