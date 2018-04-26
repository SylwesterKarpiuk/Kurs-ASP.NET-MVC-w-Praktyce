using MvcSiteMapProvider;
using SpodIglyMVC.DAL;
using SpodIglyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpodIglyMVC.Infrastructure
{
    public class ProductListDynamicNodeProvider:DynamicNodeProviderBase
    {
        private StoreContext _db = new StoreContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            // Build value 
            var returnValue = new List<DynamicNode>();

            foreach (Genre g in _db.Genres)
            {
                DynamicNode n = new DynamicNode();
                n.Title = g.Name;
                n.Key = "Genre_" + g.GenreId;
                n.RouteValues.Add("genrename", g.Name);
                returnValue.Add(n);
            }

            // Return 
            return returnValue;
        }
    }
}