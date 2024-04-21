using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using Practica_Razor_Html_Helper.Models;

namespace Practica_Razor_Html_Helper.Controllers
{
    public class EquiposController : Controller
    {

        private readonly equiposDbContext _equiposDbContext;

        public EquiposController (equiposDbContext equiposDbContext)
        {
            _equiposDbContext = equiposDbContext;
        }





        public IActionResult Index()
        {
            //Aqui se obtienen los datos de marcas de la base para mostrarlo en el dropdown
            var listaDeMarcas = (from m in _equiposDbContext.Marcas
                                 select m).ToList();
            ViewData["listadoDeMarcas"] = new SelectList(listaDeMarcas, "id_marcas", "nombre_marca");

            //Aqui se obtienen los datos de Tipo de Equipo de la base para mostrarlo en el dropdown
            var listaDeTipoEquipo = (from m in _equiposDbContext.tipo_equipo
                                     select m).ToList();
            ViewData["listadoDetipo_equipo"] = new SelectList(listaDeTipoEquipo, "id_tipo_eq", "descripcion");

            //Aqui se obtienen los datos de Tipo de Equipo de la base para mostrarlo en el dropdown
            var listaDeEstadoEquipo = (from m in _equiposDbContext.estados_equipo
                                       select m).ToList();
            ViewData["listadoDeestado_equipo"] = new SelectList(listaDeEstadoEquipo, "id_estados_equipo", "estado");

            //Aqui se obtienen los datos de toda la tabla equipos
            var listadoDeEquipos = (from e in _equiposDbContext.Equipos
                                    join m in _equiposDbContext.Marcas on e.marca_id equals m.id_marcas
                                    select new
                                    {
                                        nombre = e.nombre,
                                        descripcion = e.descripcion,
                                        marca_id = e.marca_id,
                                        marca_nombre = m.nombre_marca
                                    }).ToList();
            ViewData["listadoEquipo"] = listadoDeEquipos;

            return View();
        }


        public IActionResult CrearEquipos(Equipos nuevoEquipo)
        {
            _equiposDbContext.Add(nuevoEquipo);
            _equiposDbContext.SaveChanges();

            return RedirectToAction("Index");
        }


    }




    }

