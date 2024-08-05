using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosAbinarios
{
    internal class Mensaje : IMensaje
    {
        public string EmailMensaje(string mensaje)
        {

            return "-email-." + mensaje;
        }

        public string SmsMensaje(string mensaje)
        {
            return "-sms-." + mensaje;
        }
    }
}
