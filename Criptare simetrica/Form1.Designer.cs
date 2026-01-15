namespace CriptareSimetricaDorin;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.txtFile = new System.Windows.Forms.TextBox();
        this.btnBrowse = new System.Windows.Forms.Button();
        this.cmbAlgo = new System.Windows.Forms.ComboBox();
        this.cmbMode = new System.Windows.Forms.ComboBox();
        this.cmbPadding = new System.Windows.Forms.ComboBox();
        this.txtKey = new System.Windows.Forms.TextBox();
        this.btnGenKey = new System.Windows.Forms.Button();
        this.txtIV = new System.Windows.Forms.TextBox();
        this.btnGenIV = new System.Windows.Forms.Button();
        this.btnEncrypt = new System.Windows.Forms.Button();
        this.btnDecrypt = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.label6 = new System.Windows.Forms.Label();
        
        // New Controls
        this.rbFile = new System.Windows.Forms.RadioButton();
        this.rbText = new System.Windows.Forms.RadioButton();
        this.txtInputText = new System.Windows.Forms.TextBox();
        this.txtOutputText = new System.Windows.Forms.TextBox();
        this.labelOutput = new System.Windows.Forms.Label();

        this.SuspendLayout();

        // 
        // Row 0: Mode Selection
        // 
        this.rbFile.AutoSize = true;
        this.rbFile.Location = new System.Drawing.Point(20, 10);
        this.rbFile.Name = "rbFile";
        this.rbFile.Size = new System.Drawing.Size(70, 19);
        this.rbFile.TabIndex = 20;
        this.rbFile.TabStop = true;
        this.rbFile.Text = "Fisier";
        this.rbFile.Checked = true;
        this.rbFile.UseVisualStyleBackColor = true;
        this.rbFile.CheckedChanged += new System.EventHandler(this.rbMode_CheckedChanged);

        this.rbText.AutoSize = true;
        this.rbText.Location = new System.Drawing.Point(100, 10);
        this.rbText.Name = "rbText";
        this.rbText.Size = new System.Drawing.Size(70, 19);
        this.rbText.TabIndex = 21;
        this.rbText.Text = "Text";
        this.rbText.UseVisualStyleBackColor = true;
        this.rbText.CheckedChanged += new System.EventHandler(this.rbMode_CheckedChanged);

        // 
        // Row 1: Input (File or Text)
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(20, 45);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(56, 15);
        this.label1.TabIndex = 0;
        this.label1.Text = "Input";

        // File Controls
        this.txtFile.Location = new System.Drawing.Point(140, 42);
        this.txtFile.Name = "txtFile";
        this.txtFile.Size = new System.Drawing.Size(300, 23);
        this.txtFile.TabIndex = 1;

        this.btnBrowse.Location = new System.Drawing.Point(450, 42);
        this.btnBrowse.Name = "btnBrowse";
        this.btnBrowse.Size = new System.Drawing.Size(90, 23);
        this.btnBrowse.TabIndex = 2;
        this.btnBrowse.Text = "Browse";
        this.btnBrowse.UseVisualStyleBackColor = true;
        this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

        // Text Controls (Initially Hidden or overlapped)
        this.txtInputText.Location = new System.Drawing.Point(140, 42);
        this.txtInputText.Name = "txtInputText";
        this.txtInputText.PlaceholderText = "Introduceti textul de criptat...";
        this.txtInputText.Size = new System.Drawing.Size(400, 23);
        this.txtInputText.TabIndex = 22;
        this.txtInputText.Visible = false;

        // 
        // Row 2: Algoritm
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(20, 85);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(54, 15);
        this.label2.TabIndex = 3;
        this.label2.Text = "Algoritm";

        this.cmbAlgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbAlgo.FormattingEnabled = true;
        this.cmbAlgo.Items.AddRange(new object[] {
        "AES",
        "DES",
        "TripleDES",
        "Rijndael",
        "RC2"});
        this.cmbAlgo.Location = new System.Drawing.Point(140, 82);
        this.cmbAlgo.Name = "cmbAlgo";
        this.cmbAlgo.Size = new System.Drawing.Size(150, 23);
        this.cmbAlgo.TabIndex = 4;

        // 
        // Row 3: Modul de operare
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(20, 125);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(101, 15);
        this.label3.TabIndex = 5;
        this.label3.Text = "Modul de operare";

        this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbMode.FormattingEnabled = true;
        this.cmbMode.Items.AddRange(new object[] {
        "CBC",
        "ECB",
        "CFB"});
        this.cmbMode.Location = new System.Drawing.Point(140, 122);
        this.cmbMode.Name = "cmbMode";
        this.cmbMode.Size = new System.Drawing.Size(150, 23);
        this.cmbMode.TabIndex = 6;

        // 
        // Row 4: Padding
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(20, 165);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(51, 15);
        this.label4.TabIndex = 7;
        this.label4.Text = "Padding";

        this.cmbPadding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbPadding.FormattingEnabled = true;
        this.cmbPadding.Items.AddRange(new object[] {
        "PKCS7",
        "None",
        "Zeros"});
        this.cmbPadding.Location = new System.Drawing.Point(140, 162);
        this.cmbPadding.Name = "cmbPadding";
        this.cmbPadding.Size = new System.Drawing.Size(150, 23);
        this.cmbPadding.TabIndex = 8;

        // 
        // Row 5: IV
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(20, 205);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(17, 15);
        this.label5.TabIndex = 9;
        this.label5.Text = "IV";

        this.txtIV.Location = new System.Drawing.Point(140, 202);
        this.txtIV.Name = "txtIV";
        this.txtIV.Size = new System.Drawing.Size(300, 23);
        this.txtIV.TabIndex = 10;

        this.btnGenIV.Location = new System.Drawing.Point(450, 202);
        this.btnGenIV.Name = "btnGenIV";
        this.btnGenIV.Size = new System.Drawing.Size(90, 23);
        this.btnGenIV.TabIndex = 11;
        this.btnGenIV.Text = "GenerateIV";
        this.btnGenIV.UseVisualStyleBackColor = true;
        this.btnGenIV.Click += new System.EventHandler(this.btnGenIV_Click);

        // 
        // Row 6: Key
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(20, 245);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(26, 15);
        this.label6.TabIndex = 12;
        this.label6.Text = "Key";

        this.txtKey.Location = new System.Drawing.Point(140, 242);
        this.txtKey.Name = "txtKey";
        this.txtKey.Size = new System.Drawing.Size(300, 23);
        this.txtKey.TabIndex = 13;

        this.btnGenKey.Location = new System.Drawing.Point(450, 242);
        this.btnGenKey.Name = "btnGenKey";
        this.btnGenKey.Size = new System.Drawing.Size(90, 23);
        this.btnGenKey.TabIndex = 14;
        this.btnGenKey.Text = "GenerateKey";
        this.btnGenKey.UseVisualStyleBackColor = true;
        this.btnGenKey.Click += new System.EventHandler(this.btnGenKey_Click);

        // 
        // Row 7: Buttons
        // 
        this.btnEncrypt.Location = new System.Drawing.Point(20, 280);
        this.btnEncrypt.Name = "btnEncrypt";
        this.btnEncrypt.Size = new System.Drawing.Size(100, 30);
        this.btnEncrypt.TabIndex = 15;
        this.btnEncrypt.Text = "Encrypt";
        this.btnEncrypt.UseVisualStyleBackColor = true;
        this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

        this.btnDecrypt.Location = new System.Drawing.Point(140, 280);
        this.btnDecrypt.Name = "btnDecrypt";
        this.btnDecrypt.Size = new System.Drawing.Size(100, 30);
        this.btnDecrypt.TabIndex = 16;
        this.btnDecrypt.Text = "Decrypt";
        this.btnDecrypt.UseVisualStyleBackColor = true;
        this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

        // 
        // Row 8: Output (Text Mode Only)
        // 
        this.labelOutput.AutoSize = true;
        this.labelOutput.Location = new System.Drawing.Point(20, 320);
        this.labelOutput.Name = "labelOutput";
        this.labelOutput.Size = new System.Drawing.Size(48, 15);
        this.labelOutput.TabIndex = 23;
        this.labelOutput.Text = "Output:";
        this.labelOutput.Visible = false;

        this.txtOutputText.Location = new System.Drawing.Point(20, 340);
        this.txtOutputText.Multiline = true;
        this.txtOutputText.Name = "txtOutputText";
        this.txtOutputText.ReadOnly = true;
        this.txtOutputText.Size = new System.Drawing.Size(520, 100);
        this.txtOutputText.TabIndex = 24;
        this.txtOutputText.Visible = false;


        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(580, 460);
        this.Controls.Add(this.rbText);
        this.Controls.Add(this.rbFile);
        this.Controls.Add(this.txtInputText);
        this.Controls.Add(this.txtOutputText);
        this.Controls.Add(this.labelOutput);
        this.Controls.Add(this.btnDecrypt);
        this.Controls.Add(this.btnEncrypt);
        this.Controls.Add(this.btnGenKey);
        this.Controls.Add(this.txtKey);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.btnGenIV);
        this.Controls.Add(this.txtIV);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.cmbPadding);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.cmbMode);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.cmbAlgo);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.btnBrowse);
        this.Controls.Add(this.txtFile);
        this.Controls.Add(this.label1);
        this.Name = "Form1";
        this.Text = "Criptare Simetrica Dorin";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox txtFile;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.ComboBox cmbAlgo;
    private System.Windows.Forms.ComboBox cmbMode;
    private System.Windows.Forms.ComboBox cmbPadding;
    private System.Windows.Forms.TextBox txtKey;
    private System.Windows.Forms.Button btnGenKey;
    private System.Windows.Forms.TextBox txtIV;
    private System.Windows.Forms.Button btnGenIV;
    private System.Windows.Forms.Button btnEncrypt;
    private System.Windows.Forms.Button btnDecrypt;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.RadioButton rbFile;
    private System.Windows.Forms.RadioButton rbText;
    private System.Windows.Forms.TextBox txtInputText;
    private System.Windows.Forms.TextBox txtOutputText;
    private System.Windows.Forms.Label labelOutput;
}
