using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServiceEjemplo.Models;

namespace WebServiceEjemplo.Controllers
{
    public class ProductoController : ApiController
    {
        ModeloDB db = new ModeloDB();

        [ActionName("Obtener")]
        [HttpGet]
        public IHttpActionResult ObtenerTodo()
        {

            try
            {
                var consulta = from Producto in db.Productos
                               select new ProductoDTO
                               {
                                   ID = Producto.ID,
                                   Nombre = Producto.Nombre,
                                   Precio = Producto.Precio,
                                   CantidadStock = Producto.CantidadStock,
                                   CantidadVendido = Producto.CantidadVendido
                               };
                return Ok(consulta);
            }
            catch (Exception)
            {
                return InternalServerError();
            }


        }
    }
}
