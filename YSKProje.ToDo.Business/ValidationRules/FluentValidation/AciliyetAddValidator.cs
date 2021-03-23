using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.DTO.DTOs.AciliyetDtos;

namespace YSKProje.ToDo.Business.ValidationRules.FluentValidation
{
    public class AciliyetAddValidator : AbstractValidator<AciliyetAddDto>
    {
        public AciliyetAddValidator()
        {
            RuleFor(I => I.Tanim).NotNull().WithMessage("Tanım alanı boş geçilemez");
        }
    }
}
