using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
namespace MVC.Controllers
{
    public class ArchtypeController : Controller
    {
        // GET: Archtype
        public ActionResult Index()
        {
            List<ArchtypeIndexModel> indexModel = new List<ArchtypeIndexModel>();
            indexModel.AddRange(new BLL_Archtype().GetCompleteArchtypeIndex());
            return View(indexModel);
        }

        // GET: Archtype/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Archtype/Create
        [HttpPost]
        public ActionResult Create(ArchtypeCreateModel createModel)
        {
            try
            {
                new BLL_Archtype().CreateArchtype(createModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Archtype/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Archtype/Edit/5
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
    }
}
