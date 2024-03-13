using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORY
{

    // Repositorio de productos
    public interface IProductoREPOSITORY
    {
        List<Producto> ObtenertTodos();
        void GuardarTodos(List<Producto> productos);

    }
}
