using Contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace Contracted.Controllers
{
  [Route("api/[controller]")]
  public class JobController : Controller
  {
    private readonly JobsService _js;
    public JobController(JobsService js)
    {
      _js = js;
    }
    // GET

  }
}