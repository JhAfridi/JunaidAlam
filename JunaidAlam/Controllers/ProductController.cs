using JunaidAlam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace JunaidAlam.Controllers
{
    public class ProductController : Controller
    {

        private ContxtDb db = null;

        public ProductController()
        {
            db = new ContxtDb();
        }

        public ActionResult Index(string srhtxt)
        {
            if (srhtxt != null)
            {
                Session["txt"] = srhtxt.ToString();
                return View(db.Products.Where(x => x.P_Name.StartsWith(srhtxt)).ToList());
            }
            else
            {
                return View(db.Products.ToList());
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index","Product");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            if (id > 0)
            {
                return View(db.Products.Find(id));
            }

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Product p)
        {
            if (ModelState.IsValid)
            {
                db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                var data = db.Products.Find(id);
                if (data != null)
                {
                    db.Products.Remove(data);
                    db.SaveChanges();
                    return RedirectToAction("Index","Product");
                }
            }

            return View();
        }


        public ActionResult Details(int id)
        {
            var data = db.Products.Find(id);
            return View(data);
        }
    }
}