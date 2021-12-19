using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Person.Controllers.API
{
    public class PersonController : Controller
    {
        // GET: Person
        [EnableCors("*,*,*,*")]
        public ActionResult Index()
        {
            Person person1 = new Person("tikva", "yosef", 25, "tikva@gmail.com");

            return View(person1);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

       
        [HttpPost]
        // POST: Person/Create
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

   
        // POST: Person/Edit/5
        [HttpPut]
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


        [HttpDelete]
        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

      
    }
}
