using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApiData.Models
{
    public class ModelCombos
    {
        private int _id;
        private string _codigo;
        private string _descripcion;
        private int _status;

        public int Id { get => _id; set => _id = value; }
        public string Cod { get => _codigo; set => _codigo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        public int status { get => _status; set => _status = value; }

    }

}
