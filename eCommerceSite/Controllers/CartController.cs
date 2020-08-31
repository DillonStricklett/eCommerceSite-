using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceSite.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Add(int id) // Id of the product to add
        {
            // Get product from the DB
            // Add product to cart cookie

            // Redirect back to previous page
            return View();
        }

        public IActionResult Summary()
        {
            // Display all products in the shopping cart
            return View();
        }
    }
}
