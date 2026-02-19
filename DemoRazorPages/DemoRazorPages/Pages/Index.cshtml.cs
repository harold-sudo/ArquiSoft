using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Nombre { get; set; }
        public string Mensaje { get; set; }

        public string Saludo { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Mensaje = $"Hola Mundo Razor Pages: {DateTime.Now}";
        }

        public void OnPost()
        {
            Saludo = $"Hola {Nombre}";
        }
    }
}
