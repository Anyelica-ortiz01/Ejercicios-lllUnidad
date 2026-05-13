using ControlInventario.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario.Repositories
{
    public interface IInventarioRepository
    {
        void RegistrarProducto(Inventario producto);

        List<Inventario> ObtenerTodos();

        List<Inventario> ObtenerStockMenorA5();

        decimal ObtenerValorTotalInventario();
    }
}
