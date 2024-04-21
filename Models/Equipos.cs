using System.ComponentModel.DataAnnotations;

namespace Practica_Razor_Html_Helper.Models
{
    public class Equipos
    {



        [Key]

        [Display(Name = "Id Equipo")]
        public int id_equipos { get; set; }

        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Display(Name = "Descripcion de la marca")]
        public string? descripcion { get; set; }

        [Display(Name = "Id Equipo")]
        public int tipo_equipo_id { get; set; }

        [Display(Name = "Id de la marca")]
        public int marca_id { get; set; }

        [Display(Name = "Modelo")]
        public string? modelo { get; set; }

        [Display(Name = "Anio Compra")]
        public int anio_compra { get; set; }

        [Display(Name = "Costo")]
        public double costo { get; set; }


        [Display(Name = "Descripcion de la marca")]
        public int vida_util { get; set; }

        [Display(Name = "Estado Equipo Id")]
        public int estado_equipo_id { get; set; }

        [Display(Name = "Estado")]
        public string? estado { get; set; }

        











    }
}
