using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using appapi.Repository;
using appapi.Models;

namespace appapi.Controllers
{
    [Route("api/[controller]")]
    public class MenuCategoryController : Controller
    {
        private readonly IMenuCategoryRepository _menuCategoryRepository;

        public MenuCategoryController(IMenuCategoryRepository menuCategoryRepository)
        {
            _menuCategoryRepository = menuCategoryRepository;
        }

        [HttpGet]
        public IEnumerable<MenuCategory> Get()
        {
            return _menuCategoryRepository.GetAllMenuCategories();
        }

        //// GET: MenuCategory/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: MenuCategory/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: MenuCategory/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: MenuCategory/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: MenuCategory/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: MenuCategory/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: MenuCategory/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}