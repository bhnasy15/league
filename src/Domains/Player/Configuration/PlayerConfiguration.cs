namespace Domains.Player
{
    using Common;
	using Domains.Linker;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PlayerConfiguration : BaseEntityconfiguration<Player>
    {
        public override void Configure(EntityTypeBuilder<Player> builder)
        {
			builder.HasOne<PlayerTeam>(p => p.team);
        }
    }
}
