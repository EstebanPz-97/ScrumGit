using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrumGit.Models
{
        [Table("rol")]
    public class rol
    {
        [Key]
        public int IdRol { get; set; }
        [Required]

        [Display(Name ="nombre de rol")]        
        public string NomnbreRol { get; set; }


        [Display(Name ="Descripcion rol")]
        public string DescripcionRol { get; set; }
    }
}
