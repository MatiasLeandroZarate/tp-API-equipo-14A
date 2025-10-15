using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoBD datos = new AccesoBD();

            try
            {
                datos.setearQuery("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.ID = (int)datos.Lector["Id"];
                    aux.DescripcionMarca = (string)datos.Lector["Descripcion"];

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

        public void Agregar(Marca nuevo)
        {
            AccesoBD datos = new AccesoBD();

            try
            {
                datos.setearQuery("insert into MARCAS (Descripcion) Values(@descripcion);" + "Select cast (SCOPE_IDENTITY() AS INT) AS ID");
                datos.setearParametro("@descripcion", nuevo.DescripcionMarca);

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

        public void Modificar(Marca modificar)
        {
            AccesoBD datos = new AccesoBD();
            try
            {
                datos.setearQuery("update MARCAS set Descripcion = @descripcion where id = @id");
                
                datos.setearParametro("@descripcion", modificar.DescripcionMarca);
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
                datos.setearQuery("Delete from MARCAS where Id = @Id");
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
