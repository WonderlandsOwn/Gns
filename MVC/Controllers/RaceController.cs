using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;
namespace MVC.Controllers
{
    public class RaceController : Controller
    {
        // GET: Race
        public ActionResult Index()
        {
            List<RaceIndexModel> indexModel = new List<RaceIndexModel>();
            indexModel.AddRange(new BLL_Race().GetCompleteRaceIndex());
            return View(indexModel);
        }
        
        // GET: Race/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Race/Create
        [HttpPost]
        public ActionResult Create(RaceCreateModel createModel)
        {
            try
            {
                new BLL_Race().CreateRace(createModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Race/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Race/Edit/5
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
