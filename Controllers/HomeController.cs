using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork15.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string SourceCurrency,string DestinationCurrency,double Amount)
        {
            double Result = 0;
            if (SourceCurrency.Equals("usd") && DestinationCurrency.Equals("usd"))
                Result = Amount;
            else if (SourceCurrency.Equals("usd") && DestinationCurrency.Equals("mmk"))
                Result = Amount * 2000;
            else if (SourceCurrency.Equals("usd") && DestinationCurrency.Equals("sgd"))
                Result = Amount * 1.3268;
            else if (SourceCurrency.Equals("sgd") && DestinationCurrency.Equals("sgd"))
                Result = Amount;
            else if (SourceCurrency.Equals("sgd") && DestinationCurrency.Equals("usd"))
                Result = Amount / 1.3268;
            else if (SourceCurrency.Equals("sgd") && DestinationCurrency.Equals("mmk"))
                Result = Amount *1586;
            else if (SourceCurrency.Equals("mmk") && DestinationCurrency.Equals("mmk"))
                Result = Amount;
            else if (SourceCurrency.Equals("mmk") && DestinationCurrency.Equals("usd"))
                Result = Amount / 2000;
            else if (SourceCurrency.Equals("mmk") && DestinationCurrency.Equals("sgd"))
                Result = Amount * 1586;
            ViewBag.FinalResult = Result;
            return View();
        }
    }
}
