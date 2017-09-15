namespace TreehouseDefense.exe
{
  class AccurateTower : Tower
  {
    protected override double Accuracy { get; } = 0.9;

    public AccurateTower(MapLocation location) : base(location)
    {}
  }
}
