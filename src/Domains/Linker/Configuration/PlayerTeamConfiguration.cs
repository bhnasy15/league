namespace Domains.Linker
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PlayerTeamConfiguration : IEntityTypeConfiguration<PlayerTeam>
    {
        public void Configure(EntityTypeBuilder<PlayerTeam> builder)
        {
			builder.HasKey(pt => pt.PlayerId);
        }
    }
}

