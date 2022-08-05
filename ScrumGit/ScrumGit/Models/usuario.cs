using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrumGit.Models
{
    [Table("usuario")]
    public class usuario
    {
        [Key]
        public int Idusuario { get; set; }
        [Required]

        [Display(Name ="Primer nombre")]
        public string Nombre1 { get; set; }

        [Display(Name = "segundo nombre")]
        public string Nombre2 { get; set; }

        [Display(Name = "Primer apellido")]
        public string apellido1 { get; set; }

        [Display(Name = "Segundo apellido")]
        public string apellido2 { get; set; }

        [Display(Name = "Telefono")]
        public int Telefono { get; set; }

        [Display(Name = "Correo")]
        public string correo { get; set; }

        [Display(Name = "contraseña")]
        public string password { get; set; }

        [Display(Name = "rol")]
        public int IdRol { get; set; }

        public virtual rol rol { get; set; }


    }
}
