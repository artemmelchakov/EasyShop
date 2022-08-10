﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EasyShop.Models;
using EasyShop.DataAccessLayer.Models.Products;
using EasyShop.DataAccessLayer.Repositories;

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
            return View(new Picture());
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
