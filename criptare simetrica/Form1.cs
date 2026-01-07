using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptareSimetricaDorin;

public partial class Form1 : Form
{
    SymmetricAlgorithm myAlgo;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        if (cmbAlgo.Items.Count > 0) cmbAlgo.SelectedIndex = 0;
        if (cmbMode.Items.Count > 0) cmbMode.SelectedIndex = 0;
        if (cmbPadding.Items.Count > 0) cmbPadding.SelectedIndex = 0;
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        if (ofd.ShowDialog() == DialogResult.OK)
        {
            txtFile.Text = ofd.FileName;
        }
    }

    private void UpdateAlgorithmObject()
    {
        if (myAlgo != null)
        {
            myAlgo.Clear();
            myAlgo.Dispose();
        }

        string algName = cmbAlgo.Text;
        switch (algName)
        {
            case "AES": myAlgo = Aes.Create(); break;
            case "DES": 
#pragma warning disable SYSLIB0021
                myAlgo = DES.Create(); 
#pragma warning restore SYSLIB0021
                break;
            case "TripleDES": myAlgo = TripleDES.Create(); break;
            case "Rijndael": 
#pragma warning disable SYSLIB0022
                myAlgo = Rijndael.Create(); 
#pragma warning restore SYSLIB0022
                break;
            case "RC2": 
#pragma warning disable SYSLIB0021
                myAlgo = RC2.Create(); 
#pragma warning restore SYSLIB0021
                break;
            default: myAlgo = Aes.Create(); break;
        }

        myAlgo.Mode = (CipherMode)Enum.Parse(typeof(CipherMode), cmbMode.Text);
        myAlgo.Padding = (PaddingMode)Enum.Parse(typeof(PaddingMode), cmbPadding.Text);
    }

    private void btnGenKey_Click(object sender, EventArgs e)
    {
        UpdateAlgorithmObject();
        myAlgo.GenerateKey();
        txtKey.Text = Convert.ToBase64String(myAlgo.Key);
    }

    private void btnGenIV_Click(object sender, EventArgs e)
    {
        if (myAlgo == null) UpdateAlgorithmObject();
        
        myAlgo.GenerateIV();
        txtIV.Text = Convert.ToBase64String(myAlgo.IV);
    }

    private void rbMode_CheckedChanged(object sender, EventArgs e)
    {
        bool isFileMode = rbFile.Checked;

        // Toggle visibility
        txtFile.Visible = isFileMode;
        btnBrowse.Visible = isFileMode;
        
        txtInputText.Visible = !isFileMode;
        txtOutputText.Visible = !isFileMode;
        labelOutput.Visible = !isFileMode;
        
        // Reset inputs on mode switch for clarity
        if (!isFileMode) 
        {
            txtFile.Clear();
        }
        else
        {
            txtInputText.Clear();
            txtOutputText.Clear();
        }
    }

    private async void btnEncrypt_Click(object sender, EventArgs e)
    {
        await RunCryptoOperation(true);
    }

    private async void btnDecrypt_Click(object sender, EventArgs e)
    {
        await RunCryptoOperation(false);
    }

    private async Task RunCryptoOperation(bool encrypt)
    {
        if (string.IsNullOrEmpty(txtKey.Text) || string.IsNullOrEmpty(txtIV.Text))
        {
            MessageBox.Show("Generati Key si IV mai intai!");
            return;
        }

        SetInterfaceState(false);

        try
        {
            UpdateAlgorithmObject();
            myAlgo.Key = Convert.FromBase64String(txtKey.Text);
            myAlgo.IV = Convert.FromBase64String(txtIV.Text);

            ICryptoTransform transform = encrypt ? myAlgo.CreateEncryptor() : myAlgo.CreateDecryptor();

            if (rbFile.Checked)
            {
                // -- FILE MODE --
                string inputFile = txtFile.Text;
                if (!File.Exists(inputFile))
                {
                    MessageBox.Show("Selectati un fisier valid!");
                    return;
                }
                string outputFile = inputFile + (encrypt ? ".enc" : ".dec");

                await Task.Run(() =>
                {
                    using (FileStream fsIn = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                    using (FileStream fsOut = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                    using (CryptoStream cs = new CryptoStream(fsOut, transform, CryptoStreamMode.Write))
                    {
                        fsIn.CopyTo(cs);
                    }
                });
                MessageBox.Show((encrypt ? "Criptare" : "Decriptare") + " reusita!\nFisier: " + outputFile);
            }
            else
            {
                // -- TEXT MODE --
                string inputText = txtInputText.Text;
                if (string.IsNullOrEmpty(inputText))
                {
                    MessageBox.Show("Introduceti text!");
                    return;
                }

                byte[] inputBytes;
                if (encrypt)
                {
                    inputBytes = Encoding.UTF8.GetBytes(inputText);
                }
                else
                {
                    // For decryption, input is Base64
                    try
                    {
                        inputBytes = Convert.FromBase64String(inputText);
                    }
                    catch
                    {
                        MessageBox.Show("Textul pentru decriptare trebuie sa fie Base64 valid!");
                        return;
                    }
                }

                byte[] outputBytes = await Task.Run(() =>
                {
                    using (MemoryStream msOut = new MemoryStream())
                    using (CryptoStream cs = new CryptoStream(msOut, transform, CryptoStreamMode.Write))
                    {
                        cs.Write(inputBytes, 0, inputBytes.Length);
                        cs.FlushFinalBlock();
                        return msOut.ToArray();
                    }
                });

                if (encrypt)
                {
                    txtOutputText.Text = Convert.ToBase64String(outputBytes);
                }
                else
                {
                    txtOutputText.Text = Encoding.UTF8.GetString(outputBytes);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Eroare: " + ex.Message);
        }
        finally
        {
            SetInterfaceState(true);
        }
    }

    private void SetInterfaceState(bool enabled)
    {
        btnEncrypt.Enabled = enabled;
        btnDecrypt.Enabled = enabled;
        btnGenKey.Enabled = enabled;
        btnGenIV.Enabled = enabled;
        
        // Also toggle radio buttons to prevent switching mid-operation
        rbFile.Enabled = enabled;
        rbText.Enabled = enabled;
    }
}
