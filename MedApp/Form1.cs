using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedApp
{
    public partial class Form1 : Form
    {

        List<Pacient> lstPacienti = new List<Pacient>();
        List<Pacient> lstCitita;
        List<Diagnostic> lstDiagnostic = new List<Diagnostic>()
        {
           new Diagnostic(new string[]{ "febră","tuse","oboseală","pierderea gustului sau a mirosului"}, "COVID-19", "vaccin"),
           new Diagnostic(new string[]{"Febra brusca inalta intre 38 si 40 grade Celsius","Dureri musculare","Transpiratie", "Frisoane","Oboseala","Tuse seaca"}, "Raceala", "analgezice, supa de pui, ceaiuri"),
           new Diagnostic(new string[]{"Febra brusca inalta intre 38 si 40 grade Celsius","Dureri musculare","Transpiratie", "Frisoane","Oboseala","Tuse seaca"}, "Raceala", "analgezice, supa de pui, ceaiuri"),
           new Diagnostic(new string[]{"Frisoane","Febra","Tuse","Durere in gat","Varsaturi"}, "Gripa", "Medicamente anitivirale, ceaiuri, analgezice"),
           new Diagnostic(new string[]{"Eruptie cutanata","Febra","Durere de cap"}, "Varicela", "Lotiuni calmante,comprese reci,medicamente antiinflamatorii"),
           new Diagnostic(new string[]{"Febra inalta","Tuse","Rinoree","Ochi rosii"}, "Pojar", "Tratamente antitermice"),
           new Diagnostic(new string[]{"Sete","Poliurie","Polifagie","Oboseala"}, "Diabet", "Insulina"),
           new Diagnostic(new string[]{"Febra inalta","Tuse","Rinoree","Ochi rosii"}, "Pojar", "Tratamente antitermice"),
           new Diagnostic(new string[]{"Febra inalta","Tuse","Rinoree","Ochi rosii"}, "Pojar", "Tratamente antitermice"),
           new Diagnostic(new string[]{ "febră","tuse","oboseală","pierderea gustului sau a mirosului"}, "COVID-19", "vaccin"),
           new Diagnostic(new string[]{ "febră","tuse","oboseală","pierderea gustului sau a mirosului"}, "COVID-19", "vaccin"),
           new Diagnostic(new string[]{ "febră","tuse","oboseală","pierderea gustului sau a mirosului"}, "COVID-19", "vaccin")
    };

        List<Programare> lstProgramare = new List<Programare>();

        public Form1()
        {
            InitializeComponent();

        }

        private void btnCasierie_Click(object sender, EventArgs e)
        {
            foreach (Pacient pacient in lstPacienti)
            {
                if (pacient.Facturat == "Neachitat")
                    if (pacient.NumePacient != cbCostFinal.Text)
                        cbCostFinal.Items.Add(pacient.NumePacient.ToString());
            }
            cbCostFinal.Visible = true;
            lbNumePacient.Visible = true;
            btnAchita.Visible = true;
        }

        private void btnAchita_Click(object sender, EventArgs e)
        {
            foreach (Pacient p in lstPacienti)
                if (cbCostFinal.Text == p.NumePacient)
                {
                    tbMess.Text += $"\r\n Pacientul {p.NumePacient} a achitatat factura.";
                    cbCostFinal.Items.Clear(); lvProgramari.BeginUpdate(); p.Facturat = "Achitat"; lvProgramari.EndUpdate();
                }
            btnAchita.Enabled = true;
            cbCostFinal.Visible = false;
            lbNumePacient.Visible = false;
            btnAchita.Visible = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fisOut = new FileStream("Cabinet.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fisOut, lstPacienti);
            fisOut.Close();
            MessageBox.Show($"Au fost serializati {lstPacienti.Count} pacienti");
        }

        private void pacientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.ShowDialog();
            //lucru in forma 2
            if (m.DialogResult == DialogResult.OK)
            {
                Pacient pacient1 = new Pacient();
                pacient1.NumePacient = m.tbNumePacient.Text;
                pacient1.CNP = m.tbCNP.Text;
                pacient1.DataNastere = m.dtDataNastere.Value;
                pacient1.Adresa = m.tbAdresa.Text;
                pacient1.Sex = m.cbSex.Text;
                pacient1.NumarTelefon = m.tbTelefon.Text;
                pacient1.Email = m.tbEmail.Text;
                Programare programare1 = new Programare();
                programare1.DataProgramare = m.dtDataProgramare.Value;
                programare1.Serviciu = m.cbServiciu.Text;
                if (m.cbServiciu.Text == "Consult")
                {
                    programare1.Cost = 200;
                }
                else if (m.cbServiciu.Text == "Ecografie")
                {
                    programare1.Cost = 350;
                }
                else if (m.cbServiciu.Text == "Check-Up")
                {
                    programare1.Cost = 300;
                }
                else if (m.cbServiciu.Text == "Analize")
                {
                    programare1.Cost = 500;
                }
                else if (m.cbServiciu.Text == "Testare SARS-COV-2")
                {
                    programare1.Cost = 350;
                }
                lstProgramare.Add(programare1);
                lstPacienti.Add(pacient1);
                tbMess.Text += "\r\nRetinem datele: " + pacient1;
                ListViewItem itm = new ListViewItem(m.dtDataProgramare.Text);
                itm.SubItems.Add(m.tbNumePacient.Text);
                itm.SubItems.Add(programare1.Cost.ToString());
                itm.SubItems.Add(pacient1.Facturat);
                lvProgramari.Items.Add(itm);
                lvProgramari.Refresh();
            }
        }

        private void diagnosticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 m = new Form3();
            m.ShowDialog();
            //lucru in forma 3

            if (m.DialogResult == DialogResult.OK)
            {

                Pacient pacient1 = new Pacient();
                Diagnostic diagnostic = new Diagnostic();
                string[] vectorSimptome = m.tbSimptome.Text.Split(',');
                diagnostic.Simptome = new string[vectorSimptome.Length];
                for (int i = 0; i < vectorSimptome.Length; i++)
                {
                    diagnostic.Simptome[i] = vectorSimptome[i];
                }
                pacient1.NumePacient = m.tbNume.Text;
                diagnostic.Boala = m.cbBoala.Text;
                diagnostic.Medicamentatie = m.tbMedicamentatie.Text;
                lstDiagnostic.Add(diagnostic);
                tbMess.Text += "\r\nRetinem datele: " + diagnostic;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FileStream fisIn = new FileStream("Cabinet.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            if (fisIn.CanRead)
            {
                lstCitita = (List<Pacient>)bf.Deserialize(fisIn);
                tbMess.Text += "\r\nTest citire din fisier: ";
                foreach (Pacient x in lstCitita)
                {
                    tbMess.Text += $"\r\n {x}";
                }
                MessageBox.Show($"Au fost cititi {lstCitita.Count} pacienti");
                fisIn.Close();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbMess.Text = "Lista pacientilor: \n";
            foreach (Pacient p in lstPacienti)
            {
                tbMess.Text += $"\r\n{p}";
            }
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Lista pacientilor: \n", new Font("Arial", 15), Brushes.Red, 10, 10);
            int linia = 1;
            foreach (Pacient p in lstPacienti)
            {
                g.DrawString($"\r\n{p} ", new Font("Arial", 15), Brushes.Red, 10, 10 + linia * 20);
                linia++;
            }
        }
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void graficDiagnosticeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form4 desen = new Form4();
            int[] vectContor = new int[10];
            foreach (Diagnostic d in lstDiagnostic)
            {
                if (d.Boala == "COVID-19") { vectContor[0]++; }
                if (d.Boala == "Depresie") { vectContor[1]++; }
                if (d.Boala == "Varicela") { vectContor[2]++; }
                if (d.Boala == "Gripa") { vectContor[3]++; }
                if (d.Boala == "Pojar") { vectContor[4]++; }
                if (d.Boala == "Diabet") { vectContor[5]++; }
                if (d.Boala == "Raceala") { vectContor[6]++; }
                if (d.Boala == "ToxiinfectieAlimentara") { vectContor[7]++; }
                if (d.Boala == "Cancer") { vectContor[8]++; }
                if (d.Boala == "Rujeola") { vectContor[9]++; }            
            }
            for (int i = 0; i < 10; i++)
            {
                tbMess.Text += $"\r\n{vectContor[i]}";
            }
            desen.vectDiagnostic = vectContor;
            desen.ShowDialog();
        }

        private void ratingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 rating = new Form5();
            rating.ShowDialog();
        }
    }

    [Serializable]

    class Pacient
    {
        public string NumePacient { get; set; }
        public string CNP { get; set;}
        public string Facturat { get; set; }
        public DateTime DataNastere { get; set; }
        public string Adresa { get; set; }
        public string Sex { get; set; }
        public string NumarTelefon { get; set; }
        public string Email { get; set; }

        public Pacient(string numePacient = "Anonim", string cNP ="1000000000001", DateTime dataNastere=default, string adresa="Necunoscuta", string sex="Necunoscut", string numarTelefon="0700000000", string email="Necunoscut", string facurat="Neachitat")
        {
            NumePacient = numePacient;
            CNP = cNP;
            DataNastere = dataNastere;
            Adresa = adresa;
            Sex = sex;
            NumarTelefon = numarTelefon;
            Email = email;
            Facturat = facurat;
        }

        public Pacient(Pacient sursa)
        {
            NumePacient = sursa.NumePacient;
            CNP = sursa.CNP;
            DataNastere = sursa.DataNastere;
            Adresa = sursa.Adresa;
            Sex = sursa.Sex;
            NumarTelefon = sursa.NumarTelefon;
            Email = sursa.Email;
        }

        public override string ToString()
        {
            return $"{NumePacient} a fost inregistrat cu datele: {CNP} , {DataNastere} , {Adresa} , {Sex} , {NumarTelefon} , {Email}";
        }

    }

    [Serializable]

    class Programare
    {
        public DateTime DataProgramare { get; set; }
        public string Serviciu { get; set; }
        public double Cost { get; set; }

        Pacient p;

        public Programare(DateTime dataProgramare =default, string serviciu = "Consult", double cost = 200, string _numePacient = "Anonim",
            string _cNP = "1000000000001", DateTime _dataNastere = default, string _adresa = "Necunoscuta", string _sex = "Necunoscut", string _numarTelefon = "0700000000", string _email = "Necunoscut")
        {
            DataProgramare = dataProgramare;
            Serviciu = serviciu;
            Cost = cost;
            p = new Pacient( _numePacient, _cNP , _dataNastere, _adresa,  _sex, _numarTelefon, _email);
        }

        public Programare(Programare sursa)
        {
            DataProgramare = sursa.DataProgramare;
            Serviciu = sursa.Serviciu;
            Cost = sursa.Cost;
            p = sursa.p;
        }

        public override string ToString()
        {
            return $"{p.NumePacient} a facut o programare pentru data de {DataProgramare} .";
        }
    }

    [Serializable]

    class Diagnostic
    {
        public string[] Simptome { get; set; }
        public string Boala { get; set; }
        public string Medicamentatie { get; set; }

        Pacient p;

        public Diagnostic(string[] simptome=null, string boala="Nedeterminata", string medicamentatie="Necunoscuta", string _numePacient = "Anonim",
            string _cNP = "1000000000001", DateTime _dataNastere = default, string _adresa = "Necunoscuta", string _sex = "Necunoscut", string _numarTelefon = "0700000000", string _email = "Necunoscut")
        {
            if (simptome != null)
            {
                Simptome = new string[simptome.Length];
                for (int i = 0; i < simptome.Length; i++) Simptome[i] = simptome[i];
            }
            Boala = boala;
            Medicamentatie = medicamentatie;
            p = new Pacient(_numePacient, _cNP, _dataNastere, _adresa, _sex, _numarTelefon, _email);
        }

        public Diagnostic(Diagnostic sursa)
        {
            Simptome = new string[sursa.Simptome.Length];
            for (int i = 0; i < sursa.Simptome.Length; i++) Simptome[i] = sursa.Simptome[i]; Boala = sursa.Boala;
            Medicamentatie = sursa.Medicamentatie;
            p = sursa.p;
        }
        public static Diagnostic operator +(Diagnostic d, string simptom)
        {
            string[] s = new string[d.Simptome.Length + 1];
            d.Simptome.CopyTo(s, 0);
            s[s.Length - 1] = simptom;
            d.Simptome = s;
            return d;
        }
        public override string ToString()
        {
            string sirSimptome;
            if (Simptome != null)
                sirSimptome = string.Join(", ", Simptome);
            else
                sirSimptome = "";
            return $"{p.NumePacient} , prezentand simptomele {sirSimptome} a fost diagnosticat cu {Boala} .";
        }

    }
}
