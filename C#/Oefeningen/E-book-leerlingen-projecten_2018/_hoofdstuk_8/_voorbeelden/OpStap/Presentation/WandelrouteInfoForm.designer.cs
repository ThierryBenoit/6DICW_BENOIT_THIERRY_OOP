namespace Presentation
{
    partial class WandelrouteInfoForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.kmTextBox = new System.Windows.Forms.TextBox();
            this.gemeenteTextBox = new System.Windows.Forms.TextBox();
            this.provincieTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.opslaanSluitenButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "kilometers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "gemeente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "provincie";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(84, 16);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(150, 20);
            this.idTextBox.TabIndex = 5;
            this.idTextBox.TabStop = false;
            // 
            // naamTextBox
            // 
            this.naamTextBox.Location = new System.Drawing.Point(84, 43);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(150, 20);
            this.naamTextBox.TabIndex = 1;
            // 
            // kmTextBox
            // 
            this.kmTextBox.Location = new System.Drawing.Point(84, 72);
            this.kmTextBox.Name = "kmTextBox";
            this.kmTextBox.Size = new System.Drawing.Size(150, 20);
            this.kmTextBox.TabIndex = 2;
            // 
            // gemeenteTextBox
            // 
            this.gemeenteTextBox.Location = new System.Drawing.Point(84, 102);
            this.gemeenteTextBox.Name = "gemeenteTextBox";
            this.gemeenteTextBox.Size = new System.Drawing.Size(150, 20);
            this.gemeenteTextBox.TabIndex = 3;
            // 
            // provincieTextBox
            // 
            this.provincieTextBox.Location = new System.Drawing.Point(84, 132);
            this.provincieTextBox.Name = "provincieTextBox";
            this.provincieTextBox.Size = new System.Drawing.Size(150, 20);
            this.provincieTextBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.opslaanSluitenButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 43);
            this.panel1.TabIndex = 10;
            // 
            // opslaanSluitenButton
            // 
            this.opslaanSluitenButton.Location = new System.Drawing.Point(68, 11);
            this.opslaanSluitenButton.Name = "opslaanSluitenButton";
            this.opslaanSluitenButton.Size = new System.Drawing.Size(131, 23);
            this.opslaanSluitenButton.TabIndex = 5;
            this.opslaanSluitenButton.Text = "Opslaan en Sluiten";
            this.opslaanSluitenButton.UseVisualStyleBackColor = true;
            this.opslaanSluitenButton.Click += new System.EventHandler(this.opslaanSluitenButton_Click);
            // 
            // WandelrouteInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 218);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.provincieTextBox);
            this.Controls.Add(this.gemeenteTextBox);
            this.Controls.Add(this.kmTextBox);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WandelrouteInfoForm";
            this.Text = "Info wandelroute";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.TextBox kmTextBox;
        private System.Windows.Forms.TextBox gemeenteTextBox;
        private System.Windows.Forms.TextBox provincieTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button opslaanSluitenButton;
    }
}