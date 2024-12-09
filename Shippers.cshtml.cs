using Microsoft.AspNetCore.Mvc.RazorPages; // To use PageModel.
using Microsoft.AspNetCore.Mvc; // To use [BindProperty], IActionResult.
using Northwind.EntityModels;

namespace Northwind.Web.Pages;

public class ShippersModel : PageModel
{
   private NorthwindContext _db;
   public ShippersModel(NorthwindContext db)
   {
    _db = db;
   }
   public IEnumerable<Shipper>? Shippers { get; set; }

   [BindProperty]
   public Shipper? Shipper { get; set; }

   public void OnGet()
   {
    ViewData["title"] = "Repartidores";
    Shippers = _db.Shippers.OrderBy((x) => x.ShipperId);
   }
}
