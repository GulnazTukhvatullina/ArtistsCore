﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ArtistsCore;

namespace ArtistWeb.Controllers
{
    public class ArttController : Controller
    {
        public IActionResult Index()
        {
            var art = DataAccess.GetArtist();
            return View(art);
        }

        public IActionResult PaintArt()
        {
            var paint = DataAccess.GetPainting_Artists();
            return View(paint);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Artist artist)
        {
            ArtistStorage.Add(artist);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Remove(int ID_artist)
        {
            ArtistStorage.RemoveByName(ID_artist);
            return RedirectToAction("Index");
        }
    }
}
