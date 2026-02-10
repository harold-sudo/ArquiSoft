using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucionDiagnostico
{
    internal class Ayudantes: Empleado
    {
		private bool tieneConocimientoEnCocina;

		public bool TieneConocimientoEnCocina
        {
			get { return tieneConocimientoEnCocina; }
			set { tieneConocimientoEnCocina = value; }
		}

		public Ayudantes()
		{
		}
        public Ayudantes(int ci, string ciExt, string nombres, string primerApellido, string segundoApellido, DateTime fechaNacimiento, DateTime fechaIngreso, double salarioBaseMensual, double horasExtra, bool tieneConocimientoEnCocina)
            : base(ci, ciExt, nombres, primerApellido, segundoApellido, fechaNacimiento, fechaIngreso, salarioBaseMensual, horasExtra)
        {
            TieneConocimientoEnCocina = tieneConocimientoEnCocina;
        }

        public override double CalculoLiquidoPagable()
        {
            return base.CalculoLiquidoPagable() + CalculoSalarioAdicional(40);
        }
    }
}
