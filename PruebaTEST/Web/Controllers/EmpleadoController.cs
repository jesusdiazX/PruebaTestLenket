using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{

    [AllowAnonymous]
    [RoutePrefix("api/Empleado")]
    public class EmpleadoController : Controller
    {
        // GET
        public ActionResult Index()
        {

            var llista = getEmpledos();

            return View();
        }








        

        public JsonResult getEmpledos() {
            List<Empleado> lista = new List<Empleado>();
            try
            {

                
                HttpWebRequest request = WebRequest.Create("http://localhost:53871/api/empleados/GetEmpleado") as HttpWebRequest;

                //request.Accept = "application/xrds+xml";  
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                WebHeaderCollection header = response.Headers;

                var encoding = ASCIIEncoding.ASCII;
                using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
                {
                    string responseText = reader.ReadToEnd();

                   lista = JsonConvert.DeserializeObject<List<Empleado>>(responseText.ToString());
                    
                }

            }
            catch (Exception)
            {

                throw;
            }



            return Json(lista,JsonRequestBehavior.AllowGet);
        
        }

        public JsonResult getEmpledoId(int id)
        {
            Empleado empleado = new Empleado();
            try
            {


                HttpWebRequest request = WebRequest.Create("http://localhost:53871/api/empleados/GetEmpleadoId?id=" +id) as HttpWebRequest;             
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                WebHeaderCollection header = response.Headers;
                var encoding = ASCIIEncoding.ASCII;
                using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
                {
                    string responseString = reader.ReadToEnd();

                    empleado = JsonConvert.DeserializeObject<Empleado>(responseString.ToString());

                }

            }
            catch (Exception)
            {

                throw;
            }



            return Json(empleado, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetEstados()
        {
            List<Cat_Entidades> lista = new List<Cat_Entidades>();
            try
            {


                HttpWebRequest request = WebRequest.Create("http://localhost:53871/api/empleados/GetEstados") as HttpWebRequest;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                WebHeaderCollection header = response.Headers;

                var encoding = ASCIIEncoding.ASCII;
                using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
                {
                    string responseText = reader.ReadToEnd();

                    lista = JsonConvert.DeserializeObject<List<Cat_Entidades>>(responseText.ToString());

                }

            }
            catch (Exception ex)
            {
               
            }



            return Json(lista, JsonRequestBehavior.AllowGet);

        }

        public JsonResult   AddEmpledos(Empleado emp)
        {
               Empleado empleado = new Empleado();
            try
            {
                HttpClient _httpClient = new HttpClient();
                var body = JsonConvert.SerializeObject(emp);
                var requestContent = new StringContent(body, Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:53871/api/Empleados");
                request.Content = requestContent;
                using (HttpResponseMessage response = _httpClient.SendAsync(request).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                       
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                        return null;
                    else
                        throw new Exception("Error  en Inserta()");
                }

                

            }
            
            catch (Exception ex)
            {

                throw;
            }



            return Json("Exito",JsonRequestBehavior.AllowGet); 

        }


        public JsonResult Actualiza(Empleado emp)
        {
            Empleado empleado = new Empleado();
            try
            {
                HttpClient _httpClient = new HttpClient();
                var body = JsonConvert.SerializeObject(emp);
                var requestContent = new StringContent(body, Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage(HttpMethod.Put, "http://localhost:53871/api/Empleados");
                request.Content = requestContent;
                using (HttpResponseMessage response = _httpClient.SendAsync(request).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                       
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                        return null;
                    else
                        throw new Exception("Error Actualiza()");
                }



            }

            catch (Exception ex)
            {

                throw;
            }



            return Json("Exito", JsonRequestBehavior.AllowGet);

        }

        public JsonResult Delete(Empleado emp)
        {
            Empleado empleado = new Empleado();
            try
            {
                HttpClient _httpClient = new HttpClient();
                var body = JsonConvert.SerializeObject(emp);
                var requestContent = new StringContent(body, Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage(HttpMethod.Delete, "http://localhost:53871/api/Empleados");
                request.Content = requestContent;
                using (HttpResponseMessage response = _httpClient.SendAsync(request).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                      
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                        return null;
                    else
                        throw new Exception("Error Delete");
                }



            }

            catch (Exception ex)
            {

                throw;
            }



            return Json("Exito", JsonRequestBehavior.AllowGet);

        }




    }
}