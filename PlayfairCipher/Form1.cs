using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlayfairCipher
{
    public partial class Form1 : Form
    {
        private char[,] matrix = new char[5, 5];

        public Form1()
        {
            InitializeComponent();
        }

        // 1. Generarea Matricei 5x5 pe baza Cheii
        private void GenerateMatrix(string key)
        {
            string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ"; // Lipseste J (I=J)
            string processedKey = "";
            
            // Curatam cheia: Doar litere, Majuscule, J devine I
            key = key.ToUpper().Replace("J", "I");
            foreach(char c in key)
            {
                if (char.IsLetter(c) && !processedKey.Contains(c))
                    processedKey += c;
            }

            // Adaugam restul alfabetului
            string finalString = processedKey;
            foreach(char c in alphabet)
            {
                if (!finalString.Contains(c))
                    finalString += c;
            }

            // Umplem matricea si o afisam pentru debug
            int index = 0;
            string displayMatrix = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = finalString[index];
                    displayMatrix += matrix[i, j] + " ";
                    index++;
                }
                displayMatrix += "\r\n";
            }
            txtMatrix.Text = displayMatrix; // Afisam matricea in UI
        }

        // 2. Pregatirea textului (adaugare X intre duplicate si la final)
        private string PrepareText(string input)
        {
            string clean = "";
            input = input.ToUpper().Replace("J", "I");
            
            // Pastram doar literele
            foreach (char c in input)
                if (char.IsLetter(c)) clean += c;

            string prepared = "";
            for (int i = 0; i < clean.Length; i++)
            {
                char c1 = clean[i];
                // Verificam daca e ultima litera sau daca urmatoarea e identica
                if (i == clean.Length - 1)
                {
                    prepared += c1 + "X";
                }
                else if (c1 == clean[i + 1])
                {
                    prepared += c1 + "X"; // Inseram X intre litere identice (ex: HELL -> HELXL)
                }
                else
                {
                    prepared += c1.ToString() + clean[i + 1].ToString();
                    i++; // Sarim peste urmatoarea litera ca am luat-o deja in pereche
                }
            }
            return prepared;
        }

        // 3. Gasirea pozitiei unui caracter in matrice
        private Point GetPosition(char c)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (matrix[i, j] == c)
                        return new Point(i, j); // i = rand, j = coloana
            return new Point(0, 0);
        }

        // 4. Logica Principala (Criptare sau Decriptare)
        private string PlayfairProcess(string input, string key, bool encrypt)
        {
            GenerateMatrix(key);
            string text = encrypt ? PrepareText(input) : input.ToUpper().Replace(" ", ""); 
            // La decriptare presupunem ca textul e deja in perechi corecte, scoatem doar spatiile

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i += 2)
            {
                char a = text[i];
                // Safety check for incomplete pairs at the end of decryption input
                char b = (i + 1 < text.Length) ? text[i + 1] : 'X'; 

                Point p1 = GetPosition(a);
                Point p2 = GetPosition(b);

                int r1 = p1.X, c1 = p1.Y;
                int r2 = p2.X, c2 = p2.Y;

                if (r1 == r2) // Acelasi Rand
                {
                    if (encrypt)
                    {
                        c1 = (c1 + 1) % 5;
                        c2 = (c2 + 1) % 5;
                    }
                    else
                    {
                        c1 = (c1 - 1 + 5) % 5; // +5 asigura ca nu avem rezultat negativ la modulo
                        c2 = (c2 - 1 + 5) % 5;
                    }
                }
                else if (c1 == c2) // Aceeasi Coloana
                {
                    if (encrypt)
                    {
                        r1 = (r1 + 1) % 5;
                        r2 = (r2 + 1) % 5;
                    }
                    else
                    {
                        r1 = (r1 - 1 + 5) % 5;
                        r2 = (r2 - 1 + 5) % 5;
                    }
                }
                else // Dreptunghi (Schimbam coloanele)
                {
                    int temp = c1;
                    c1 = c2;
                    c2 = temp;
                }

                result.Append(matrix[r1, c1]);
                result.Append(matrix[r2, c2]);
            }

            return result.ToString();
        }

        // --- Butoane ---

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text) || string.IsNullOrEmpty(txtKey.Text)) return;
            
            string cipher = PlayfairProcess(txtInput.Text, txtKey.Text, true);
            
            // Formatam rezultatul in grupuri de cate 2 pentru citibilitate
            string formatted = "";
            for (int i = 0; i < cipher.Length; i += 2)
            {
                 if (i + 2 <= cipher.Length)
                     formatted += cipher.Substring(i, 2) + " ";
                 else
                     formatted += cipher.Substring(i);
            }
            
            txtResult.Text = formatted.Trim();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text) || string.IsNullOrEmpty(txtKey.Text)) return;

            // La decriptare, inputul poate avea spatii (ex: "AB CD"), le curatam in functie
            string plain = PlayfairProcess(txtInput.Text, txtKey.Text, false);
            txtResult.Text = plain;
        }
    }
}
