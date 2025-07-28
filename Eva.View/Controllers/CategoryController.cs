using Eva.Domain._Entities;
using Eva.Services.CategoryServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Eva.View.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryServices categoryServices;

        public CategoryController(ICategoryServices categoryServices)
        {
            this.categoryServices = categoryServices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(categoryServices.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Categories categories)
        {
            categoryServices.Add(categories);
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = categoryServices.GetById(id);
            if (category == null)
                return NotFound();
            return View(category);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        public ActionResult Edit(Categories category)
        {
            try
            {
                categoryServices.Update(category);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                if (await categoryServices.Delete(id) > 0)
                    return RedirectToAction(nameof(Index));

                return NotFound();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
