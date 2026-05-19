using System.Windows.Forms;

namespace impiccatoGraff
{
    public partial class Form1 : Form
    {
        List<string> parole = new List<string>();
        Random rnd = new Random();
        string trattini = "";

        int tent = 0, contJolly = 0;

        string par, lettera;

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
            trattini = "";
            string[] arrTemp;

            if (parole.Count == 0)
            {
                using (StreamReader sr = new StreamReader("parole_categorie.csv"))
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
                    trattini = trattini + "-";
                }

                lblTrat.Text = "";
                lblTrat.Text = trattini;
            }
            else
            {
                par = parole[rnd.Next(0, parole.Count)];

                for (int i = 0; i < par.Length; i++)
                {
                    trattini = trattini + "-";
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
                lblScritTent.Visible = true;
                buttonJolly.Visible = true;
                messaggioJolly.Visible= false;

                buttonF.Visible = false;
                buttonM.Visible = false;
                buttonD.Visible = false;
                lblGameOver.Visible = false;

            }
            else
            {

                GenPar.Visible = false;
                labelInsert.Visible = false;
                textInsert.Visible = false;
                buttonInsert.Visible = false;
                lblScritTent.Visible = false;
                lblGameOver.Visible = false;
                buttonJolly.Visible = false;
                messaggioJolly.Visible = false;

                buttonF.Visible = true;
                buttonM.Visible = true;
                buttonD.Visible = true;
            }
        }

        private void VisGameOver(bool v)
        {
            if (v == true)
            {
                GenPar.Visible = false;
                labelInsert.Visible = false;
                textInsert.Visible = false;
                buttonInsert.Visible = false;
                lblScritTent.Visible = false;
                lblTent.Visible = false;
                lblTrat.Visible = false;
                buttonJolly.Visible = false;
                messaggioJolly.Visible = false;

                lblGameOver.Text = "";
                lblGameOver.Text = "GAME OVER";

                lblGameOver.Visible = true;
            }
            else
            {
                GenPar.Visible = false;
                labelInsert.Visible = false;
                textInsert.Visible = false;
                buttonInsert.Visible = false;
                lblScritTent.Visible = false;
                lblTent.Visible = false;
                lblTrat.Visible = false;
                buttonJolly.Visible = false;
                messaggioJolly.Visible = false;

                lblGameOver.Text = "";
                lblGameOver.Text = "WIN";

                lblGameOver.Visible = true;
            }
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            tent = 10;
            lblTent.Text = Convert.ToString(tent);
            VisualizzaGioco(true);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            tent = 8;
            lblTent.Text = Convert.ToString(tent);
            VisualizzaGioco(true);

        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            tent = 5;
            lblTent.Text = Convert.ToString(tent);
            VisualizzaGioco(true);

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

            lettera = textInsert.Text;

            lettera = lettera.ToLower();

            par = par.ToLower();

            if (par.Contains(lettera) == true)
            {
                char[] arrayTrattini = trattini.ToCharArray();

                for (int i = 0; i < par.Length; i++)
                {
                    if (par[i] == Convert.ToChar(lettera))
                    {
                        arrayTrattini[i] = Convert.ToChar(lettera);
                    }
                }

                trattini = new string(arrayTrattini);

                lblTrat.Text = "";
                lblTrat.Text = trattini;

                if (lblTrat.Text == par)
                {
                    VisGameOver(false);
                }

            }
            else
            {
                tent = tent - 1;

                lblTent.Text = Convert.ToString(tent);

                if (tent == 0)
                {
                    VisGameOver(true);
                }
            }
        }

        private void buttonJolly_Click(object sender, EventArgs e)
        {
            int indiceLetteraCas = rnd.Next(0, par.Length);
            char letteraScelta;

            if (contJolly == 0)
            {
                while (par[indiceLetteraCas] == trattini[indiceLetteraCas])
                {
                    indiceLetteraCas = rnd.Next(0, par.Length);
                }

                letteraScelta = par[indiceLetteraCas];

                char[] arrayTrattini = trattini.ToCharArray();

                for (int i = 0; i < par.Length; i++)
                {
                    if (par[i] == letteraScelta)
                    {
                        arrayTrattini[i] = letteraScelta;
                    }
                }

                trattini = new string(arrayTrattini);

                lblTrat.Text = "";
                lblTrat.Text = trattini;

                contJolly = contJolly + 1;
            }
            else
            {
                messaggioJolly.Visible = true;
            }
        }
    }
}
