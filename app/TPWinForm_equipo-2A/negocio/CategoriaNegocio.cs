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
        public List<Categoria> Listar()
        {
			List<Categoria> lista = new List<Categoria>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("select id, descripcion from CATEGORIAS");
				datos.ejecutarLectura();
				while (datos.Lector.Read())
				{
					Categoria cat = new Categoria();
					cat.ID = (int) datos.Lector["id"];
					cat.Descripcion = (string) datos.Lector["Descripcion"];
                    lista.Add(cat);
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
