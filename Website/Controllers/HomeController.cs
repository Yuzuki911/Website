using Core.Services;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using Website.ViewModel;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _booksService;
        private readonly IGenreService _genreService;
        public HomeController(IBookService booksService, IGenreService genreService)
        {
            _booksService = booksService;
            _genreService = genreService;
        }

        public ActionResult Index()
        {

            var listNewBook = _booksService.GetCountNewBook(6);
            var listBestSeller = _booksService.GetCountBestSeller(8);
            var listAllBook = _booksService.GetAllBook();
            var listBookByBiographic = _booksService.GetBooksByGenreId(_genreService.GetGenreIdByGenreName("Biographic"));
            var listBookByAdventure = _booksService.GetBooksByGenreId(_genreService.GetGenreIdByGenreName("Adventure"));
            var listBookByChildren = _booksService.GetBooksByGenreId(_genreService.GetGenreIdByGenreName("Children"));
            var listBookByCook = _booksService.GetBooksByGenreId(_genreService.GetGenreIdByGenreName("Cook"));

            var listNewBookViewModel = AutoMapper.Mapper.Map<IEnumerable<BookViewModel>>(listNewBook);
            var listBestSellerViewModel = AutoMapper.Mapper.Map<IEnumerable<BookViewModel>>(listBestSeller);
            var listAllBookViewModel = AutoMapper.Mapper.Map<IEnumerable<BookViewModel>>(listAllBook);
            var listBookByBiographicViewModel = AutoMapper.Mapper.Map<IEnumerable<BookViewModel>>(listBookByBiographic);
            var listBookByAdventureViewModel = AutoMapper.Mapper.Map<IEnumerable<BookViewModel>>(listBookByAdventure);
            var listBookByChildrenViewModel = AutoMapper.Mapper.Map<IEnumerable<BookViewModel>>(listBookByChildren);
            var listBookByCookViewModel = AutoMapper.Mapper.Map<IEnumerable<BookViewModel>>(listBookByCook);

            //this render in page
            ViewBag.listNewBook = listNewBookViewModel;
            ViewBag.listBestSeller = listBestSellerViewModel;

            //this go to booklistpartialview
            ViewBag.listAllBook = listAllBookViewModel;
            ViewBag.listBookByBiographic = listBookByBiographicViewModel;
            ViewBag.listBookByAdventure = listBookByAdventureViewModel;
            ViewBag.listBookByChildren = listBookByChildrenViewModel;
            ViewBag.listBookByCook = listBookByCookViewModel;



            // lấy ra phim vừa xem
            ViewBag.BookSeen = (ICollection<BookViewModel>)Session["BookSeen"];

            return View();
        }
        public JsonResult DetailPopup(Guid Id)
        {
            if (Id == null)
            {
                return Json(new HttpStatusCodeResult(HttpStatusCode.BadRequest));
            }
            Book book = _booksService.Find(Id);

            if (book == null)
            {
                return Json(HttpNotFound());
            }
            ICollection<BookViewModel> list = new List<BookViewModel>();
            var bookmodel = AutoMapper.Mapper.Map<BookViewModel>(book);
            list.Add(bookmodel);
            Session["BookSeen"] = list;
            return Json(bookmodel);
        }
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}