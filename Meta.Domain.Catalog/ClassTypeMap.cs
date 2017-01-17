using Meta.Domain.Command;
using Meta.Domain.Query;
using System;
using System.Collections.Generic;

namespace Meta.Domain
{
   internal interface IClassTypeMap : IClassTypeCommands, IClassTypeQuery { }

   internal class ClassTypeMap : IClassTypeMap
   {
      private IDictionary<IIdentity, IClassType> ItemsByIdentity = new Dictionary<IIdentity, IClassType>();
      private IDictionary<string, IClassType> ItemsByName = new Dictionary<string, IClassType>();
      private IDictionary<Guid, IClassType> ItemsById = new Dictionary<Guid, IClassType>();

      #region private
      private int Count { get { return ItemsByIdentity.Count; } }

      private void Add(IClassType classType)
      {
         if (Contains(classType) == false)
         {
            ItemsByIdentity.Add(classType, classType);
            ItemsByName.Add(classType.Name, classType);
            ItemsById.Add(classType.Id, classType);
         }
         else
         {
            Update(classType);
         }
      }

      private void Remove(IClassType classType)
      {
         if (Contains(classType) == true)
         {
            ItemsByIdentity.Remove(classType);
            ItemsByName.Remove(classType.Name);
            ItemsById.Remove(classType.Id);
         }
      }
      private void Update(IClassType classType)
      {
         if (Contains(classType) == false)
         {
            Add(classType);
         }
         else
         {
            ItemsByIdentity[classType] = classType;
            ItemsById[classType.Id] = classType;
            ItemsByName[classType.Name] = classType;
         }
      }
      private bool Contains(IIdentity identity)
      {
         return ItemsByIdentity.ContainsKey(identity) && Contains(identity.Name) && Contains(identity.Id);
      }
      private bool Contains(string name)
      {
         return ItemsByName.ContainsKey(name);
      }
      private bool Contains(Guid id)
      {
         return ItemsById.ContainsKey(id);
      }
      #endregion

      #region IClassTypeQuery
      int IClassTypeQuery.Count
      {
         get
         {
            return Count;
         }
      }
      bool IClassTypeQuery.Contains(string name)
      {
         return Contains(name);
      }

      bool IClassTypeQuery.Contains(Guid id)
      {
         return Contains(id);
      }
      #endregion

      #region IClassTypeCommands
      void IClassTypeCommands.Add(IClassType classType)
      {
         Add(classType);
      }

      void IClassTypeCommands.Remove(IClassType classType)
      {
         Remove(classType);
      }

      void IClassTypeCommands.Update(IClassType classType)
      {
         Update(classType);
      }
      #endregion

   }
}
