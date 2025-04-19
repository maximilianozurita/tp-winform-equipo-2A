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
                datos.setearConsulta("select a.id, a.Codigo, a.Nombre, a.Descripcion, a.Precio, a.IdMarca, m.Descripcion as marcaDescripcion, a.IdCategoria, c.Descripcion as categoriaDescripcion from ARTICULOS as a left join CATEGORIAS c on (c.id = a.IdCategoria) left join MARCAS m on (m.id=a.IdMarca)");    
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
                        ID = datos.Lector["IdMarca"] != DBNull.Value ? (int)datos.Lector["IdMarca"] : 0,
                        Descripcion = datos.Lector["marcaDescripcion"] != DBNull.Value ? (string)datos.Lector["marcaDescripcion"] : ""
                    };
                    articulo.Categoria = new Categoria
                    {
                        ID = datos.Lector["IdCategoria"] != DBNull.Value ? (int)datos.Lector["IdCategoria"] : 0,
                        Descripcion = datos.Lector["categoriaDescripcion"] != DBNull.Value ? (string)datos.Lector["categoriaDescripcion"] : ""
                    };
                    articulo.Imagenes = new List<Imagen>();
                    ImagenNegocio imgNegocio = new ImagenNegocio();
                    articulo.Imagenes = imgNegocio.ListarByArticuloId(IdArticulo);
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
