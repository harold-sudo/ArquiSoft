using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

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
            string connectionString = configuration.GetConnectionString("MySQLConecction")!;
            string query = @"INSERT INTO oficina (nombre,direccion)
                            VALUES(@nombre, @direccion)";

            // Problemas:
            // 1. Complejidad en la codificación -> soporte 
            // 2. Manejo de caracteres especiales
            // 3. inyeccion sql
            // uso de parametros
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", Nombre);
                command.Parameters.AddWithValue("@direccion", Direccion);
                connection.Open();
                command.ExecuteNonQuery();
            }

            return RedirectToPage("Oficina");
        }
    }
}

// En equipos:
// Eliminación con soft delete
// Edición