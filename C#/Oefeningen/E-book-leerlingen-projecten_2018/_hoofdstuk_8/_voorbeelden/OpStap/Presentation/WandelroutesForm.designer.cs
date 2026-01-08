namespace Presentation
{
    partial class WandelroutesForm
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
            this.verwijderButton = new System.Windows.Forms.Button();
            this.nieuwButton = new System.Windows.Forms.Button();
            this.toonButton = new System.Windows.Forms.Button();
            this.wandelroutesListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.verwijderButton);
            this.panel1.Controls.Add(this.nieuwButton);
            this.panel1.Controls.Add(this.toonButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 45);
            this.panel1.TabIndex = 0;
            // 
            // verwijderButton
            // 
            this.verwijderButton.Location = new System.Drawing.Point(219, 11);
            this.verwijderButton.Name = "verwijderButton";
            this.verwijderButton.Size = new System.Drawing.Size(75, 23);
            this.verwijderButton.TabIndex = 2;
            this.verwijderButton.Text = "Verwijder";
            this.verwijderButton.UseVisualStyleBackColor = true;
            this.verwijderButton.Click += new System.EventHandler(this.verwijderButton_Click);
            // 
            // nieuwButton
            // 
            this.nieuwButton.Location = new System.Drawing.Point(137, 11);
            this.nieuwButton.Name = "nieuwButton";
            this.nieuwButton.Size = new System.Drawing.Size(75, 23);
            this.nieuwButton.TabIndex = 1;
            this.nieuwButton.Text = "Nieuw";
            this.nieuwButton.UseVisualStyleBackColor = true;
            this.nieuwButton.Click += new System.EventHandler(this.nieuwButton_Click);
            // 
            // toonButton
            // 
            this.toonButton.Location = new System.Drawing.Point(55, 11);
            this.toonButton.Name = "toonButton";
            this.toonButton.Size = new System.Drawing.Size(75, 23);
            this.toonButton.TabIndex = 0;
            this.toonButton.Text = "Toon";
            this.toonButton.UseVisualStyleBackColor = true;
            this.toonButton.Click += new System.EventHandler(this.toonButton_Click);
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
            // WandelroutesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 261);
            this.Controls.Add(this.wandelroutesListBox);
            this.Controls.Add(this.panel1);
            this.Name = "WandelroutesForm";
            this.Text = "Wandelroutes";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button verwijderButton;
        private System.Windows.Forms.Button nieuwButton;
        private System.Windows.Forms.Button toonButton;
        private System.Windows.Forms.ListBox wandelroutesListBox;

    }
}