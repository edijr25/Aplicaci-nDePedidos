using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class classProductosPrecios : classProductos
    {
        #region Propiedades
        public decimal PrecioPublico { get; set; }

        public decimal PrecioMayoreo { get; set;  }

        public decimal PorcentajeIva { get; set; }

        public decimal PorcentajeIeps { get; set; }
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public override string ToString()
        {
            return base.ToString() +
                $"Precio público: {PrecioPublico.ToString("C")}" +
                $"Precio mayoreo: {PrecioMayoreo.ToString("C")}" +
                $"Porcentaje IVA: {PorcentajeIva.ToString()}" +
                $"Porcentaje IEPS: {PorcentajeIeps.ToString()}";
        }

        public decimal DesglosaImpuestos(recMontosImpuestos Montos)
        {
            decimal resultado = 0;
            recImpuestos Impuestos = new recImpuestos(PorcentajeIva, PorcentajeIeps);
            resultado = CalculoPrecios.DesglosaImpuesto(PrecioPublico, Impuestos, 
                                            Montos);
            return resultado;
        }
        #endregion
    }
}
