namespace PierresBakery.Models
{
  public class Bread
  {

    public int BreadCount {get; set; }
    public Bread (int breadCount)
    {
      BreadCount = breadCount;
    }

    public int Cost ()
    {
      int cost = 0;
      int loaves = BreadCount;

      while (loaves > 0)
      {
        if (loaves >= 3)
        {
          int loafTriples = loaves / 3;
          cost += 10 * loafTriples;
          loaves -= (loafTriples * 3);
        }

        cost += (5 * loaves);
        loaves = 0;
      }
      return cost;
    }
  }
}
