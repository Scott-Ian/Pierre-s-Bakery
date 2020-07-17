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
      return BreadCount * 5;
    }
  }
}
