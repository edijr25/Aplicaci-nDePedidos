using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06libPedidos
{
    public class classRepositorioArchivosProductos : IntRepositorioProductos
    {
        #region Propiedades
        public string NombreArchivo {  get; set; }
        #endregion

        #region Constructor
        public classRepositorioArchivosProductos(string nombreArchivo)
        {
                NombreArchivo = nombreArchivo;
        }
        #endregion

        #region Metodos
        #endregion
        public Dictionary<string, recProductos> ObtenTodos()
        {
            TextReader textReader;
            string linea;
            Dictionary<string, recProductos> Productos = new Dictionary<string, recProductos>();
            if (File.Exists(NombreArchivo))
            {
                using (textReader = new StreamReader(NombreArchivo))
                {
                    do
                    {
                        linea = textReader.ReadLine();
                        if (linea != null)
                        {
                            string[] campos = linea.Split(',');
                            Productos.Add(campos[2], new recProductos(Convert.ToInt32(campos[0]), campos[1], campos[2]));
                        }
                    } while (linea != null);
                    textReader.Close();
                }
            }
            return Productos;
        }
    }
}
