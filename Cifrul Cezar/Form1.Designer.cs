namespace CaesarCipherDorin;

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
        this.btnEncrypt = new System.Windows.Forms.Button();
        this.btnDecrypt = new System.Windows.Forms.Button();
        this.btnCrack = new System.Windows.Forms.Button();
        this.txtResult = new System.Windows.Forms.TextBox();
        this.lstAnalysis = new System.Windows.Forms.ListBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
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
        this.txtInput.Size = new System.Drawing.Size(350, 23);
        this.txtInput.TabIndex = 1;

        // 
        // btnEncrypt
        // 
        this.btnEncrypt.Location = new System.Drawing.Point(12, 70);
        this.btnEncrypt.Name = "btnEncrypt";
        this.btnEncrypt.Size = new System.Drawing.Size(110, 30);
        this.btnEncrypt.TabIndex = 2;
        this.btnEncrypt.Text = "Cripteaza (+3)";
        this.btnEncrypt.UseVisualStyleBackColor = true;
        this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

        // 
        // btnDecrypt
        // 
        this.btnDecrypt.Location = new System.Drawing.Point(128, 70);
        this.btnDecrypt.Name = "btnDecrypt";
        this.btnDecrypt.Size = new System.Drawing.Size(110, 30);
        this.btnDecrypt.TabIndex = 3;
        this.btnDecrypt.Text = "Decripteaza (-3)";
        this.btnDecrypt.UseVisualStyleBackColor = true;
        this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

        // 
        // btnCrack
        // 
        this.btnCrack.Location = new System.Drawing.Point(244, 70);
        this.btnCrack.Name = "btnCrack";
        this.btnCrack.Size = new System.Drawing.Size(118, 30);
        this.btnCrack.TabIndex = 4;
        this.btnCrack.Text = "Criptanaliza";
        this.btnCrack.UseVisualStyleBackColor = true;
        this.btnCrack.Click += new System.EventHandler(this.btnCrack_Click);

        // 
        // label2 - Result
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(12, 110);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(39, 15);
        this.label2.TabIndex = 5;
        this.label2.Text = "Result";

        // 
        // txtResult
        // 
        this.txtResult.Location = new System.Drawing.Point(12, 130);
        this.txtResult.Name = "txtResult";
        this.txtResult.ReadOnly = true;
        this.txtResult.Size = new System.Drawing.Size(350, 23);
        this.txtResult.TabIndex = 6;

        // 
        // label3 - Analysis
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(12, 165);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(116, 15);
        this.label3.TabIndex = 7;
        this.label3.Text = "Criptanaliza (0-25)";

        // 
        // lstAnalysis
        // 
        this.lstAnalysis.FormattingEnabled = true;
        this.lstAnalysis.ItemHeight = 15;
        this.lstAnalysis.Location = new System.Drawing.Point(12, 185);
        this.lstAnalysis.Name = "lstAnalysis";
        this.lstAnalysis.Size = new System.Drawing.Size(350, 199);
        this.lstAnalysis.TabIndex = 8;

        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(384, 400);
        this.Controls.Add(this.lstAnalysis);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.txtResult);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.btnCrack);
        this.Controls.Add(this.btnDecrypt);
        this.Controls.Add(this.btnEncrypt);
        this.Controls.Add(this.txtInput);
        this.Controls.Add(this.label1);
        this.Name = "Form1";
        this.Text = "Caesar Cipher (+3)";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.Button btnEncrypt;
    private System.Windows.Forms.Button btnDecrypt;
    private System.Windows.Forms.Button btnCrack;
    private System.Windows.Forms.TextBox txtResult;
    private System.Windows.Forms.ListBox lstAnalysis;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    #endregion
}
