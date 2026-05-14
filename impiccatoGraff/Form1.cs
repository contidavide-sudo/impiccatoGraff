using System.Windows.Forms;

namespace impiccatoGraff
{
    public partial class Form1 : Form
    {
        List<string> parole = new List<string>();
        Random rnd = new Random();
        string trattini = "";

        int tent = 0;

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

                buttonF.Visible = true;
                buttonM.Visible = true;
                buttonD.Visible = true;
            }
        }

        private void VisGameOver()
        {
            GenPar.Visible = false;
            labelInsert.Visible = false;
            textInsert.Visible = false;
            buttonInsert.Visible = false;
            lblScritTent.Visible = false;
            lblTent.Visible = false;
            lblGameOver.Visible = true;

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
            }
            else
            {
                tent = tent - 1;

                lblTent.Text = Convert.ToString(tent);

                VisGameOver();
            }
        }

       
    }
}
