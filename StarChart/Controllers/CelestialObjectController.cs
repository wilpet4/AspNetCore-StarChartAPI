﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
