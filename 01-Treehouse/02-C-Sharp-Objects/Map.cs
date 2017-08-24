namespace TreehouseDefense
{
  class Map
  {
    public readonly int Width;
    public readonly int Height;

    //  Constructor
    public Map(int width, int height)
    {
      Width = width;
      Height = height;
    }

    //  Return true if point is on map
    public bool OnMap(Point point)
    {
      return point.X >= 0 && point.X < Width &&
             point.Y >= 0 && point.Y < Height;
    }
  }
}
