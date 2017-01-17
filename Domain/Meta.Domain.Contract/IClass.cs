
using System.Collections.Generic;

namespace Meta.Domain.Contract
{
   public interface IClass
   {
      IEnumerable<IAttribute> Attributes { get; }
   }
}
