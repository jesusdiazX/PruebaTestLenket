using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApiNegocio.Interfaces
{
 public   interface IUsuario
    {
        Task<object> login(string usuario, string password);
    }
}
