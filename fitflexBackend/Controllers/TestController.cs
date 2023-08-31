using fitflexBackend.Data;
using fitflexBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace fitflexBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        private readonly FitFlexDbContext _dbContext;

        public TestController(FitFlexDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //[HttpGet]

        //public ActionResult<IEnumerable<GymClass>> TestConnection()
        //{
        //    var count = _dbContext.Users.Count();
        //    return Ok("Connection successful"); // Return a response indicating success
        //}

    }

}
