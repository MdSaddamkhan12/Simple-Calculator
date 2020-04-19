using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new calc());
        }
        [HttpPost]
        public ActionResult Index(calc c,string calculate)
        {
           if(calculate == "add")
            {
                c.Total = c.number_1 + c.number_2;

            }
            else if (calculate == "sub")
            {
                c.Total = c.number_1 - c.number_2;

            }
            else if (calculate == "mul")
            {
                c.Total = c.number_1 * c.number_2;

            }
            else 
            {
                c.Total = c.number_1 / c.number_2;

            }
            return View(c);
        }
    }
}