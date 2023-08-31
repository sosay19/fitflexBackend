using fitflexBackend.Data;
using fitflexBackend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fitflexBackend.Controllers
{

    // Controllers/MembersController.cs
    [Route("api/[controller]")]
    //[Authorize]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly FitFlexDbContext _dbContext;

        public MembersController(FitFlexDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Member>>> GetMembers()
        {
            return await _dbContext.Members.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Member>> CreateMember(Member member)
        {
            _dbContext.Members.Add(member);
            await _dbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMembers), new { id = member.Id }, member);
        }

        // Add more CRUD actions as needed
    }
}
