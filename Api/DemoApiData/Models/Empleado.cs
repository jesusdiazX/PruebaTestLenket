namespace DemoApiData.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string NumeroNomina { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string ApellidoPaterno { get; set; }

        [StringLength(100)]
        public string ApellidoMaterno { get; set; }

        public int? IdEstado { get; set; }
    }
}
