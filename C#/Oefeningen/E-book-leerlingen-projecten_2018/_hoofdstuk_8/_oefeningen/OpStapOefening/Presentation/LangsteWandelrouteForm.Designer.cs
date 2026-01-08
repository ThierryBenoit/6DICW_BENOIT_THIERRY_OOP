namespace Presentation
{
    partial class LangsteWandelrouteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LangsteWandelrouteForm));
            this.label1 = new System.Windows.Forms.Label();
            this.langsteRouteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // langsteRouteLabel
            // 
            this.langsteRouteLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.langsteRouteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.langsteRouteLabel.ForeColor = System.Drawing.Color.White;
            this.langsteRouteLabel.Location = new System.Drawing.Point(12, 132);
            this.langsteRouteLabel.Name = "langsteRouteLabel";
            this.langsteRouteLabel.Size = new System.Drawing.Size(297, 20);
            this.langsteRouteLabel.TabIndex = 2;
            this.langsteRouteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LangsteWandelrouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 180);
            this.Controls.Add(this.langsteRouteLabel);
            this.Controls.Add(this.label1);
            this.Name = "LangsteWandelrouteForm";
            this.Text = "LangsteWandelrouteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label langsteRouteLabel;
    }
}