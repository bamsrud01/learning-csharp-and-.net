namespace TreehouseDefense.exe
{
  class SniperTower : Tower
  {
    protected override int Range { get; } = 3;

    protected override double Accuracy { get; } = 0.8;

    public SniperTower(MapLocation location) : base(location)
    {}
  }
}
