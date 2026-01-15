using System;
using System.Text;
using System.Windows.Forms;

namespace CifrulPlusN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.Text = "HELLO"; 
            numN.Value = 5;
        }

        private string ShiftString(string input, int k)
        {
            StringBuilder sb = new StringBuilder();
            
            input = input.ToUpper();

            foreach (char c in input)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    int x = c - 'A';
                    int newX = ((x + k) % 26 + 26) % 26;
                    char newC = (char)('A' + newX);
                    sb.Append(newC);
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            int n = (int)numN.Value;
            txtResult.Text = ShiftString(txtInput.Text, n);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            int n = (int)numN.Value;
            txtResult.Text = ShiftString(txtInput.Text, -n);
        }

        private void btnCryptanalysis_Click(object sender, EventArgs e)
        {
            lstAnalysis.Items.Clear();
            string cipherText = txtInput.Text;

            for (int key = 0; key < 26; key++)
            {
                string plainTextCandidate = ShiftString(cipherText, -key);

                lstAnalysis.Items.Add("n = " + key + ": " + plainTextCandidate);
            }
        }
    }
}
