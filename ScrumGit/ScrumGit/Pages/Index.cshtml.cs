using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScrumGit.Datos;
using ScrumGit.Models;

namespace ScrumGit.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        
        private readonly ApplicationDbContext _contexto;

        public IndexModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        public IEnumerable<producto> productos { get; set; }

        public async Task OnGet()
        {
            productos = await _contexto.producto.ToListAsync();
        }
      

    }
}