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
            textInsert.Location = new Point(607, 310);
            textInsert.Name = "textInsert";
            textInsert.Size = new Size(107, 23);
            textInsert.TabIndex = 1;
            // 
            // labelInsert
            // 
            labelInsert.AutoSize = true;
            labelInsert.Location = new Point(607, 280);
            labelInsert.Name = "labelInsert";
            labelInsert.Size = new Size(111, 15);
            labelInsert.TabIndex = 2;
            labelInsert.Text = "Inserisci una lettera:";
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(735, 310);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(82, 23);
            buttonInsert.TabIndex = 3;
            buttonInsert.Text = "Inserisci";
            buttonInsert.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(631, 162);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // GenPar
            // 
            GenPar.Location = new Point(607, 162);
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
            lblTrat.Location = new Point(176, 247);
            lblTrat.Name = "lblTrat";
            lblTrat.Size = new Size(0, 15);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 519);
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
    }
}
