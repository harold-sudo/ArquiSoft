using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SolucionEjercicio3
{
    internal class Docente:Usuario
    {
        #region Atributos
        private string especialidad;
        private bool tienePosgradoEducacionSuperior;
        #endregion

        #region Propiedades
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }       
        public bool TienePosgradoEducacionSuperior
        {
            get { return tienePosgradoEducacionSuperior; }
            set { tienePosgradoEducacionSuperior = value; }
        }
        #endregion

        #region Constructores
        public Docente()
        {

        }        
        public Docente(string ci, string primerApellido, string segundoApellido, string nombres, string correoElectronico, string rol, string nombreUsuario, string contrasenia, string especialidad, bool tienePosgradoEducacionSuperior)
            :base(ci, primerApellido, segundoApellido, nombres, correoElectronico, rol, nombreUsuario, contrasenia)
        {
            Especialidad = especialidad;
            TienePosgradoEducacionSuperior=tienePosgradoEducacionSuperior;
        }
        #endregion

        #region Métodos
        //NOTA: Para la propiedad TienePosgradoEducacionSuperior no es correcto
        //desplegar True o False (no aplica en escenarios reales)
        //Por ello mostramos Si o No
        public override string ObtenerDatosCompletos()
        {
            return base.ObtenerDatosCompletos() + $" Especialidad: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Especialidad)} Diplomado Educación Superior: {(TienePosgradoEducacionSuperior?"Si":"No")}";
        }
        #endregion

    }
}
