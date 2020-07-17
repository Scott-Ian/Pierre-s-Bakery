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
      return PastryCount * 2;
    }
  }
}