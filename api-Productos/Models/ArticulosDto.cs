using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_Productos.Models
{
    public class ArticulosDto
    {
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string DescripcionART { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public decimal Precio { get; set; }
    }
}