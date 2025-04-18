using System;
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
                    Articulo articulo = new Articulo
                    {
                        ID = (int)datos.Lector["id"],
                        Codigo = (string)datos.Lector["Codigo"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        Precio = (float)datos.Lector["Precio"],
                        Marca = new Marca
                        {
                            ID = (int)datos.Lector["IdMarca"],
                            Descripcion = (string)datos.Lector["marcaDescripcion"]
                        },
                        //Objeto Categoria
                        Categoria = new Categoria
                        {
                            ID = (int)datos.Lector["IdCategoria"],
                            Descripcion = (string)datos.Lector["categoriaDescripcion"]
                        },
                        //Objeto Imagen
                        Imagenes = new List<Imagen>()
                        //Aca consultar a muchas imagenes
                    };

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
    }
}
