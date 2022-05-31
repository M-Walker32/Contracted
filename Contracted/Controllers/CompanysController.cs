using Contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace Contracted.Controllers
{
  [Route("api/[controller]")]
  public class CompanysController : Controller
  {
    private readonly CompanysService _cs;
    private readonly JobsService _js;
    public CompanysController(CompanysService cs, JobsService js)
    {
      _cs = cs;
      _js = js;
    }
    // GET

  }
}