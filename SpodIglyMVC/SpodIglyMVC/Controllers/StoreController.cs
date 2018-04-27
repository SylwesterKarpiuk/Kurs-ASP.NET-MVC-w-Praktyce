using SpodIglyMVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpodIglyMVC.Controllers
{
    public class StoreController : Controller
    {
        StoreContext db = new StoreContext();

        // GET: Store
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            var album = db.Albums.Find(id);
            return View(album);
        }
        public ActionResult List(string genrename, string searchQuery = null)
        {
            var genre = db.Genres.Include("album").Where(g => g.Name.ToUpper() == genrename.ToUpper()).Single();
            var albums = genre.album.Where(a => (searchQuery == null ||
                                                 a.AlbumTitle.ToLower().Contains(searchQuery.ToLower()) ||
                                                 a.ArtistName.ToLower().Contains(searchQuery.ToLower())) &&
                                                 !a.isHidden);
            if (Request.IsAjaxRequest())
            {
                return PartialView("ProductList", albums);
            }
            return View(albums);
        }

        [ChildActionOnly]
        [OutputCache(Duration =80000)]
        public ActionResult GenresMenu()
        {
            var genres = db.Genres.ToList();

            return PartialView(genres);
        }
        public ActionResult AlbumsSuggestions(string term)
        {
            var albums = this.db.Albums.Where(a => a.AlbumTitle.ToLower().Contains(term.ToLower()) && !a.isHidden).Take(5).Select(a => new { label = a.AlbumTitle });

            return Json(albums, JsonRequestBehavior.AllowGet);
        }
    }
}