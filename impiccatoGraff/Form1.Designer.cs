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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            immBase = new PictureBox();
            immPalo = new PictureBox();
            immPaloOr = new PictureBox();
            immCorda = new PictureBox();
            immTesta = new PictureBox();
            immCorpo = new PictureBox();
            immBraSin = new PictureBox();
            immBraDes = new PictureBox();
            immGamSin = new PictureBox();
            immGamDes = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)immBase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)immPalo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)immPaloOr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)immCorda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)immTesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)immCorpo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)immBraSin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)immBraDes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)immGamSin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)immGamDes).BeginInit();
            SuspendLayout();
            // 
            // labelTitolo
            // 
            labelTitolo.AutoSize = true;
            labelTitolo.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitolo.ForeColor = SystemColors.MenuHighlight;
            labelTitolo.Location = new Point(177, 56);
            labelTitolo.Name = "labelTitolo";
            labelTitolo.Size = new Size(757, 69);
            labelTitolo.TabIndex = 0;
            labelTitolo.Text = "GIOCO DELL' IMPICCATO";
            labelTitolo.TextAlign = ContentAlignment.TopCenter;
            // 
            // textInsert
            // 
            textInsert.Location = new Point(663, 452);
            textInsert.Margin = new Padding(3, 4, 3, 4);
            textInsert.Name = "textInsert";
            textInsert.Size = new Size(122, 27);
            textInsert.TabIndex = 1;
            // 
            // labelInsert
            // 
            labelInsert.AutoSize = true;
            labelInsert.Location = new Point(663, 412);
            labelInsert.Name = "labelInsert";
            labelInsert.Size = new Size(139, 20);
            labelInsert.TabIndex = 2;
            labelInsert.Text = "Inserisci una lettera:";
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(809, 452);
            buttonInsert.Margin = new Padding(3, 4, 3, 4);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(94, 31);
            buttonInsert.TabIndex = 3;
            buttonInsert.Text = "Inserisci";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(690, 216);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // GenPar
            // 
            GenPar.Location = new Point(663, 213);
            GenPar.Name = "GenPar";
            GenPar.Size = new Size(206, 45);
            GenPar.TabIndex = 5;
            GenPar.Text = "Genera parola";
            GenPar.UseVisualStyleBackColor = true;
            GenPar.Click += GenPar_Click;
            // 
            // lblTrat
            // 
            lblTrat.AutoSize = true;
            lblTrat.Font = new Font("Courier New", 16F, FontStyle.Bold);
            lblTrat.Location = new Point(145, 229);
            lblTrat.Name = "lblTrat";
            lblTrat.Size = new Size(0, 31);
            lblTrat.TabIndex = 6;
            // 
            // buttonF
            // 
            buttonF.Location = new Point(467, 213);
            buttonF.Margin = new Padding(3, 4, 3, 4);
            buttonF.Name = "buttonF";
            buttonF.Size = new Size(120, 52);
            buttonF.TabIndex = 7;
            buttonF.Text = "Facile";
            buttonF.UseVisualStyleBackColor = true;
            buttonF.Click += buttonF_Click;
            // 
            // buttonM
            // 
            buttonM.Location = new Point(467, 313);
            buttonM.Margin = new Padding(3, 4, 3, 4);
            buttonM.Name = "buttonM";
            buttonM.Size = new Size(120, 52);
            buttonM.TabIndex = 8;
            buttonM.Text = "Medio";
            buttonM.UseVisualStyleBackColor = true;
            buttonM.Click += buttonM_Click;
            // 
            // buttonD
            // 
            buttonD.Location = new Point(467, 413);
            buttonD.Margin = new Padding(3, 4, 3, 4);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(120, 52);
            buttonD.TabIndex = 9;
            buttonD.Text = "Diffcile";
            buttonD.UseVisualStyleBackColor = true;
            buttonD.Click += buttonD_Click;
            // 
            // lblScritTent
            // 
            lblScritTent.AutoSize = true;
            lblScritTent.Location = new Point(53, 161);
            lblScritTent.Name = "lblScritTent";
            lblScritTent.Size = new Size(139, 20);
            lblScritTent.TabIndex = 10;
            lblScritTent.Text = "Tentativi rimanenti: ";
            // 
            // lblTent
            // 
            lblTent.AutoSize = true;
            lblTent.Location = new Point(186, 161);
            lblTent.Name = "lblTent";
            lblTent.Size = new Size(0, 20);
            lblTent.TabIndex = 11;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGameOver.ForeColor = SystemColors.MenuHighlight;
            lblGameOver.Location = new Point(302, 297);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(0, 106);
            lblGameOver.TabIndex = 12;
            // 
            // buttonJolly
            // 
            buttonJolly.Location = new Point(678, 521);
            buttonJolly.Margin = new Padding(3, 4, 3, 4);
            buttonJolly.Name = "buttonJolly";
            buttonJolly.Size = new Size(70, 68);
            buttonJolly.TabIndex = 13;
            buttonJolly.Text = "Jolly ";
            buttonJolly.UseVisualStyleBackColor = true;
            buttonJolly.Click += buttonJolly_Click;
            // 
            // messaggioJolly
            // 
            messaggioJolly.AutoSize = true;
            messaggioJolly.Location = new Point(646, 604);
            messaggioJolly.Name = "messaggioJolly";
            messaggioJolly.Size = new Size(140, 20);
            messaggioJolly.TabIndex = 14;
            messaggioJolly.Text = "Hai hia usato il jolly";
            // 
            // buttonIndizioCat
            // 
            buttonIndizioCat.Location = new Point(809, 521);
            buttonIndizioCat.Name = "buttonIndizioCat";
            buttonIndizioCat.Size = new Size(95, 68);
            buttonIndizioCat.TabIndex = 15;
            buttonIndizioCat.Text = "Indizio  categoria";
            buttonIndizioCat.UseVisualStyleBackColor = true;
            buttonIndizioCat.Click += buttonIndizioCat_Click;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Location = new Point(825, 604);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(0, 20);
            lblCat.TabIndex = 16;
            // 
            // lblParInt
            // 
            lblParInt.AutoSize = true;
            lblParInt.Location = new Point(663, 313);
            lblParInt.Name = "lblParInt";
            lblParInt.Size = new Size(169, 20);
            lblParInt.TabIndex = 17;
            lblParInt.Text = "Inserisci la parola intera:";
            // 
            // InsParInt
            // 
            InsParInt.Location = new Point(663, 352);
            InsParInt.Margin = new Padding(3, 4, 3, 4);
            InsParInt.Name = "InsParInt";
            InsParInt.Size = new Size(162, 27);
            InsParInt.TabIndex = 18;
            // 
            // buttonParInt
            // 
            buttonParInt.Location = new Point(856, 352);
            buttonParInt.Margin = new Padding(3, 4, 3, 4);
            buttonParInt.Name = "buttonParInt";
            buttonParInt.Size = new Size(94, 31);
            buttonParInt.TabIndex = 19;
            buttonParInt.Text = "Inserisci";
            buttonParInt.UseVisualStyleBackColor = true;
            buttonParInt.Click += buttonParInt_Click;
            // 
            // immBase
            // 
            immBase.Image = (Image)resources.GetObject("immBase.Image");
            immBase.Location = new Point(2, 406);
            immBase.Name = "immBase";
            immBase.Size = new Size(347, 283);
            immBase.SizeMode = PictureBoxSizeMode.Zoom;
            immBase.TabIndex = 20;
            immBase.TabStop = false;
            // 
            // immPalo
            // 
            immPalo.Image = (Image)resources.GetObject("immPalo.Image");
            immPalo.Location = new Point(99, 297);
            immPalo.Name = "immPalo";
            immPalo.Size = new Size(125, 366);
            immPalo.TabIndex = 21;
            immPalo.TabStop = false;
            // 
            // immPaloOr
            // 
            immPaloOr.Image = (Image)resources.GetObject("immPaloOr.Image");
            immPaloOr.Location = new Point(99, 297);
            immPaloOr.Name = "immPaloOr";
            immPaloOr.Size = new Size(255, 66);
            immPaloOr.TabIndex = 22;
            immPaloOr.TabStop = false;
            // 
            // immCorda
            // 
            immCorda.Image = (Image)resources.GetObject("immCorda.Image");
            immCorda.Location = new Point(126, 313);
            immCorda.Name = "immCorda";
            immCorda.Size = new Size(285, 350);
            immCorda.SizeMode = PictureBoxSizeMode.Zoom;
            immCorda.TabIndex = 23;
            immCorda.TabStop = false;
            // 
            // immTesta
            // 
            immTesta.Image = (Image)resources.GetObject("immTesta.Image");
            immTesta.Location = new Point(279, 380);
            immTesta.Name = "immTesta";
            immTesta.Size = new Size(86, 69);
            immTesta.SizeMode = PictureBoxSizeMode.CenterImage;
            immTesta.TabIndex = 24;
            immTesta.TabStop = false;
            // 
            // immCorpo
            // 
            immCorpo.Image = (Image)resources.GetObject("immCorpo.Image");
            immCorpo.Location = new Point(247, 436);
            immCorpo.Name = "immCorpo";
            immCorpo.Size = new Size(150, 85);
            immCorpo.SizeMode = PictureBoxSizeMode.CenterImage;
            immCorpo.TabIndex = 25;
            immCorpo.TabStop = false;
            // 
            // immBraSin
            // 
            immBraSin.Image = (Image)resources.GetObject("immBraSin.Image");
            immBraSin.Location = new Point(262, 455);
            immBraSin.Name = "immBraSin";
            immBraSin.Size = new Size(57, 38);
            immBraSin.SizeMode = PictureBoxSizeMode.CenterImage;
            immBraSin.TabIndex = 26;
            immBraSin.TabStop = false;
            // 
            // immBraDes
            // 
            immBraDes.Image = (Image)resources.GetObject("immBraDes.Image");
            immBraDes.Location = new Point(325, 455);
            immBraDes.Name = "immBraDes";
            immBraDes.Size = new Size(54, 35);
            immBraDes.SizeMode = PictureBoxSizeMode.CenterImage;
            immBraDes.TabIndex = 27;
            immBraDes.TabStop = false;
            // 
            // immGamSin
            // 
            immGamSin.Image = (Image)resources.GetObject("immGamSin.Image");
            immGamSin.Location = new Point(230, 521);
            immGamSin.Name = "immGamSin";
            immGamSin.Size = new Size(125, 62);
            immGamSin.SizeMode = PictureBoxSizeMode.CenterImage;
            immGamSin.TabIndex = 28;
            immGamSin.TabStop = false;
            // 
            // immGamDes
            // 
            immGamDes.Image = (Image)resources.GetObject("immGamDes.Image");
            immGamDes.Location = new Point(325, 521);
            immGamDes.Name = "immGamDes";
            immGamDes.Size = new Size(57, 62);
            immGamDes.SizeMode = PictureBoxSizeMode.CenterImage;
            immGamDes.TabIndex = 29;
            immGamDes.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 692);
            Controls.Add(immGamDes);
            Controls.Add(immGamSin);
            Controls.Add(immBraDes);
            Controls.Add(immBraSin);
            Controls.Add(immCorpo);
            Controls.Add(immTesta);
            Controls.Add(immPaloOr);
            Controls.Add(immPalo);
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
            Controls.Add(immCorda);
            Controls.Add(immBase);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)immBase).EndInit();
            ((System.ComponentModel.ISupportInitialize)immPalo).EndInit();
            ((System.ComponentModel.ISupportInitialize)immPaloOr).EndInit();
            ((System.ComponentModel.ISupportInitialize)immCorda).EndInit();
            ((System.ComponentModel.ISupportInitialize)immTesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)immCorpo).EndInit();
            ((System.ComponentModel.ISupportInitialize)immBraSin).EndInit();
            ((System.ComponentModel.ISupportInitialize)immBraDes).EndInit();
            ((System.ComponentModel.ISupportInitialize)immGamSin).EndInit();
            ((System.ComponentModel.ISupportInitialize)immGamDes).EndInit();
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
        private PictureBox immBase;
        private PictureBox immPalo;
        private PictureBox immPaloOr;
        private PictureBox immCorda;
        private PictureBox immTesta;
        private PictureBox immCorpo;
        private PictureBox immBraSin;
        private PictureBox immBraDes;
        private PictureBox immGamSin;
        private PictureBox immGamDes;
    }
}
