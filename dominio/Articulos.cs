using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulos
    {
        public int ID { get; set; }
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string DescripcionART { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public string UrlImagen { get; set;}
        public decimal Precio { get; set; }

        public Articulos()
        {
            Marca = new Marca();   
            Categoria = new Categoria();
        }
    }
}
