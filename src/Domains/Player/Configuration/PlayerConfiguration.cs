namespace Domains.Player
{
    using Common;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PlayerConfiguration : BaseEntityconfiguration<Player>
    {
        public override void Configure(EntityTypeBuilder<Player> builder)
        {
			builder.HasOne(p => p.Team).WithOne();
        }
    }
}
