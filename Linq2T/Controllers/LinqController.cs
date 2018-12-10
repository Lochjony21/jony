using Linq2T.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Linq2T.Controllers
{
    public class LinqController : Controller
    {
        Studiante db = new Studiante();
        // GET: Linq
        public ActionResult Index()
        {
            var listado = db.lista();
   
            return View(listado.ToList());
        }
        [ HttpPost]
        public ActionResult Index(string txtbuscar, string select)
        {

            var listado = db.lista();
            string formato = txtbuscar.Trim();
            var query = from a in db.lista() select a;

           // usando select
            if (txtbuscar != "")
            {
                if (select =="1")
                {
                    query = from n in db.lista() where n.Nombre.Contains(formato) select n;
                }
                if (select == "2")
                {
                    query = from n in db.lista() where n.Materia.Contains(formato) select n;
                }
                if (select == "3")
                {
                    double prom = Convert.ToDouble(formato);
                    query = from n in db.lista() where n.Promedio == prom select n;
                }

            }
        

            //usando  radio button

            {
                if (select == "1")
                {
                    query = from n in db.lista() where n.Nombre.Contains(formato) select n;
                }
                if (select == "2")
                {
                    query = from n in db.lista() where n.Materia.Contains(formato) select n;
                }
                if (select == "3")
                {
                    double prom = Convert.ToDouble(formato);
                    query = from n in db.lista() where n.Promedio == prom select n;
                }

            }
        

            // var query = from n in listado where n.Materia.Contains(txtbuscar)  select n;

            return View(query.ToList());
        }
      
        // List<string> materias = new List<string>()
        //{
        //  "matematica", "algoritmo", "MVC bassico", "histria del internet", "use tools", "linq"
        //};
        //var query = from n in materias where n.Contains("M") select n;
        //return View(query.ToList());

    }
        
    
}