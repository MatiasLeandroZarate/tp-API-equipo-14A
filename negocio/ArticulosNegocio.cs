using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticulosNegocio
    {
        public List<Articulos> ListarProductos()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoBD datos = new AccesoBD();

            try
            {
                datos.setearQuery("Select ART.Id ,ART.Codigo,M.Id as IdMarca, M.Descripcion as Marca,  ART.Nombre , ART.Descripcion, ART.Precio, C.Id as IdCat ,C.Descripcion as Categoria, I.ImagenUrl from ARTICULOS as ART"
                + " left join IMAGENES as I on ART.Id = I.IdArticulo"
                + " left join MARCAS as M on ART.IdMarca = M.Id"
                + " left join CATEGORIAS as C on ART.IdCategoria = C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();


                    aux.ID = (int)datos.Lector["Id"];
                    aux.CodigoArticulo = datos.Lector["Codigo"] != DBNull.Value ? (string)datos.Lector["Codigo"] : string.Empty;

                    aux.Marca.ID = datos.Lector["IdMarca"] != DBNull.Value ? (int)datos.Lector["IdMarca"] : 0;
                    aux.Marca.DescripcionMarca = datos.Lector["Marca"] != DBNull.Value ? (string)datos.Lector["Marca"] : string.Empty; ;

                    aux.Nombre = datos.Lector["Nombre"] != DBNull.Value ? (string)datos.Lector["Nombre"] : string.Empty;
                    aux.DescripcionART = datos.Lector["Descripcion"] != DBNull.Value ? (string)datos.Lector["Descripcion"] : string.Empty;
                    aux.Precio = datos.Lector["Precio"] != DBNull.Value ? (decimal)datos.Lector["Precio"] : 0;

                    aux.Categoria.ID = datos.Lector["IdCat"] != DBNull.Value ? (int)datos.Lector["IdCat"] : 0;
                    aux.Categoria.DescripcionCategoria = datos.Lector["Categoria"] != DBNull.Value ? (string)datos.Lector["Categoria"] : string.Empty;

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    { aux.UrlImagen = (string)datos.Lector["ImagenUrl"]; }

                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Agregar(Articulos nuevo)
        {
            AccesoBD datos = new AccesoBD();
            //AccesoBD datosImagen = new AccesoBD();

            try
            {
                datos.setearQuery("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) Values(@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @precio);" + "Select cast (SCOPE_IDENTITY() AS INT) AS ID");
                datos.setearParametro("@codigo", nuevo.CodigoArticulo);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.DescripcionART);
                datos.setearParametro("@idMarca", nuevo.Marca.ID);
                datos.setearParametro("@idCategoria", nuevo.Categoria.ID);
                datos.setearParametro("@precio", nuevo.Precio);

                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    nuevo.ID = Convert.ToInt32(datos.Lector["ID"]);
                }
                datos.cerrarLector();

                //datosImagen.setearQuery("insert into IMAGENES (IdArticulo, ImagenUrl) Values(@idArticulo, @imagenUrl)");
                //datosImagen.setearParametro("@idArticulo", nuevo.ID);
                //datosImagen.setearParametro("@imagenUrl", nuevo.UrlImagen);
                //datosImagen.ejecutarAccion();

            }
            catch (Exception ex)
            { 
                throw ex;
            }

            finally 
            { 
                datos.cerrarConexion();
                //datosImagen.cerrarConexion();
            }
        }

        public void Modificar(Articulos modificar)
        {
            AccesoBD datos = new AccesoBD();
            //AccesoBD datosImagen = new AccesoBD();
            try
            {
                datos.setearQuery("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, Precio = @precio where id = @id");
                
                datos.setearParametro("@codigo", modificar.CodigoArticulo);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@descripcion", modificar.DescripcionART);
                datos.setearParametro("@idMarca", modificar.Marca.ID);
                datos.setearParametro("@idCategoria", modificar.Categoria.ID);
                datos.setearParametro("@precio", modificar.Precio);
                datos.setearParametro("@id", modificar.ID);
                datos.ejecutarAccion();
                
                //datosImagen.setearQuery("update IMAGENES set ImagenUrl = @imagenUrl where IdArticulo = @id");
                //datosImagen.setearParametro("@imagenUrl", modificar.UrlImagen);
                //datosImagen.setearParametro("@id", modificar.ID);

                //datosImagen.ejecutarAccion();
                
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
                //datosImagen.cerrarConexion();
            }
        }

        // EN LA BASE DE DATOS, NO EXISTE UN CAMPO "Activo", HAY QUE CREARLO. 
        //IGUALMENTE SE DEJA EL METODO POR SI SE DESEA IMPLEMENTAR.
        /*
        public void EliminarLogico(int id)
        {
            try
            {
                AccesoBD datos = new AccesoBD();
                datos.setearQuery("Update ARTICULOS set Activo = 0 where Id = @Id");
                datos.setearParametro("@id", id);
                datos.ejecutarLectura();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        */
        public void EliminarDB(int id)
        {
            try
            {
                AccesoBD datos = new AccesoBD();
                datos.setearQuery("Delete from ARTICULOS where Id = @Id");
                datos.setearParametro("@id",id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        
        
    
        
    }
}
