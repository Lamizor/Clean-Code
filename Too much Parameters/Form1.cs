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
      DessinerQuadri(
        Int32.Parse(tbx1.Text), Int32.Parse(tby1.Text),
        Int32.Parse(tbx2.Text), Int32.Parse(tby2.Text),
        Int32.Parse(tbx3.Text), Int32.Parse(tby3.Text),
        Int32.Parse(tbx4.Text), Int32.Parse(tby4.Text));
    }

    private void DessinerQuadri(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
    {
      var gr = Graphics.FromHwnd(pictureBox1.Handle);
      gr.Clear(BackColor);
      var points = new Point[4];
      points[0] = new Point(x1, y1);
      points[1] = new Point(x2, y2);
      points[2] = new Point(x3, y3);
      points[3] = new Point(x4, y4);

      gr.DrawPolygon(new Pen(Color.Black), points);
    }
  }
}
