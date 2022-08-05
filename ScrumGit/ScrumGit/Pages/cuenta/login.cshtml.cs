using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;





namespace ScrumGit.Pages.cuenta
{
    public class loginModel : PageModel
    {
        [BindProperty]
        public credencial? credencial { get; set; }


        public void OnGet()
        {
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
