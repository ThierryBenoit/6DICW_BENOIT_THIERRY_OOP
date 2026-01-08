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
            this.opnieuwOpStarttijdButton = new System.Windows.Forms.Button();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.aftelklokTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // opnieuwOpStarttijdButton
            // 
            this.opnieuwOpStarttijdButton.Location = new System.Drawing.Point(12, 49);
            this.opnieuwOpStarttijdButton.Name = "opnieuwOpStarttijdButton";
            this.opnieuwOpStarttijdButton.Size = new System.Drawing.Size(260, 23);
            this.opnieuwOpStarttijdButton.TabIndex = 0;
            this.opnieuwOpStarttijdButton.Text = "Op starttijd";
            this.opnieuwOpStarttijdButton.UseVisualStyleBackColor = true;
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.Color.Black;
            this.displayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.displayTextBox.ForeColor = System.Drawing.Color.Yellow;
            this.displayTextBox.Location = new System.Drawing.Point(12, 78);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(260, 50);
            this.displayTextBox.TabIndex = 1;
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.displayTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // aftelklokTimer
            // 
            this.aftelklokTimer.Enabled = true;
            this.aftelklokTimer.Interval = 1000;
            this.aftelklokTimer.Tick += new System.EventHandler(this.aftelklokTimer_Tick);
            // 
            // AftelklokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.opnieuwOpStarttijdButton);
            this.Name = "AftelklokForm";
            this.Text = "Aftelklok";
            this.Load += new System.EventHandler(this.AftelklokForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button opnieuwOpStarttijdButton;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Timer aftelklokTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}

