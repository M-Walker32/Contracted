using System;
using System.Collections.Generic;
using Contracted.Models;
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
    internal Job Get(int id)
    {
      Job found = _repo.Get(id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal Job Create(Job job)
    {
      return _repo.Create(job);
    }

    internal void Delete(int id)
    {
      Get(id);
      _repo.Delete(id);
    }

    internal List<JobsViewModel> GetContractors(int id)
    {
      List<JobsViewModel> jobs = _repo.GetContractors(id);
      return jobs;
    }
  }
}