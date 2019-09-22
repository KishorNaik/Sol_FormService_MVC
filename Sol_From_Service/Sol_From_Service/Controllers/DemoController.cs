using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_From_Service.Core.Context;
using Sol_From_Service.Models;

namespace Sol_From_Service.Controllers
{
    public class DemoController : Controller
    {

        public async Task<IActionResult> Index([FromServices] IUserContext userContext)
        {
            var data = await userContext.AddUserAsync();

            base.ViewBag.Data = data;
            return View();
        }

        public IActionResult DemoTest(){
            
        }
    }


}
