using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAzure.Models
{
    public class ModeloDepartamentos
    {
        ContextoDepartamentos contexto;

        public ModeloDepartamentos()
        {
            this.contexto = new ContextoDepartamentos();
        }

        public List<DEPT> GetDepartamentos()
        {
            var consulta = from datos in contexto.DEPT
                           select datos;
            return consulta.ToList();
        }
    }
}