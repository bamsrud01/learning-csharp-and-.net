namespace TreehouseDefense.exe
{
  class PowerTower : Tower
  {
    protected override int Range { get; } = 2;

    public PowerTower(MapLocation location) : base(location)
    {}
  }
}
