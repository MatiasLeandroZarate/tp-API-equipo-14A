using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_Productos.Models
{
    public class MarcaDto
    {
        public string DescripcionMarca { get; set; }

        public override string ToString()
        {
            return DescripcionMarca;
        }
    }
}