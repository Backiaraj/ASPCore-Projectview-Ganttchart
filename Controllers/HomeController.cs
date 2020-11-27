using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPCoreGanttDemo.Models;
using Syncfusion.EJ2.Gantt;

namespace ASPCoreGanttDemo.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            ViewBag.DataSource = GanttData.SelfData();
            ViewBag.projectResources = GanttData.GetResources();
            return View();
        }        
    }
}
