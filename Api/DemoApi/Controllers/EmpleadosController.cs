using DemoApiData.Models;
using DemoApiNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace DemoApi.Controllers
{
    [System.Web.Http.AllowAnonymous]
    [System.Web.Http.RoutePrefix("api/empleados")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmpleadosController : ApiController
    {
        // GET: Empleados
        private readonly IEmpleados _service;


        public EmpleadosController(IEmpleados catalogo)
        {
            _service = catalogo;


        }

       [System.Web.Http.HttpGet]

        [System.Web.Http.Route("GetEmpleado")]
        public  List<Empleado> GetEmpleados()
        {


            var list =  _service.getEmpleados();

            return list.ToList();
        }


        [System.Web.Http.HttpGet]

        [System.Web.Http.Route("GetEmpleadoId")]
        public Empleado GetEmpleadosId(int id)
        {


            var list = _service.getEmpleadosId(id);

            return list;
        }

        [System.Web.Http.HttpGet]

        [System.Web.Http.Route("GetEstados")]
        public List<Cat_Entidades> GetEstados()
        {


            var list = _service.GetEstados();

            return list.ToList();
        }


        [System.Web.Http.HttpPost]
        public Empleado add(Empleado add)
        {


            var list = _service.Add(add);

            return null;
        }
        [System.Web.Http.HttpPut]
        public Empleado updt(Empleado Upd)
        {


            var list = _service.UpdEmpleado(Upd);

            return null;
        }
        [System.Web.Http.HttpDelete]
        public Empleado delete(Empleado del)
        {


            var list = _service.Delete(del);

            return null;
        }

    }
}