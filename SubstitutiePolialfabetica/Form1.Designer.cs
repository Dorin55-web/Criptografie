namespace SubstitutiePolialfabetica;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.txtInput = new System.Windows.Forms.TextBox();
        this.txtAlfabete = new System.Windows.Forms.TextBox();
        this.btnEncrypt = new System.Windows.Forms.Button();
        this.btnDecrypt = new System.Windows.Forms.Button();
        this.txtResult = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // label1
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
        this.txtInput.Size = new System.Drawing.Size(400, 23);
        this.txtInput.TabIndex = 1;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(12, 70);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(127, 15);
        this.label2.TabIndex = 2;
        this.label2.Text = "Alfabete de substitutie";
        // 
        // txtAlfabete
        // 
        this.txtAlfabete.Location = new System.Drawing.Point(12, 90);
        this.txtAlfabete.Multiline = true;
        this.txtAlfabete.Name = "txtAlfabete";
        this.txtAlfabete.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtAlfabete.Size = new System.Drawing.Size(400, 100);
        this.txtAlfabete.TabIndex = 3;
        // 
        // btnEncrypt
        // 
        this.btnEncrypt.Location = new System.Drawing.Point(12, 200);
        this.btnEncrypt.Name = "btnEncrypt";
        this.btnEncrypt.Size = new System.Drawing.Size(90, 30);
        this.btnEncrypt.TabIndex = 4;
        this.btnEncrypt.Text = "Cripteaza";
        this.btnEncrypt.UseVisualStyleBackColor = true;
        this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
        // 
        // btnDecrypt
        // 
        this.btnDecrypt.Location = new System.Drawing.Point(120, 200);
        this.btnDecrypt.Name = "btnDecrypt";
        this.btnDecrypt.Size = new System.Drawing.Size(90, 30);
        this.btnDecrypt.TabIndex = 5;
        this.btnDecrypt.Text = "Decripteaza";
        this.btnDecrypt.UseVisualStyleBackColor = true;
        this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(12, 240);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(39, 15);
        this.label3.TabIndex = 6;
        this.label3.Text = "Result";
        // 
        // txtResult
        // 
        this.txtResult.Location = new System.Drawing.Point(12, 260);
        this.txtResult.Name = "txtResult";
        this.txtResult.ReadOnly = true;
        this.txtResult.Size = new System.Drawing.Size(400, 23);
        this.txtResult.TabIndex = 7;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(440, 300);
        this.Controls.Add(this.txtResult);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.btnDecrypt);
        this.Controls.Add(this.btnEncrypt);
        this.Controls.Add(this.txtAlfabete);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.txtInput);
        this.Controls.Add(this.label1);
        this.Name = "Form1";
        this.Text = "Substitutie Polialfabetica";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.TextBox txtAlfabete;
    private System.Windows.Forms.Button btnEncrypt;
    private System.Windows.Forms.Button btnDecrypt;
    private System.Windows.Forms.TextBox txtResult;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
}
