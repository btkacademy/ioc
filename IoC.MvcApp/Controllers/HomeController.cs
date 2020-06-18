using IoC.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IoC.MvcApp.Controllers
{
    public class HomeController : Controller
    {
        IXService _xService;
        IGenericService<string> _genericService;
        public HomeController(IXService xService, IGenericService<string> genericService)
        {
            _xService = xService;
            _genericService = genericService;
        }
        // GET: Home
        public ActionResult Index()
        {
            _xService.Method1();
            _genericService.GenericMethod("123");
            return View();
        }
    }
}