using System.Windows.Forms;

namespace Too_much_Parameters
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void bDraw_Click(object sender, EventArgs e)
    {
      Point[] points = new Point[4];
      points[0] = new Point(int.Parse(tbx1.Text), int.Parse(tby1.Text));
      points[1] = new Point(int.Parse(tbx2.Text), int.Parse(tby2.Text));
      points[2] = new Point(int.Parse(tbx3.Text), int.Parse(tby3.Text));
      points[3] = new Point(int.Parse(tbx4.Text), int.Parse(tby4.Text));

      MonQuadri quadri = new MonQuadri(points[0], points[1], points[2], points[3]);
      MessageBox.Show("Le quadrilatère va être dessiné avec la classe " + points[0].GetType());
      DessinerQuadri(
        points[0],
        points[1],
        points[2],
        points[3]);

      MessageBox.Show("Le quadrilatère va être dessiné avec la classe " + quadri.GetType());
      DessinerQuadri(quadri);
    }

    private void DessinerQuadri(Point point1, Point point2, Point point3, Point point4)
    {
      var gr = Graphics.FromHwnd(pictureBox1.Handle);
      gr.Clear(BackColor);
      var points = new Point[4];
      points[0] = point1;
      points[1] = point2;
      points[2] = point3;
      points[3] = point4;

      gr.DrawPolygon(new Pen(Color.Black), points);
    }
    private void DessinerQuadri(MonQuadri quadri)
    {
      var gr = Graphics.FromHwnd(pictureBox1.Handle);
      gr.Clear(BackColor);
      gr.DrawPolygon(new Pen(Color.Black), quadri.MesPoints);
    }
  }
}
