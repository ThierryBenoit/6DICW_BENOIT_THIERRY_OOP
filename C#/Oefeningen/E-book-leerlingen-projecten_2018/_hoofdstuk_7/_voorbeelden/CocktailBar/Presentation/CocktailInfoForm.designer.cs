namespace Presentation
{
    partial class CocktailInfoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.kostprijsTextBox = new System.Windows.Forms.TextBox();
            this.ingredientenListBox = new System.Windows.Forms.ListBox();
            this.toonButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inhoudTextBox = new System.Windows.Forms.TextBox();
            this.alcoholpercentageTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pittigerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "kostprijs";
            // 
            // naamTextBox
            // 
            this.naamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naamTextBox.Location = new System.Drawing.Point(16, 5);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(158, 26);
            this.naamTextBox.TabIndex = 1;
            // 
            // kostprijsTextBox
            // 
            this.kostprijsTextBox.Location = new System.Drawing.Point(113, 41);
            this.kostprijsTextBox.Name = "kostprijsTextBox";
            this.kostprijsTextBox.Size = new System.Drawing.Size(61, 20);
            this.kostprijsTextBox.TabIndex = 2;
            // 
            // ingredientenListBox
            // 
            this.ingredientenListBox.FormattingEnabled = true;
            this.ingredientenListBox.Location = new System.Drawing.Point(211, 4);
            this.ingredientenListBox.Name = "ingredientenListBox";
            this.ingredientenListBox.Size = new System.Drawing.Size(156, 82);
            this.ingredientenListBox.TabIndex = 5;
            // 
            // toonButton
            // 
            this.toonButton.Location = new System.Drawing.Point(211, 93);
            this.toonButton.Name = "toonButton";
            this.toonButton.Size = new System.Drawing.Size(156, 24);
            this.toonButton.TabIndex = 0;
            this.toonButton.Text = "Toon ingredient";
            this.toonButton.UseVisualStyleBackColor = true;
            this.toonButton.Click += new System.EventHandler(this.toonButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "inhoud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "alcoholpercentage";
            // 
            // inhoudTextBox
            // 
            this.inhoudTextBox.Location = new System.Drawing.Point(113, 67);
            this.inhoudTextBox.Name = "inhoudTextBox";
            this.inhoudTextBox.Size = new System.Drawing.Size(41, 20);
            this.inhoudTextBox.TabIndex = 3;
            // 
            // alcoholpercentageTextBox
            // 
            this.alcoholpercentageTextBox.Location = new System.Drawing.Point(113, 93);
            this.alcoholpercentageTextBox.Name = "alcoholpercentageTextBox";
            this.alcoholpercentageTextBox.Size = new System.Drawing.Size(41, 20);
            this.alcoholpercentageTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ml";
            // 
            // pittigerButton
            // 
            this.pittigerButton.Location = new System.Drawing.Point(12, 136);
            this.pittigerButton.Name = "pittigerButton";
            this.pittigerButton.Size = new System.Drawing.Size(355, 24);
            this.pittigerButton.TabIndex = 6;
            this.pittigerButton.Text = "Maak cocktail pittiger";
            this.pittigerButton.UseVisualStyleBackColor = true;
            // 
            // CocktailInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 128);
            this.Controls.Add(this.pittigerButton);
            this.Controls.Add(this.alcoholpercentageTextBox);
            this.Controls.Add(this.inhoudTextBox);
            this.Controls.Add(this.toonButton);
            this.Controls.Add(this.ingredientenListBox);
            this.Controls.Add(this.kostprijsTextBox);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "CocktailInfoForm";
            this.Text = "CocktailInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.TextBox kostprijsTextBox;
        private System.Windows.Forms.ListBox ingredientenListBox;
        private System.Windows.Forms.Button toonButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inhoudTextBox;
        private System.Windows.Forms.TextBox alcoholpercentageTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pittigerButton;
    }
}