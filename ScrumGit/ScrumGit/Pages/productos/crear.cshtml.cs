using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ScrumGit.Datos;
using ScrumGit.Models;

namespace ScrumGit.Pages.productos
{
    public class crearModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _hostEnvironment;
        public crearModel(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }
        [BindProperty]

        public producto producto { get; set; }


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            string filename = @"";
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string result = Path.GetFileNameWithoutExtension(filename);
            string extension = Path.GetExtension(producto.ImagenFile.FileName);
            producto.ImagenProducto = filename = filename + DateTime.Now.ToString("yymmssff") + extension;
            string path = Path.Combine(wwwRootPath + "/img/", filename);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await producto.ImagenFile.CopyToAsync(fileStream);
            }
            _context.Add(producto);
            await _context.SaveChangesAsync();
            return RedirectToPage("/index");


        }
    }
}
