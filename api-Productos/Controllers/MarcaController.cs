using dominio;
using negocio;
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
        public void Post([FromBody] Marca marca)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca nuevo = new Marca();

            nuevo.DescripcionMarca = marca.DescripcionMarca;
            negocio.Agregar(nuevo);
        }

        // PUT: api/Categoria/5
        public void Put(int id, [FromBody] Marca marca)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca modificar = new Marca();

            modificar.DescripcionMarca = marca.DescripcionMarca;
            modificar.ID = id;
            negocio.Modificar(modificar);
        }

        // DELETE: api/Categoria/5
        public void Delete(int id)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            negocio.EliminarDB(id);
        }
    }
}
