// Controllers/GymClassesController.cs

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using fitflexBackend.Models;
using fitflexBackend.Models;
using fitflexBackend.Data;
using Microsoft.AspNetCore.Authorization;

namespace fitflexBackend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class GymClassesController : ControllerBase
    {
        private readonly FitFlexDbContext _context;

        public GymClassesController(FitFlexDbContext context)
        {
            _context = context;
        }
        private static List<GymClass> _gymClasses = new List<GymClass>
        {
            new GymClass { Id = 1, Name = "Yoga", StartTime = DateTime.Parse("2023-09-01 10:00 AM") },
            // Add more sample data
        };

        [HttpGet]
        public ActionResult<IEnumerable<GymClass>> Get()
        {
            return Ok(_gymClasses);
        }

        // Add more CRUD actions as needed (POST, PUT, DELETE)
    }
}
