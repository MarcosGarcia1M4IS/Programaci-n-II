using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORY
{
    public class GestorProductos
    {
        private IProductoREPOSITORY _repository;

        public GestorProductos( IProductoREPOSITORY repository)
        {
            _repository = repository;
        }


        public List<Producto> ObtenerTodosLosProductos()
        {
            return _repository.ObtenertTodos();

        }

        public void AgergarProducto(Producto producto)
        {
            List<Producto> productos = _repository.ObtenertTodos();
            productos.Add(producto);
            _repository.GuardarTodos(productos);
        }
    }
}
