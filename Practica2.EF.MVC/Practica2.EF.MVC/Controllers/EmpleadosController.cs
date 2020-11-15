using Practica2.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica2.EF.MVC.Controllers
{
    public class EmpleadosController : Controller
    {
        public ActionResult Index()
        {

            NorthwindEntities db = new NorthwindEntities();

            return View(db.Employees.ToList());
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Agregar(Employees e)
        {

            if (!ModelState.IsValid)
                return View();

            try
            {
                using (var db = new NorthwindEntities())
                {

                    db.Employees.Add(e);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }

            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Error al agregar el Empleado");
                return View();
            }

        }

        public ActionResult ListaRegion()
        {

            NorthwindEntities db = new NorthwindEntities();

            return PartialView(db.Region.ToList());
        }

        //[HttpGet] no es necesario colocar el get
        public ActionResult Editar(int id)
        {
            try
            {
                using (var db = new NorthwindEntities())
                {
                    Employees empl = db.Employees.Find(id);
                    return View(empl);
                }
                   
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Error al Editar el Empleado");
                return View();
            }
        }
        
        //>>>>>>>>>>>Buscar que significa en el video esto: (y tambien el actionresult)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Employees e)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();

                using (var db = new NorthwindEntities())
                {
                    Employees emp = db.Employees.Find(e.EmployeeID);
                    emp.LastName  = e.LastName;
                    emp.FirstName = e.FirstName;
                    emp.BirthDate = e.BirthDate;
                    emp.HireDate  = e.HireDate;
                    emp.Region    = e.Region;

                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Error al Editar el Empleado");
                return View();
            }
            
        }

        public ActionResult DetallesEmpleados(int id)
        {
            try
            {
                using (var db = new NorthwindEntities())
                {
                    Employees empl = db.Employees.Find(id);
                    return View(empl);
                }

            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Error al Editar el Empleado");
                return View();
            }
        }

        public ActionResult EliminarEmpleado(int id)
        {
            try
            {
                using (var db = new NorthwindEntities())
                {
                    Employees empl = db.Employees.Find(id);
                    db.Employees.Remove(empl);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }

            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Error al Editar el Empleado");
                return View();
            }
        }

        public static string NombreRegion(string id)
        {
            try
            {
                using (var db = new NorthwindEntities())
                {
                    int i;
                    i = Convert.ToInt32(id);
                    if (i == 0)
                        return "Sin Region";


                    return db.Region.Find(i).RegionDescription;

                }
            }
            catch (Exception)
            {

                return "Sin Region";
            }

        }
    }
}