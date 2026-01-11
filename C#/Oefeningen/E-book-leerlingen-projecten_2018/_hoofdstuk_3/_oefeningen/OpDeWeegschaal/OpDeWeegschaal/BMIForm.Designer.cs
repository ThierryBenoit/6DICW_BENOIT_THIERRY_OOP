namespace OpDeWeegschaal
{
    partial class BMIForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gewichtOmhoog = new System.Windows.Forms.Button();
            this.gewichtInKg = new System.Windows.Forms.TextBox();
            this.gewichtOmlaag = new System.Windows.Forms.Button();
            this.LengteInMeter = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BmiBerekend = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::OpDeWeegschaal.Properties.Resources.Schermafbeelding_2026_01_11_110258;
            this.pictureBox1.Location = new System.Drawing.Point(266, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 281);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "gewicht (in kg)";
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "grootte (in m)";
            this.textBox2.WordWrap = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // gewichtOmhoog
            // 
            this.gewichtOmhoog.Location = new System.Drawing.Point(215, 86);
            this.gewichtOmhoog.Name = "gewichtOmhoog";
            this.gewichtOmhoog.Size = new System.Drawing.Size(18, 19);
            this.gewichtOmhoog.TabIndex = 4;
            this.gewichtOmhoog.Text = "+";
            this.gewichtOmhoog.UseVisualStyleBackColor = true;
            this.gewichtOmhoog.Click += new System.EventHandler(this.gewichtOmhoog_Click);
            // 
            // gewichtInKg
            // 
            this.gewichtInKg.Location = new System.Drawing.Point(156, 85);
            this.gewichtInKg.Name = "gewichtInKg";
            this.gewichtInKg.ReadOnly = true;
            this.gewichtInKg.Size = new System.Drawing.Size(53, 20);
            this.gewichtInKg.TabIndex = 5;
            // 
            // gewichtOmlaag
            // 
            this.gewichtOmlaag.Location = new System.Drawing.Point(131, 86);
            this.gewichtOmlaag.Name = "gewichtOmlaag";
            this.gewichtOmlaag.Size = new System.Drawing.Size(19, 20);
            this.gewichtOmlaag.TabIndex = 6;
            this.gewichtOmlaag.Text = "-";
            this.gewichtOmlaag.UseVisualStyleBackColor = true;
            this.gewichtOmlaag.Click += new System.EventHandler(this.gewichtOmlaag_Click);
            // 
            // LengteInMeter
            // 
            this.LengteInMeter.Location = new System.Drawing.Point(156, 51);
            this.LengteInMeter.Name = "LengteInMeter";
            this.LengteInMeter.ReadOnly = true;
            this.LengteInMeter.Size = new System.Drawing.Size(53, 20);
            this.LengteInMeter.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(59, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 13);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "BMI";
            // 
            // BmiBerekend
            // 
            this.BmiBerekend.AccessibleDescription = "";
            this.BmiBerekend.Cursor = System.Windows.Forms.Cursors.No;
            this.BmiBerekend.Location = new System.Drawing.Point(156, 172);
            this.BmiBerekend.Name = "BmiBerekend";
            this.BmiBerekend.ReadOnly = true;
            this.BmiBerekend.Size = new System.Drawing.Size(53, 20);
            this.BmiBerekend.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(59, 222);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(53, 13);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "Status";
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(156, 215);
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Size = new System.Drawing.Size(77, 20);
            this.Status.TabIndex = 13;
            // 
            // BMIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 281);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.BmiBerekend);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LengteInMeter);
            this.Controls.Add(this.gewichtOmlaag);
            this.Controls.Add(this.gewichtInKg);
            this.Controls.Add(this.gewichtOmhoog);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BMIForm";
            this.Text = "BMIForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button gewichtOmhoog;
        private System.Windows.Forms.TextBox gewichtInKg;
        private System.Windows.Forms.Button gewichtOmlaag;
        private System.Windows.Forms.TextBox LengteInMeter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox BmiBerekend;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox Status;
    }
}

