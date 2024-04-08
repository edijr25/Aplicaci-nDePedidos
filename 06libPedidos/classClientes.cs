using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class classClientes : ClassPersonas
    {
        #region Propiedades
        public string Rfc { get; set; }
        public int idCliente 
        {
            get { return IdPersona;}
            set { IdPersona = value; }

        }
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public override string ToString()
        {
            string cadena = $"idCliente = {idCliente.ToString()} NombreCompleto = {NombreCompleto} Rfc {Rfc}";
            return cadena;
        }
        #endregion
    }
}
