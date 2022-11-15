namespace What_Are_Those
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
      this.cbACentrer = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // cbACentrer
      // 
      this.cbACentrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbACentrer.FormattingEnabled = true;
      this.cbACentrer.ItemHeight = 15;
      this.cbACentrer.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
      this.cbACentrer.Location = new System.Drawing.Point(192, 219);
      this.cbACentrer.Name = "cbACentrer";
      this.cbACentrer.Size = new System.Drawing.Size(100, 23);
      this.cbACentrer.TabIndex = 1;
      this.cbACentrer.Text = "0";
      this.cbACentrer.SelectedIndexChanged += new System.EventHandler(this.cbACentrer_SelectedIndexChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 461);
      this.Controls.Add(this.cbACentrer);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "Form1";
      this.Text = "Centré sur moi !";
      this.ResumeLayout(false);

    }

        #endregion

        private ComboBox cbACentrer;
    }
}