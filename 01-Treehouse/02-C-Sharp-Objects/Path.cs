namespace TreehouseDefense
{
  class Path
  {
    //  This time, keep the fields private for "encapsulation"
    private readonly MapLocation[] _path;

    public Path(MapLocation[] path)
    {
      _path = path;
    }

    public MapLocation GetLocationAt(int pathStep)
    {
      return (pathStep < _path.Length) ? _path[pathStep] : null;
    }
  }
}
