using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SbongumusaStudyGroup.Models;

namespace SbongumusaStudyGroup.Controllers
{
    public class Group27Controller : Controller
    {
        // GET: Group27
        public ActionResult Index()
        {
            List<Group27> Students = new List<Group27>
            {
                new Group27
                {
                    StudentNumber = "u01234567",
                    Name ="Jane",
                    Surname = "Doe",
                    Email = "jane.doe@tuks.co.za",
                },
                new Group27
                {
                    StudentNumber = "u12345678",
                    Name ="John",
                    Surname = "Doe",
                    Email = "john.doe@tuks.co.za",
                },
                new Group27
                {
                    StudentNumber = "u5237841",
                    Name ="Lindo",
                    Surname = "Nkosi",
                    Email = "lindo.nkosi@tuks.co.za",
                },
                new Group27
                {
                    StudentNumber = "u6785243",
                    Name ="Pearl",
                    Surname = "Mbatha",
                    Email = "pearl.mbatha@tuks.co.za",
                },
                new Group27
                {
                    StudentNumber = "u5972327",
                    Name ="Lungile",
                    Surname = "Masina",
                    Email = "lungile.masina@tuks.co.za",
                }
            };
            return View(Students);
        }
    }
}
;