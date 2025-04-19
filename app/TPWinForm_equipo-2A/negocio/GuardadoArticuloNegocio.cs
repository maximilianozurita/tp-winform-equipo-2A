using dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class GuardadoArticuloNegocio
    {
        public ArticuloSimple ArticuloSimple {  get; set; }

        public bool Guardar()
        {
            if (this.ArticuloSimple == null) return false;

            AccesoDatos accesoDatos = new AccesoDatos();
            int idForImage;
            try
            {
                string query = @"insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) 
                        values (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @precio);
                        select scope_identity();";

                accesoDatos.setearConsulta(query);
                accesoDatos.setearParametro("@codigo", ArticuloSimple.Code);
                accesoDatos.setearParametro("@nombre", ArticuloSimple.Name);
                accesoDatos.setearParametro("@descripcion", ArticuloSimple.Description);
                accesoDatos.setearParametro("@idMarca", ArticuloSimple.Brand);
                accesoDatos.setearParametro("@idCategoria", ArticuloSimple.Category);
                accesoDatos.setearParametro("@precio", ArticuloSimple.Price);
                accesoDatos.ejecutarLectura();

                if (accesoDatos.Lector.Read())
                {
                    idForImage = Convert.ToInt32(accesoDatos.Lector[0]);
                    if (idForImage > 0)
                        return false;
                    string queryImage = @"insert into imagenes values(IdArticulo,ImagenUrl) values (@idArt,@url)";
                    accesoDatos.setearConsulta(queryImage);
                    accesoDatos.setearParametro("@idArt", idForImage);
                    accesoDatos.setearParametro("@url", ArticuloSimple.ImageUrl);
                    accesoDatos.ejecutarLectura();
                    return true;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

    }
}
