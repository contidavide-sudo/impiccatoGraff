using System.Windows.Forms;

namespace impiccatoGraff
{
    public partial class Form1 : Form
    {
        //Inizializzazione delle variabili globali
        List<string> parole = new List<string>();
        Random rnd = new Random();
        string trattini = "", mod;

        private PictureBox[] immImp;

        int tent = 0, contJolly = 0, cont = 0;

        string par, lettera;

        public Form1()
        {
            InitializeComponent();

            //Inizializzazione dell'array di pictureBox per la comparsa dellimpiccato
            immImp = new PictureBox[] { immBase, immPalo, immPaloOr, immCorda, immTesta, immCorpo, immBraSin, immBraDes, immGamSin, immGamDes };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Preaparazione del campo di gioco quando avvio il programma
            VisualizzaGioco(false);
        }

        //Funzione del pulsante per la generazione della parola segreta
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
                buttonIndizioCat.Visible = true;
                lblCat.Visible = true;
                messaggioJolly.Visible = false;
                InsParInt.Visible = true;
                buttonParInt.Visible = true;
                lblParInt.Visible = true;

                immBase.Visible = false;
                immPalo.Visible = false;
                immPaloOr.Visible = false;
                immCorda.Visible = false;
                immTesta.Visible = false;
                immCorpo.Visible = false;
                immBraSin.Visible = false;
                immBraDes.Visible = false;
                immGamSin.Visible = false;
                immGamDes.Visible = false;

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
                buttonIndizioCat.Visible = false;
                messaggioJolly.Visible = false;
                lblCat.Visible = false;
                InsParInt.Visible = false;
                buttonParInt.Visible = false;
                lblParInt.Visible = false;

                immBase.Visible = false;
                immPalo.Visible = false;
                immPaloOr.Visible = false;
                immCorda.Visible = false;
                immTesta.Visible = false;
                immCorpo.Visible = false;
                immBraSin.Visible = false;
                immBraDes.Visible = false;
                immGamSin.Visible = false;
                immGamDes.Visible = false;

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
                buttonIndizioCat.Visible = false;
                messaggioJolly.Visible = false;
                lblCat.Visible = false;
                InsParInt.Visible = false;
                buttonParInt.Visible = false;
                lblParInt.Visible = false;

                immBase.Visible = false;
                immPalo.Visible = false;
                immPaloOr.Visible = false;
                immCorda.Visible = false;
                immTesta.Visible = false;
                immCorpo.Visible = false;
                immBraSin.Visible = false;
                immBraDes.Visible = false;
                immGamSin.Visible = false;
                immGamDes.Visible = false;

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
                buttonIndizioCat.Visible = false;
                messaggioJolly.Visible = false;
                lblCat.Visible = false;
                InsParInt.Visible = false;
                buttonParInt.Visible = false;
                lblParInt.Visible = false;

                immBase.Visible = false;
                immPalo.Visible = false;
                immPaloOr.Visible = false;
                immCorda.Visible = false;
                immTesta.Visible = false;
                immCorpo.Visible = false;
                immBraSin.Visible = false;
                immBraDes.Visible = false;
                immGamSin.Visible = false;
                immGamDes.Visible = false;

                lblGameOver.Text = "";
                lblGameOver.Text = "WIN";

                lblGameOver.Visible = true;
            }
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            tent = 10;
            mod = "F";
            lblTent.Text = Convert.ToString(tent);
            VisualizzaGioco(true);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            tent = 8;
            mod = "M";
            lblTent.Text = Convert.ToString(tent);
            VisualizzaGioco(true);

        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            tent = 5;
            mod = "D";
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
                cont = cont + 1;

                lblTent.Text = Convert.ToString(tent);

                if (mod == "F")
                {
                    if (cont < immImp.Length)
                    {
                        immImp[cont].Visible = true;
                    }
                }
                else if (mod == "M")
                {
                    immImp[0].Visible = true;

                    if (cont < immImp.Length)
                    {
                        immImp[cont].Visible = true;
                    }

                    if (cont == 4 || cont == 6)
                    {
                        cont++;
                        if (cont < immImp.Length) immImp[cont].Visible = true;
                    }
                }
                else
                {
                    immImp[0].Visible = true;
                    immImp[1].Visible = true;

                    int indiceImmagine = cont * 2;

                    if (indiceImmagine < immImp.Length)
                    {
                        immImp[indiceImmagine].Visible = true;
                        immImp[indiceImmagine + 1].Visible = true;
                    }
                }

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

        private void buttonIndizioCat_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("parole_categorie.csv"))
            {
                string[] rigaCat = sr.ReadLine().Split(",");
                string riga = sr.ReadLine();
                string[] linea;
                int ind = -1;

                while (riga != null)
                {
                    linea = riga.Split(",");

                    for (int i = 0; i < rigaCat.Length; i++)
                    {
                        if (linea[i] == par)
                        {
                            ind = i;
                        }
                    }

                    riga = sr.ReadLine();
                }

                lblCat.Text = "";
                lblCat.Text = rigaCat[ind];

            }

        }

        private void buttonParInt_Click(object sender, EventArgs e)
        {
            string parInt = InsParInt.Text;

            parInt = parInt.ToLower();

            if (parInt == par)
            {
                VisGameOver(false);
            }
            else
            {
                VisGameOver(true);
            }
        }

      
    }
}
