using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class classProductos
    {
        #region Propiedades
        public int idProducto { get; set; }
        public string Descripcion { get; set; }

        public string CodigoBarras { get; set;}
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public override string ToString()
        {
            return $"idProducto: {idProducto.ToString()} " +
                   $"Descripcion: {Descripcion} "  +
                   $"Codigo Barras: {CodigoBarras} ";
        }
        #endregion
    }
}
