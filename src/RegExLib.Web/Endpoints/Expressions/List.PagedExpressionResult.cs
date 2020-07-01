﻿using System.Collections.Generic;
using RegExLib.Web.ApiModels;

namespace RegExLib.Web.Endpoints.Expressions
{
  public class PagedExpressionResult
  {
    public int Page { get; }
    public int TotalRecords { get; }
    public IEnumerable<ExpressionDTO> Expressions { get; }

    public PagedExpressionResult(int page, int totalRecords, IEnumerable<ExpressionDTO> expressions)
    {
      Page = page;
      TotalRecords = totalRecords;
      Expressions = expressions;
    }
  }
}
