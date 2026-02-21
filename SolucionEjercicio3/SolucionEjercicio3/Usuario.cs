using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEjercicio3
{
    // -----------------------------------------------------------------------------
    // NOTA: El uso de #region es para fines didácticos y de organización.
    // No es obligatorio utilizarlo en las evaluaciones    
    // -----------------------------------------------------------------------------
    internal class Usuario
    {
        #region Atributos
        private string ci;
        private string primerApellido;
        private string segundoApellido;
        private string nombres;
        private string correoElectronico;
        private string rol;
        private string nombreUsuario;
        private string contrasenia;
        #endregion

        #region Propiedades
        public string Ci
        {
            get { return ci; }
            set { ci = value; }
        }        
        public string PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }
        public string SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }        
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }  
        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        // -----------------------------------------------------------------------------        
        //NOTA: La siguiente propiedad es para mostrar el Nombre Completo si se requiriera 
        //hacerlo desde la clase. Lo hago por la aclaración que mencioné en clases
        //de que debería manejarse de manera atómica dicho atributo.
        //También nos servirá como parámetro para la validación requerida
        // -----------------------------------------------------------------------------        
        public string NombreCompleto
        {
            get { return Nombres + " "+PrimerApellido+" "+SegundoApellido; }
            
        }


        #endregion

        #region Constructores
        public Usuario()
        {
        }

        public Usuario(string ci, string primerApellido, string segundoApellido, string nombres, string correoElectronico, string rol, string nombreUsuario, string contrasenia)
        {
            Ci = ci;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Nombres = nombres;
            CorreoElectronico = correoElectronico;
            Rol = rol;
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
        }

        #endregion

        #region Métodos
        //NOTA: Aplicamos este polimorfismo porque no es apropiado
        //formatear los datos en los setters (set) ya que ello podría
        //no ser aplicable en escenarios diferentes
        public virtual string ObtenerDatosCompletos()
        {
            return $"CI: {Ci.Trim()} Nombre Completo: {NombreCompleto.Trim()} Correo: {CorreoElectronico.Trim()} Rol: {Rol} Nombre de Usuario: {NombreUsuario} Contraseña: {Contrasenia}";
        }

        #endregion

    }
}
