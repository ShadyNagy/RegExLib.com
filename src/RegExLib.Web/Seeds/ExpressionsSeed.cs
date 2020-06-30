﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegExLib.Core.Entities;
using RegExLib.Infrastructure.Data;

namespace RegExLib.Web.Seeds
{
  public class ExpressionsSeed : ISeedData
  {
    public static readonly Expression Expression1 = new Expression("title", "pattern", "description", 1);
    private readonly AppDbContext _dbContext;

    public ExpressionsSeed(AppDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public void PopulateTestData()
    {
      if (HasData())
      {
        return;
      }

      _dbContext.RemoveRange(_dbContext.Expression);
      
      _dbContext.SaveChanges();
      _dbContext.Expression.Add(Expression1);

      _dbContext.SaveChanges();
    }

    private bool HasData()
    {
      return _dbContext.Expression.Any();
    }
  }
}
