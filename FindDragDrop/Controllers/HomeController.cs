using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindDragDrop.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FindDragDrop.Controllers
{
    public class HomeController : Controller
    {
        ObjectRepository repository;

        public HomeController(ObjectRepository repository)
        {
            this.repository = repository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var viewModel = repository.GetAllObjects();
            return View(viewModel);
        }
    }
}

