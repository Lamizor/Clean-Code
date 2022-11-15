namespace Too_much_code_lines
{
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
      if(disposing && (components != null))
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
      this.lNom = new System.Windows.Forms.Label();
      this.tbNom = new System.Windows.Forms.TextBox();
      this.lPrenom = new System.Windows.Forms.Label();
      this.tbPrenom = new System.Windows.Forms.TextBox();
      this.lAge = new System.Windows.Forms.Label();
      this.tbAge = new System.Windows.Forms.TextBox();
      this.lbPersonne = new System.Windows.Forms.ListBox();
      this.bAjouter = new System.Windows.Forms.Button();
      this.lAgeMoy = new System.Windows.Forms.Label();
      this.tbAgeMoy = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lNom
      // 
      this.lNom.AutoSize = true;
      this.lNom.Location = new System.Drawing.Point(12, 9);
      this.lNom.Name = "lNom";
      this.lNom.Size = new System.Drawing.Size(34, 15);
      this.lNom.TabIndex = 0;
      this.lNom.Text = "Nom";
      // 
      // tbNom
      // 
      this.tbNom.Location = new System.Drawing.Point(12, 27);
      this.tbNom.Name = "tbNom";
      this.tbNom.Size = new System.Drawing.Size(100, 23);
      this.tbNom.TabIndex = 1;
      // 
      // lPrenom
      // 
      this.lPrenom.AutoSize = true;
      this.lPrenom.Location = new System.Drawing.Point(12, 60);
      this.lPrenom.Name = "lPrenom";
      this.lPrenom.Size = new System.Drawing.Size(49, 15);
      this.lPrenom.TabIndex = 0;
      this.lPrenom.Text = "Prénom";
      // 
      // tbPrenom
      // 
      this.tbPrenom.Location = new System.Drawing.Point(12, 78);
      this.tbPrenom.Name = "tbPrenom";
      this.tbPrenom.Size = new System.Drawing.Size(100, 23);
      this.tbPrenom.TabIndex = 1;
      // 
      // lAge
      // 
      this.lAge.AutoSize = true;
      this.lAge.Location = new System.Drawing.Point(12, 110);
      this.lAge.Name = "lAge";
      this.lAge.Size = new System.Drawing.Size(28, 15);
      this.lAge.TabIndex = 0;
      this.lAge.Text = "Age";
      // 
      // tbAge
      // 
      this.tbAge.Location = new System.Drawing.Point(12, 128);
      this.tbAge.Name = "tbAge";
      this.tbAge.Size = new System.Drawing.Size(100, 23);
      this.tbAge.TabIndex = 1;
      // 
      // lbPersonne
      // 
      this.lbPersonne.FormattingEnabled = true;
      this.lbPersonne.ItemHeight = 15;
      this.lbPersonne.Location = new System.Drawing.Point(118, 27);
      this.lbPersonne.Name = "lbPersonne";
      this.lbPersonne.Size = new System.Drawing.Size(414, 124);
      this.lbPersonne.TabIndex = 2;
      // 
      // bAjouter
      // 
      this.bAjouter.Location = new System.Drawing.Point(12, 157);
      this.bAjouter.Name = "bAjouter";
      this.bAjouter.Size = new System.Drawing.Size(100, 23);
      this.bAjouter.TabIndex = 3;
      this.bAjouter.Text = "Ajouter";
      this.bAjouter.UseVisualStyleBackColor = true;
      this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
      // 
      // lAgeMoy
      // 
      this.lAgeMoy.AutoSize = true;
      this.lAgeMoy.Location = new System.Drawing.Point(118, 161);
      this.lAgeMoy.Name = "lAgeMoy";
      this.lAgeMoy.Size = new System.Drawing.Size(68, 15);
      this.lAgeMoy.TabIndex = 4;
      this.lAgeMoy.Text = "Age Moyen";
      // 
      // tbAgeMoy
      // 
      this.tbAgeMoy.Location = new System.Drawing.Point(192, 157);
      this.tbAgeMoy.Name = "tbAgeMoy";
      this.tbAgeMoy.ReadOnly = true;
      this.tbAgeMoy.Size = new System.Drawing.Size(100, 23);
      this.tbAgeMoy.TabIndex = 1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(557, 205);
      this.Controls.Add(this.lAgeMoy);
      this.Controls.Add(this.bAjouter);
      this.Controls.Add(this.lbPersonne);
      this.Controls.Add(this.tbAgeMoy);
      this.Controls.Add(this.tbAge);
      this.Controls.Add(this.tbPrenom);
      this.Controls.Add(this.tbNom);
      this.Controls.Add(this.lAge);
      this.Controls.Add(this.lPrenom);
      this.Controls.Add(this.lNom);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label lNom;
    private TextBox tbNom;
    private Label lPrenom;
    private TextBox tbPrenom;
    private Label lAge;
    private TextBox tbAge;
    private ListBox lbPersonne;
    private Button bAjouter;
    private Label lAgeMoy;
    private TextBox tbAgeMoy;
  }
}