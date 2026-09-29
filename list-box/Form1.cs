namespace list_box
{
    public partial class Form1 : Form
    {
        List<string> origineDati = new List<string>();
        public Form1()
        {
            InitializeComponent();
            caricaDati("animali.txt");
            aggiorna();
        }

        private void caricaDati (string nomeFile)
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

        private void buttonRim_Click(object sender, EventArgs e)
        {

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        private void aggiorna()
        {
            listBoxAnimali.Items.Clear();
            foreach (string a in origineDati)
            {
                listBoxAnimali.Items.Add(a);
            }
        }

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
    }
}
