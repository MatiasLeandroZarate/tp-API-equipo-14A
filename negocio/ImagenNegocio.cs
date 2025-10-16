using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> Listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoBD datos = new AccesoBD();

            try
            {
                datos.setearQuery("select Id, IdArticulo, ImagenUrl from IMAGENES");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.ID = (int)datos.Lector["Id"];
                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];

                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

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

        public void Agregar(Imagen nuevo)
        {
            AccesoBD datos = new AccesoBD();
            try
            {
                datos.setearQuery("insert into IMAGENES (IdArticulo , ImagenUrl) Values(@IdArticulo, @ImagenUrl);" + "Select cast (SCOPE_IDENTITY() AS INT) AS ID");
                datos.setearParametro("@IdArticulo", nuevo.IdArticulo);
                datos.setearParametro("@ImagenUrl", nuevo.ImagenUrl);

                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    nuevo.ID = Convert.ToInt32(datos.Lector["ID"]);
                }
                datos.cerrarLector();
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

        public void Modificar(Imagen modificar)
        {
            AccesoBD datos = new AccesoBD();
            try
            {
                datos.setearQuery("update IMAGENES set IdArticulo = @idarticulo, ImagenUrl = @imagenurl where id = @id");

                datos.setearParametro("@idarticulo", modificar.IdArticulo);
                datos.setearParametro("@imagenurl", modificar.ImagenUrl);
                datos.setearParametro("@id", modificar.ID);
                datos.ejecutarAccion();

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

        public void EliminarDB(int id)
        {
            try
            {
                AccesoBD datos = new AccesoBD();
                datos.setearQuery("Delete from IMAGENES where Id = @Id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
