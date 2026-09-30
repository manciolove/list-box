namespace list_box
{
    public partial class Form1 : Form
    {

        // variabili globali
        List<string> origineDati = new List<string>();
        string nomeFile;


        public Form1()
        {
            InitializeComponent();
            caricaDati("animali.txt");
            aggiorna();
        }

        // carica dati
        private void caricaDati(string nomeFile)
        {
            if (!File.Exists(nomeFile))
            {
                MessageBox.Show("file non esistente");
            }
            else
            {
                using (StreamReader sr = new StreamReader(nomeFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string riga = sr.ReadLine();
                        if (ControlloStringa(riga) == true)
                        {
                            riga = riga.Trim();
                            riga = riga.ToLower();
                            origineDati.Add(riga);
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // button rimozione
        private void buttonRim_Click(object sender, EventArgs e)
        {
            int indice = listBoxAnimali.SelectedIndex;

            if (indice != -1)
            {
                origineDati.RemoveAt(indice);
                aggiorna();
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // button aggiunta
        private void buttonAgg_Click(object sender, EventArgs e)
        {
            if (ControlloStringa(txtAgg.Text) == false)
            {
                MessageBox.Show("errore stringa non valida");
            }
            if (string.IsNullOrEmpty(txtAgg.Text))
            {
                MessageBox.Show("errore. La text box e vuota");
            }
            else
            {
                string txtLower = txtAgg.Text.ToLower().Trim();
                origineDati.Add(txtLower);
                aggiorna();
            }
        }

        // aggiorna
        private void aggiorna()
        {
            listBoxAnimali.Items.Clear();
            foreach (string a in origineDati)
            {
                listBoxAnimali.Items.Add(a);
            }
        }

        // controllo stringa
        private bool ControlloStringa(string x)
        {
            if (x == null)
            {
                return false;
            }
            if (x == "")
            {
                return false;
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != ' ')
                {
                    return true;
                }
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // button modifica
        private void buttonMod_Click(object sender, EventArgs e)
        {
            int indice = listBoxAnimali.SelectedIndex;

            if (indice != -1)
            {
                origineDati[indice] = txtMod.Text;
                aggiorna();
            }
            else
            {
                MessageBox.Show("impossibile modificare");
            }
        }

        // text box modifica
        private void txtMod_TextChanged(object sender, EventArgs e)
        {

        }

        // button salva
        private void buttonSalva_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(nomeFile))
            {
                foreach (string s in origineDati)
                {
                    sw.WriteLine(s);
                }
            }
        }

        // button file
        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                nomeFile = ofd.FileName;
                caricaDati(nomeFile);
                aggiorna();
            }
            else
            {
                MessageBox.Show("errore, nessun file selezionato");
            }
        }
    }
}