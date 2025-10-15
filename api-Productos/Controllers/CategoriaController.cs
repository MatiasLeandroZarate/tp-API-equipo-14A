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
        public void Post([FromBody]Categoria categoria)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria nuevo = new Categoria();

            nuevo.DescripcionCategoria = categoria.DescripcionCategoria;
            negocio.Agregar(nuevo);
        }

        // PUT: api/Categoria/5
        public void Put(int id, [FromBody]Categoria categoria)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria modificar = new Categoria();

            modificar.DescripcionCategoria = categoria.DescripcionCategoria;
            modificar.ID = id;
            negocio.Modificar(modificar);
        }

        // DELETE: api/Categoria/5
        public void Delete(int id)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            negocio.EliminarDB(id);
        }
    }
}
