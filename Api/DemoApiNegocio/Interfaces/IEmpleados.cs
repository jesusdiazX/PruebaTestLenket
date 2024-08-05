using DemoApiData.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApiNegocio.Interfaces
{
 public   interface IEmpleados
    {
        List<Empleado> getEmpleados();
        Empleado getEmpleadosId(int id);
        Empleado Add(Empleado emp);
        Empleado UpdEmpleado(Empleado emp);
        Empleado Delete(Empleado id);
        List<Cat_Entidades> GetEstados();
    }
}
