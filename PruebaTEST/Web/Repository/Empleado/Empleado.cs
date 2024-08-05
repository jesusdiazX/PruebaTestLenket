using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Web.Dao;

namespace Web.Repository.Empleado
{
    public class Empleado : IEmpleado
    {


        public Empleado()
        {

        }
        public  List<Dao.Empleado> GetEmpleadosAsync()
        {
            using (var _repo = new ModelContextEntity())
            {
                var db = new ModelContextEntity();
                var list = db.Empleado.ToList();



                return list.ToList();
            }
        }
    }
}