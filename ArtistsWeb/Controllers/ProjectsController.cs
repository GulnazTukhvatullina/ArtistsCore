using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ArtistsCore;

namespace ArtistsWeb.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            var artists = ArtistStorage.art;
            return View(artists);
        }
    }
}
