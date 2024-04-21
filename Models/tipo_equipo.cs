using System.ComponentModel.DataAnnotations;

namespace Practica_Razor_Html_Helper.Models
{
    public class tipo_equipo
    {
        [Key]

        [Display(Name = "Tipo Equipo")]
        public int id_tipo_equipo { get; set; }

        [Display(Name = "Descripcion")]
        public string? descripcion { get; set; }

        [Display(Name = "Estado")]
        public string? estado { get; set; }

    }
}
