using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select a.id, a.Codigo, a.Nombre, a.Descripcion, a.Precio, a.IdMarca, m.Descripcion as marcaDescripcion, a.IdCategoria, c.Descripcion as categoriaDescripcion from ARTICULOS as a join CATEGORIAS c on (c.id = a.IdCategoria) join MARCAS m on (m.id=a.IdMarca)");    
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    int IdArticulo = (int)datos.Lector["id"];
                    Articulo articulo = new Articulo();

                    articulo.ID = IdArticulo;
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.Precio = (float)(decimal)datos.Lector["Precio"];
                    articulo.Marca = new Marca
                    {
                        ID = (int)datos.Lector["IdMarca"],
                        Descripcion = (string)datos.Lector["marcaDescripcion"]
                    };
                    articulo.Categoria = new Categoria
                    {
                        ID = (int)datos.Lector["IdCategoria"],
                        Descripcion = (string)datos.Lector["categoriaDescripcion"]
                    };
                    articulo.Imagenes = new List<Imagen>();
                    articulo.Imagenes = GetImagenesByArticuloId(IdArticulo);
                    lista.Add(articulo);
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
        public List<Imagen> GetImagenesByArticuloId(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Imagen> lista = new List<Imagen>();
            try
            {
                datos.setearConsulta("select Id, ImagenUrl from IMAGENES where IdArticulo = @IdArticulo");
                datos.setearParametro("@IdArticulo", id);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Imagen imagen = new Imagen
                    {
                        ID = (int)datos.Lector["Id"],
                        IdArticulo = id,
                        ImagenUrl = (string)datos.Lector["ImagenUrl"]
                    };
                    lista.Add(imagen);
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
    }
}
