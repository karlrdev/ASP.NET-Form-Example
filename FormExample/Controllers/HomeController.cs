using FormExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace FormExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new LoginViewModel { EducationList = GetList(), UserEducation = new List<Education>
            {
                new Education()
            } });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private List<SelectListItem> GetList()
        {
            return new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "Art",
                    Value = "0"
                },
                new SelectListItem
                {
                    Text = "Music",
                    Value = "1"
                },
                new SelectListItem
                {
                    Text = "English",
                    Value = "2"
                },
                new SelectListItem
                {
                    Text = "Math",
                    Value = "3"
                }
            };
        }

        public IActionResult GetNewRow(int index)
        {
            var list = new List<Education>();

            for (int i = 0; i < index + 1; i++)
            {
                list.Add(new Education());
            }


            return PartialView("~/Views/Shared/dataRow.cshtml", new AddRowViewModel()
            {
                EducationList = GetList(),
                UserEducation = list,
                Index = index
            });
        }

        public IActionResult FormSubmit(LoginViewModel model)
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