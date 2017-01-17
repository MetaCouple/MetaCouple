
using Meta.Domain;

namespace Meta.Domain.Command
{
   public interface IClassTypeCommands
   {
      void Add(IClassType classType);
      void Remove(IClassType classType);
      void Update(IClassType classType);
   }
}
