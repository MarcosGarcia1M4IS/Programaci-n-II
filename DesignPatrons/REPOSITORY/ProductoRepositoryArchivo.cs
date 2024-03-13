using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORY
{
    public class ProductoRepositoryArchivo : IProductoREPOSITORY
    {

        private string _nombreArchivo;
        public  ProductoRepositoryArchivo(string nombreArchivo)
        {
            _nombreArchivo = nombreArchivo;
        }
        public void GuardarTodos(List<Producto> productos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_nombreArchivo))
                {

                    foreach (Producto producto in productos)
                    {
                        sw.WriteLine($"{producto.Nombre}, {producto.Precio}");
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al guardar el archivo" + e.Message);
                
            }
        }

        public List<Producto> ObtenertTodos()
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                using (StreamReader sr = new StreamReader(_nombreArchivo))
                {
                    string linea;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(" , ");
                        Producto producto = new Producto
                        {
                            Nombre = datos[0],
                            Precio = Convert.ToDecimal(datos[1])
                        };
                        productos.Add(producto);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al leer" + e.Message);
            }
                return productos;
        }
    }
}
