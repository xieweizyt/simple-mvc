using Microsoft.AspNetCore.Mvc;
using WebApplication1.Service;
using WebApplication1.Service.Orders;

namespace WebApplication1.Controllers
{
    public class IOCController : Controller
    {
        private IUserService _service;
        private IOrderService _orderService;
        public IOCController(IUserService service, IOrderService orderService)
        {
            _service = service;
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            _service.GetUser();
            _orderService.GetOrders();
            return View();
        }
    }
}
