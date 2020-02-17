using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Array.Helpers;
using Array.Models;
using Microsoft.AspNetCore.Mvc;

namespace Array.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lista(FormModel nums, SortHelper sh)
        {
            nums.Mayor = sh.NMayor(nums.Numeros);
            nums.Menor = sh.NMenor(nums.Numeros);
            return View(nums);
        }
    }
}