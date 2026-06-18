namespace Presentation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DataGridViewVloot = new System.Windows.Forms.DataGridView();
            this.dataGridViewPlaneten = new System.Windows.Forms.DataGridView();
            this.dataGridViewPersonages = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CylonDetectButton = new System.Windows.Forms.Button();
            this.LaadVlootButton = new System.Windows.Forms.Button();
            this.LaadPersonagesButton = new System.Windows.Forms.Button();
            this.HerlaadButton = new System.Windows.Forms.Button();
            this.LaadPlanetenButton = new System.Windows.Forms.Button();
            this.DeleteCyclonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVloot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaneten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonages)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewVloot
            // 
            this.DataGridViewVloot.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridViewVloot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewVloot.Location = new System.Drawing.Point(12, 568);
            this.DataGridViewVloot.Name = "DataGridViewVloot";
            this.DataGridViewVloot.RowHeadersWidth = 51;
            this.DataGridViewVloot.RowTemplate.Height = 24;
            this.DataGridViewVloot.Size = new System.Drawing.Size(637, 209);
            this.DataGridViewVloot.TabIndex = 0;
            // 
            // dataGridViewPlaneten
            // 
            this.dataGridViewPlaneten.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPlaneten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaneten.Location = new System.Drawing.Point(12, 365);
            this.dataGridViewPlaneten.Name = "dataGridViewPlaneten";
            this.dataGridViewPlaneten.RowHeadersWidth = 51;
            this.dataGridViewPlaneten.RowTemplate.Height = 24;
            this.dataGridViewPlaneten.Size = new System.Drawing.Size(637, 197);
            this.dataGridViewPlaneten.TabIndex = 1;
            // 
            // dataGridViewPersonages
            // 
            this.dataGridViewPersonages.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPersonages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonages.Location = new System.Drawing.Point(676, 163);
            this.dataGridViewPersonages.Name = "dataGridViewPersonages";
            this.dataGridViewPersonages.RowHeadersWidth = 51;
            this.dataGridViewPersonages.RowTemplate.Height = 24;
            this.dataGridViewPersonages.Size = new System.Drawing.Size(367, 614);
            this.dataGridViewPersonages.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 85);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cylon Detector Test";
            // 
            // CylonDetectButton
            // 
            this.CylonDetectButton.Location = new System.Drawing.Point(12, 84);
            this.CylonDetectButton.Name = "CylonDetectButton";
            this.CylonDetectButton.Size = new System.Drawing.Size(222, 47);
            this.CylonDetectButton.TabIndex = 4;
            this.CylonDetectButton.Text = "Detect Cylon";
            this.CylonDetectButton.UseVisualStyleBackColor = true;
            this.CylonDetectButton.Click += new System.EventHandler(this.CylonDetectButton_Click);
            // 
            // LaadVlootButton
            // 
            this.LaadVlootButton.Location = new System.Drawing.Point(12, 137);
            this.LaadVlootButton.Name = "LaadVlootButton";
            this.LaadVlootButton.Size = new System.Drawing.Size(222, 47);
            this.LaadVlootButton.TabIndex = 5;
            this.LaadVlootButton.Text = "Laad Vloot";
            this.LaadVlootButton.UseVisualStyleBackColor = true;
            this.LaadVlootButton.Click += new System.EventHandler(this.LaadVlootButton_Click);
            // 
            // LaadPersonagesButton
            // 
            this.LaadPersonagesButton.Location = new System.Drawing.Point(12, 188);
            this.LaadPersonagesButton.Name = "LaadPersonagesButton";
            this.LaadPersonagesButton.Size = new System.Drawing.Size(222, 47);
            this.LaadPersonagesButton.TabIndex = 6;
            this.LaadPersonagesButton.Text = "Laad Personages";
            this.LaadPersonagesButton.UseVisualStyleBackColor = true;
            this.LaadPersonagesButton.Click += new System.EventHandler(this.LaadPersonagesButton_Click);
            // 
            // HerlaadButton
            // 
            this.HerlaadButton.Location = new System.Drawing.Point(12, 241);
            this.HerlaadButton.Name = "HerlaadButton";
            this.HerlaadButton.Size = new System.Drawing.Size(222, 47);
            this.HerlaadButton.TabIndex = 7;
            this.HerlaadButton.Text = "Herlaad data";
            this.HerlaadButton.UseVisualStyleBackColor = true;
            this.HerlaadButton.Click += new System.EventHandler(this.HerlaadButton_Click);
            // 
            // LaadPlanetenButton
            // 
            this.LaadPlanetenButton.Location = new System.Drawing.Point(12, 294);
            this.LaadPlanetenButton.Name = "LaadPlanetenButton";
            this.LaadPlanetenButton.Size = new System.Drawing.Size(222, 47);
            this.LaadPlanetenButton.TabIndex = 8;
            this.LaadPlanetenButton.Text = "Laad planeten";
            this.LaadPlanetenButton.UseVisualStyleBackColor = true;
            this.LaadPlanetenButton.Click += new System.EventHandler(this.LaadPlanetenButton_Click);
            // 
            // DeleteCyclonButton
            // 
            this.DeleteCyclonButton.Location = new System.Drawing.Point(741, 97);
            this.DeleteCyclonButton.Name = "DeleteCyclonButton";
            this.DeleteCyclonButton.Size = new System.Drawing.Size(222, 47);
            this.DeleteCyclonButton.TabIndex = 9;
            this.DeleteCyclonButton.Text = "Delete Cylon";
            this.DeleteCyclonButton.UseVisualStyleBackColor = true;
            this.DeleteCyclonButton.Click += new System.EventHandler(this.DeleteCyclonButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 796);
            this.Controls.Add(this.DeleteCyclonButton);
            this.Controls.Add(this.LaadPlanetenButton);
            this.Controls.Add(this.HerlaadButton);
            this.Controls.Add(this.LaadPersonagesButton);
            this.Controls.Add(this.LaadVlootButton);
            this.Controls.Add(this.CylonDetectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPersonages);
            this.Controls.Add(this.dataGridViewPlaneten);
            this.Controls.Add(this.DataGridViewVloot);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVloot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaneten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewVloot;
        private System.Windows.Forms.DataGridView dataGridViewPlaneten;
        private System.Windows.Forms.DataGridView dataGridViewPersonages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CylonDetectButton;
        private System.Windows.Forms.Button LaadVlootButton;
        private System.Windows.Forms.Button LaadPersonagesButton;
        private System.Windows.Forms.Button HerlaadButton;
        private System.Windows.Forms.Button LaadPlanetenButton;
        private System.Windows.Forms.Button DeleteCyclonButton;
    }
}

