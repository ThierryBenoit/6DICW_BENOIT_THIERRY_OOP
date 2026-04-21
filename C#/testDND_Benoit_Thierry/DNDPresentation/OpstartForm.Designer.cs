namespace DNDPresentation
{
    partial class OpstartForm
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
            NaamBox = new TextBox();
            Sterktebox = new TextBox();
            VoegToeButton = new Button();
            ToonHierButton = new Button();
            ToonFormulierButton = new Button();
            comboBox1 = new ComboBox();
            NaamEnLeeftijd = new TextBox();
            SuspendLayout();
            // 
            // NaamBox
            // 
            NaamBox.Location = new Point(52, 49);
            NaamBox.Name = "NaamBox";
            NaamBox.Size = new Size(100, 23);
            NaamBox.TabIndex = 0;
            // 
            // Sterktebox
            // 
            Sterktebox.Location = new Point(52, 96);
            Sterktebox.Name = "Sterktebox";
            Sterktebox.Size = new Size(100, 23);
            Sterktebox.TabIndex = 1;
            // 
            // VoegToeButton
            // 
            VoegToeButton.Location = new Point(212, 74);
            VoegToeButton.Name = "VoegToeButton";
            VoegToeButton.Size = new Size(75, 23);
            VoegToeButton.TabIndex = 2;
            VoegToeButton.Text = "Voeg toe";
            VoegToeButton.UseVisualStyleBackColor = true;
            VoegToeButton.Click += VoegToeButton_Click;
            // 
            // ToonHierButton
            // 
            ToonHierButton.Location = new Point(163, 270);
            ToonHierButton.Name = "ToonHierButton";
            ToonHierButton.Size = new Size(75, 23);
            ToonHierButton.TabIndex = 3;
            ToonHierButton.Text = "Toon hier";
            ToonHierButton.UseVisualStyleBackColor = true;
            ToonHierButton.Click += ToonHierButton_Click;
            // 
            // ToonFormulierButton
            // 
            ToonFormulierButton.Location = new Point(163, 224);
            ToonFormulierButton.Name = "ToonFormulierButton";
            ToonFormulierButton.Size = new Size(75, 23);
            ToonFormulierButton.TabIndex = 4;
            ToonFormulierButton.Text = "Toon formulier";
            ToonFormulierButton.UseVisualStyleBackColor = true;
            ToonFormulierButton.Click += ToonFormulierButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(137, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // NaamEnLeeftijd
            // 
            NaamEnLeeftijd.Location = new Point(138, 299);
            NaamEnLeeftijd.Name = "NaamEnLeeftijd";
            NaamEnLeeftijd.Size = new Size(100, 23);
            NaamEnLeeftijd.TabIndex = 6;
            NaamEnLeeftijd.Visible = false;
            // 
            // OpstartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 327);
            Controls.Add(NaamEnLeeftijd);
            Controls.Add(comboBox1);
            Controls.Add(ToonFormulierButton);
            Controls.Add(ToonHierButton);
            Controls.Add(VoegToeButton);
            Controls.Add(Sterktebox);
            Controls.Add(NaamBox);
            Name = "OpstartForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NaamBox;
        private TextBox Sterktebox;
        private Button VoegToeButton;
        private Button ToonHierButton;
        private Button ToonFormulierButton;
        private ComboBox comboBox1;
        private TextBox NaamEnLeeftijd;
    }
}
