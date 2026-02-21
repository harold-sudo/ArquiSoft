using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEjercicio3
{
    internal class Estudiante:Usuario
    {
        #region Atributos
        private short anioBachillerato;
        private string tipoInstitucionBachillerato;
        #endregion

        #region Propiedades
        public short AnioBachillerato
        {
            get { return anioBachillerato; }
            set { anioBachillerato = value; }
        }
        public string TipoInstitucionBachillerato
        {
            get { return tipoInstitucionBachillerato; }
            set { tipoInstitucionBachillerato = value; }
        }
        #endregion

        #region Constructores
        public Estudiante()
        {

        }        
        public Estudiante(string ci, string primerApellido, string segundoApellido, string nombres, string correoElectronico, string rol, string nombreUsuario, string contrasenia, short anioBachillerato, string tipoInstitucionBachillerato)
            :base(ci, primerApellido, segundoApellido, nombres, correoElectronico, rol, nombreUsuario, contrasenia)
        {
            AnioBachillerato = anioBachillerato;
            TipoInstitucionBachillerato = tipoInstitucionBachillerato;            
        }
        #endregion

        #region Métodos
        public override string ObtenerDatosCompletos()
        {
            return base.ObtenerDatosCompletos() + $" Año Bachillerato: {AnioBachillerato} Tipo de Institución: {TipoInstitucionBachillerato.ToUpper()}";
        }
        #endregion
    }
}
