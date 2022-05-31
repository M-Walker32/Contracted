using System;
using System.Collections.Generic;
using Contracted.Models;
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
    internal List<Company> Get()
    {
      return _repo.Get();
    }
    // GET BY ID
    internal Company Get(int id)
    {
      Company found = _repo.Get(id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    // CREATE
    internal Company Create(Company company)
    {
      Company newCompany = _repo.Create(company);
      return company;
    }
    // DELETE
    internal void Delete(int id)
    {
      Company found = Get(id);
      _repo.Delete(id);
    }
  }
}