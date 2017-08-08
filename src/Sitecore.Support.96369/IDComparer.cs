using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Buckets.Search.SearchOperations
{
    //Sitecore.Support.96369
    public class IDComparer : IEqualityComparer<Item>
    {
        public bool Equals(Item item1, Item item2)
        {
            return item1.ID == item2.ID;
        }

        public int GetHashCode(Item obj)
        {
            return obj.ID.GetHashCode();
        }
    }
    //
}