using Contracted.Repositories;

namespace Contracted.Services
{
  public class CompanysService
  {
    private readonly CompanysRepository _repo;
    public CompanysService(CompanysRepository repo)
    {
      _repo = repo;
    }
    // GET
  }
}