using System;
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


    }
}
