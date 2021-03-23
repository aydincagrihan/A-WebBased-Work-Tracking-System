using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.DTO.DTOs.GorevDtos;

namespace YSKProje.ToDo.Business.ValidationRules.FluentValidation
{
    public class GorevAddValidator : AbstractValidator<GorevAddDto>
    {

        public GorevAddValidator()
        {
            RuleFor(I => I.Ad).NotNull().WithMessage("Ad alanı gereklidir");
            RuleFor(I => I.AciliyetId).ExclusiveBetween(0, int.MaxValue).WithMessage("Lütfen bir aciliyet durumu seçiniz");
        }
    }
}
