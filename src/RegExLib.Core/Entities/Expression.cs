﻿using RegExLib.SharedKernel;

namespace RegExLib.Core.Entities
{
    public class Expression : BaseEntity
  {
        public int AuthorId { get; private set; }
        public string Title { get; private set; }
        public string Pattern { get; private set; }
        public string Description { get; private set; }

        public Expression(string title, string pattern, string description, int authorId)
        {
            Title = title;
            Pattern = pattern;
            Description = description;
            AuthorId = authorId;
        }

        public override string ToString() => Title;
    }
}