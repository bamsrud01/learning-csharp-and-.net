namespace TreehouseDefense
{
  class Invader
  {
    private readonly Path _path;
    private int _pathStep = 0;

    public MapLocation Location { get; private set; }

    public Invader(Path path)
    {
      _path = path;
      Location = _path.GetLocationAt(0);
    }

    public void Move()
    {
      _pathStep += 1;
      Location = _path.GetLocationAt(_pathStep);
    }
  }
}
