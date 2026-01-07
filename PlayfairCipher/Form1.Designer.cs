namespace PlayfairCipher;

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
        this.txtKey = new System.Windows.Forms.TextBox();
        this.txtInput = new System.Windows.Forms.TextBox();
        this.btnEncrypt = new System.Windows.Forms.Button();
        this.btnDecrypt = new System.Windows.Forms.Button();
        this.txtResult = new System.Windows.Forms.TextBox();
        this.txtMatrix = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // label1 (Key)
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 15);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(26, 15);
        this.label1.TabIndex = 0;
        this.label1.Text = "Key";
        // 
        // txtKey
        // 
        this.txtKey.Location = new System.Drawing.Point(60, 12);
        this.txtKey.Name = "txtKey";
        this.txtKey.Size = new System.Drawing.Size(200, 23);
        this.txtKey.TabIndex = 1;
        // 
        // label2 (Input)
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(12, 50);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(35, 15);
        this.label2.TabIndex = 2;
        this.label2.Text = "Input";
        // 
        // txtInput
        // 
        this.txtInput.Location = new System.Drawing.Point(60, 47);
        this.txtInput.Name = "txtInput";
        this.txtInput.Size = new System.Drawing.Size(200, 23);
        this.txtInput.TabIndex = 3;
        // 
        // btnEncrypt
        // 
        this.btnEncrypt.Location = new System.Drawing.Point(60, 80);
        this.btnEncrypt.Name = "btnEncrypt";
        this.btnEncrypt.Size = new System.Drawing.Size(90, 30);
        this.btnEncrypt.TabIndex = 4;
        this.btnEncrypt.Text = "Cripteaza";
        this.btnEncrypt.UseVisualStyleBackColor = true;
        this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
        // 
        // btnDecrypt
        // 
        this.btnDecrypt.Location = new System.Drawing.Point(170, 80);
        this.btnDecrypt.Name = "btnDecrypt";
        this.btnDecrypt.Size = new System.Drawing.Size(90, 30);
        this.btnDecrypt.TabIndex = 5;
        this.btnDecrypt.Text = "Decripteaza";
        this.btnDecrypt.UseVisualStyleBackColor = true;
        this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
        // 
        // label3 (Result)
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(12, 130);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(39, 15);
        this.label3.TabIndex = 6;
        this.label3.Text = "Result";
        // 
        // txtResult
        // 
        this.txtResult.Location = new System.Drawing.Point(60, 127);
        this.txtResult.Name = "txtResult";
        this.txtResult.ReadOnly = true;
        this.txtResult.Size = new System.Drawing.Size(200, 23);
        this.txtResult.TabIndex = 7;
        // 
        // label4 (Matrix)
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(280, 15);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(41, 15);
        this.label4.TabIndex = 8;
        this.label4.Text = "Matrix";
        // 
        // txtMatrix
        // 
        this.txtMatrix.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtMatrix.Location = new System.Drawing.Point(280, 40);
        this.txtMatrix.Multiline = true;
        this.txtMatrix.Name = "txtMatrix";
        this.txtMatrix.Size = new System.Drawing.Size(150, 150);
        this.txtMatrix.TabIndex = 9;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(460, 210);
        this.Controls.Add(this.txtMatrix);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.txtResult);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.btnDecrypt);
        this.Controls.Add(this.btnEncrypt);
        this.Controls.Add(this.txtInput);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.txtKey);
        this.Controls.Add(this.label1);
        this.Name = "Form1";
        this.Text = "Playfair Cipher";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox txtKey;
    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.Button btnEncrypt;
    private System.Windows.Forms.Button btnDecrypt;
    private System.Windows.Forms.TextBox txtResult;
    private System.Windows.Forms.TextBox txtMatrix;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
}
