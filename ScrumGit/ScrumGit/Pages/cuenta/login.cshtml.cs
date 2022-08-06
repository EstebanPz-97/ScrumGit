using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ScrumGit.Models;
using Microsoft.EntityFrameworkCore;
using ScrumGit.Datos;





namespace ScrumGit.Pages.cuenta
{
    public class loginModel : PageModel
    {
        [BindProperty]
        public credencial? credencial { get; set; }

        public usuario? usuario { get; set; }


        public void OnGet()
        {
        }

        private readonly ApplicationDbContext _contexto;

        public loginModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> OnPost()
        {
           usuario = _contexto.usuario.FromSqlRaw("select * from usuario where correo={0} and password={1}",credencial.usuario,credencial.password).FirstOrDefault();

            if (usuario != null && usuario.Idusuario != 0)
            {
                return RedirectToPage("/Admin/inicioAdmin");
            }else {
                return RedirectToPage("/cuenta/login");
            }
        }


    }

    public class credencial
    {
        [Required]
        public string? usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? password { get; set; }
    }

}
