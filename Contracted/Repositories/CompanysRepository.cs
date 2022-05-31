using System.Data;

namespace Contracted.Repositories
{
  public class CompanysRepository
  {
    private readonly IDbConnection _db;
    public CompanysRepository(IDbConnection db)
    {
      _db = db;
    }
    // GET
  }
}