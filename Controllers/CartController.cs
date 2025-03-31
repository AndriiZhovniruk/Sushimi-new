using Microsoft.AspNetCore.Mvc;
using Sushimi.Data;
using Sushimi.Models;

public class CartController : Controller
{
    private readonly CartService _cartService;
    private readonly ApplicationDbContext _context;

    public CartController(CartService cartService, ApplicationDbContext context)
    {
        _cartService = cartService;
        _context = context;
    }

    public IActionResult Index()
    {
        var cart = _cartService.GetCart();
        return View(cart);
    }

    public IActionResult AddToCart(int id)
    {
        var dish = _context.Dishes.FirstOrDefault(d => d.Id == id);
        if (dish != null)
        {
            _cartService.AddToCart(new CartItem
            {
                DishId = dish.Id,
                Name = dish.Name,
                Quantity = 1,
                Price = dish.Price
            });
        }

        return RedirectToAction("Index", dish.Category);
    }

    public IActionResult RemoveFromCart(int id)
    {
        _cartService.RemoveFromCart(id);
        return RedirectToAction("Index");
    }

    public IActionResult ClearCart()
    {
        _cartService.ClearCart();
        return RedirectToAction("Index");
    }
    public IActionResult GetCartItems()
    {
        var cart = _cartService.GetCart();
        return Json(cart);
    }

    public IActionResult GetCartPartial()
    {
        var cart = _cartService.GetCart();
        return PartialView("_CartPartial", cart);
    }
}
