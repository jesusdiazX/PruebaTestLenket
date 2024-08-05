using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleInjector;
using System.Threading.Tasks;
using DemoApiNegocio.Interfaces;
using DemoApiNegocio.Services;

namespace DemoApiNegocio
{
    public class Resolvers
    {

        #region Public Methods

        public static void RegisterServices(Container container)
        {
           
            container.Register<IEmpleados, EmpleadosService>(Lifestyle.Singleton);
          

        }

        #endregion Public Methods
    }
}
