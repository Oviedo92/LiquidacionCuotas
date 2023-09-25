using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Liquidacion
    {
        public Liquidacion(string identificacion, char tipoAfiliacion, float salario, float valorServicio, string numeroLiquidacion, float tarifa)
        {
            Identificacion = identificacion;
            TipoAfiliacion = tipoAfiliacion;
            Salario = salario;
            ValorServicio = valorServicio;
            NumeroLiquidacion = numeroLiquidacion;
            Tarifa = tarifa;
        }

        public Liquidacion()
        {


        }

        public string Identificacion { get; set; }
        public char TipoAfiliacion { get; set; }
        public float Salario { get; set; }
        public float ValorServicio { get; set; }
        public string NumeroLiquidacion { get; set; }
        public float Tarifa { get; set; }
    }
}
