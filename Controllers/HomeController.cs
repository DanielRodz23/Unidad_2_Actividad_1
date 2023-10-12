using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;
using Unidad_2_Actividad_1.Models.Entities;
using Unidad_2_Actividad_1.Models.ViewModels;

namespace Unidad_2_Actividad_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            AnimalesContext context = new AnimalesContext();
            var datos = context.Clase.Select(x => new IndexViewModel() 
            {
                Id = x.Id,
                Nombre=x.Nombre??"Sin nombre",
                Descripcion=x.Descripcion??"Sin descripcion"
            });
            return View(datos);

        }
        public IActionResult Especies(string id)
        {
            id = id.Replace("-", " ");
            AnimalesContext context = new();
            var datos=context.Clase.Where(x=>x.Nombre==id).Select(x=>new EspeciesViewModel()
            {
                Id=x.Id,
                Nombre=x.Nombre??"Sin nombre"
            }).FirstOrDefault();
            var proye = context.Especies.Where(x => x.IdClase == datos.Id).Select(x => new EspecieModel()
            {
                Id= x.Id,
                Nombre=x.Especie
            });
            datos.Especies = proye;
            return View(datos);
        }
        public IActionResult Especie(string id)
        {
            id = id.Replace("-", " ");
            AnimalesContext context = new();
            var datos = context.Especies.Where(x => x.Especie == id).Include(x=>x.IdClaseNavigation).Select(x=>
            new EspecieViewModel()
            {
                Id=x.Id,
                Nombre=x.Especie,
                IdClase=(int)x.IdClase,
                NombreClase=x.IdClaseNavigation!=null?x.IdClaseNavigation.Nombre: "Sin clase",
                Peso = (double)x.Peso,
                Tamano=(int)x.Tamaño,
                Habitat=x.Habitat,
                Descripcion=x.Observaciones??"Sin descripcion"
            }).FirstOrDefault();
            return View(datos);
        }
    }
}
