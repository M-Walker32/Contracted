using Contracted.Repositories;

namespace Contracted.Services
{
  public class JobsService
  {
    private readonly JobsRepository _repo;
    public JobsService(JobsRepository repo)
    {
      _repo = repo;
    }
    // GET
  }
}