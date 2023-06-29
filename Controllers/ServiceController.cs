using LifetimeServices.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;

namespace LifetimeServices.Controllers
{
    public class ServiceController : Controller
    {
        ILogger<ServiceController> _logger;
        ITransient _transientService1;
        ITransient _transientService2;

        IScoped _scopedService1;
        IScoped _scopedService2;

        ISingleton _singletonService1;
        ISingleton _singletonService2;
        public ServiceController(ILogger<ServiceController> logger, ITransient transientService1, ITransient transientService2, IScoped scopedService1,IScoped scopedService2, ISingleton singletonService1, ISingleton singletonService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;

            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;



            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;

            _logger = logger;
        }
        public IActionResult Index()
        {

            ViewBag.message1 = "First Instance " + _transientService1.GetID().ToString();
            ViewBag.message2 = "Second Instance " + _transientService2.GetID().ToString();

            ViewBag.message3 = "First Instance " + _scopedService1.GetID().ToString();
            ViewBag.message4 = "Second Instance " + _scopedService2.GetID().ToString();



            ViewBag.message5 = "First Instance " + _singletonService1.GetID().ToString();
            ViewBag.message6 = "Second Instance " + _singletonService2.GetID().ToString();

            return View();
        }
    }
}
