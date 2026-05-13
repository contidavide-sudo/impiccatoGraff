using System.Windows.Forms;

namespace impiccatoGraff
{
    public partial class Form1 : Form
    {
        List<string> parole = new List<string>();
        Random rnd = new Random();

        int tent = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VisualizzaGioco(false);
        }

        private void GenPar_Click(object sender, EventArgs e)
        {
            string par, trattini = "";
            string[] arrTemp;

            if (parole.Count == 0)
            {
                using (StreamReader sr = new StreamReader("lista_categorie.csv"))
                {
                    sr.ReadLine();
                    string riga = sr.ReadLine();

                    while (riga != null)
                    {
                        arrTemp = riga.Split(',');

                        for (int i = 0; i < arrTemp.Length; i++)
                        {
                            parole.Add(arrTemp[i]);
                        }

                        riga = sr.ReadLine();
                    }
                }

                par = parole[rnd.Next(0, parole.Count)];

                for (int i = 0; i < par.Length; i++)
                {
                    trattini = trattini + " _ ";
                }

                lblTrat.Text = "";
                lblTrat.Text = trattini;
            }
            else
            {
                par = parole[rnd.Next(0, parole.Count)];

                for (int i = 0; i < par.Length; i++)
                {
                    trattini = trattini + " _ ";
                }

                lblTrat.Text = "";
                lblTrat.Text = trattini;
            }
        }
        private void VisualizzaGioco(bool v)
        {
            if (v == true)
            {
                GenPar.Visible = true;
                labelInsert.Visible = true;
                textInsert.Visible = true;
                buttonInsert.Visible = true;

                buttonF.Visible = false;
                buttonM.Visible = false;
                buttonD.Visible = false;

            }
            else
            {

                GenPar.Visible = false;
                labelInsert.Visible = false;
                textInsert.Visible = false;
                buttonInsert.Visible = false;

                buttonF.Visible = true;
                buttonM.Visible = true;
                buttonD.Visible = true;
            }
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            tent = 10;
            VisualizzaGioco(true);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            tent = 8;
            VisualizzaGioco(true);

        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            tent = 5;
            VisualizzaGioco(true);

        }

    }
}
