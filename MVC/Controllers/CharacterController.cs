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
            createModel.AvailablePrimaryArchtypes = new BLL_Archtype().GetBasicList(1);
            createModel.AvailableSecondaryArchtypes = new BLL_Archtype().GetBasicList(2);
            createModel.AvailableTertiaryArchtypes = new BLL_Archtype().GetBasicList(3);
            return View(createModel);
        }

        // POST: Character/Create
        [HttpPost]
        public ActionResult Create(CharacterCreateModel  createModel)
        {
            try
            {
                new BLL_Character().CreateCharacter(createModel);

                return RedirectToAction("Index", new { Id = createModel.PlayerId });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            CharacterDetailModel detailModel = new BLL_Character().GetCharacterDetails(id);
            return View(detailModel);
        }
        // GET: Character/Edit/5
        public ActionResult Edit(int id)
        {
            return View("Error");
        }

        // POST: Character/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Error");
            }
            catch
            {
                return View();
            }
        }
    }
}
