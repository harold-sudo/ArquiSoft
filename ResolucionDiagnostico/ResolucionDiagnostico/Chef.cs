using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucionDiagnostico
{
    internal class Chef: Empleado
    {
        const double FACTOR = 70;
		private string especialidad;

		public string Especialidad
        {
			get { return especialidad; }
			set { especialidad = value; }
		}

		public Chef()
		{

		}
        public Chef(int ci, string ciExt, string nombres, string primerApellido, string segundoApellido, DateTime fechaNacimiento, DateTime fechaIngreso, double salarioBaseMensual, double horasExtra, string especialidad)
            :base(ci, ciExt, nombres, primerApellido, segundoApellido, fechaNacimiento, fechaIngreso, salarioBaseMensual, horasExtra)
        {
            Especialidad = especialidad;
        }

        public override double CalculoLiquidoPagable()
        {
            return base.CalculoLiquidoPagable() + CalculoSalarioAdicional(FACTOR);
        }
    }
}
