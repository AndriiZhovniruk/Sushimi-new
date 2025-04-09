using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sushimi.Data;
using Sushimi.Models;

namespace SushiMI.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ======== LOGIN ========

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            // ⚠️ ТИМЧАСОВИЙ ВАРІАНТ, пізніше можна підключити таблицю User
            if (username == "admin" && password == "admin123")
            {
                HttpContext.Session.SetString("IsAdmin", "true");
                return RedirectToAction("Dashboard");
            }

            ViewBag.Error = "Невірний логін або пароль";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("IsAdmin");
            return RedirectToAction("Index");
        }

        // ======== DASHBOARD ========
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
                return RedirectToAction("Index");
            var stats = _context.Dishes
                .GroupBy(d => d.Category)
                .Select(g => new CategoryStatsViewModel
                {
                    Category = g.Key,
                    DishStats = g.Select(d => new DishStatViewModel
                    {
                        DishName = d.Name,
                        OrderCount = _context.OrderItems
                            .Where(oi => oi.DishName == d.Name)
                            .Sum(oi => oi.Quantity)
                    })
                    //.OrderBy(ds => ds.OrderCount)
                    .OrderByDescending(x => x.OrderCount)
                    .ToList()
                })
                .ToList();

            return View(stats);
        }

        // ======== ORDERS ========
        public IActionResult Orders()
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
                return RedirectToAction("Index");

            var orders = _context.Orders
                .Include(o => o.OrderItems)
                .ToList();

            return View(orders);
        }

        // ======== MANAGE DISHES ========
        public IActionResult ManageDishes()
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
                return RedirectToAction("Index");

            var dishes = _context.Dishes.ToList();
            return View(dishes);
        }

        [HttpGet]
        public IActionResult CreateDish()
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
                return RedirectToAction("Index");

            return View();
        }

        [HttpPost]
        public IActionResult CreateDish(Dish dish, IFormFile imageFile)
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
                return RedirectToAction("Index");

            if (ModelState.IsValid)
            {
                _context.Dishes.Add(dish);
                _context.SaveChanges(); // Потрібно, щоб dish.Id згенерувався

                if (imageFile != null && imageFile.Length > 0)
                {
                    var imagePath = Path.Combine("wwwroot", "Img", dish.Category);
                    Directory.CreateDirectory(imagePath); // Створити директорію, якщо її нема

                    var filePath = Path.Combine(imagePath, $"{dish.Id}.png");
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        imageFile.CopyTo(stream);
                    }
                }

                return RedirectToAction("ManageDishes");
            }

            return View(dish);
        }

        //[HttpPost]
        //public IActionResult EditDish(Dish dish, IFormFile image)
        //{
        //    if (HttpContext.Session.GetString("IsAdmin") != "true")
        //        return RedirectToAction("Index");

        //    if (ModelState.IsValid)
        //    {
        //        // Оновлення страви в базі
        //        _context.Dishes.Update(dish);
        //        _context.SaveChanges();

        //        // Якщо зображення було завантажено, зберігаємо його
        //        if (image != null)
        //        {
        //            var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Img", dish.Category, $"{dish.Id}.png");
        //            using (var stream = new FileStream(imagePath, FileMode.Create))
        //            {
        //                image.CopyTo(stream);
        //            }
        //        }

        //        return RedirectToAction("ManageDishes");
        //    }

        //    return View(dish);
        //}

        [HttpPost]
        public IActionResult EditDish(Dish dish)
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
                return RedirectToAction("Index");

            if (ModelState.IsValid)
            {
                // Отримуємо стару категорію, перш ніж оновити
                var existingDish = _context.Dishes.AsNoTracking().FirstOrDefault(d => d.Id == dish.Id);
                if (existingDish == null)
                    return NotFound();

                string oldCategory = existingDish.Category;

                _context.Dishes.Update(dish);
                _context.SaveChanges();

                // Якщо потрібно — тут можна також обробити зображення або оновити шлях

                return RedirectToAction("ManageDishes");
            }

            // Якщо модель невалідна — повертаємо назад форму з тією ж стравою
            return View(dish);
        }

        [HttpGet]
        public IActionResult DeleteDish(int id)
        {
            var dish = _context.Dishes.Find(id);
            if (dish == null)
                return NotFound();

            _context.Dishes.Remove(dish);
            _context.SaveChanges();

            // Видалити зображення
            var imagePath = Path.Combine("wwwroot", "Img", dish.Category, $"{dish.Id}.png");
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);

            return RedirectToAction("ManageDishes");
        }
        public IActionResult EditDish(int id)
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
                return RedirectToAction("Index");

            var dish = _context.Dishes.FirstOrDefault(d => d.Id == id);
            if (dish == null)
                return NotFound();

            return View(dish);
        }
    }
}