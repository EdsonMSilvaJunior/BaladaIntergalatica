using Balada.Domain.Entities;
using FluentValidation;

namespace Balada.Domain.Validators
{
    class EstabelecimentoValidator : AbstractValidator<Estabelecimento>
    {
        public EstabelecimentoValidator()
        {
            RuleFor(x => x.Name)
                .MaximumLength(60).WithMessage("Maximo de caracteries é 60.")
                .NotEmpty().WithMessage("Campo obrigatório.");
            RuleFor(x => x.RestrictedObjects)
                .NotEmpty().WithMessage("Campo obrigatório.");
            RuleFor(x => x.BannedList)
                .NotEmpty().WithMessage("Campo obrigatório.");
        }

    }
}
