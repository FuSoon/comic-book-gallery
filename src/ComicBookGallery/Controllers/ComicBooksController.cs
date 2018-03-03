using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Data;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRespository _comicBookRespository = null;

        public ComicBooksController()
        {
            _comicBookRespository = new ComicBookRespository();
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            //var comicBook = _comicBookRespository.GetComicBook(id.Value);
            var comicBook = _comicBookRespository.GetComicBook((int)id);
            
            return View(comicBook);
        }
    }
}