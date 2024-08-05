using DemoApiData.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApiNegocio.Interfaces
{
 public   interface IPersonal
    {

        Task<IEnumerable> GetPersonal();
        Task<IEnumerable> GetPersonal( int id);
        Task<object> NuevoPersonal(ModelPersonal obj);
        Task<object> ActualizarPersonal(ModelPersonal obj);
        Task<object> EliminarPersonal(int id , int idMotivo);



    }
}
