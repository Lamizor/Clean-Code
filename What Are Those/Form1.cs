namespace What_Are_Those
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    public static void PlacerComposantSurFenetre
      (Control ComposantAPlacer, Control Fenetre)
    {
      ComposantAPlacer.Location = new Point(-10 +
         ((Fenetre.Width - ComposantAPlacer.Width) / 2),
         -20 +
        ((Fenetre.Height - ComposantAPlacer.Height) / 2));
    }
    public static void PlacerComposantSurFenetre
      (Control ComposantAPlacer, Control Fenetre, Positions position)
    {
      int xPos = -10, yPos = -20;
      switch(position)
      {
        case Positions.HautGauche://HautGauche
          xPos = 0;
          yPos = 0;
          break;

        case Positions.HautCentre://HautCentre
          xPos = -10 + ((Fenetre.Width - ComposantAPlacer.Width) / 2);
          yPos = 0;
          break;

        case Positions.HautDroit://HautDroite
          xPos = -20 + (Fenetre.Width - ComposantAPlacer.Width);
          yPos = 0;
          break;

        case Positions.MilieuGauche://MilieuGauche
          xPos = 0;
          yPos = -20 + ((Fenetre.Height - ComposantAPlacer.Height) / 2);
          break;

        case Positions.MilieuCentre://MilieuCentre
          xPos = -10 + ((Fenetre.Width - ComposantAPlacer.Width) / 2);
          yPos = -20 + ((Fenetre.Height - ComposantAPlacer.Height) / 2);
          break;

        case Positions.MilieuDroit://MilieuDroite
          xPos = -20 + Fenetre.Width - ComposantAPlacer.Width;
          yPos = -20 + ((Fenetre.Height - ComposantAPlacer.Height) / 2);
          break;

        case Positions.BasGauche://BasGauche
          xPos = 0;
          yPos = -40 + (Fenetre.Height - ComposantAPlacer.Height);
          break;

        case Positions.BasCentre://BasCentre
          xPos = -10 + ((Fenetre.Width - ComposantAPlacer.Width) / 2);
          yPos = -40 + (Fenetre.Height - ComposantAPlacer.Height);
          break;

        case Positions.BasDroit://BasDroite
          xPos = -20 + (Fenetre.Width - ComposantAPlacer.Width);
          yPos = -40 + (Fenetre.Height - ComposantAPlacer.Height);
          break;
      }
      ComposantAPlacer.Location = new Point(xPos, yPos);
    }

    private void cbACentrer_SelectedIndexChanged(object sender, EventArgs e)
    {
      PlacerComposantSurFenetre(
        cbACentrer,
        this,
        (Positions)byte.Parse(cbACentrer.SelectedItem.ToString()));
      cbACentrer.SelectedItem.ToString();
    }

    public enum Positions : byte
    {
      HautGauche, HautCentre, HautDroit,
      MilieuGauche, MilieuCentre, MilieuDroit,
      BasGauche, BasCentre, BasDroit
    }
  }
}
