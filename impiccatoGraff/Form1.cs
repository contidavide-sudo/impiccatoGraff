using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Reflection.Emit;

namespace impiccatoGraff
{
    public partial class Form1 : Form
    {
        List<string> parole = new List<string>();
        Random rnd = new Random();
        string par;
        Label[] labels;
        public Form1()
        {
            InitializeComponent();
        }

        private void GenPar_Click(object sender, EventArgs e)
        {
            if (parole.Count == 0)
            {
                using (StreamReader sr = new StreamReader("paroleImp.csv"))
                {
                    sr.ReadLine();
                    string riga = sr.ReadLine();

                    while (riga != null)
                    {
                        parole.Add(riga);
                        riga = sr.ReadLine();
                    }
                }
            }
            else
            {
                par = parole[rnd.Next(0, parole.Count)];

                labels = new Label[par.Length];

                for (int i = 0; i < par.Length; i++)
                {
                    labels[i] = new Label();
                    labels[i].Text = "_";
                    labels[i].AutoSize = true;
                    labels[i].Font = new Font("Arial", 20);
                    labels[i].Location = new Point(20 + i * 40, 50);

                    this.Controls.Add(labels[i]);
                }
            }
        }


        }
    }
}
