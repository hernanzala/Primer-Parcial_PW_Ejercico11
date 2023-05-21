using Microsoft.AspNetCore.Mvc;
using ParcialUnoWebApi.Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaAppi.Controllers
{
    [ApiController]
    [Route("api/productos")]
    public class ProductosController
    {
        public List<Mproductos> Datos = new List<Mproductos>()
        { //COLECCION DE OBJETOS EN MEMORIA CREADO EN UNA LISTA
            new Mproductos()
            {
                id = 1,
                descripcion = "Coleccion de ",
                precio = 3939,

            },

            new Mproductos()
            {
                id = 2,
                descripcion = "objetos",
                precio = 3838,

            },

            new Mproductos()
            {
                id = 3,
                descripcion = "en memoria",
                precio = 3737,

            },
        };

        [HttpGet] //METODO GET
        public async Task<ActionResult<List<Mproductos>>> Get()
        {
            return Datos.ToList();
        }
    }
}


            


        

