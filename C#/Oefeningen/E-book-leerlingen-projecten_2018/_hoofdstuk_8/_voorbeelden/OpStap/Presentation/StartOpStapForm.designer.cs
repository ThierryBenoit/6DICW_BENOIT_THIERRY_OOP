namespace Presentation
{
    partial class StartOpStapForm
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
            this.zoekenOpProvincieButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wandelroutesButton
            // 
            this.wandelroutesButton.Location = new System.Drawing.Point(7, 17);
            this.wandelroutesButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.wandelroutesButton.Name = "wandelroutesButton";
            this.wandelroutesButton.Size = new System.Drawing.Size(210, 46);
            this.wandelroutesButton.TabIndex = 0;
            this.wandelroutesButton.Text = "Wandelroutes";
            this.wandelroutesButton.UseVisualStyleBackColor = true;
            this.wandelroutesButton.Click += new System.EventHandler(this.wandelroutesButton_Click);
            // 
            // zoekenOpProvincieButton
            // 
            this.zoekenOpProvincieButton.Location = new System.Drawing.Point(7, 71);
            this.zoekenOpProvincieButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.zoekenOpProvincieButton.Name = "zoekenOpProvincieButton";
            this.zoekenOpProvincieButton.Size = new System.Drawing.Size(210, 46);
            this.zoekenOpProvincieButton.TabIndex = 1;
            this.zoekenOpProvincieButton.Text = "Zoeken op provincie";
            this.zoekenOpProvincieButton.UseVisualStyleBackColor = true;
            this.zoekenOpProvincieButton.Click += new System.EventHandler(this.zoekenOpProvincieButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(7, 125);
            this.infoButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(210, 46);
            this.infoButton.TabIndex = 2;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // StartOpStapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 181);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.zoekenOpProvincieButton);
            this.Controls.Add(this.wandelroutesButton);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "StartOpStapForm";
            this.Text = "Op Stap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wandelroutesButton;
        private System.Windows.Forms.Button zoekenOpProvincieButton;
        private System.Windows.Forms.Button infoButton;
    }
}