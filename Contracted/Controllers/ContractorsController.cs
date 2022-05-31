using Contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace Contracted.Controllers
{
  [Route("api/[controller]")]
  public class ContractorsController : Controller
  {
    private readonly ContractorsService _cs;
    private readonly JobsService _js;
    public ContractorsController(ContractorsService cs, JobsService js)
    {
      _cs = cs;
      _js = js;
    }
    // GET

  }
}