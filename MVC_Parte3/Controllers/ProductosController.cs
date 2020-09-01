using MVC_Parte3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Parte3.Controllers
{
    public class ProductosController : Controller
    {
        List<ClsDatos> producto = new List<ClsDatos>();
        public ProductosController()
        {
            ClsDatos obj = new ClsDatos();
            obj.descripcion = "Manzana";
            obj.cantidad = 10;
            obj.precio = 0.50m;
            producto.Add(obj);

            ClsDatos obj1 = new ClsDatos();
            obj1.descripcion = "Banana";
            obj1.cantidad = 15;
            obj1.precio = 0.80m;
            producto.Add(obj1);
        }
        // GET: Productos
        public ViewResult MostrarProductos(int id)//sub clase de actionresult
        {
            ClsDatos obj = producto[id];
            return View(obj);
        }
    }
}