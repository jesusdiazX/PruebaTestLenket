using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Cat_Entidades
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Estado { get; set; }
    }
}