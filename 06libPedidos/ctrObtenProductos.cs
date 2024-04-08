using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class ctrObtenProductos
    {
        #region Propiedades
        private IntRepositorioProductos repoProductos;

        public Dictionary<string, recProductos> Productos { get; set; }

        #endregion

        #region Constructor
        public ctrObtenProductos(IntRepositorioProductos prepoProductos) 
        { 
            repoProductos = prepoProductos;
            Productos = new Dictionary<string, recProductos>();

        }
        #endregion

        #region Metodos
        public void ObtenProductos()
        {
            Productos.Clear();
            Productos = repoProductos.ObtenTodos();
        }

        public bool ObtenProducto(string codigoBarras, out recProductos producto)
        {
            return Productos.TryGetValue(codigoBarras, out producto);
        }
        #endregion
    }
}
