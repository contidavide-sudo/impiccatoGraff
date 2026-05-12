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
            textInsert.Location = new Point(694, 413);
            textInsert.Margin = new Padding(3, 4, 3, 4);
            textInsert.Name = "textInsert";
            textInsert.Size = new Size(122, 27);
            textInsert.TabIndex = 1;
            // 
            // labelInsert
            // 
            labelInsert.AutoSize = true;
            labelInsert.Location = new Point(694, 374);
            labelInsert.Name = "labelInsert";
            labelInsert.Size = new Size(139, 20);
            labelInsert.TabIndex = 2;
            labelInsert.Text = "Inserisci una lettera:";
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(840, 413);
            buttonInsert.Margin = new Padding(3, 4, 3, 4);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(94, 31);
            buttonInsert.TabIndex = 3;
            buttonInsert.Text = "Inserisci";
            buttonInsert.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(721, 216);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // GenPar
            // 
            GenPar.Location = new Point(694, 216);
            GenPar.Name = "GenPar";
            GenPar.Size = new Size(206, 46);
            GenPar.TabIndex = 5;
            GenPar.Text = "Genera parola";
            GenPar.UseVisualStyleBackColor = true;
            GenPar.Click += GenPar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 692);
            Controls.Add(GenPar);
            Controls.Add(label1);
            Controls.Add(buttonInsert);
            Controls.Add(labelInsert);
            Controls.Add(textInsert);
            Controls.Add(labelTitolo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
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
    }
}
