using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD.Pages
{
    public class OficinaSucursalCreateModel : PageModel
    {
        private readonly IConfiguration configuration;
        [BindProperty]
        public string Nombre { get; set; }

        [BindProperty]
        public string Direccion { get; set; }

        public OficinaSucursalCreateModel(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void OnGet()
        {
           
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("Oficina");
            string connectionString = configuration.GetConnectionString("MySQLConecction");
            string query = @"";
        }
    }
}
