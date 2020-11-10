using System.ComponentModel.DataAnnotations;
namespace FormularioPRG.Models
{
    public class Producto
    {
        [Required]
        [Display(Name="Nombre")]
        public string nombre { get; set; }

        
        [Required]
        [Display(Name="Precio")]
        public double precio { get; set; }

        [Required]
        [Display(Name="Descripción")]
        public string descripcion { get; set; }
    }
}