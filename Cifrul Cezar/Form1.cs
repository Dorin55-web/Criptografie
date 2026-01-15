using System;
using System.Text;
using System.Windows.Forms;

namespace CaesarCipherDorin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.Text = "AVE CAESAR";
        }

        private string ShiftText(string input, int k)
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
            txtResult.Text = ShiftText(txtInput.Text, 3);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtResult.Text = ShiftText(txtInput.Text, -3);
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            lstAnalysis.Items.Clear();
            string cipherText = txtInput.Text;

            for (int k = 1; k < 26; k++)
            {
                string possiblePlaintext = ShiftText(cipherText, -k);
                lstAnalysis.Items.Add("Shift -" + k + ": " + possiblePlaintext);
            }

            MessageBox.Show("Cauta in lista randul care are sens (ar trebui sa fie la Shift -3).");
        }
    }
}
