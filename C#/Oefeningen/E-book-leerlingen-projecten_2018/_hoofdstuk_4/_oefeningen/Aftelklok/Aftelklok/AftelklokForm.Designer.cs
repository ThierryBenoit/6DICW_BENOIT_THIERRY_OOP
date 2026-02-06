namespace Aftelklok
{
    partial class AftelklokForm
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
            this.components = new System.ComponentModel.Container();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.opnieuwOpStarttijd = new System.Windows.Forms.Button();
            this.aftelklokTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.opnieuw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.Color.Black;
            this.displayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextBox.ForeColor = System.Drawing.Color.Lime;
            this.displayTextBox.Location = new System.Drawing.Point(27, 41);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(128, 49);
            this.displayTextBox.TabIndex = 0;
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.displayTextBox.TextChanged += new System.EventHandler(this.displayTextBox_TextChanged);
            // 
            // opnieuwOpStarttijd
            // 
            this.opnieuwOpStarttijd.Location = new System.Drawing.Point(27, 12);
            this.opnieuwOpStarttijd.Name = "opnieuwOpStarttijd";
            this.opnieuwOpStarttijd.Size = new System.Drawing.Size(128, 23);
            this.opnieuwOpStarttijd.TabIndex = 1;
            this.opnieuwOpStarttijd.Text = "Op starttijd";
            this.opnieuwOpStarttijd.UseVisualStyleBackColor = true;
            this.opnieuwOpStarttijd.Click += new System.EventHandler(this.opnieuwOpStarttijd_Click);
            // 
            // aftelklokTimer
            // 
            this.aftelklokTimer.Enabled = true;
            this.aftelklokTimer.Interval = 1000;
            this.aftelklokTimer.Tick += new System.EventHandler(this.aftelklokTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // opnieuw
            // 
            this.opnieuw.Location = new System.Drawing.Point(91, 96);
            this.opnieuw.Name = "opnieuw";
            this.opnieuw.Size = new System.Drawing.Size(64, 23);
            this.opnieuw.TabIndex = 3;
            this.opnieuw.Text = "STOP";
            this.opnieuw.UseVisualStyleBackColor = true;
            this.opnieuw.Click += new System.EventHandler(this.button2_Click);
            // 
            // AftelklokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 155);
            this.Controls.Add(this.opnieuw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.opnieuwOpStarttijd);
            this.Controls.Add(this.displayTextBox);
            this.Name = "AftelklokForm";
            this.Text = "Aftelklok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button opnieuwOpStarttijd;
        private System.Windows.Forms.Timer aftelklokTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button opnieuw;
    }
}

