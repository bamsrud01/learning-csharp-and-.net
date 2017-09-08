namespace TreehouseDefense
{
  class Level
  {
    private readonly Invader[] _invaders;

    public Tower[] towers { get; set; }

    public Level(Invader[] invaders)
    {
      _invaders = invaders;
    }

    //  Return true if player wins, false if player loses
    public bool Play()
    {
      //  Run until all invaders are neutralized or an invader reaches end of path
      int remainingInvaders = _invaders.Length;

      while(remainingInvaders > 0)
      {
        //  Each tower has an opportunity to fire
        foreach(Tower tower in towers)
        {
          tower.FireOnInvaders(_invaders);
        }

        //  Count and move invaders on the path
        remainingInvaders = 0;
        foreach(Invader invader in _invaders)
        {
          if(invader.IsActive)
          {
            invader.Move();
            if(invader.HasScored)
            {
              return false;
            }
            remainingInvaders++;
          }
        }
      }
      return true;
    }
  }
}
