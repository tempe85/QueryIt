
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace QueryIt
{
  public class EmployeeDb : DbContext
  {
    public DbSet<Employee> Employees { get; set; }
  }

  public interface IRepository<T> : IDisposable
  {
    void Add(T newEntity);
    void Delete(T entity);
    T FindById(int id);
    IQueryable<T> FindAll();
    int Commit();
  }

  public class SqlRespository<T> : IRepository<T> where T: class
  {
    DbContext _ctx;
    DbSet<T> _set;
    public SqlRespository(DbContext ctx)
    {
      _ctx = ctx;
      _set = _ctx.Set<T>();
    }
    public void Add(T newEntity)
    {
      _set.Add(newEntity);
    }

    public int Commit()
    {
      return _ctx.SaveChanges();
    }

    public void Delete(T entity)
    {
      throw new NotImplementedException();
    }

    public void Dispose()
    {
      _ctx.Dispose();
    }

    public IQueryable<T> FindAll()
    {
      throw new NotImplementedException();
    }

    public T FindById(int id)
    {
      throw new NotImplementedException();
    }
  }

}
