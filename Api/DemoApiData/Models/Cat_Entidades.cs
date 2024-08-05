namespace DemoApiData.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cat_Entidades
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Estado { get; set; }
    }
}
