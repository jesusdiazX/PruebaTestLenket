using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosAbinarios
{
 public   class PrincipalService
    {

        private readonly IMensaje _service;

        public PrincipalService(IMensaje service)
        {
            _service = service;
        }

        public string EmailMensaje()
        {

            return _service.EmailMensaje("Se envio  el EMAIL ");
        }

        public string SmsMensaje()
        {

            return _service.SmsMensaje("Se envio  el SMS ");
        }


    }
}
