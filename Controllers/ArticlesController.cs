using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public class ArticlesController : Controller
    {
        //
        // GET: /Articles/

        public string Index()
        {
            return "Home";
        }

        //
        // GET: /Articles/Details/5

        public int Details(int id)
        {
            return id;
        }

        public string ByAuthor(string author)
        {
            if (author == "Scott")
            {
                return "A,B,C";
            }


            return "oops";
        }

        //
        // GET: /Articles/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Articles/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Articles/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Articles/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Articles/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Articles/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
