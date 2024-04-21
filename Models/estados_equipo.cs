using System.ComponentModel.DataAnnotations;

namespace Practica_Razor_Html_Helper.Models
{
    public class estados_equipo
    {

        [Key]


        [Display(Name = "Estados Equipo")]
        public int id_estados_equipo { get; set; }

        [Display(Name = "Descripcion de la marca")]
        public string? descripcion { get; set; }

        [Display(Name = "Estado")]
        public string? estado { get; set; }



    }
}
