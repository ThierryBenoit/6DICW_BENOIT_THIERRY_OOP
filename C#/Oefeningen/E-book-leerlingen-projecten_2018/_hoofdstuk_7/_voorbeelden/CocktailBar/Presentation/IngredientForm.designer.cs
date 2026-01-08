namespace Presentation
{
    partial class IngredientForm
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
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.hoeveelheidTextBox = new System.Windows.Forms.TextBox();
            this.alcoholpercentageTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hoeveelheid:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alcoholpercentage:";
            // 
            // naamTextBox
            // 
            this.naamTextBox.Location = new System.Drawing.Point(115, 14);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(100, 20);
            this.naamTextBox.TabIndex = 1;
            // 
            // hoeveelheidTextBox
            // 
            this.hoeveelheidTextBox.Location = new System.Drawing.Point(115, 40);
            this.hoeveelheidTextBox.Name = "hoeveelheidTextBox";
            this.hoeveelheidTextBox.Size = new System.Drawing.Size(77, 20);
            this.hoeveelheidTextBox.TabIndex = 2;
            // 
            // alcoholpercentageTextBox
            // 
            this.alcoholpercentageTextBox.Location = new System.Drawing.Point(115, 66);
            this.alcoholpercentageTextBox.Name = "alcoholpercentageTextBox";
            this.alcoholpercentageTextBox.Size = new System.Drawing.Size(77, 20);
            this.alcoholpercentageTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ml";
            // 
            // IngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 107);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alcoholpercentageTextBox);
            this.Controls.Add(this.hoeveelheidTextBox);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IngredientForm";
            this.Text = "IngredientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.TextBox hoeveelheidTextBox;
        private System.Windows.Forms.TextBox alcoholpercentageTextBox;
        private System.Windows.Forms.Label label4;
    }
}