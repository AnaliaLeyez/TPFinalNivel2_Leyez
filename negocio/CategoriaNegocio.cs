using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            List<Categoria> listaCateg = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Descripcion From CATEGORIAS");
                datos.ejecutarLectura();
                SqlDataReader lector = datos.Lector;
                while (lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)lector["Id"];
                    aux.Descripcion = (string)lector["Descripcion"];                    

                    listaCateg.Add(aux);
                }
                return listaCateg;
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

        public void agregar(Categoria nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into CATEGORIAS (Id, Descripcion) values (@Id, @Descripcion)");
                datos.setearParametro("@Id", nuevo.Id);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);

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
    }
}
