using System.Collections.Generic;

namespace Meta.Domain
{
   public interface IClass
   {
      IClassType ClassType { get; }
      IEnumerable<IAttribute> Attributes { get; }
   }
}
