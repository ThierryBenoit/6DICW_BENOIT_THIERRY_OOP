namespace TestNumericUpDown
{
    partial class NumericUpDownForm
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
            this.vakNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vakNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // vakNumericUpDown
            // 
            this.vakNumericUpDown.Location = new System.Drawing.Point(22, 43);
            this.vakNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.vakNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.vakNumericUpDown.Name = "vakNumericUpDown";
            this.vakNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.vakNumericUpDown.TabIndex = 2;
            this.vakNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "een NumericUpDown:";
            // 
            // NumericUpDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 90);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vakNumericUpDown);
            this.Name = "NumericUpDownForm";
            this.Text = "NumericUpDownForm";
            ((System.ComponentModel.ISupportInitialize)(this.vakNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown vakNumericUpDown;
        private System.Windows.Forms.Label label2;
    }
}

