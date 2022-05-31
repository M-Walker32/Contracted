using System;
using System.Collections.Generic;
using Contracted.Models;
using Contracted.Repositories;

namespace Contracted.Services
{
  public class ContractorsService
  {
    private readonly ContractorsRepository _repo;
    public ContractorsService(ContractorsRepository repo)
    {
      _repo = repo;
    }

    // GET
    internal List<Contractor> Get()
    {
      return _repo.Get();
    }
    // GET BY ID
    internal Contractor Get(int id)
    {
      Contractor found = _repo.Get(id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    // CREATE
    internal Contractor Create(Contractor contractor)
    {
      Contractor newContractor = _repo.Create(contractor);
      return contractor;
    }
    // DELETE
    internal void Delete(int id)
    {
      Contractor found = Get(id);
      _repo.Delete(id);
    }
  }
}