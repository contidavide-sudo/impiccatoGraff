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
            SuspendLayout();
            // 
            // labelTitolo
            // 
            labelTitolo.AutoSize = true;
            labelTitolo.Font = new Font("Swis721 BdCnOul BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitolo.ForeColor = SystemColors.MenuHighlight;
            labelTitolo.Location = new Point(225, 32);
            labelTitolo.Name = "labelTitolo";
            labelTitolo.Size = new Size(493, 58);
            labelTitolo.TabIndex = 0;
            labelTitolo.Text = "GIOCO DELL' IMPICCATO";
            labelTitolo.TextAlign = ContentAlignment.TopCenter;
            labelTitolo.Click += label1_Click;
            // 
            // textInsert
            // 
            textInsert.Location = new Point(607, 275);
            textInsert.Name = "textInsert";
            textInsert.Size = new Size(107, 23);
            textInsert.TabIndex = 1;
            // 
            // labelInsert
            // 
            labelInsert.AutoSize = true;
            labelInsert.Location = new Point(607, 246);
            labelInsert.Name = "labelInsert";
            labelInsert.Size = new Size(111, 15);
            labelInsert.TabIndex = 2;
            labelInsert.Text = "Inserisci una lettera:";
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(735, 275);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(82, 23);
            buttonInsert.TabIndex = 3;
            buttonInsert.Text = "Inserisci";
            buttonInsert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 519);
            Controls.Add(buttonInsert);
            Controls.Add(labelInsert);
            Controls.Add(textInsert);
            Controls.Add(labelTitolo);
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
    }
}
