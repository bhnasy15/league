namespace Domains.Team
{
    using AutoMapper;

    public class TeamMapperProfile : Profile
    {
        public TeamMapperProfile()
        {
            CreateMap<Team, TeamViewModel>().ReverseMap();
        }
    }
}

