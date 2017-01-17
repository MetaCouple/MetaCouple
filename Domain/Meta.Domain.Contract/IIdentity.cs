using System;

namespace Meta.Domain
{
   public interface IIdentity
   {
      string Name { get; }
      Guid Id { get; }
   }
}
