using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using asp_net_core_mvc_mysql_dashboard.Models;
using Newtonsoft.Json;

namespace asp_net_core_mvc_mysql_dashboard.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            SalesDBContext context = HttpContext.RequestServices.GetService(typeof(SalesDBContext)) as SalesDBContext;
            ViewData["Title"] = "Anychart ASP.NET Core C# dashboard";
            ViewData["ChartTitle"] = "Top 5 sales";
            ViewData["ChartData"] = JsonConvert.SerializeObject(context.GetTopSales());
            return View(context.GetTopSales());
        }
    }
}
