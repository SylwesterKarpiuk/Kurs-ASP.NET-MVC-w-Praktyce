using MvcSiteMapProvider;
using SpodIglyMVC.DAL;
using SpodIglyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpodIglyMVC.Infrastructure
{
    public class ProductDetailsDynamicNodeProvider : DynamicNodeProviderBase
    {
        private StoreContext _db = new StoreContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            // Build value 
            var returnValue = new List<DynamicNode>();

            foreach (Album a in _db.Albums)
            {
                DynamicNode n = new DynamicNode();
                n.Title = a.AlbumTitle;
                n.Key = "Album_" + a.AlbumId;
                n.ParentKey = "Genre_" + a.GenreId;
                n.RouteValues.Add("id", a.AlbumId);
                returnValue.Add(n);
            }

            // Return 
            return returnValue;
        }
    }
}