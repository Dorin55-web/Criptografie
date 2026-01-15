namespace MonoalphabeticCipher;

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
        this.txtInput = new System.Windows.Forms.TextBox();
        this.txtKey = new System.Windows.Forms.TextBox();
        this.btnGenKey = new System.Windows.Forms.Button();
        this.btnEncrypt = new System.Windows.Forms.Button();
        this.btnDecrypt = new System.Windows.Forms.Button();
        this.btnAnalyze = new System.Windows.Forms.Button();
        this.txtResult = new System.Windows.Forms.TextBox();
        this.txtStats = new System.Windows.Forms.TextBox();
        this.lblInput = new System.Windows.Forms.Label();
        this.lblKey = new System.Windows.Forms.Label();
        this.lblResult = new System.Windows.Forms.Label();
        this.lblStats = new System.Windows.Forms.Label();
        this.SuspendLayout();

        // 
        // lblInput
        // 
        this.lblInput.AutoSize = true;
        this.lblInput.Location = new System.Drawing.Point(12, 15);
        this.lblInput.Name = "lblInput";
        this.lblInput.Size = new System.Drawing.Size(60, 15);
        this.lblInput.TabIndex = 0;
        this.lblInput.Text = "Input Text";

        // 
        // txtInput
        // 
        this.txtInput.Location = new System.Drawing.Point(12, 35);
        this.txtInput.Name = "txtInput";
        this.txtInput.Size = new System.Drawing.Size(400, 23);
        this.txtInput.TabIndex = 1;

        // 
        // lblKey
        // 
        this.lblKey.AutoSize = true;
        this.lblKey.Location = new System.Drawing.Point(12, 70);
        this.lblKey.Name = "lblKey";
        this.lblKey.Size = new System.Drawing.Size(117, 15);
        this.lblKey.TabIndex = 2;
        this.lblKey.Text = "Cipher Key (26 chars)";

        // 
        // txtKey
        // 
        this.txtKey.Location = new System.Drawing.Point(12, 90);
        this.txtKey.Name = "txtKey";
        this.txtKey.Size = new System.Drawing.Size(280, 23);
        this.txtKey.TabIndex = 3;

        // 
        // btnGenKey
        // 
        this.btnGenKey.Location = new System.Drawing.Point(300, 90);
        this.btnGenKey.Name = "btnGenKey";
        this.btnGenKey.Size = new System.Drawing.Size(112, 23);
        this.btnGenKey.TabIndex = 4;
        this.btnGenKey.Text = "Genereaza Cheie";
        this.btnGenKey.UseVisualStyleBackColor = true;
        this.btnGenKey.Click += new System.EventHandler(this.btnGenKey_Click);

        // 
        // btnEncrypt
        // 
        this.btnEncrypt.Location = new System.Drawing.Point(12, 130);
        this.btnEncrypt.Name = "btnEncrypt";
        this.btnEncrypt.Size = new System.Drawing.Size(90, 30);
        this.btnEncrypt.TabIndex = 5;
        this.btnEncrypt.Text = "Cripteaza";
        this.btnEncrypt.UseVisualStyleBackColor = true;
        this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

        // 
        // btnDecrypt
        // 
        this.btnDecrypt.Location = new System.Drawing.Point(110, 130);
        this.btnDecrypt.Name = "btnDecrypt";
        this.btnDecrypt.Size = new System.Drawing.Size(90, 30);
        this.btnDecrypt.TabIndex = 6;
        this.btnDecrypt.Text = "Decripteaza";
        this.btnDecrypt.UseVisualStyleBackColor = true;
        this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

        // 
        // btnAnalyze
        // 
        this.btnAnalyze.Location = new System.Drawing.Point(210, 130);
        this.btnAnalyze.Name = "btnAnalyze";
        this.btnAnalyze.Size = new System.Drawing.Size(200, 30);
        this.btnAnalyze.TabIndex = 7;
        this.btnAnalyze.Text = "Criptanaliza (Frecventa)";
        this.btnAnalyze.UseVisualStyleBackColor = true;
        this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);

        // 
        // lblResult
        // 
        this.lblResult.AutoSize = true;
        this.lblResult.Location = new System.Drawing.Point(12, 180);
        this.lblResult.Name = "lblResult";
        this.lblResult.Size = new System.Drawing.Size(52, 15);
        this.lblResult.TabIndex = 8;
        this.lblResult.Text = "Rezultat";

        // 
        // txtResult
        // 
        this.txtResult.Location = new System.Drawing.Point(12, 200);
        this.txtResult.Multiline = true;
        this.txtResult.Name = "txtResult";
        this.txtResult.ReadOnly = true;
        this.txtResult.Size = new System.Drawing.Size(400, 80);
        this.txtResult.TabIndex = 9;

        // 
        // lblStats
        // 
        this.lblStats.AutoSize = true;
        this.lblStats.Location = new System.Drawing.Point(430, 15);
        this.lblStats.Name = "lblStats";
        this.lblStats.Size = new System.Drawing.Size(107, 15);
        this.lblStats.TabIndex = 10;
        this.lblStats.Text = "Statistica Frecvente";

        // 
        // txtStats
        // 
        this.txtStats.Location = new System.Drawing.Point(430, 35);
        this.txtStats.Multiline = true;
        this.txtStats.Name = "txtStats";
        this.txtStats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtStats.Size = new System.Drawing.Size(250, 245);
        this.txtStats.TabIndex = 11;
        this.txtStats.Font = new System.Drawing.Font("Consolas", 9F);

        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(700, 320);
        this.Controls.Add(this.txtStats);
        this.Controls.Add(this.lblStats);
        this.Controls.Add(this.txtResult);
        this.Controls.Add(this.lblResult);
        this.Controls.Add(this.btnAnalyze);
        this.Controls.Add(this.btnDecrypt);
        this.Controls.Add(this.btnEncrypt);
        this.Controls.Add(this.btnGenKey);
        this.Controls.Add(this.txtKey);
        this.Controls.Add(this.lblKey);
        this.Controls.Add(this.txtInput);
        this.Controls.Add(this.lblInput);
        this.Name = "Form1";
        this.Text = "Substitutie Monoalfabetica";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.TextBox txtKey;
    private System.Windows.Forms.Button btnGenKey;
    private System.Windows.Forms.Button btnEncrypt;
    private System.Windows.Forms.Button btnDecrypt;
    private System.Windows.Forms.Button btnAnalyze;
    private System.Windows.Forms.TextBox txtResult;
    private System.Windows.Forms.TextBox txtStats;
    private System.Windows.Forms.Label lblInput;
    private System.Windows.Forms.Label lblKey;
    private System.Windows.Forms.Label lblResult;
    private System.Windows.Forms.Label lblStats;
}
