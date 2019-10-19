using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;
namespace PruebaTecnica.Controllers
{
    public class CubeController : Controller
    {
        // GET: Cube
        public ActionResult Index()
        {
            return View();
        }
           
        [HttpPost]
        public ActionResult Result(string data)
        {
            SumCube sumCube = new SumCube(data);
            sumCube.Summation();
            return View(sumCube);
        }
    }
}