using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEjercicio3
{
    internal class Administrativo:Usuario
    {
        #region Atributos
        private decimal salario;
        private string cargo;
        #endregion

        #region Propiedades
        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        }  
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        #endregion

        #region Constructores
        public Administrativo()
        {

        }
        //Esta es la forma de hacer Constructores Heredados
        public Administrativo(string ci, string primerApellido, string segundoApellido, string nombres, string correoElectronico, string rol, string nombreUsuario, string contrasenia,decimal salario, string cargo)
            : base(ci, primerApellido, segundoApellido, nombres, correoElectronico, rol, nombreUsuario, contrasenia)
        {
            Salario = salario;
            Cargo = cargo;
        }
        #endregion

        #region Métodos
        public override string ObtenerDatosCompletos()
        {
            return base.ObtenerDatosCompletos()+$" Salario: {Salario} Cargo: {Cargo.ToLower()}";
        }
        #endregion
    }
}
