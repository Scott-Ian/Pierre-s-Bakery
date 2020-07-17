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
          cost += 10;
          loaves -= 3;
        }
        else 
        {
          loaves --;
          cost += 5;
        }
      }
      return cost;
    }
  }
}
