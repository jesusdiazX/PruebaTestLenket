using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApi.Response
{
    public static class DatoResponse
    {
        #region Public Methods

        public static DatoResponse<object> ToDtoException(this Exception exception)
        {
            return new DatoResponse<object>(null, false, exception.Message);
        }

        public static DatoResponse<T> ToDto<T>(this T data, bool success = true, string message = "")
        {
            return new DatoResponse<T>(data, success, message);
        }

        #endregion Public Methods
    }


   
    public class DatoResponse<T>
    {
        #region Public Constructors

        public DatoResponse(T data, bool success = true)
        {
            Data = data;
            Success = success;
        }

        public DatoResponse(T data, bool success, string message)
        {
            Data = data;
            Message = message;
            Success = success;
        }


        #endregion Public Constructors

        #region Public Properties

        public T Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }

        public object Error { get; set; }

        #endregion Public Properties
    }
}