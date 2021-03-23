using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.DTO.DTOs.RaporDtos;

namespace YSKProje.ToDo.Business.ValidationRules.FluentValidation
{
    public class RaporUpdateValidator : AbstractValidator<RaporUpdateDto>
    {
        public RaporUpdateValidator()
        {
            RuleFor(I => I.Tanim).NotNull().WithMessage("Tanım alanı boş geçilemez");
            RuleFor(I => I.Detay).NotNull().WithMessage("Detay alanı boş geçilemez");
        }
    }
}
