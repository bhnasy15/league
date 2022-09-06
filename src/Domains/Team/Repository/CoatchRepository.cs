namespace Domains.Team
{
	using Common;
    using Microsoft.EntityFrameworkCore;

    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        public TeamRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
