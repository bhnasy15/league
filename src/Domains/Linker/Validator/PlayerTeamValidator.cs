namespace Domains.Linker
{
    using FluentValidation;

    public class PlayerTeamValidator : AbstractValidator<PlayerTeam>
    {
        public PlayerTeamValidator()
        {
			RuleFor( pt => pt.PlayerId).NotEmpty();
			RuleFor( pt => pt.TeamId).NotEmpty();
        }
    }
}
