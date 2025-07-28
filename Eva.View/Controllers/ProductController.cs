using Eva.Domain._Entities;
using Eva.Services.CategoryServices.Services.Interfaces;
using Eva.Services.ProductServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Eva.View.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index()
        {

            return View(productService.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            productService.Add(product);
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = productService.GetById(id);
            if (product == null)
                return NotFound();
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                productService.Update(product);

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
                if (await productService.Delete(id) > 0)
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
