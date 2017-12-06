using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindDragDrop.Models;
using FindDragDrop.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FindDragDrop.Controllers
{
    public class HomeController : Controller
    {
        ObjectRepository repository;

        //IMemoryCache cache;
        //public HomeController(IMemoryCache cache)
        //{
        //    this.cache = cache;
        //}

        public HomeController(ObjectRepository repository)
        {
            this.repository = repository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            IndexVM indexVM = new IndexVM
            {
                Name = Request.Cookies["Name"],
            };
           
            return View(indexVM);
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(LoginVM viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            Response.Cookies.Append("Name", viewModel.Name);
            repository.AddNewUser(viewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult GetObjects()
        {
            var viewModel = repository.GetAllObjects();
            return PartialView("_Partial", viewModel);
        }
              
       
    }
}

