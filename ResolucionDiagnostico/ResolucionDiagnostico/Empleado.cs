using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucionDiagnostico
{    
    internal class Empleado:ICalculableLiquidoPagable
    {

		#region Atributos de la clase
		private int ci;
        private string ciExt;
        private string nombres;
        private string primerApellido;
        private string segundoApellido;
        private DateTime fechaNacimiento;
        private DateTime fechaIngreso;
        private double salarioBaseMensual;
        private double horasExtra;
		#endregion

        #region Propiedades de la Clase
        public int Ci
		{
			get { return ci; }
			set { ci = value; }
		}
		

		public string CiExt
		{
			get { return ciExt; }
			set { ciExt = value; }
		}		

		public string Nombres
		{
			get { return nombres; }
			set { nombres = value; }
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

		

		public DateTime FechaNacimiento
		{
			get { return fechaNacimiento; }
			set { fechaNacimiento = value; }
		}

		

		public DateTime FechaIngreso
		{
			get { return fechaIngreso; }
			set { fechaIngreso = value; }
		}

		

		public double SalarioBaseMensual
        {
			get { return salarioBaseMensual; }
			set { salarioBaseMensual = value; }
		}

		

		public double HorasExtra
		{
			get { return horasExtra; }
			set { horasExtra = value; }
            
        }
        #endregion

        public Empleado()
        {
            
        }

        public Empleado(int ci, string ciExt, string nombres, string primerApellido, string segundoApellido, DateTime fechaNacimiento, DateTime fechaIngreso, double salarioBaseMensual, double horasExtra)
        {
            Ci = ci;
            CiExt = ciExt;
            Nombres = nombres;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            FechaNacimiento = fechaNacimiento;
            FechaIngreso = fechaIngreso;
            SalarioBaseMensual = salarioBaseMensual;
            HorasExtra = horasExtra;
        }

        #region Métodos de la clase
        public virtual double CalculoLiquidoPagable()
        {
			return SalarioBaseMensual;
        }

		public double CalculoSalarioAdicional(double factor)
		{
			return HorasExtra * factor;
        }
        #endregion

    }
}
