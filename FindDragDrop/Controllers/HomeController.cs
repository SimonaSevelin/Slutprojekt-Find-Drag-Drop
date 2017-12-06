using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindDragDrop.Models;
using FindDragDrop.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FindDragDrop.Controllers
{
    public class HomeController : Controller
    {

        UserManager<IdentityUser> userManager;
        SignInManager<IdentityUser> signInManager;
        RoleManager<IdentityRole> roleManager;
        IdentityDbContext identityContext;

        public HomeController(
        UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager,
        RoleManager<IdentityRole> roleManager,
         IdentityDbContext identityContext)


        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.identityContext = identityContext;

            identityContext.Database.EnsureCreated();
        }


        //ObjectRepository repository;

        //public HomeController(ObjectRepository repository)
        //{
        //    this.repository = repository;
        //}

        // GET: /<controller>/

        [Authorize]
        public IActionResult Index()
        {
            //IndexVM indexVM = new IndexVM
            //{
            //    Name = Request.Cookies["Name"],
            //};

            return View(/*indexVM*/);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult LogIn(LoginVM viewModel)
        {
            //if (!ModelState.IsValid)
            //    return View(viewModel);

            //Response.Cookies.Append("Name", viewModel.Name);
            ////repository.AddNewUser(viewModel);
            //return RedirectToAction(nameof(Index));
            return View();
        }

        //public IActionResult GetObjects()
        //{
        //    //var viewModel = repository.GetAllObjects();
        //    //return PartialView("_Partial", viewModel);
        //}


    }
}

