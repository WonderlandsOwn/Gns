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
            createModel.AvailableRaces = new BLL_Race().GetBasicList();
            createModel.AvailableArchtypes = new BLL_Archtype().GetBasicList();
            return View(createModel);
        }

        // POST: Character/Create
        [HttpPost]
        public ActionResult Create(CharacterCreateModel  createModel)
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
    }
}
