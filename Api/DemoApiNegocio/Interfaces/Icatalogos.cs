using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApiNegocio.Interfaces
{
  public  interface Icatalogos
    {


        Task<IEnumerable> getPaises();
        Task<IEnumerable> getMotivos();
        
    }
}
