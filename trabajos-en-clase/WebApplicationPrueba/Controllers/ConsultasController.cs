using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationPrueba.Data;
using WebApplicationPrueba.Entities;

namespace WebApplicationPrueba.Controllers
{
    public class ConsultasController : Controller
    {
        readonly ApplicationDbContext _context;
        public ConsultasController(ApplicationDbContext applicarionDbContext)
        {
            _context = applicarionDbContext;
        }
        [Authorize]
        public IEnumerable<Departamento> Departamentos()
        {
            return _context.Departamentos;
        }
        public IEnumerable<Empleado> Empleados()
        {
            //metodos diferidos
            //return _context.Empleados.OrderBy(e => e.Apellido);//ordenar acendente
            //return _context.Empleados.OrderByDescending(e => e.Apellido);//ordenar decendente
            //return _context.Empleados.OrderBy(e => e.Nombre).ThenBy(e => e.Apellido);

            //var consulta = _context.Empleados; //IQueareable
            //var empleados = consulta.ToList(); //List<Empleado>

            IOrderedQueryable<Empleado> consulta = _context.Empleados.OrderBy(x => x.Nombre); //IQueareable
            List<Empleado> empleados = consulta.ToList(); //List<Empleado>
            var Sebas = empleados.Where(x => x.Nombre == "Sebastian");
            var menor = empleados[0].Salario;
            foreach (var item in empleados)//procedimental
            {
                if (item.Salario < menor)
                {
                    menor = item.Salario;
                }
            }
            var menorRapido = empleados.Min(e => e.Salario);//no procedimental
            var mayor = empleados.Min(e => e.Nacimiento);



            return empleados.OrderBy(e => e.NombreCompleto);
        }
        public IEnumerable<Empleado> EmpleadosPaginados(int pagina, int registrosPagina)
        {
            var salto = (pagina - 1) * registrosPagina;
            return _context.Empleados.Skip(salto).Take(registrosPagina);
        }
        ////public IEnumerable<Curso> Cursos()
        //{
        //    IOrderedQueryable<Curso> consulta = _context.Cursos.OrderBy(x => x.NumeroCreditos);
        //    List<Curso> cursos = consulta.ToList();
        //    var creditoAlto = cursos[0].NumeroCreditos;
        //    foreach (var item in cursos)
        //    {
        //        if (item.NumeroCreditos < creditoAlto)
        //        {
        //            creditoAlto = item.NumeroCreditos;
        //        }
        //    }
        //    //IQueryable<Curso> curso = (IQueryable<Curso>)(from c in _context.Cursos
        //    //    select c.NumeroCreditos);

        //    return cursos.OrderBy(x => x.NumeroCreditos);
        //}
        public object Emjemplo1()
        {
            System.DateTime fechaConsulta = new System.DateTime(1999, 1, 1);

            var consulta = from e in _context.Empleados
                           where e.Nacimiento > fechaConsulta
                           select e;

            var consulta2 = _context.Empleados
                .Where(e => e.Nacimiento > fechaConsulta)
                .Select(e => e);


            //return consulta.ToArray();
            //return consulta2.ToLIst();
            return null;
        }
        public object Emjemplo2()
        {
            var anonimo = new
            {
                Saludo = "Hola Mundo",
                Estado = "Me encuentro muy bien"
            };
            var consulta = from e in _context.Empleados
                           join d in _context.Departamentos
                           on e.DepartamentoID equals d.DepartamentoId
                           select new {
                               NombreCompleto = $"{e.Nombre} {e.Apellido}",
                               Departamento = d.Nombre
                           };
            var consulta1 = _context.Empleados
               .Include(e => e.Departamento)
               .Select(e => new {
                   NombreCompleto = $"{e.Nombre} {e.Apellido}",
                   Departamento = e.Departamento.Nombre
               });

            var consulta2= _context.Empleados
               .Include(e => e.Departamento)
               .Select(e => new {
                   Name =e.Nombre,
                   Department = e.Departamento.DepartamentoId
               });


            return null;
        }
        public void Emjemplo3()
        {
            using ApplicationDbContext mainContext = new ApplicationDbContext();
            {
                mainContext.Empleados
               .Include(e => e.Departamento)
               .Select(e => new
               {
                   NombreCompleto = $"{e.Nombre} {e.Apellido}",
                   Departamento = e.Departamento.Nombre
               });
            }
        }

    }
}


























































//IOrderedQueryable<Empleado> consulta = _context.Empleados.OrderBy(x => x.EmpleadoId);
//IOrderedQueryable<Conyuge> consulta2 = _context.Conyuges.OrderBy(y => y.EmpleadoId);
//List<Conyuge> conyuges = consulta2.ToList();
//List<Empleado> empleados = consulta.ToList();
//if(consulta == consulta2)
//    var conyugueEmpleado
//    return

//IOrderedQueryable<Empleado> consulta = _context.Empleados.OrderBy(x => x.NombreCompleto);
//List<Empleado> empleados = consulta.ToList();
//IEnumerable<Empleado> empleado = from empleadoid in
//                                 where EmpleadoId !== '0'
//                                 select empleadoid;
//IOrderedQueryable<Conyuge> consulta2 = _context.Conyuges.OrderBy(x => x.NombreCompleto);
//List<Conyuge> conyuges = consulta2.ToList();
//foreach (var i in conyuges)
//{
//    var conyugesEmpleados
//}












