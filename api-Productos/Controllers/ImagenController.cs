using dominio;
using negocio;
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
        public void Post([FromBody]Imagen imagen)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            Imagen nuevo = new Imagen();

            nuevo.IdArticulo = imagen.IdArticulo;
            nuevo.ImagenUrl = imagen.ImagenUrl;
            negocio.Agregar(nuevo);
        }

        // PUT: api/Imagen/5
        public void Put(int id, [FromBody] Imagen imagen)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            Imagen modificar = new Imagen();

            modificar.IdArticulo = imagen.IdArticulo;
            modificar.ImagenUrl = imagen.ImagenUrl;
            modificar.ID = id;
            negocio.Modificar(modificar);
        }

        // DELETE: api/Imagen/5
        public void Delete(int id)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            negocio.EliminarDB(id);
        }
    }
}
