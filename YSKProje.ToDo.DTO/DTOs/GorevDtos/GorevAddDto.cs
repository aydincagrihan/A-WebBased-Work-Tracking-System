using System;
using System.Collections.Generic;
using System.Text;

namespace YSKProje.ToDo.DTO.DTOs.GorevDtos
{
    public class GorevAddDto
    {
        //[Required(ErrorMessage = "Ad alanı gereklidir")]
        public string Ad { get; set; }

        public string Aciklama { get; set; }
        //[Range(0, int.MaxValue, ErrorMessage = "Lütfen bir aciliyet durumu seçiniz")]
        public int AciliyetId { get; set; }
    }
}
