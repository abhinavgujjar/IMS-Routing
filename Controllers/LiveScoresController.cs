using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public class LiveScoresController : Controller
    {
        //
        // GET: /LiveScores/

        public string Index()
        {
            return "Livescores index";
        }

        //
        // GET: /LiveScores/Details/5

        public string Details(string country, int over)
        {
            if (country == "India")
            {
                if (over == 40)
                    return "234/6";
            }

            if (country == "Pakistan")
            {
                if (over == 20)
                    return "35/7";
            }

            return "Aww.. snap";
        }

        //
        // GET: /LiveScores/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /LiveScores/Create

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
        // GET: /LiveScores/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /LiveScores/Edit/5

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
        // GET: /LiveScores/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /LiveScores/Delete/5

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
