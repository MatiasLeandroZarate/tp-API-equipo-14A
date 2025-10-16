using dominio;
using negocio;
using api_Productos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api_Productos.Controllers
{
    public class CategoriaController : ApiController
    {
        // GET: api/Categoria
        public IEnumerable<Categoria> Get()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            return negocio.listar();
        }

        // GET: api/Categoria/5
        public Categoria Get(int id)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            List<Categoria> lista = negocio.listar();

            return lista.Find(x => x.ID == id);
        }

        // POST: api/Categoria
        public HttpResponseMessage Post([FromBody]CategoriaDto categoria)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria nuevo = new Categoria();

            if(string.IsNullOrWhiteSpace(categoria.DescripcionCategoria))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La descripción es obligatoria.");

            nuevo.DescripcionCategoria = categoria.DescripcionCategoria;
            negocio.Agregar(nuevo);

            return Request.CreateResponse(HttpStatusCode.OK, "Categoría agregada correctamente.");
        }

        // PUT: api/Categoria/5
        public HttpResponseMessage Put(int id, [FromBody] CategoriaDto categoria)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria modificar = new Categoria();

            var lista = negocio.listar();
            var Existente= lista.Find(x => x.ID == id);

            if (Existente == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La categoría no existe.");
            }

            if (string.IsNullOrWhiteSpace(categoria.DescripcionCategoria))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La descripción es obligatoria.");

            modificar.DescripcionCategoria = categoria.DescripcionCategoria;
            modificar.ID = id;
            negocio.Modificar(modificar);

            return Request.CreateResponse(HttpStatusCode.OK, "Categoría modificada correctamente.");
        }

        // DELETE: api/Categoria/5
        public HttpResponseMessage Delete(int id)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            var lista = negocio.listar();
            var Existente = lista.Find(x => x.ID == id);

            if (Existente == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "La categoría no existe.");
            }

            negocio.EliminarDB(id);

            return Request.CreateResponse(HttpStatusCode.OK, "Categoría eliminada correctamente.");
        }
    }
}
