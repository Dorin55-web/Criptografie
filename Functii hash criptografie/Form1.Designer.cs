namespace HashAppDorin;

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
        this.txtPath = new System.Windows.Forms.TextBox();
        this.btnBrowse = new System.Windows.Forms.Button();
        this.cmbAlgo = new System.Windows.Forms.ComboBox();
        this.btnCompute = new System.Windows.Forms.Button();
        this.txtResult = new System.Windows.Forms.TextBox();
        this.rbFile = new System.Windows.Forms.RadioButton();
        this.rbText = new System.Windows.Forms.RadioButton();
        this.txtInputText = new System.Windows.Forms.TextBox();
        this.SuspendLayout();

        this.rbFile.AutoSize = true;
        this.rbFile.Checked = true;
        this.rbFile.Location = new System.Drawing.Point(12, 12);
        this.rbFile.Name = "rbFile";
        this.rbFile.Size = new System.Drawing.Size(94, 19);
        this.rbFile.TabIndex = 0;
        this.rbFile.TabStop = true;
        this.rbFile.Text = "Din Fisier";
        this.rbFile.UseVisualStyleBackColor = true;
        this.rbFile.CheckedChanged += new System.EventHandler(this.rbMode_CheckedChanged);

        this.rbText.AutoSize = true;
        this.rbText.Location = new System.Drawing.Point(130, 12);
        this.rbText.Name = "rbText";
        this.rbText.Size = new System.Drawing.Size(94, 19);
        this.rbText.TabIndex = 1;
        this.rbText.Text = "Text Direct";
        this.rbText.UseVisualStyleBackColor = true;
        this.rbText.CheckedChanged += new System.EventHandler(this.rbMode_CheckedChanged);

        this.txtPath.Location = new System.Drawing.Point(12, 40);
        this.txtPath.Name = "txtPath";
        this.txtPath.Size = new System.Drawing.Size(460, 23);
        this.txtPath.TabIndex = 2;

        this.btnBrowse.Location = new System.Drawing.Point(478, 40);
        this.btnBrowse.Name = "btnBrowse";
        this.btnBrowse.Size = new System.Drawing.Size(75, 23);
        this.btnBrowse.TabIndex = 3;
        this.btnBrowse.Text = "Browse...";
        this.btnBrowse.UseVisualStyleBackColor = true;
        this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

        this.txtInputText.Enabled = false;
        this.txtInputText.Location = new System.Drawing.Point(12, 69);
        this.txtInputText.Name = "txtInputText";
        this.txtInputText.PlaceholderText = "Introduceti textul aici...";
        this.txtInputText.Size = new System.Drawing.Size(541, 23);
        this.txtInputText.TabIndex = 4;

        this.cmbAlgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbAlgo.FormattingEnabled = true;
        this.cmbAlgo.Items.AddRange(new object[] {
        "MD5",
        "SHA1",
        "SHA256",
        "SHA384",
        "SHA512",
        "RIPEMD160"});
        this.cmbAlgo.Location = new System.Drawing.Point(12, 100);
        this.cmbAlgo.Name = "cmbAlgo";
        this.cmbAlgo.Size = new System.Drawing.Size(121, 23);
        this.cmbAlgo.TabIndex = 5;

        this.btnCompute.Location = new System.Drawing.Point(139, 100);
        this.btnCompute.Name = "btnCompute";
        this.btnCompute.Size = new System.Drawing.Size(120, 23);
        this.btnCompute.TabIndex = 6;
        this.btnCompute.Text = "Calculeaza Hash";
        this.btnCompute.UseVisualStyleBackColor = true;
        this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);

        this.txtResult.Location = new System.Drawing.Point(12, 130);
        this.txtResult.Multiline = true;
        this.txtResult.Name = "txtResult";
        this.txtResult.ReadOnly = true;
        this.txtResult.Size = new System.Drawing.Size(541, 150);
        this.txtResult.TabIndex = 7;

        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(565, 300);
        this.Controls.Add(this.txtResult);
        this.Controls.Add(this.btnCompute);
        this.Controls.Add(this.cmbAlgo);
        this.Controls.Add(this.txtInputText);
        this.Controls.Add(this.btnBrowse);
        this.Controls.Add(this.txtPath);
        this.Controls.Add(this.rbText);
        this.Controls.Add(this.rbFile);
        this.Name = "Form1";
        this.Text = "Hash App Dorin";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox txtPath;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.ComboBox cmbAlgo;
    private System.Windows.Forms.Button btnCompute;
    private System.Windows.Forms.TextBox txtResult;
    private System.Windows.Forms.RadioButton rbFile;
    private System.Windows.Forms.RadioButton rbText;
    private System.Windows.Forms.TextBox txtInputText;
}
