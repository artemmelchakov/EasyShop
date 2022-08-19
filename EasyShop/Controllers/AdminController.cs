using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using EasyShop.DataAccessLayer.Models;
using EasyShop.DataAccessLayer.Repositories;
using EasyShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EasyShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private BaseProductRepository<BaseProduct> baseProductRepository;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
            baseProductRepository = new BaseProductRepository<BaseProduct>();
        }

        public IActionResult Index()
        {
            IEnumerable<Type> baseProductSubtypes = FindTypesOfProduct(type => type.IsSubclassOf(typeof(BaseProduct)));
            ViewBag.BaseProductSubtypes = baseProductSubtypes;
            return View();
        }

        private IEnumerable<Type> FindTypesOfProduct(Func<Type, bool> predicate)
        {
            return Assembly.GetAssembly(typeof(BaseProduct)).GetTypes().Where(predicate);
        }

        public IActionResult FillProductProperties(string productType)
        {
            IEnumerable<Type> types = FindTypesOfProduct(type => productType == type.Name);
            Type type = types.First();
            TypeInfo typeInfo = type.GetTypeInfo();
            PropertyInfo[] propertyInfo = typeInfo.GetProperties();
            ViewBag.PropertyInfo = propertyInfo;

            List<string> propertyNames = new List<string>();
            foreach (var property in ViewBag.PropertyInfo)
            {
                propertyNames.Add(property.Name);
            }
            ViewBag.PropertyNames = propertyNames;

            return View();
        }

        public IActionResult CreateProduct()
        {
            return View();
        }
    }
}