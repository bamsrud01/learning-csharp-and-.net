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

    public GetLocationAt(int pathStep)
    {
      if(pathStep < _path.length)
      {
        return _path[pathStep];
      }
      else
      {
        return null;
      }
    }
  }
}
