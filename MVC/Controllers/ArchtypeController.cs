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
            List<ArchtypeIndexRowModel> indexModel = new List<ArchtypeIndexRowModel>();
            indexModel.AddRange(new BLL_Archtype().GetCompleteArchtypeIndex());
            return View(indexModel);
        }

        public ActionResult Create(int? id)
        {
            List<ListPair> availableRanks = new BLL_Archtype().GetAvailableRanks();
            return View(
                new ArchtypeCreateModel()
                {
                    ArchtypeRankId = id ?? availableRanks[0].Id,
                    AvailableRanks = availableRanks
                });
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

        public ActionResult Details(int id)
        {
            ArchtypeDetailModel detailModel = new BLL_Archtype().GetArchtypeDetails(id);

            return View(detailModel);
        }
        //// GET: Archtype/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View("Error");
        //}

        //// POST: Archtype/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Error");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
