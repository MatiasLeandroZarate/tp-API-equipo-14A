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
    public class MarcaController : ApiController
    {
        public IEnumerable<Marca> Get()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            return negocio.listar();
        }

        // GET: api/Categoria/5
        public Marca Get(int id)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            List<Marca> lista = negocio.listar();

            return lista.Find(x => x.ID == id);
        }

        // POST: api/Categoria
        public HttpResponseMessage Post([FromBody] MarcaDto marca)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca nuevo = new Marca();

            if (string.IsNullOrWhiteSpace(marca.DescripcionMarca))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La descripción es obligatoria.");

            nuevo.DescripcionMarca = marca.DescripcionMarca;
            negocio.Agregar(nuevo);

            return Request.CreateResponse(HttpStatusCode.OK, "Marca agregada correctamente.");
        }

        // PUT: api/Categoria/5
        public HttpResponseMessage Put(int id, [FromBody] MarcaDto marca)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca modificar = new Marca();

            var lista = negocio.listar();
            var Existente = lista.Find(x => x.ID == id);

            if (Existente == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La marca no existe.");
            }

            if (string.IsNullOrWhiteSpace(marca.DescripcionMarca))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La descripción es obligatoria.");

            modificar.DescripcionMarca = marca.DescripcionMarca;
            modificar.ID = id;
            negocio.Modificar(modificar);

            return Request.CreateResponse(HttpStatusCode.OK, "Marca modificada correctamente.");
        }

        // DELETE: api/Categoria/5
        public HttpResponseMessage Delete(int id)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            var lista = negocio.listar();
            var Existente = lista.Find(x => x.ID == id);

            if (Existente == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "La marca no existe.");
            }

            negocio.EliminarDB(id);

            return Request.CreateResponse(HttpStatusCode.OK, "Marca eliminada correctamente.");
        }
    }
}
