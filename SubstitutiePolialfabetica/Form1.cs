using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SubstitutiePolialfabetica
{
    public partial class Form1 : Form
    {
        // Alfabetul standard pentru a gasi indicii
        const string standard = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Poti pre-completa casuta cu datele din imagine pentru testare rapida
            txtAlfabete.Text = 
                "FRQSPYMHNJOELKDVAGXTIWBUZC\r\n" +
                "SWZCINJTELAFQUMKPXDOVBRGHY\r\n" +
                "CITYWLNZEVOMQGUPJFXBRAHSKD";
            
            txtInput.Text = "ABB BCC AB";
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Proceseaza(true);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Proceseaza(false);
        }

        private void Proceseaza(bool criptare)
        {
            // 1. Citim alfabetele de substitutie din TextBox
            // Split pe NewLine ne da un vector cu fiecare rand
            string[] linii = txtAlfabete.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            
            // Verificare simpla
            if (linii.Length == 0)
            {
                MessageBox.Show("Nu ai introdus alfabetele de substitutie!");
                return;
            }

            string input = txtInput.Text.ToUpper();
            string rezultat = "";
            
            int n = linii.Length; // Numarul de alfabete (n=3 in exemplu)
            int k = 0; // Contorul pentru a schimba alfabetele ciclic

            // 2. Parcurgem textul
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                // Procesam doar literele
                if (standard.Contains(c.ToString()))
                {
                    // Selectam alfabetul curent (linia 0, 1 sau 2)
                    string alfabetCurent = linii[k % n].ToUpper(); // Asiguram ca e Upper
                    
                    // Curatam spatiile eventuale din alfabetul citit
                    alfabetCurent = alfabetCurent.Trim(); 

                    char caracterNou = '?';

                    if (criptare)
                    {
                        // CRIPTARE:
                        // Gasim pozitia literei in alfabetul STANDARD
                        int index = standard.IndexOf(c);
                        // Luam litera de pe aceeasi pozitie din ALFABETUL AMESTECAT
                        if (index < alfabetCurent.Length)
                             caracterNou = alfabetCurent[index];
                    }
                    else
                    {
                        // DECRIPTARE:
                        // Gasim pozitia literei in ALFABETUL AMESTECAT
                        int index = alfabetCurent.IndexOf(c);
                        // Luam litera de pe aceeasi pozitie din ALFABETUL STANDARD
                        if (index >= 0)
                            caracterNou = standard[index];
                    }

                    rezultat += caracterNou;
                    
                    // Trecem la urmatorul alfabet doar daca am procesat o litera
                    k++; 
                }
                else
                {
                    // Daca e spatiu sau paranteza, il copiem asa cum e
                    rezultat += c;
                    // NU incrementam k (de obicei semnele nu consuma cheia)
                }
            }

            txtResult.Text = rezultat;
        }
    }
}
