namespace Contracted.Models
{
  public class Companys
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
  public class JobsViewModel : Companys
  {
    public int JobId { get; set; }
  }
}