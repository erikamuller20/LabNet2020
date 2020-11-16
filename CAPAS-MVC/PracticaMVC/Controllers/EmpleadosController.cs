using ENTIDAD;
using LOGICA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PracticaMVC.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult Index()
        {
            var empl = EmpleadosLogica.ListarEmpleados();
            return View(empl);
        }

        public ActionResult CrearEmpleado()
        {
            return View();
        }

        [HttpPost] //el de arriba por defecto es get no hace falta colocarlo
        public ActionResult CrearEmpleado(Employees empl)
        {
            try
            {

                if (empl.FirstName == null)
                    return Json(new { ok = false, msg = "Debe ingresar el nombre del Empleado" }, JsonRequestBehavior.AllowGet);

                System.Threading.Thread.Sleep(1000);

                EmpleadosLogica.Crear(empl);
                return Json(new { ok = true, toRedirect = Url.Action("Index") }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(new { ok = false, msg = "Error al crear el Empleado" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult DetalleEmpleado(int id)
        {
            try
            {
                var empl = EmpleadosLogica.DetalleEmpelado(id);
                return View(empl);

            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Error al Buscar el Empleado");
                return View();
            }
        }

        public ActionResult EditarEmpleado(int id)
        {

            var empl = EmpleadosLogica.DetalleEmpelado(id);
            return View(empl);
        }

        [HttpPost]
        public ActionResult EditarEmpleado(Employees empl)
        {

            try
            {
                System.Threading.Thread.Sleep(1000);

                EmpleadosLogica.EditarEmpleado(empl);
                return Json(new { ok = true, toRedirect = Url.Action("Index") }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(new { ok = false, msg = "Error al Editar el Empleado" }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult EliminarEmpleado(int idEmp)
        {

            try
            {
                System.Threading.Thread.Sleep(1000);

                EmpleadosLogica.EliminarEmpleado(idEmp);
                return Json(new { ok = true, toRedirect = Url.Action("Index") }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(new { ok = false, msg = "Error al Eliminar el Empleado" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult ListarRegion()
        {
            var reg = EmpleadosLogica.ListarRegion();
            return PartialView(reg);
        }

        public static string NombreRegion(string id)
        {
            try
            {
                if (id == null)
                    return "Sin Region";

                return EmpleadosLogica.GetRegion(id).RegionDescription;


            }
            catch (Exception)
            {
                return "Sin Region";
            }
        }
    }
}