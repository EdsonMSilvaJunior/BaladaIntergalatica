using Balada.Domain.Entities;
using FluentValidation;
using System;

namespace Balada.Domain.Validators
{
    public class AlienValidator : AbstractValidator<Alien>
    {
        public AlienValidator()
        {
            RuleFor(x => x.Name)
                .MaximumLength(60).WithMessage("Maximo de caracteries é 60.")
                .NotEmpty().WithMessage("Campo obrigatótio.");
            RuleFor(x => x.DateBirth)
                .LessThan(DateTime.Now).WithMessage("Data de nascimento inválida.")
                .NotEmpty().WithMessage("Campo obrigatório.");
            RuleFor(x => x.Objects)
                .NotEmpty().WithMessage("Campo obrigatório.");
        }
    }
}
