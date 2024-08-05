using DemoApiData.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApiNegocio.Interfaces
{
 public   interface IProducto
    {

        Task<IEnumerable> getProducto();
        Task<IEnumerable> getProducto(int IdProducto);
        Task<object> NuevoProducto(ModelProducto obj);
        Task<object> Actualizar(ModelProducto obj);

        
        Task<object> EliminarProducto(int id);
        Task<object> GetPais();


    }
}
