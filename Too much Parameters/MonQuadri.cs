namespace Too_much_Parameters
{
  public class MonQuadri
  {
    public Point[] MesPoints = new Point[4];
    public MonQuadri(Point point1, Point point2, Point point3, Point point4)
    {
      MesPoints[0] = point1;
      MesPoints[1] = point2;
      MesPoints[2] = point3;
      MesPoints[3] = point4;
    }
  }
}
