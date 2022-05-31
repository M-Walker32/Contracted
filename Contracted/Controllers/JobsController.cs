using System;
using Contracted.Models;
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
    // CREATE
    [HttpPost]
    public ActionResult<Job> Create([FromBody] Job job)
    {
      try
      {
        Job newjob = _js.Create(job);
        return Ok(job);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // DELETE 
    [HttpDelete("{id}")]
    public ActionResult<string> Delete(int id)
    {
      try
      {
        _js.Delete(id);
        return Ok("delorted");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}