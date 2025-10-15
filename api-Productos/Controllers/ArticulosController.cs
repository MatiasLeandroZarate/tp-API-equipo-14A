using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using dominio;
using negocio;
using api_Productos.Models;

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
        public void Post([FromBody]ArticulosDto articulo)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulos nuevo = new Articulos();

            nuevo.CodigoArticulo = articulo.CodigoArticulo;
            nuevo.Nombre = articulo.Nombre;
            nuevo.DescripcionART = articulo.DescripcionART;
            nuevo.Marca = new Marca { ID = articulo.IdMarca};
            nuevo.Categoria = new Categoria { ID = articulo.IdCategoria};
            nuevo.Precio = articulo.Precio;

            negocio.Agregar(nuevo);

        }

        // PUT: api/Listar/5
        public void Put(int id, [FromBody]ArticulosDto articulo)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulos modificar = new Articulos();

            modificar.CodigoArticulo = articulo.CodigoArticulo;
            modificar.Nombre = articulo.Nombre;
            modificar.DescripcionART = articulo.DescripcionART;
            modificar.Marca = new Marca { ID = articulo.IdMarca };
            modificar.Categoria = new Categoria { ID = articulo.IdCategoria };
            modificar.Precio = articulo.Precio;
            modificar.ID = id;

            negocio.Modificar(modificar);
        }

        // DELETE: api/Listar/5
        public void Delete(int id)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            negocio.EliminarDB(id);
        }
    }
}
