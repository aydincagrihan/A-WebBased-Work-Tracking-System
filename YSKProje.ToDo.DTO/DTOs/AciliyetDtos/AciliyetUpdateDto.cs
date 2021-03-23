using System;
using System.Collections.Generic;
using System.Text;

namespace YSKProje.ToDo.DTO.DTOs.AciliyetDtos
{
    public class AciliyetUpdateDto
    {
        public int Id { get; set; }
        //[Display(Name = "Tanım :")]
        //[Required(ErrorMessage = "Tanım alanı gereklidir")]
        public string Tanim { get; set; }
    }
}
