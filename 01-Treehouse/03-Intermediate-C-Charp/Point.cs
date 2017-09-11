using System;

namespace TreehouseDefense
{
  class Point
  {
    public readonly int X;
    public readonly int Y;

    //  Constructor
    public Point(int x, int y)
    {
      X = x;
      Y = y;
    }

    //  Calculate distance between this and coordinates
    public int DistanceTo(int x, int y)
    {
      return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2));
    }

    //  Calculate the distance between this and point object
    public int DistanceTo(Point point)
    {
      return DistanceTo(point.X, point.Y);
    }
  }
}
