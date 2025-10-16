using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_Productos.Models
{
    public class CategoriaDto
    {
        public string DescripcionCategoria { get; set; }

        public override string ToString()
        {
            return DescripcionCategoria;
        }
    }
}