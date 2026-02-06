namespace Wielertenue
{
    partial class BestellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestellingForm));
            this.wielertruiPictureBox = new System.Windows.Forms.PictureBox();
            this.wielertenuePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aantalNumericUpAndDown = new System.Windows.Forms.NumericUpDown();
            this.waterdichtZakjeCheckBox = new System.Windows.Forms.CheckBox();
            this.broekCheckBox = new System.Windows.Forms.CheckBox();
            this.superzeemCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrijsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wielertruiPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wielertenuePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalNumericUpAndDown)).BeginInit();
            this.SuspendLayout();
            // 
            // wielertruiPictureBox
            // 
            this.wielertruiPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wielertruiPictureBox.Image")));
            this.wielertruiPictureBox.Location = new System.Drawing.Point(16, 9);
            this.wielertruiPictureBox.Name = "wielertruiPictureBox";
            this.wielertruiPictureBox.Size = new System.Drawing.Size(358, 345);
            this.wielertruiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wielertruiPictureBox.TabIndex = 0;
            this.wielertruiPictureBox.TabStop = false;
            // 
            // wielertenuePictureBox
            // 
            this.wielertenuePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wielertenuePictureBox.Image")));
            this.wielertenuePictureBox.Location = new System.Drawing.Point(12, 12);
            this.wielertenuePictureBox.Name = "wielertenuePictureBox";
            this.wielertenuePictureBox.Size = new System.Drawing.Size(358, 345);
            this.wielertenuePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wielertenuePictureBox.TabIndex = 0;
            this.wielertenuePictureBox.TabStop = false;
            this.wielertenuePictureBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aantal";
            // 
            // aantalNumericUpAndDown
            // 
            this.aantalNumericUpAndDown.Location = new System.Drawing.Point(497, 50);
            this.aantalNumericUpAndDown.Name = "aantalNumericUpAndDown";
            this.aantalNumericUpAndDown.Size = new System.Drawing.Size(120, 20);
            this.aantalNumericUpAndDown.TabIndex = 2;
            this.aantalNumericUpAndDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aantalNumericUpAndDown.ValueChanged += new System.EventHandler(this.aantalNumericUpAndDown_ValueChanged);
            // 
            // waterdichtZakjeCheckBox
            // 
            this.waterdichtZakjeCheckBox.AutoSize = true;
            this.waterdichtZakjeCheckBox.Location = new System.Drawing.Point(449, 100);
            this.waterdichtZakjeCheckBox.Name = "waterdichtZakjeCheckBox";
            this.waterdichtZakjeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.waterdichtZakjeCheckBox.TabIndex = 3;
            this.waterdichtZakjeCheckBox.UseVisualStyleBackColor = true;
            this.waterdichtZakjeCheckBox.CheckedChanged += new System.EventHandler(this.waterdichtZakjeCheckBox_CheckedChanged);
            // 
            // broekCheckBox
            // 
            this.broekCheckBox.AutoSize = true;
            this.broekCheckBox.Location = new System.Drawing.Point(449, 144);
            this.broekCheckBox.Name = "broekCheckBox";
            this.broekCheckBox.Size = new System.Drawing.Size(15, 14);
            this.broekCheckBox.TabIndex = 4;
            this.broekCheckBox.UseVisualStyleBackColor = true;
            this.broekCheckBox.CheckedChanged += new System.EventHandler(this.broekCheckBox_CheckedChanged);
            // 
            // superzeemCheckBox
            // 
            this.superzeemCheckBox.AutoSize = true;
            this.superzeemCheckBox.Location = new System.Drawing.Point(449, 184);
            this.superzeemCheckBox.Name = "superzeemCheckBox";
            this.superzeemCheckBox.Size = new System.Drawing.Size(15, 14);
            this.superzeemCheckBox.TabIndex = 5;
            this.superzeemCheckBox.UseVisualStyleBackColor = true;
            this.superzeemCheckBox.Visible = false;
            this.superzeemCheckBox.CheckedChanged += new System.EventHandler(this.superzeemCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Waterdichte zakjes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "inclusief wielerbroek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inclusief Superzeem";
            this.label4.Visible = false;
            // 
            // PrijsTextBox
            // 
            this.PrijsTextBox.Location = new System.Drawing.Point(449, 277);
            this.PrijsTextBox.Name = "PrijsTextBox";
            this.PrijsTextBox.ReadOnly = true;
            this.PrijsTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrijsTextBox.TabIndex = 9;
            // 
            // BestellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 369);
            this.Controls.Add(this.PrijsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.superzeemCheckBox);
            this.Controls.Add(this.broekCheckBox);
            this.Controls.Add(this.waterdichtZakjeCheckBox);
            this.Controls.Add(this.aantalNumericUpAndDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wielertenuePictureBox);
            this.Controls.Add(this.wielertruiPictureBox);
            this.Name = "BestellingForm";
            this.Text = "BestellingWielertenueForm";
            ((System.ComponentModel.ISupportInitialize)(this.wielertruiPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wielertenuePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalNumericUpAndDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wielertruiPictureBox;
        private System.Windows.Forms.PictureBox wielertenuePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown aantalNumericUpAndDown;
        private System.Windows.Forms.CheckBox waterdichtZakjeCheckBox;
        private System.Windows.Forms.CheckBox broekCheckBox;
        private System.Windows.Forms.CheckBox superzeemCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrijsTextBox;
    }
}