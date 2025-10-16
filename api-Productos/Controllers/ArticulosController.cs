using api_Productos.Models;
using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;
using System.Web.UI.WebControls.WebParts;

namespace api_Productos.Controllers
{
    public class ArticulosController : ApiController
    {
        // GET: api/Listar
        public IEnumerable<Articulos> Get()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            return negocio.ListarProductos();
        }

        // GET: api/Listar/5
        public Articulos Get(int id)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            List<Articulos> lista = negocio.ListarProductos();

            return lista.Find(x=> x.ID == id);
        }

        // POST: api/Listar
        public HttpResponseMessage Post([FromBody]ArticulosDto articulo)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            CategoriaNegocio negocioCat = new CategoriaNegocio();
            MarcaNegocio negocioMar = new MarcaNegocio();

            if(string.IsNullOrWhiteSpace(articulo.CodigoArticulo))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El codigo es obligatorio.");

            if (string.IsNullOrWhiteSpace(articulo.Nombre))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El nombre es obligatorio.");

            if(string.IsNullOrWhiteSpace(articulo.DescripcionART))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La descripción es obligatoria.");

            Categoria categoria = negocioCat.listar().Find(x => x.ID == articulo.IdCategoria);
            if (categoria == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La categoría no existe.");

            Marca marca = negocioMar.listar().Find(x => x.ID == articulo.IdMarca);
            if (marca == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La marca no existe.");

            if (articulo.Precio < 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El precio no puede ser negativo.");

            Articulos nuevo = new Articulos();
            nuevo.CodigoArticulo = articulo.CodigoArticulo;
            nuevo.Nombre = articulo.Nombre;
            nuevo.DescripcionART = articulo.DescripcionART;
            nuevo.Marca = new Marca { ID = articulo.IdMarca};
            nuevo.Categoria = new Categoria { ID = articulo.IdCategoria};
            nuevo.Precio = articulo.Precio;

            negocio.Agregar(nuevo);

            return Request.CreateResponse(HttpStatusCode.OK, "Artículo agregado correctamente.");
        }

        // PUT: api/Listar/5
        public HttpResponseMessage Put(int id, [FromBody]ArticulosDto articulo)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulos modificar = new Articulos();

            CategoriaNegocio negocioCat = new CategoriaNegocio();
            MarcaNegocio negocioMar = new MarcaNegocio();


            var lista = negocio.ListarProductos();
            var Existente = lista.Find(x => x.ID == id);

            if (Existente == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El artículo no existe.");
            }

            if (string.IsNullOrWhiteSpace(articulo.CodigoArticulo))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El codigo es obligatorio.");

            if (string.IsNullOrWhiteSpace(articulo.Nombre))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(articulo.DescripcionART))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La descripción es obligatoria.");

            Categoria categoria = negocioCat.listar().Find(x => x.ID == articulo.IdCategoria);
            if (categoria == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La categoría no existe.");

            Marca marca = negocioMar.listar().Find(x => x.ID == articulo.IdMarca);
            if (marca == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La marca no existe.");

            if (articulo.Precio < 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El precio no puede ser negativo.");

            modificar.CodigoArticulo = articulo.CodigoArticulo;
            modificar.Nombre = articulo.Nombre;
            modificar.DescripcionART = articulo.DescripcionART;
            modificar.Marca = new Marca { ID = articulo.IdMarca };
            modificar.Categoria = new Categoria { ID = articulo.IdCategoria };
            modificar.Precio = articulo.Precio;
            modificar.ID = id;

            negocio.Modificar(modificar);

            return Request.CreateResponse(HttpStatusCode.OK, "Artículo modificado correctamente.");
        }

        // DELETE: api/Listar/5
        public HttpResponseMessage Delete(int id)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            var lista = negocio.ListarProductos();
            var Existente = lista.Find(x => x.ID == id);

            if (Existente == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "El artículo no existe.");
            }

            negocio.EliminarDB(id);

            return Request.CreateResponse(HttpStatusCode.OK, "Artículo eliminado correctamente.");
        }
    }
}
