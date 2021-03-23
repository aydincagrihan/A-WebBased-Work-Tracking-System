using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.DTO.DTOs.AciliyetDtos;

namespace YSKProje.ToDo.Business.ValidationRules.FluentValidation
{
    public class AciliyetUpdateValidator : AbstractValidator<AciliyetUpdateDto>
    {
        public AciliyetUpdateValidator()
        {
            RuleFor(I => I.Tanim).NotNull().WithMessage("Tanım alanı boş geçilemez");
        }
    }
}
