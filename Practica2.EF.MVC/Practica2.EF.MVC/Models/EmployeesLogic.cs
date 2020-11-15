using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica2.EF.MVC.Models
{
    public class EmployeesLogic
    {
        public int EmployeeID { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Nombres")]
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        [Required]
        [Display(Name = "Fecha Nacimiento")]
        public Nullable<System.DateTime> BirthDate { get; set; }
        [Required]
        [Display(Name = "Fecha Ingreso")]
        public Nullable<System.DateTime> HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
    }

    [MetadataType(typeof(EmployeesLogic))]

    public partial class Employees
    {
        public string NombreCompleto { get { return FirstName + " " + LastName; } }
    }

}