namespace Domains.Team
{
	using Common;
    public class TeamUnitOfWork : BaseUnitOfWork<Team>, ITeamUnitOfWork
    {
        public TeamUnitOfWork(ITeamRepository teamRepository) : base(teamRepository)
        {
        }
    }
}
