namespace PierresBakery.Models
{
  public class Pastries
  {
    public int PastryCount {get; set; }
    public Pastries (int pastryCount)
    {
      PastryCount = pastryCount;
    }

    public int Cost ()
    {
      int pastryCount = 0;
      int cost = 0;

      while (pastryCount > 0)
      {
        if (pastryCount >= 3)
        {
          
        }
      }
      return PastryCount * 2;
    }
  }
}