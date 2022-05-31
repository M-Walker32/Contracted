using System.Collections.Generic;
using System.Data;
using System.Linq;
using Contracted.Models;
using Dapper;

namespace Contracted.Repositories
{
  public class JobsRepository
  {
    private readonly IDbConnection _db;
    public JobsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal Job Create(Job job)
    {
      string sql = @"
      INSERT INTO jobs
      (contractorId, companyId)
      VALUES
      (@ContractorId, @CompanyId);
      SELECT LAST_INSERT_ID();";
      job.Id = _db.ExecuteScalar<int>(sql, job);
      return job;
    }

    internal Job Get(int id)
    {
      string sql = "SELECT * FROM jobs WHERE id = @id";
      return _db.QueryFirstOrDefault<Job>(sql, new { id });
    }

    internal List<JobsViewModel> GetContractors(int id)
    {
      string sql = @"
      SELECT
      p.*,
      j.id AS jobId
      FROM jobs j
      JOIN jobs j ON j.contractorId = j.id
      WHERE j.companyId = @companyId";
      return _db.Query<JobsViewModel>(sql, new { id }).ToList();
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM jobs WHERE id = @id LIMIT 1";
      _db.Execute(sql, new { id });
    }
  }
}