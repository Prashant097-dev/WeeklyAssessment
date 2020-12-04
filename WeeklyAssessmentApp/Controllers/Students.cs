using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeeklyAssessmentApp.Models;

namespace WeeklyAssessmentApp.Controllers
{
    public class Students : Controller
    {
        public IActionResult Display()
        {
            List<Student>  stulist=new List<Student> 
            {
            new Student(){Id=101,Name="Pranjal",DOB=DateTime.Parse("06/06/1998"),Contact=9874563214},
            new Student(){Id=102,Name="Amar",DOB=DateTime.Parse("05/07/1997"),Contact=9746312584},
            new Student(){Id=103,Name="Anita",DOB=DateTime.Parse("04/08/1996"),Contact=8521479635},
            new Student(){Id=104,Name="Prateek",DOB=DateTime.Parse("09/09/1995"),Contact=7531598462},
            new Student(){Id=105,Name="Sharad",DOB=DateTime.Parse("06/08/1997"),Contact=9632587412}
            };
            ViewBag.nos = stulist.Count();

            return View(stulist);
        }
    }
}
