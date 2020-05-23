using AspNetCoreDependencyInjection.Configs;
using AspNetCoreDependencyInjection.Helpers;
using AspNetCoreDependencyInjection.Models;
using AspNetCoreDependencyInjection.Services;
using AspNetCoreDependencyInjection.ServicesImplentaions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace AspNetCoreDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMessageServiceA _messageService;

        private readonly GuidProvider _guidHelper;

        public HomeController(ILogger<HomeController> logger,
            IMessageServiceA messageService,
            LiteDbConfig liteDbConfig,
            GuidProvider guidHelper)
        {
            _logger = logger;
            _messageService = messageService;
            _messageService = new MessageServiceAA();
            _guidHelper = guidHelper;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel()
            {
                Id = _guidHelper.GetGuidAsFormatedString(),
                Message = _messageService.Message(),
                DateTime = DateTime.Now,
            };

            return View(model);
        }

        public IActionResult ContactMe()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}