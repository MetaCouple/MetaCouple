using Meta.Domain.Command;
using Meta.Domain.Query;
using System;

namespace Meta.Domain
{
   public interface IClassTypeCatalog : IClassTypeCommands, IClassTypeQuery
   {
   }
}
