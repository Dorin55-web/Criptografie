using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace HashAppDorin;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        if (cmbAlgo.Items.Count > 0)
            cmbAlgo.SelectedIndex = 2; 
    }

    private void rbMode_CheckedChanged(object sender, EventArgs e)
    {
        bool isFileMode = rbFile.Checked;
        txtPath.Enabled = isFileMode;
        btnBrowse.Enabled = isFileMode;
        txtInputText.Enabled = !isFileMode;
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
        OpenFileDialog dlg = new OpenFileDialog();
        if (dlg.ShowDialog() == DialogResult.OK)
        {
            txtPath.Text = dlg.FileName;
        }
    }

    private async void btnCompute_Click(object sender, EventArgs e)
    {
        string path = txtPath.Text;
        string textInput = txtInputText.Text;
        string algoType = cmbAlgo.Text;
        bool isFileMode = rbFile.Checked;

        if (isFileMode && (string.IsNullOrEmpty(path) || !File.Exists(path)))
        {
            MessageBox.Show("Fisier invalid!");
            return;
        }

        btnCompute.Enabled = false;
        txtResult.Text = "Se calculeaza...";

        try
        {
            string hexResult = "";
            if (isFileMode)
            {
                hexResult = await Task.Run(() => ComputeHashFile(path, algoType));
            }
            else
            {
                hexResult = await Task.Run(() => ComputeHashText(textInput, algoType));
            }
            
            txtResult.Text = hexResult;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Eroare: " + ex.Message);
        }
        finally
        {
            btnCompute.Enabled = true;
        }
    }

    private string ComputeHashFile(string filePath, string algorithm)
    {
        using (FileStream stream = File.OpenRead(filePath))
        {
            return ComputeHashFromStream(stream, algorithm);
        }
    }

    private string ComputeHashText(string text, string algorithm)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(text);
        using (MemoryStream stream = new MemoryStream(bytes))
        {
            return ComputeHashFromStream(stream, algorithm);
        }
    }

    private string ComputeHashFromStream(Stream stream, string algorithm)
    {
        HashAlgorithm hash = null;

        switch (algorithm)
        {
            case "MD5": hash = MD5.Create(); break;
            case "SHA1": hash = SHA1.Create(); break;
            case "SHA256": hash = SHA256.Create(); break;
            case "SHA384": hash = SHA384.Create(); break;
            case "SHA512": hash = SHA512.Create(); break;
            case "RIPEMD160": 
                return "RIPEMD160 not supported";
            default: hash = SHA256.Create(); break;
        }

        if (hash != null)
        {
            byte[] data = hash.ComputeHash(stream);
            hash.Dispose();
            return BitConverter.ToString(data).Replace("-", "").ToLower();
        }
        return "Eroare";
    }
}
