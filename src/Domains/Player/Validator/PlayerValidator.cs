namespace Domains.Player
{
	using Common;
    using FluentValidation;

    public class PlayerValidator : BaseValidator<PlayerViewModel>
    {
        public PlayerValidator()
        {
			RuleFor(p => p.number).NotEmpty().WithMessage("Player Number can't be empty"); 
        }
    }
}
