using System;
using Meta.Domain.Command;
using Meta.Domain.Query;

namespace Meta.Domain
{
   internal class ClassTypeCatalog : IClassTypeCatalog
   {
      private IClassTypeMap Map = new ClassTypeMap();


      int IClassTypeQuery.Count { get { return Map.Count; } }

      void IClassTypeCommands.Add(IClassType classType)
      {
         throw new NotImplementedException();
      }

      bool IClassTypeQuery.Contains(Guid id)
      {
         return Map.Contains(id);
      }

      bool IClassTypeQuery.Contains(string name)
      {
         return Map.Contains(name);
      }

      void IClassTypeCommands.Remove(IClassType classType)
      {
      }

      void IClassTypeCommands.Update(IClassType classType)
      {
         throw new NotImplementedException();
      }
   }
}
