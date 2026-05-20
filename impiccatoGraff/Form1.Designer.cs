namespace impiccatoGraff
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
            labelTitolo = new Label();
            textInsert = new TextBox();
            labelInsert = new Label();
            buttonInsert = new Button();
            label1 = new Label();
            GenPar = new Button();
            lblTrat = new Label();
            buttonF = new Button();
            buttonM = new Button();
            buttonD = new Button();
            lblScritTent = new Label();
            lblTent = new Label();
            lblGameOver = new Label();
            buttonJolly = new Button();
            messaggioJolly = new Label();
            buttonIndizioCat = new Button();
            lblCat = new Label();
            lblParInt = new Label();
            InsParInt = new TextBox();
            buttonParInt = new Button();
            SuspendLayout();
            // 
            // labelTitolo
            // 
            labelTitolo.AutoSize = true;
            labelTitolo.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitolo.ForeColor = SystemColors.MenuHighlight;
            labelTitolo.Location = new Point(155, 42);
            labelTitolo.Name = "labelTitolo";
            labelTitolo.Size = new Size(605, 55);
            labelTitolo.TabIndex = 0;
            labelTitolo.Text = "GIOCO DELL' IMPICCATO";
            labelTitolo.TextAlign = ContentAlignment.TopCenter;
            // 
            // textInsert
            // 
            textInsert.Location = new Point(580, 339);
            textInsert.Name = "textInsert";
            textInsert.Size = new Size(107, 23);
            textInsert.TabIndex = 1;
            // 
            // labelInsert
            // 
            labelInsert.AutoSize = true;
            labelInsert.Location = new Point(580, 309);
            labelInsert.Name = "labelInsert";
            labelInsert.Size = new Size(111, 15);
            labelInsert.TabIndex = 2;
            labelInsert.Text = "Inserisci una lettera:";
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(708, 339);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(82, 23);
            buttonInsert.TabIndex = 3;
            buttonInsert.Text = "Inserisci";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(604, 162);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // GenPar
            // 
            GenPar.Location = new Point(580, 160);
            GenPar.Margin = new Padding(3, 2, 3, 2);
            GenPar.Name = "GenPar";
            GenPar.Size = new Size(180, 34);
            GenPar.TabIndex = 5;
            GenPar.Text = "Genera parola";
            GenPar.UseVisualStyleBackColor = true;
            GenPar.Click += GenPar_Click;
            // 
            // lblTrat
            // 
            lblTrat.AutoSize = true;
            lblTrat.Font = new Font("Courier New", 16F, FontStyle.Bold);
            lblTrat.Location = new Point(127, 172);
            lblTrat.Name = "lblTrat";
            lblTrat.Size = new Size(0, 25);
            lblTrat.TabIndex = 6;
            // 
            // buttonF
            // 
            buttonF.Location = new Point(409, 160);
            buttonF.Name = "buttonF";
            buttonF.Size = new Size(105, 39);
            buttonF.TabIndex = 7;
            buttonF.Text = "Facile";
            buttonF.UseVisualStyleBackColor = true;
            buttonF.Click += buttonF_Click;
            // 
            // buttonM
            // 
            buttonM.Location = new Point(409, 235);
            buttonM.Name = "buttonM";
            buttonM.Size = new Size(105, 39);
            buttonM.TabIndex = 8;
            buttonM.Text = "Medio";
            buttonM.UseVisualStyleBackColor = true;
            buttonM.Click += buttonM_Click;
            // 
            // buttonD
            // 
            buttonD.Location = new Point(409, 310);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(105, 39);
            buttonD.TabIndex = 9;
            buttonD.Text = "Diffcile";
            buttonD.UseVisualStyleBackColor = true;
            buttonD.Click += buttonD_Click;
            // 
            // lblScritTent
            // 
            lblScritTent.AutoSize = true;
            lblScritTent.Location = new Point(46, 121);
            lblScritTent.Name = "lblScritTent";
            lblScritTent.Size = new Size(111, 15);
            lblScritTent.TabIndex = 10;
            lblScritTent.Text = "Tentativi rimanenti: ";
            // 
            // lblTent
            // 
            lblTent.AutoSize = true;
            lblTent.Location = new Point(163, 121);
            lblTent.Name = "lblTent";
            lblTent.Size = new Size(0, 15);
            lblTent.TabIndex = 11;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGameOver.ForeColor = SystemColors.MenuHighlight;
            lblGameOver.Location = new Point(264, 223);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(0, 86);
            lblGameOver.TabIndex = 12;
            // 
            // buttonJolly
            // 
            buttonJolly.Location = new Point(593, 391);
            buttonJolly.Name = "buttonJolly";
            buttonJolly.Size = new Size(61, 51);
            buttonJolly.TabIndex = 13;
            buttonJolly.Text = "Jolly ";
            buttonJolly.UseVisualStyleBackColor = true;
            buttonJolly.Click += buttonJolly_Click;
            // 
            // messaggioJolly
            // 
            messaggioJolly.AutoSize = true;
            messaggioJolly.Location = new Point(565, 453);
            messaggioJolly.Name = "messaggioJolly";
            messaggioJolly.Size = new Size(110, 15);
            messaggioJolly.TabIndex = 14;
            messaggioJolly.Text = "Hai hia usato il jolly";
            // 
            // buttonIndizioCat
            // 
            buttonIndizioCat.Location = new Point(708, 391);
            buttonIndizioCat.Margin = new Padding(3, 2, 3, 2);
            buttonIndizioCat.Name = "buttonIndizioCat";
            buttonIndizioCat.Size = new Size(83, 51);
            buttonIndizioCat.TabIndex = 15;
            buttonIndizioCat.Text = "Indizio  categoria";
            buttonIndizioCat.UseVisualStyleBackColor = true;
            buttonIndizioCat.Click += buttonIndizioCat_Click;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Location = new Point(722, 453);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(0, 15);
            lblCat.TabIndex = 16;
            // 
            // lblParInt
            // 
            lblParInt.AutoSize = true;
            lblParInt.Location = new Point(580, 235);
            lblParInt.Name = "lblParInt";
            lblParInt.Size = new Size(133, 15);
            lblParInt.TabIndex = 17;
            lblParInt.Text = "Inserisci la parola intera:";
            // 
            // InsParInt
            // 
            InsParInt.Location = new Point(580, 264);
            InsParInt.Name = "InsParInt";
            InsParInt.Size = new Size(142, 23);
            InsParInt.TabIndex = 18;
            // 
            // buttonParInt
            // 
            buttonParInt.Location = new Point(749, 264);
            buttonParInt.Name = "buttonParInt";
            buttonParInt.Size = new Size(82, 23);
            buttonParInt.TabIndex = 19;
            buttonParInt.Text = "Inserisci";
            buttonParInt.UseVisualStyleBackColor = true;
            buttonParInt.Click += buttonParInt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 519);
            Controls.Add(buttonParInt);
            Controls.Add(InsParInt);
            Controls.Add(lblParInt);
            Controls.Add(lblCat);
            Controls.Add(buttonIndizioCat);
            Controls.Add(messaggioJolly);
            Controls.Add(buttonJolly);
            Controls.Add(lblGameOver);
            Controls.Add(lblTent);
            Controls.Add(lblScritTent);
            Controls.Add(buttonD);
            Controls.Add(buttonM);
            Controls.Add(buttonF);
            Controls.Add(lblTrat);
            Controls.Add(GenPar);
            Controls.Add(label1);
            Controls.Add(buttonInsert);
            Controls.Add(labelInsert);
            Controls.Add(textInsert);
            Controls.Add(labelTitolo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitolo;
        private TextBox textInsert;
        private Label labelInsert;
        private Button buttonInsert;
        private Label label1;
        private Button GenPar;
        private Label lblTrat;
        private Button buttonF;
        private Button buttonM;
        private Button buttonD;
        private Label lblScritTent;
        private Label lblTent;
        private Label lblGameOver;
        private Button buttonJolly;
        private Label messaggioJolly;
        private Button buttonIndizioCat;
        private Label lblCat;
        private Label lblParInt;
        private TextBox InsParInt;
        private Button buttonParInt;
    }
}
