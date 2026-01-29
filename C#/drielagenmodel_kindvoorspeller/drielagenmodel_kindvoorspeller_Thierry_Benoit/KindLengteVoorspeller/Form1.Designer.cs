namespace KindLengteVoorspeller
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
            label1 = new Label();
            label2 = new Label();
            LengteVrouwTxT = new TextBox();
            LengteManTxT = new TextBox();
            LengteDochterKnop = new Button();
            LengteZoonKnop = new Button();
            AantalPogingen = new TextBox();
            GroteKind = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 33);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Lengte man in cm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 69);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 1;
            label2.Text = "Lengte vrouw in cm:";
            // 
            // LengteVrouwTxT
            // 
            LengteVrouwTxT.Location = new Point(186, 66);
            LengteVrouwTxT.Name = "LengteVrouwTxT";
            LengteVrouwTxT.Size = new Size(100, 23);
            LengteVrouwTxT.TabIndex = 2;
            // 
            // LengteManTxT
            // 
            LengteManTxT.Location = new Point(186, 33);
            LengteManTxT.Name = "LengteManTxT";
            LengteManTxT.Size = new Size(100, 23);
            LengteManTxT.TabIndex = 3;
            // 
            // LengteDochterKnop
            // 
            LengteDochterKnop.Location = new Point(606, 126);
            LengteDochterKnop.Name = "LengteDochterKnop";
            LengteDochterKnop.Size = new Size(140, 23);
            LengteDochterKnop.TabIndex = 4;
            LengteDochterKnop.Text = "Bereken lengte dochter";
            LengteDochterKnop.UseVisualStyleBackColor = true;
            LengteDochterKnop.Click += LengteDochterKnop_Click;
            // 
            // LengteZoonKnop
            // 
            LengteZoonKnop.Location = new Point(606, 155);
            LengteZoonKnop.Name = "LengteZoonKnop";
            LengteZoonKnop.Size = new Size(140, 23);
            LengteZoonKnop.TabIndex = 5;
            LengteZoonKnop.Text = "Bereken lengte zoon";
            LengteZoonKnop.UseVisualStyleBackColor = true;
            LengteZoonKnop.Click += LengteZoonKnop_Click;
            // 
            // AantalPogingen
            // 
            AantalPogingen.Location = new Point(32, 274);
            AantalPogingen.Name = "AantalPogingen";
            AantalPogingen.ReadOnly = true;
            AantalPogingen.Size = new Size(139, 23);
            AantalPogingen.TabIndex = 6;
            AantalPogingen.Text = "Nog geen berekeningen";
            // 
            // GroteKind
            // 
            GroteKind.BackColor = Color.Black;
            GroteKind.Font = new Font("Arial", 29F, FontStyle.Regular, GraphicsUnit.Pixel);
            GroteKind.ForeColor = Color.White;
            GroteKind.Location = new Point(372, 126);
            GroteKind.Name = "GroteKind";
            GroteKind.ReadOnly = true;
            GroteKind.Size = new Size(100, 41);
            GroteKind.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GroteKind);
            Controls.Add(AantalPogingen);
            Controls.Add(LengteZoonKnop);
            Controls.Add(LengteDochterKnop);
            Controls.Add(LengteManTxT);
            Controls.Add(LengteVrouwTxT);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox LengteVrouwTxT;
        private TextBox LengteManTxT;
        private Button LengteDochterKnop;
        private Button LengteZoonKnop;
        private TextBox AantalPogingen;
        private TextBox GroteKind;
    }
}
