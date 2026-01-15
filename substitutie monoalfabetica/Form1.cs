using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Windows.Forms;

namespace MonoalphabeticCipher
{
    public partial class Form1 : Form
    {
        const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenKey_Click(object sender, EventArgs e)
        {
            char[] chars = alphabet.ToCharArray();
            
            for (int i = 0; i < chars.Length; i++)
            {
                int r = rnd.Next(chars.Length);
                char aux = chars[i];
                chars[i] = chars[r];
                chars[r] = aux;
            }
            
            txtKey.Text = new string(chars);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            if (key.Length != 26) 
            {
                MessageBox.Show("Cheia trebuie sa aiba 26 de caractere unice!");
                return;
            }

            string input = txtInput.Text.ToUpper();
            string output = "";

            foreach (char c in input)
            {
                int index = alphabet.IndexOf(c);
                if (index != -1)
                {
                    output += key[index];
                }
                else
                {
                    output += c;
                }
            }
            txtResult.Text = output;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            if (key.Length != 26) return;

            string input = txtInput.Text.ToUpper();
            string output = "";

            foreach (char c in input)
            {
                int index = key.IndexOf(c);
                if (index != -1)
                {
                    output += alphabet[index];
                }
                else
                {
                    output += c;
                }
            }
            txtResult.Text = output;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            string text = txtInput.Text.ToUpper();
            int[] frequencies = new int[26];
            int totalLetters = 0;

            foreach(char c in text)
            {
                if (alphabet.Contains(c.ToString()))
                {
                    int index = alphabet.IndexOf(c);
                    frequencies[index]++;
                    totalLetters++;
                }
            }

            txtStats.Text = "Frecventa Literelor:\r\n";
            txtStats.Text += "-------------------\r\n";
            
            for(int i=0; i<26; i++)
            {
                if (frequencies[i] > 0)
                {
                    double percentage = (double)frequencies[i] / totalLetters * 100;
                    txtStats.Text += alphabet[i] + ": " + frequencies[i] + " (" + percentage.ToString("0.00") + "%)\r\n";
                }
            }

            txtStats.Text += "\r\nSFAT Criptanaliza:\r\n";
            txtStats.Text += "Litera cu cel mai mare procentaj este probabil E sau A.\r\n";
            txtStats.Text += "Urmatoarele sunt probabil I, R, N (in romana) sau T, A, O (in engleza).";
        }
    }
}
