namespace OldSchool
{
    partial class KlasForm
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
            this.afkortingTextBox = new System.Windows.Forms.TextBox();
            this.jaarTextBox = new System.Windows.Forms.TextBox();
            this.richtingTextBox = new System.Windows.Forms.TextBox();
            this.titularisTextBox = new System.Windows.Forms.TextBox();
            this.aantalLeerlingenTextBox = new System.Windows.Forms.TextBox();
            this.klasgegevensTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nieuweTitularisTextBox = new System.Windows.Forms.TextBox();
            this.wijzigTitularisButton = new System.Windows.Forms.Button();
            this.aantalLeerlingMinButton = new System.Windows.Forms.Button();
            this.aantalLeerlingPlusButton = new System.Windows.Forms.Button();
            this.klasgegevensTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // afkortingTextBox
            // 
            this.afkortingTextBox.Location = new System.Drawing.Point(121, 28);
            this.afkortingTextBox.Name = "afkortingTextBox";
            this.afkortingTextBox.ReadOnly = true;
            this.afkortingTextBox.Size = new System.Drawing.Size(153, 20);
            this.afkortingTextBox.TabIndex = 0;
            // 
            // jaarTextBox
            // 
            this.jaarTextBox.Location = new System.Drawing.Point(121, 55);
            this.jaarTextBox.Name = "jaarTextBox";
            this.jaarTextBox.ReadOnly = true;
            this.jaarTextBox.Size = new System.Drawing.Size(153, 20);
            this.jaarTextBox.TabIndex = 1;
            // 
            // richtingTextBox
            // 
            this.richtingTextBox.Location = new System.Drawing.Point(121, 82);
            this.richtingTextBox.Name = "richtingTextBox";
            this.richtingTextBox.ReadOnly = true;
            this.richtingTextBox.Size = new System.Drawing.Size(153, 20);
            this.richtingTextBox.TabIndex = 2;
            // 
            // titularisTextBox
            // 
            this.titularisTextBox.Location = new System.Drawing.Point(121, 109);
            this.titularisTextBox.Name = "titularisTextBox";
            this.titularisTextBox.ReadOnly = true;
            this.titularisTextBox.Size = new System.Drawing.Size(153, 20);
            this.titularisTextBox.TabIndex = 3;
            // 
            // aantalLeerlingenTextBox
            // 
            this.aantalLeerlingenTextBox.Location = new System.Drawing.Point(121, 136);
            this.aantalLeerlingenTextBox.Name = "aantalLeerlingenTextBox";
            this.aantalLeerlingenTextBox.ReadOnly = true;
            this.aantalLeerlingenTextBox.Size = new System.Drawing.Size(153, 20);
            this.aantalLeerlingenTextBox.TabIndex = 4;
            // 
            // klasgegevensTabControl
            // 
            this.klasgegevensTabControl.Controls.Add(this.tabPage1);
            this.klasgegevensTabControl.Controls.Add(this.tabPage2);
            this.klasgegevensTabControl.Location = new System.Drawing.Point(12, 12);
            this.klasgegevensTabControl.Name = "klasgegevensTabControl";
            this.klasgegevensTabControl.SelectedIndex = 0;
            this.klasgegevensTabControl.Size = new System.Drawing.Size(357, 213);
            this.klasgegevensTabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.afkortingTextBox);
            this.tabPage1.Controls.Add(this.aantalLeerlingenTextBox);
            this.tabPage1.Controls.Add(this.jaarTextBox);
            this.tabPage1.Controls.Add(this.titularisTextBox);
            this.tabPage1.Controls.Add(this.richtingTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(349, 187);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "mijn klasje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "aantal leerlingen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "titularis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "richting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "jaar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "afkorting:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Tomato;
            this.tabPage2.Controls.Add(this.nieuweTitularisTextBox);
            this.tabPage2.Controls.Add(this.wijzigTitularisButton);
            this.tabPage2.Controls.Add(this.aantalLeerlingMinButton);
            this.tabPage2.Controls.Add(this.aantalLeerlingPlusButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(349, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "edit";
            // 
            // nieuweTitularisTextBox
            // 
            this.nieuweTitularisTextBox.Location = new System.Drawing.Point(206, 118);
            this.nieuweTitularisTextBox.Name = "nieuweTitularisTextBox";
            this.nieuweTitularisTextBox.Size = new System.Drawing.Size(125, 20);
            this.nieuweTitularisTextBox.TabIndex = 3;
            // 
            // wijzigTitularisButton
            // 
            this.wijzigTitularisButton.Location = new System.Drawing.Point(6, 115);
            this.wijzigTitularisButton.Name = "wijzigTitularisButton";
            this.wijzigTitularisButton.Size = new System.Drawing.Size(189, 23);
            this.wijzigTitularisButton.TabIndex = 2;
            this.wijzigTitularisButton.Text = "Stel in als nieuwe titularis ->";
            this.wijzigTitularisButton.UseVisualStyleBackColor = true;
            this.wijzigTitularisButton.Click += new System.EventHandler(this.wijzigTitularisButton_Click);
            // 
            // aantalLeerlingMinButton
            // 
            this.aantalLeerlingMinButton.Location = new System.Drawing.Point(6, 60);
            this.aantalLeerlingMinButton.Name = "aantalLeerlingMinButton";
            this.aantalLeerlingMinButton.Size = new System.Drawing.Size(189, 23);
            this.aantalLeerlingMinButton.TabIndex = 1;
            this.aantalLeerlingMinButton.Text = "Een leerling vertrekt uit de klas";
            this.aantalLeerlingMinButton.UseVisualStyleBackColor = true;
            this.aantalLeerlingMinButton.Click += new System.EventHandler(this.aantalLeerlingMinButton_Click);
            // 
            // aantalLeerlingPlusButton
            // 
            this.aantalLeerlingPlusButton.Location = new System.Drawing.Point(6, 30);
            this.aantalLeerlingPlusButton.Name = "aantalLeerlingPlusButton";
            this.aantalLeerlingPlusButton.Size = new System.Drawing.Size(189, 23);
            this.aantalLeerlingPlusButton.TabIndex = 0;
            this.aantalLeerlingPlusButton.Text = "Een nieuwe leerling in de klas";
            this.aantalLeerlingPlusButton.UseVisualStyleBackColor = true;
            this.aantalLeerlingPlusButton.Click += new System.EventHandler(this.aantalLeerlingPlusButton_Click);
            // 
            // KlasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 241);
            this.Controls.Add(this.klasgegevensTabControl);
            this.Name = "KlasForm";
            this.Text = "mijn klasje";
            this.klasgegevensTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox afkortingTextBox;
        private System.Windows.Forms.TextBox jaarTextBox;
        private System.Windows.Forms.TextBox richtingTextBox;
        private System.Windows.Forms.TextBox titularisTextBox;
        private System.Windows.Forms.TextBox aantalLeerlingenTextBox;
        private System.Windows.Forms.TabControl klasgegevensTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox nieuweTitularisTextBox;
        private System.Windows.Forms.Button wijzigTitularisButton;
        private System.Windows.Forms.Button aantalLeerlingMinButton;
        private System.Windows.Forms.Button aantalLeerlingPlusButton;
    }
}

