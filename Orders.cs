using Microsoft.AspNetCore.Mvc.RazorPages; // To use PageModel.
using Microsoft.AspNetCore.Mvc; // To use [BindProperty], IActionResult.
using Northwind.EntityModels;

namespace Northwind.Web.Pages;

public class OrdersModel : PageModel
{
   private NorthwindContext _db;
   public OrdersModel(NorthwindContext db)
   {
    _db = db;
   }
   public IEnumerable<Order>? Orders { get; set; }

   [BindProperty]
   public Order? Order { get; set; }

   public void OnGet(int shipperId)
   {
    ViewData["title"] = "Repartidores";
    //Orders = _db.Orders.OrderBy((x) => x.OrderId);
//    Orders = _db.Orders.OrderBy(s => s.ShipVia == id);

    Orders = _db.Orders.Where(s => s.ShipVia == shipperId);
   }
}
