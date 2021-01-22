using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Abstract;
using Domain.Entities;

namespace WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;

        public ProductController(IProductsRepository productsRepository)
        {
            this.repository = productsRepository;
        }

        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}
