using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosAbinarios
{
   public interface IMensaje
    {

        string EmailMensaje(string mensaje);
        string SmsMensaje(string mensaje);
    }
}
