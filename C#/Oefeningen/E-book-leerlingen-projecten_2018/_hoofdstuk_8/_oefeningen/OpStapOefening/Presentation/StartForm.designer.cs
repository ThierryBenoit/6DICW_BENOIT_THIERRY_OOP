namespace Presentation
{
    partial class StartForm
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
            this.wandelroutesButton = new System.Windows.Forms.Button();
            this.oef1Button = new System.Windows.Forms.Button();
            this.oef2Button = new System.Windows.Forms.Button();
            this.oef4Button = new System.Windows.Forms.Button();
            this.oef3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wandelroutesButton
            // 
            this.wandelroutesButton.Location = new System.Drawing.Point(7, 17);
            this.wandelroutesButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.wandelroutesButton.Name = "wandelroutesButton";
            this.wandelroutesButton.Size = new System.Drawing.Size(452, 46);
            this.wandelroutesButton.TabIndex = 0;
            this.wandelroutesButton.Text = "Wandelroutes";
            this.wandelroutesButton.UseVisualStyleBackColor = true;
            this.wandelroutesButton.Click += new System.EventHandler(this.wandelroutesButton_Click);
            // 
            // oef1Button
            // 
            this.oef1Button.Location = new System.Drawing.Point(7, 71);
            this.oef1Button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.oef1Button.Name = "oef1Button";
            this.oef1Button.Size = new System.Drawing.Size(452, 46);
            this.oef1Button.TabIndex = 0;
            this.oef1Button.Text = "Oef 1: Filter wandelroutes op max afstand";
            this.oef1Button.UseVisualStyleBackColor = true;
            this.oef1Button.Click += new System.EventHandler(this.oef1Button_Click);
            // 
            // oef2Button
            // 
            this.oef2Button.Location = new System.Drawing.Point(7, 122);
            this.oef2Button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.oef2Button.Name = "oef2Button";
            this.oef2Button.Size = new System.Drawing.Size(452, 46);
            this.oef2Button.TabIndex = 0;
            this.oef2Button.Text = "Oef 2: Filter wandelroutes op range afstand";
            this.oef2Button.UseVisualStyleBackColor = true;
            this.oef2Button.Click += new System.EventHandler(this.oef2Button_Click);
            // 
            // oef4Button
            // 
            this.oef4Button.Location = new System.Drawing.Point(7, 227);
            this.oef4Button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.oef4Button.Name = "oef4Button";
            this.oef4Button.Size = new System.Drawing.Size(452, 46);
            this.oef4Button.TabIndex = 0;
            this.oef4Button.Text = "Oef 4: De langste wandelroute";
            this.oef4Button.UseVisualStyleBackColor = true;
            this.oef4Button.Click += new System.EventHandler(this.oef4Button_Click);
            // 
            // oef3Button
            // 
            this.oef3Button.Location = new System.Drawing.Point(7, 173);
            this.oef3Button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.oef3Button.Name = "oef3Button";
            this.oef3Button.Size = new System.Drawing.Size(452, 46);
            this.oef3Button.TabIndex = 0;
            this.oef3Button.Text = "Oef 3: Wis wandelroutes voor een gemeente";
            this.oef3Button.UseVisualStyleBackColor = true;
            this.oef3Button.Click += new System.EventHandler(this.oef3Button_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 296);
            this.Controls.Add(this.oef4Button);
            this.Controls.Add(this.oef3Button);
            this.Controls.Add(this.oef2Button);
            this.Controls.Add(this.oef1Button);
            this.Controls.Add(this.wandelroutesButton);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "StartForm";
            this.Text = "Op Stap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wandelroutesButton;
        private System.Windows.Forms.Button oef1Button;
        private System.Windows.Forms.Button oef2Button;
        private System.Windows.Forms.Button oef4Button;
        private System.Windows.Forms.Button oef3Button;
    }
}