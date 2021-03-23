using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.Web.StringInfo;

namespace YSKProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class GrafikController : Controller
    {
        /* 
        En çok görev tamamlamış 5 personel.
        En çok görev almış 5 personel. (Alp- 2 görevde çalışıyor)
        
            Group by.
        */

        private readonly IAppUserService _appUserService;
        public GrafikController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            TempData["Active"] = TempdataInfo.Grafik;
            return View();
        }

        public IActionResult EnCokTamamlayan()
        {
            var jsonString= JsonConvert.SerializeObject(_appUserService.GetirEnCokGorevTamamlamisPersoneller());
            return Json(jsonString);
        }


        public IActionResult EnCokCalisan()
        {
            var jsonString = JsonConvert.SerializeObject(_appUserService.GetirEnCokGorevdeCalisanPersoneller());
            return Json(jsonString);
        }


    }
}