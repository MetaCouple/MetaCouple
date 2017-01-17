using System.Collections.Generic;

namespace Meta.Domain
{
   public interface IClassType : IIdentity
   {
      IEnumerable<IAttributeType> AttributeTypes { get; }
   }
}
