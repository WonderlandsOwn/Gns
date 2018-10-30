using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
namespace MVC.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult Index()
        {
            List<PlayerIndexModel> indexModel = new List<PlayerIndexModel>();
            indexModel.AddRange(new BLL_Player().GetAllPlayers());
            return View(indexModel);
        }

        // GET: Player/Create
        public ActionResult Create()
        {            
            return View();
        }

        // POST: Player/Create
        [HttpPost]
        public ActionResult Create(PlayerCreateModel createModel)
        {
            try
            {
                new BLL_Player().CreatePlayer(createModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Player/Edit/5
        public ActionResult Edit(int id)
        {
            PlayerEditModel editModel = new BLL_Player().GetPlayerForEdit(id);

            return View(editModel);
        }

        // POST: Player/Edit/5
        [HttpPost]
        public ActionResult Edit(PlayerEditModel editModel)
        {
            try
            {
                new BLL_Player().EditPlayer(editModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //// GET: Player/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Player/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
