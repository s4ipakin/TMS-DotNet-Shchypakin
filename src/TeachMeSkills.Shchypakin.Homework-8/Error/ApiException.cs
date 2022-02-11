using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_8.Error
{
    public class ApiException
    {
        public ApiException(int statusCode, string message = null, string detailes = null)
        {
            StatusCode = statusCode;
            Message = message;
            Detailes = detailes;
        }

        public int StatusCode { get; set; }

        public string Message { get; set; }

        public string Detailes { get; set; }
    }
}
