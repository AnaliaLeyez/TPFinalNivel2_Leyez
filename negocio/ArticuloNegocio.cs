using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> listaArt = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion Marca, A.IdCategoria, C.Descripcion Categoria, A.ImagenUrl, A.Precio From ARTICULOS A, CATEGORIAS C, MARCAS M Where M.Id = A.IdMarca And C.Id = A.IdCategoria");
                datos.ejecutarLectura();
                SqlDataReader lector = datos.Lector;
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    if (!(lector["ImagenUrl"] is DBNull))
                        aux.Imagen = (string)lector["ImagenUrl"];
                    aux.Precio = Math.Round((decimal)lector["Precio"], 2);

                    listaArt.Add(aux);
                }
                return listaArt;
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

        public void agregar(Articulo nuevo)
        {
                AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, IdMarca, IdCategoria, Precio) values (@Codigo, @Nombre, @Descripcion, @ImagenUrl, @IdMarca, @IdCategoria, @Precio)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@ImagenUrl", nuevo.Imagen);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);

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

        public void modificar(Articulo existente)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo=@Codigo, Nombre=@Nombre, Descripcion=@Descripcion, ImagenUrl=@ImagenUrl, IdMarca=@IdMarca, IdCategoria=@IdCategoria, Precio=@Precio where Id=@Id");
                datos.setearParametro("@Codigo", existente.Codigo);
                datos.setearParametro("@Nombre", existente.Nombre);
                datos.setearParametro("@Descripcion", existente.Descripcion);
                datos.setearParametro("@ImagenUrl", existente.Imagen);
                datos.setearParametro("@IdMarca",existente.Marca.Id);
                datos.setearParametro("@IdCategoria", existente.Categoria.Id);
                datos.setearParametro("@Precio", existente.Precio);
                datos.setearParametro("@Id", existente.Id);

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

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from ARTICULOS where Id="+ id);
                //datos.setearConsulta("delete from ARTICULOS where Id=@Id");
                //datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion Marca, A.IdCategoria, C.Descripcion Categoria, A.ImagenUrl, A.Precio From ARTICULOS A, CATEGORIAS C, MARCAS M Where M.Id = A.IdMarca And C.Id = A.IdCategoria And ";
                switch (campo)
                {
                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "Nombre like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "Nombre like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "Nombre like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Marca":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "M.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "M.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "M.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "Precio > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "Precio < " + filtro;
                                break;
                            default:
                                consulta += "Precio = " + filtro;
                                break;
                        }
                        break;
                    case "Categoria":
                    default:
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "C.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "C.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "C.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                }
                
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                SqlDataReader lector = datos.Lector;
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    if (!(lector["ImagenUrl"] is DBNull))
                        aux.Imagen = (string)lector["ImagenUrl"];
                    aux.Precio = (decimal)lector["Precio"];

                    listaFiltrada.Add(aux);
                }
                return listaFiltrada;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
