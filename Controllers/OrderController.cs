using Microsoft.AspNetCore.Mvc;
using Sushimi.Data;
using Sushimi.Models;

public class OrderController : Controller
{
	private readonly CartService _cartService;
	private readonly ApplicationDbContext _context;

	public OrderController(CartService cartService, ApplicationDbContext context)
	{
		_cartService = cartService;
		_context = context;
	}

	public IActionResult Checkout()
	{
		var cart = _cartService.GetCart();
		return View(cart);
	}

	[HttpPost]
	public IActionResult ConfirmOrder(string address, string phoneNumber, string costumername)
	{
        var cart = _cartService.GetCart();
        if (cart.Count == 0) return RedirectToAction("Index", "Sushi");

        // Створення нового замовлення
        var order = new Order
        {
            OrderDate = DateTime.Now,
            Address = address,
            CustomerName = costumername,
            PhoneNumber = phoneNumber,
            //TotalPrice = cart.Sum(i => i.Price * i.Quantity),
            OrderItems = cart.Select(i => new OrderItem
            {
                DishId = i.DishId,
                DishName = i.Name,
                Quantity = i.Quantity,
                Price = i.Price
            }).ToList()
        };

        // Додавання замовлення в базу
        _context.Orders.Add(order);
        _context.SaveChanges();

        // Очищення кошика
        _cartService.ClearCart();

        return RedirectToAction("OrderSuccess");
    }

	public IActionResult OrderSuccess()
	{
		return View();
	}
}