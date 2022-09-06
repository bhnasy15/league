namespace Domains.Team
{
    using Common;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TeamConfiguration : BaseEntityconfiguration<Team>
    {
        public override void Configure(EntityTypeBuilder<Team> builder)
        {
        }
    }
}
