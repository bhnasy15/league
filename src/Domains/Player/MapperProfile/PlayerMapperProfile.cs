namespace Domains.Player
{
    using AutoMapper;

    public class PlayerMapperProfile : Profile
    {
        public PlayerMapperProfile()
        {
            CreateMap<Player, PlayerViewModel>().ReverseMap();
        }
    }
}

