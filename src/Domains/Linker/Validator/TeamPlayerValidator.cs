using FluentValidation;

namespace Domains.Linker
{
    public class TeamPlayerValidator : AbstractValidator<TeamPlayer>
    {
        public TeamPlayerValidator()
        {
			RuleFor(p => p.PlayerId).NotEmpty();
			RuleFor(p => p.TeamId).NotEmpty();
        }
    }
}
