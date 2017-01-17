using System;

namespace Meta.Domain.Query
{
   public interface IClassTypeQuery
   {
      int Count { get; }
      bool Contains(string name);
      bool Contains(Guid id);
   }
}
