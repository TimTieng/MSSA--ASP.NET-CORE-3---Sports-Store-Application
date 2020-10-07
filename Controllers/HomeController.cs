/*
Class: ISTA 322 - Developing Web Applications with ASP.NET CORE
Student: Tim Tieng
Instructor: Christine Lee
Date: 26 August 2020
Description: Sports Store MVC Application 
Last Revised On: 23 September 2020
Last Revised By: Tim Tieng
Revisions Made: 
    1. Added Seed Data - Ended on page 140 (31Aug2020)
    2. Continued with Project (Added Pagination) 
    3. Started implementing navigation controls
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public int PageSize = 4; //Added on 07SEP2020 - Pagination Feature
        public HomeController(IStoreRepository repo) 
        {
            repository = repo;
        }
        //public IActionResult Index() => View(repository.Products);

        //Index() Updated for pagination feature for select information to be published to View
        public ViewResult Index(string category,int productPage = 1) //Updated on 23SEP to include Category parameter
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                .Where(p=> category == null || p.Category == category)
                .OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = category == null ?
                    repository.Products.Count() :
                    repository.Products.Where(e =>
                        e.Category == category).Count()
            },
            CurrentCategory = category
        });
    }
}
