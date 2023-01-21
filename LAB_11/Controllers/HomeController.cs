using LAB_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB_11.Controllers
{
    public class HomeController : Controller
    {
        List<Student> students = new List<Student>()
        {
            new Student(){id =1 ,name="Fatima",regno = 205282,age = 23,city = "Kamra",  gpa= 3.5},
            new Student(){id =2 ,name="Mashal",regno = 205276,age = 20,city = "Attock", gpa= 3.0},
            new Student(){id =3 ,name="Sana",regno = 205361,age = 19,city = "Karachi",  gpa= 3.1},
            new Student(){id =4 ,name="Fizza",regno = 205354,age = 21,city = "Qutba", gpa= 3.6},
            new Student(){id =5 ,name="Alizay",regno = 205332,age = 22,city = "Akbar",  gpa= 2.6},
            new Student(){id =6 ,name="Faiza",regno = 205577,age = 25,city = "Wah", gpa= 2.5},
 };

        // GET: Home
        public ActionResult Index()
        {
            return View(students);
        }

        public ActionResult Edit(int id)
        {
            Student stu = new Student();
            stu = students.FirstOrDefault(x => x.id == id);
            return View(stu);
        }

        public ActionResult Delete(int id)
        {
            Student stu = new Student();
            stu = students.Find(x => x.id == id);
            students.Remove(stu);
            return View("Index", students);
        }
        public ActionResult Details(int id)
        {
            Student stu = new Student();
            stu = students.FirstOrDefault(x => x.id == id);
            return View(stu);
        }



    }


}