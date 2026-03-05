using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using System.Data.SqlTypes
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data; //ADO.NET

namespace CRUD.Pages
{
    public class OficinaModel : PageModel
    {
        public DataTable OficinaDataTable { get; set; } = new DataTable();
        private readonly IConfiguration configuration;

        public OficinaModel(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void OnGet()
        {
            Select();
        }

        void Select()
        {
            //string connectionString = configuration.GetConnectionString("MySQLConecction")!;
            string connectionString = configuration.GetConnectionString("MySQLConecction");
            string query = @"SELECT id, nombre, direccion, fechaRegistro
                FROM oficina
                WHERE estado=1
                ORDER BY 2";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                //command.CommandText = query;
                //command.Connection = connection;

                // Se ejecuta la consulta SQL del comando y los datos se transfieren al objeto adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(OficinaDataTable);
                connection.Close();
            }
        }
    }
}
