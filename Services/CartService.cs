using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Sushimi.Models;

public class CartService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private const string CartSessionKey = "Cart";

    public CartService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public List<CartItem> GetCart()
    {
        var session = _httpContextAccessor.HttpContext.Session;
        var cartJson = session.GetString(CartSessionKey);
        return cartJson != null ? JsonConvert.DeserializeObject<List<CartItem>>(cartJson) : new List<CartItem>();
    }

    public void AddToCart(CartItem item)
    {
        var cart = GetCart();
        var existingItem = cart.FirstOrDefault(x => x.DishId == item.DishId);

        if (existingItem != null)
        {
            existingItem.Quantity++;
        }
        else
        {
            cart.Add(item);
        }

        SaveCart(cart);
    }

    public void RemoveFromCart(int dishId)
    {
        var cart = GetCart();
        var item = cart.FirstOrDefault(x => x.DishId == dishId);

        if (item != null)
        {
            cart.Remove(item);
            SaveCart(cart);
        }
    }

    public void ClearCart()
    {
        SaveCart(new List<CartItem>());
    }

    private void SaveCart(List<CartItem> cart)
    {
        var session = _httpContextAccessor.HttpContext.Session;
        session.SetString(CartSessionKey, JsonConvert.SerializeObject(cart));
    }
}