namespace Presentation
{
    partial class ActiviteitToevoegenForm
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
            this.beschrijvingTextBox = new System.Windows.Forms.TextBox();
            this.datumTextBox = new System.Windows.Forms.TextBox();
            this.activiteitToevoegenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "beschrijving";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "datum";
            // 
            // beschrijvingTextBox
            // 
            this.beschrijvingTextBox.Location = new System.Drawing.Point(82, 16);
            this.beschrijvingTextBox.Name = "beschrijvingTextBox";
            this.beschrijvingTextBox.Size = new System.Drawing.Size(181, 20);
            this.beschrijvingTextBox.TabIndex = 2;
            // 
            // datumTextBox
            // 
            this.datumTextBox.Location = new System.Drawing.Point(82, 42);
            this.datumTextBox.Name = "datumTextBox";
            this.datumTextBox.Size = new System.Drawing.Size(181, 20);
            this.datumTextBox.TabIndex = 3;
            // 
            // activiteitToevoegenButton
            // 
            this.activiteitToevoegenButton.Location = new System.Drawing.Point(16, 75);
            this.activiteitToevoegenButton.Name = "activiteitToevoegenButton";
            this.activiteitToevoegenButton.Size = new System.Drawing.Size(247, 23);
            this.activiteitToevoegenButton.TabIndex = 4;
            this.activiteitToevoegenButton.Text = "Voeg activiteit toe";
            this.activiteitToevoegenButton.UseVisualStyleBackColor = true;
            // 
            // ActiviteitToevoegenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 117);
            this.Controls.Add(this.activiteitToevoegenButton);
            this.Controls.Add(this.datumTextBox);
            this.Controls.Add(this.beschrijvingTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ActiviteitToevoegenForm";
            this.Text = "Activiteit toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox beschrijvingTextBox;
        private System.Windows.Forms.TextBox datumTextBox;
        private System.Windows.Forms.Button activiteitToevoegenButton;
    }
}