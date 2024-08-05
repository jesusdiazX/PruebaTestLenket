using DemoApiData.Models;
using DemoApiNegocio.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApiNegocio.Services
{
 internal   class EmpleadosService:IEmpleados
    {

        public  List<Empleado> getEmpleados()
        {
            using (var _repo = new ModelContextEntity())
            {
                var list = _repo.Empleado.ToList();
                return list.ToList();
            }
        }
        public Empleado getEmpleadosId(int id)
        {
            using (var _repo = new ModelContextEntity())
            {
                var db = new ModelContextEntity();
                Empleado emp = _repo.Empleado.Where(x => x.Id == id).SingleOrDefault();
                return emp;
            }
        }

        public Empleado Add(Empleado emp)
        {
            using (var _repo = new ModelContextEntity())
            {
               
                _repo.Empleado.Add(emp);
                _repo.SaveChanges();



                return emp;
            }
        }

    

        public Empleado UpdEmpleado(Empleado emp)
        {
            using (var _repo = new ModelContextEntity())
            {
                Empleado upd = _repo.Empleado.Where(x => x.Id == emp.Id).SingleOrDefault();
                if (upd != null)
                {
                    _repo.Entry(upd).CurrentValues.SetValues(emp);
                    _repo.SaveChanges();

                }

                    return emp;
            }
        }

        public Empleado Delete(Empleado empleado)
        {

           


            using (var _repo = new ModelContextEntity())
            {
                Empleado delete = _repo.Empleado.Where(x => x.Id == empleado.Id).SingleOrDefault();              
                _repo.Empleado.Remove(delete);
                _repo.SaveChanges();



                return empleado;
            }
        }

        public List<Cat_Entidades> GetEstados()
        {
            using (var _repo = new ModelContextEntity())
            {

                var list = _repo.Cat_Entidades.ToList();
                return list.ToList();
            }
        }
    }
}
