using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationPrueba.Entities
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nombre { get; set; }
        public int NumeroCreditos { get; set; }
        public List<Curso> Cursos { get; set; }
    }
}













//public List<CursoEmpleado> CursosEmpleados { get; set; }


//public class CursoEmpleado
//{
//    public int CursoEmpleadoID { get; set; }

//    [ForeignKey("Curso")]
//    public int CursoId { get; set; }
//    public Curso Curso { get; set; }

//    [ForeignKey("Empleado")]
//    public int EmpleadoId { get; set; }
//    public Empleado Empleado { get; set; }

//}

