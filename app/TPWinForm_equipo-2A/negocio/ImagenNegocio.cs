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
        public List<Imagen> ListarByArticuloId(int id)
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
