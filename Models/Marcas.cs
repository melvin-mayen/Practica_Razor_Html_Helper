using System.ComponentModel.DataAnnotations;

namespace Practica_Razor_Html_Helper.Models
{
    public class Marcas
    {

        [Key]

        [Display(Name = "ID")]
        public int id_marcas { get; set; }

        [Display(Name = "Nombre de la marca")]
        public string? nombre_marca { get; set; }

        [Display(Name = "Estado")]
        public string? estados { get; set; }




    }
}
