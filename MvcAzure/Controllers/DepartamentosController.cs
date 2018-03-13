using MvcAzure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAzure.Controllers
{
    public class DepartamentosController : Controller
    {
        ModeloDepartamentos modelo;

        public DepartamentosController()
        {
            this.modelo = new ModeloDepartamentos();
        }

        // GET: Departamentos
        public ActionResult Index()
        {
            List<DEPT> lista = modelo.GetDepartamentos();
            return View(lista);
        }
    }
}