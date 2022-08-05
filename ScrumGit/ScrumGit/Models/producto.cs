using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrumGit.Models
{
    [Table("producto")]
    public class producto
    {
        [Key]
        public int Idproducto { get; set; }
        [Required]
        
        [Display(Name="Nombre producto")]
        public string Nombre { get; set; }

        [Display(Name ="Descripcion")]
        public string Descripcion { get; set; }

        [Display(Name ="Precio")]
        public float Precio { get; set; }


        [Display(Name = "Imagen")]
        public string ImagenProducto { get; set; }

        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Display(Name = "Serial")]
        public string Serial { get; set; }

        [NotMapped]
        [Display(Name = "Imagen")]
        public IFormFile ImagenFile { get; set; }


    }
}
