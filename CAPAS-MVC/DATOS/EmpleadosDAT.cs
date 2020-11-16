using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class EmpleadosDAT
    {
        public void Crear(Employees empl)
        {
            using (var db =  new NorthwindContext())
            {
                db.Employees.Add(empl);
                db.SaveChanges();
            }
        }

        public List<Employees> ListarEmpleados()
        {
            using (var db = new NorthwindContext())
            {
                return db.Employees.ToList();
            }
        }

        public Employees DetalleEmpelado(int id)
        {
            using (var db = new NorthwindContext())
            {
                return db.Employees.Find(id);
            }
        }

        public void EditarEmpleado(Employees empl)
        {
            using (var db = new NorthwindContext())
            {
                var e = db.Employees.Find(empl.EmployeeID);
                e.LastName = empl.LastName;
                e.FirstName = empl.FirstName;
                e.Title = empl.Title;
                e.TitleOfCourtesy = empl.TitleOfCourtesy;
                e.BirthDate = empl.BirthDate;
                e.HireDate =  empl.HireDate;
                e.Address = empl.Address;
                e.City = empl.City;
                e.Region = empl.Region;

                db.SaveChanges();
            }
        }

        public void EliminarEmpleado(int id)
        {
            using (var db = new NorthwindContext())
            {
                var empl = db.Employees.Find(id);
                db.Employees.Remove(empl);
                db.SaveChanges();
            }
        }

        public List<Region> ListarRegion()
        {
            using (var db = new NorthwindContext())
            {
                return db.Region.ToList();
            }
        }


        public Region getRegion(string id)
        {
            using (var db = new NorthwindContext())
            {

                int i;
                i = Convert.ToInt32(id);
                return db.Region.Where(r => r.RegionID == i).FirstOrDefault();
            }
        }
    }
}
