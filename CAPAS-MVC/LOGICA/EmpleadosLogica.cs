using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class EmpleadosLogica
    {
        private static EmpleadosDAT obj = new EmpleadosDAT();

        public static void Crear(Employees empl)
        {
            obj.Crear(empl);
        }

        public static List<Employees> ListarEmpleados()
        {
            return obj.ListarEmpleados();
        }

        public static Employees DetalleEmpelado(int id)
        {
            return obj.DetalleEmpelado(id);
        }

        public static void EditarEmpleado(Employees empl)
        {
            obj.EditarEmpleado(empl);
        }
        public static void EliminarEmpleado(int id)
        {
            obj.EliminarEmpleado(id);

        }

        public static List<Region> ListarRegion()
        {
            return obj.ListarRegion();
        }

        public static Region GetRegion(string id)
        {
            return obj.getRegion(id);
        }

 

    }
}
