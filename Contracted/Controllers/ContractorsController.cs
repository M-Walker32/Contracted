using System;
using System.Collections.Generic;
using Contracted.Models;
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
    [HttpGet]
    public ActionResult<List<Contractor>> Get()
    {
      try
      {
        List<Contractor> contractors = _cs.Get();
        return Ok(contractors);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // GET BY ID
    [HttpGet("{id}")]
    public ActionResult<Contractor> Get(int id)
    {
      try
      {
        Contractor contractor = _cs.Get(id);
        return Ok(contractor);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Contractor> Create([FromBody] Contractor contractor)
    {
      try
      {
        Contractor newcontractor = _cs.Create(contractor);
        return Ok(contractor);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<Contractor> Delete(int id)
    {
      try
      {
        _cs.Delete(id);
        return Ok();
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}