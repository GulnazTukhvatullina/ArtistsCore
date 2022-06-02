﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtistsCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArtistsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaintController : ControllerBase
    {
        // GET: api/<ArtistsController>
        [HttpGet]
        public IEnumerable<Painting_artist> GetPaint()
        {
            return DataAccess.GetPaint();
        }

        // GET api/<ArtistsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
