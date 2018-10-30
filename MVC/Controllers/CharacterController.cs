using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace MVC.Controllers
{
    public class CharacterController : Controller
    {
        // GET: Character
        public ActionResult Index(int id)
        {
            CharacterIndexModel indexModel = new CharacterIndexModel()
            {
                PlayerId = id,
                CharacterIndex = new BLL_Character().GetCharacterIndex(id)
            };
            return View(indexModel);
        }
        
        // GET: Character/Create
        public ActionResult Create(int id)
        {
            CharacterCreateModel createModel = new CharacterCreateModel();
            createModel.PlayerId = id;
            return View(createModel);
        }

        // POST: Character/Create
        [HttpPost]
        public ActionResult Create(CharacterCreateModel collection)
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

        // GET: Character/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Character/Edit/5
        [HttpPost]
        public ActionResult Edit(CharacterEditModel editModel)
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

        // GET: Character/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Character/Delete/5
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
