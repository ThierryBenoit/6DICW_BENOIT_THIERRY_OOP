namespace test_oefening
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LaadLeeftijd = new Button();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // LaadLeeftijd
            // 
            LaadLeeftijd.Location = new Point(312, 144);
            LaadLeeftijd.Name = "LaadLeeftijd";
            LaadLeeftijd.Size = new Size(133, 23);
            LaadLeeftijd.TabIndex = 0;
            LaadLeeftijd.Text = "LeeftijdLaden";
            LaadLeeftijd.UseVisualStyleBackColor = true;
            LaadLeeftijd.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 192);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(312, 225);
            button2.Name = "button2";
            button2.Size = new Size(133, 23);
            button2.TabIndex = 2;
            button2.Text = "Happy Birthday";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(312, 274);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 3;
            button1.Text = "VAMPIER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(LaadLeeftijd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LaadLeeftijd;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}
