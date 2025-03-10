using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10_Fitzgerald.Data;

namespace Mission10_Fitzgerald.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private BowlerDbContext _bowlerContext;

        public BowlerController(BowlerDbContext temp)
        {
            _bowlerContext = temp;
        }

        [HttpGet(Name = "GetBowler")]
        public IEnumerable<Bowler> Get()
        {
            var bowlerList = _bowlerContext.Bowlers
                .Include(x => x.Team)
                .Where(x => x.Team.TeamName == "Marlins" || x.Team.TeamName == "Sharks")
                .ToList();

            return bowlerList;
        }
    }
}
