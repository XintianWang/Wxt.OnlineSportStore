using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wxt.OnlineSportStore.Domain.Abstract;

namespace Wxt.OnlineSportStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository _productsRepository;

        public ProductController(IProductsRepository repo)
        {
            this._productsRepository = repo;
        }
        // GET: Product
        public ViewResult Index()
        {
            var result = _productsRepository.Products;
            return View(result);
        }
    }
}