namespace CifrulPlusN;

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
        this.numN = new System.Windows.Forms.NumericUpDown();
        this.btnEncrypt = new System.Windows.Forms.Button();
        this.btnDecrypt = new System.Windows.Forms.Button();
        this.btnCryptanalysis = new System.Windows.Forms.Button();
        this.txtResult = new System.Windows.Forms.TextBox();
        this.lstAnalysis = new System.Windows.Forms.ListBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.numN)).BeginInit();
        this.SuspendLayout();

        // 
        // label1 - Input
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 15);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(35, 15);
        this.label1.TabIndex = 0;
        this.label1.Text = "Input";

        // 
        // txtInput
        // 
        this.txtInput.Location = new System.Drawing.Point(12, 35);
        this.txtInput.Name = "txtInput";
        this.txtInput.Size = new System.Drawing.Size(250, 23);
        this.txtInput.TabIndex = 1;

        // 
        // label2 - N Value
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(280, 15);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(16, 15);
        this.label2.TabIndex = 2;
        this.label2.Text = "n";

        // 
        // numN
        // 
        this.numN.Location = new System.Drawing.Point(280, 35);
        this.numN.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
        this.numN.Name = "numN";
        this.numN.Size = new System.Drawing.Size(80, 23);
        this.numN.TabIndex = 3;
        this.numN.Value = new decimal(new int[] { 5, 0, 0, 0 });

        // 
        // btnEncrypt
        // 
        this.btnEncrypt.Location = new System.Drawing.Point(12, 70);
        this.btnEncrypt.Name = "btnEncrypt";
        this.btnEncrypt.Size = new System.Drawing.Size(120, 30);
        this.btnEncrypt.TabIndex = 4;
        this.btnEncrypt.Text = "Cripteaza (+n)";
        this.btnEncrypt.UseVisualStyleBackColor = true;
        this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

        // 
        // btnDecrypt
        // 
        this.btnDecrypt.Location = new System.Drawing.Point(142, 70);
        this.btnDecrypt.Name = "btnDecrypt";
        this.btnDecrypt.Size = new System.Drawing.Size(120, 30);
        this.btnDecrypt.TabIndex = 5;
        this.btnDecrypt.Text = "Decripteaza (-n)";
        this.btnDecrypt.UseVisualStyleBackColor = true;
        this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

        // 
        // label3 - Result
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(12, 110);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(39, 15);
        this.label3.TabIndex = 6;
        this.label3.Text = "Result";

        // 
        // txtResult
        // 
        this.txtResult.Location = new System.Drawing.Point(12, 130);
        this.txtResult.Name = "txtResult";
        this.txtResult.ReadOnly = true;
        this.txtResult.Size = new System.Drawing.Size(350, 23);
        this.txtResult.TabIndex = 7;

        // 
        // btnCryptanalysis
        // 
        this.btnCryptanalysis.Location = new System.Drawing.Point(12, 170);
        this.btnCryptanalysis.Name = "btnCryptanalysis";
        this.btnCryptanalysis.Size = new System.Drawing.Size(180, 30);
        this.btnCryptanalysis.TabIndex = 8;
        this.btnCryptanalysis.Text = "Criptanaliza (Brute Force)";
        this.btnCryptanalysis.UseVisualStyleBackColor = true;
        this.btnCryptanalysis.Click += new System.EventHandler(this.btnCryptanalysis_Click);

        // 
        // label4 - Analysis
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(12, 210);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(116, 15);
        this.label4.TabIndex = 9;
        this.label4.Text = "Toate variantele (0-25)";

        // 
        // lstAnalysis
        // 
        this.lstAnalysis.FormattingEnabled = true;
        this.lstAnalysis.ItemHeight = 15;
        this.lstAnalysis.Location = new System.Drawing.Point(12, 230);
        this.lstAnalysis.Name = "lstAnalysis";
        this.lstAnalysis.Size = new System.Drawing.Size(350, 199);
        this.lstAnalysis.TabIndex = 10;

        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(384, 450);
        this.Controls.Add(this.lstAnalysis);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.btnCryptanalysis);
        this.Controls.Add(this.txtResult);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.btnDecrypt);
        this.Controls.Add(this.btnEncrypt);
        this.Controls.Add(this.numN);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.txtInput);
        this.Controls.Add(this.label1);
        this.Name = "Form1";
        this.Text = "Cifrul +n (Caesar)";
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.numN)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.NumericUpDown numN;
    private System.Windows.Forms.Button btnEncrypt;
    private System.Windows.Forms.Button btnDecrypt;
    private System.Windows.Forms.Button btnCryptanalysis;
    private System.Windows.Forms.TextBox txtResult;
    private System.Windows.Forms.ListBox lstAnalysis;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    #endregion
}
