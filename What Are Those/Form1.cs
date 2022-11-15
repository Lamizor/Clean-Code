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
      (Control ComposantAPlacer, Control Fenetre, byte position)
    {
      int xPos = -10, yPos = -20;
      switch(position)
      {
        case 0://HautGauche
          xPos = 0;
          yPos = 0;
          break;

        case 1://HautCentre
          xPos = -10 + ((Fenetre.Width - ComposantAPlacer.Width) / 2);
          yPos = 0;
          break;

        case 2://HautDroite
          xPos = -20 + (Fenetre.Width - ComposantAPlacer.Width);
          yPos = 0;
          break;

        case 3://MilieuGauche
          xPos = 0;
          yPos = -20 + ((Fenetre.Height - ComposantAPlacer.Height) / 2);
          break;

        case 4://MilieuCentre
          xPos = -10 + ((Fenetre.Width - ComposantAPlacer.Width) / 2);
          yPos = -20 + ((Fenetre.Height - ComposantAPlacer.Height) / 2);
          break;

        case 5://MilieuDroite
          xPos = -20 + Fenetre.Width - ComposantAPlacer.Width;
          yPos = -20 + ((Fenetre.Height - ComposantAPlacer.Height) / 2);
          break;

        case 6://BasGauche
          xPos = 0;
          yPos = -40 + (Fenetre.Height - ComposantAPlacer.Height);
          break;

        case 7://BasCentre
          xPos = -10 + ((Fenetre.Width - ComposantAPlacer.Width) / 2);
          yPos = -40 + (Fenetre.Height - ComposantAPlacer.Height);
          break;

        case 8://BasDroite
          xPos = -20 + (Fenetre.Width - ComposantAPlacer.Width);
          yPos = -40 + (Fenetre.Height - ComposantAPlacer.Height);
          break;
      }
      ComposantAPlacer.Location = new Point(xPos, yPos);
    }

    private void cbACentrer_SelectedIndexChanged(object sender, EventArgs e)
    {
      PlacerComposantSurFenetre(cbACentrer, this, byte.Parse(cbACentrer.SelectedItem.ToString()));
      cbACentrer.SelectedItem.ToString();
    }
  }
}
