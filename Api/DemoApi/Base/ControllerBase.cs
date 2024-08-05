using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace DemoApi.Base
{
    public class ControllerBase: ApiController
    {

        public static string UserLogin
        {
            get
            {
                var IdentityUser = "";
#if DEBUG
                {
                    IdentityUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                }
#else
            {
                IdentityUser = HttpContext.Current.User.Identity.Name;
            }
#endif

                return IdentityUser;
            }
        }
    }
}