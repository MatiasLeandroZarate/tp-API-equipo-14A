using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoBD datos = new AccesoBD();

            try
            {
                datos.setearQuery("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.ID = (int)datos.Lector["Id"];
                    aux.DescripcionCategoria = (string)datos.Lector["Descripcion"];

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

        public void Agregar(Categoria nuevo)
        {
            AccesoBD datos = new AccesoBD();

            try
            {
                datos.setearQuery("insert into CATEGORIAS (Descripcion) Values(@descripcion);" + "Select cast (SCOPE_IDENTITY() AS INT) AS ID");
                datos.setearParametro("@descripcion", nuevo.DescripcionCategoria);

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

        public void Modificar(Categoria modificar)
        {
            AccesoBD datos = new AccesoBD();
            try
            {
                datos.setearQuery("update CATEGORIAS set Descripcion = @descripcion where id = @id");

                datos.setearParametro("@descripcion", modificar.DescripcionCategoria);
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
                datos.setearQuery("Delete from CATEGORIAS where Id = @Id");
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
