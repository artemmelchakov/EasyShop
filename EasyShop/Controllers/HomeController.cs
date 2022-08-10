using EasyShop.DataAccessLayer.Models;
using EasyShop.DataAccessLayer.Models.NHibernate;
using EasyShop.DataAccessLayer.Repositories;
using EasyShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EasyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BaseProductRepository<Picture> baseProductRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            baseProductRepository = new BaseProductRepository<Picture>();
        }

        public IActionResult AddPicture(Picture picture)
        {
            // Id --- must be set by Guid 
            picture.Description = picture.Description == null ? "do not set" : picture.Description;
            picture.Name = picture.Name == null ? "do not set" : picture.Name;
            picture.PaintingGenre = picture.PaintingGenre == null ? "do not set" : picture.PaintingGenre;
            picture.PaintingName = picture.PaintingName == null ? "do not set" : picture.PaintingName;
            picture.PaintingTechnique = picture.PaintingTechnique == null ? "do not set" : picture.PaintingTechnique;

            picture.HeightCm = 1f;
            picture.Price = 1m;
            picture.WidthCm = 1f;

            baseProductRepository.Create(picture);

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            Picture pictures;
            using(ISession session = NHibernateHelper.OpenSession())
            {
                pictures = session.Get<Picture>(new Guid("bd360021-edb5-4c9b-a7e8-924051f9a3b0"));
                return View(pictures);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
