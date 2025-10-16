using dominio;
using negocio;
using api_Productos.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api_Productos.Controllers
{
    public class ImagenController : ApiController
    {
        // GET: api/Imagen
        public IEnumerable<Imagen> Get()
        {
            ImagenNegocio negocio = new ImagenNegocio();
            return negocio.Listar();
        }

        // GET: api/Imagen/5
        public Imagen Get(int id)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            List<Imagen> lista = negocio.Listar();

            return lista.Find(x => x.ID == id);
        }

        // POST: api/Imagen
        public HttpResponseMessage Post([FromBody]ImagenDto imagen)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            Imagen nuevo = new Imagen();

            ArticulosNegocio negocioArt = new ArticulosNegocio();
            Articulos articulo = negocioArt.ListarProductos().Find(x => x.ID == imagen.IdArticulo);

            if (articulo == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El artículo no existe.");

            var lista = negocio.Listar();
            var Existente = lista.Find(x => x.IdArticulo == imagen.IdArticulo);


            // EN CASO DE QUERER QUE LOS ARTíCULOS TENGAN UNA SOLA IMAGEN, HABILITAR.

            //if (Existente != null)
            //{
            //    return Request.CreateResponse(HttpStatusCode.BadRequest, "El artículo ya tiene una imagen.");
            //}

            if (string.IsNullOrWhiteSpace(imagen.ImagenUrl))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El URL es obligatorio.");

            nuevo.IdArticulo = imagen.IdArticulo;
            nuevo.ImagenUrl = imagen.ImagenUrl;
            negocio.Agregar(nuevo);

            return Request.CreateResponse(HttpStatusCode.OK, "Imagen agregada correctamente.");
        }

        // PUT: api/Imagen/5
        public HttpResponseMessage Put(int id, [FromBody] ImagenDto imagen)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            Imagen modificar = new Imagen();

            ArticulosNegocio negocioArt = new ArticulosNegocio();
            Articulos articulo = negocioArt.ListarProductos().Find(x => x.ID == imagen.IdArticulo);

            if (articulo == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El artículo no existe.");

            var lista = negocio.Listar();
            var Existente = lista.Find(x => x.ID == id);

            if (Existente == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La imagen no existe.");
            }

            if (string.IsNullOrWhiteSpace(imagen.ImagenUrl))
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El URL es obligatorio.");

            modificar.IdArticulo = imagen.IdArticulo;
            modificar.ImagenUrl = imagen.ImagenUrl;
            modificar.ID = id;
            negocio.Modificar(modificar);

            return Request.CreateResponse(HttpStatusCode.OK, "Imagen modificada correctamente.");
        }

        // DELETE: api/Imagen/5
        public HttpResponseMessage Delete(int id)
        {
            ImagenNegocio negocio = new ImagenNegocio();

            var lista = negocio.Listar();
            var Existente = lista.Find(x => x.ID == id);

            if (Existente == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "La imagen no existe.");
            }

            negocio.EliminarDB(id);

            return Request.CreateResponse(HttpStatusCode.OK, "Imagen eliminada correctamente.");
        }
    }
}
