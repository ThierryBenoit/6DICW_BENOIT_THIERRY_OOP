namespace ProjectZonderNaam
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
            VolledigeNaam = new TextBox();
            Voornaam = new TextBox();
            Achternaam = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // VolledigeNaam
            // 
            VolledigeNaam.Location = new Point(295, 118);
            VolledigeNaam.Name = "VolledigeNaam";
            VolledigeNaam.Size = new Size(100, 23);
            VolledigeNaam.TabIndex = 0;
            VolledigeNaam.TextChanged += VolledigeNaam_TextChanged;
            // 
            // Voornaam
            // 
            Voornaam.Location = new Point(295, 181);
            Voornaam.Name = "Voornaam";
            Voornaam.Size = new Size(100, 23);
            Voornaam.TabIndex = 1;
            Voornaam.TextChanged += Voornaam_TextChanged;
            // 
            // Achternaam
            // 
            Achternaam.Location = new Point(295, 257);
            Achternaam.Name = "Achternaam";
            Achternaam.Size = new Size(100, 23);
            Achternaam.TabIndex = 2;
            Achternaam.TextChanged += Achternaam_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(577, 117);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Achternaam);
            Controls.Add(Voornaam);
            Controls.Add(VolledigeNaam);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox VolledigeNaam;
        private TextBox Voornaam;
        private TextBox Achternaam;
        private Button button1;
    }
}
