using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEjercicio3
{
    // -----------------------------------------------------------------------------
    // NOTA: Se crea esta clase por el principio de Responsabilidad Unica
    // La clase Usuario representa los datos mientras que ValidacionesUsuario se encarga de validarlos
    // Vi en clases validar en los setters (set de las propiedades) lanzando excepciones
    // ello ya mezcla responsabilidades y es dificil de re-utilizar en diferentes escenarios 
    // Los métodos creados son estáticos porque no se considera necesario crear un objeto para aplicar un método de validación
    // -----------------------------------------------------------------------------
    internal class ValidacionesUsuario
    {
        // Pasaríamos como parámetro la Propiedad NombreCompleto creada en la clase Usuario
        //TODO: Se debe optimizar el método con expresiones regulares
        public static bool EsNombreCompletoValido(string nombreCompleto)
        {
            for (int i = 0; i < nombreCompleto.Length; i++)
            {
                if (!Char.IsLetter(nombreCompleto[i]) && nombreCompleto[i]!=' ')
                {
                    return false;
                }
            }
            return nombreCompleto.Length >= 2;
        }
                
        public static bool EsCorreoElectronicoValido(string correoElectronico)
        {
            return correoElectronico.Contains("@") && correoElectronico.Contains(".");
        }
        public static bool EsContrasenaValida(string contrasena)
        {           
            return contrasena.Length >= 8;
        }
    }
}
