using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea2_02_09.Models;

namespace Tarea2_02_09.Controllers
{
    public class VistasController : Controller
    {
        private List<Cliente> clientes = new List<Cliente>() {
            new Cliente() {dni = "84029502", nombre = "Jorge Marcos", email = "fnbt@hotmail.com", fono = "999777630"},
            new Cliente() {dni = "34029502", nombre = "Jorge Ñarcos", email = "fngf@hotmail.com", fono = "991117630"},
            new Cliente() {dni = "94029552", nombre = "Forge Oarcos", email = "fgdf@hotmail.com", fono = "991117630"},
            new Cliente() {dni = "64029512", nombre = "Gorge Parcos", email = "xvct@hotmail.com", fono = "999227630"},
            new Cliente() {dni = "84029522", nombre = "Morge Jarcos", email = "fhjt@hotmail.com", fono = "999237630"},
            new Cliente() {dni = "87729503", nombre = "Torge Karcos", email = "fqqt@hotmail.com", fono = "932777630"},
            new Cliente() {dni = "88929504", nombre = "Lorge Larcos", email = "fllt@hotmail.com", fono = "999321630"},
        };

        public ActionResult Listado()
        {
            return View(clientes);
        }

        public ActionResult Buscar(string nombre = "") 
        {
            return View(clientes.Where(
                c => c.nombre.StartsWith(nombre, StringComparison.CurrentCultureIgnoreCase)));
        }
    }
}