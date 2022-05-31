using System;
using System.Collections.Generic;
using Contracted.Models;
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
    [HttpGet]
    public ActionResult<List<Company>> Get()
    {
      try
      {
        List<Company> companys = _cs.Get();
        return Ok(companys);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // GET BY ID
    [HttpGet("{id}")]
    public ActionResult<Company> Get(int id)
    {
      try
      {
        Company company = _cs.Get(id);
        return Ok(company);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // GET JOBS BY COMPANY
    [HttpGet("{id}/contractors")]
    public ActionResult<List<JobsViewModel>> GetContractors(int id)
    {
      try
      {
        List<JobsViewModel> contractors = _js.GetContractors(id);
        return Ok(contractors);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // CREATE 
    [HttpPost]
    public ActionResult<Company> Create([FromBody] Company company)
    {
      try
      {
        Company newcompany = _cs.Create(company);
        return Ok(company);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<Company> Delete(int id)
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