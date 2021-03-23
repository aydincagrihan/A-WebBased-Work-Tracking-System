using System;
using System.Collections.Generic;
using System.Text;

namespace YSKProje.ToDo.DTO.DTOs.AppUserDtos
{
    public class AppUserListDto
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "Ad alanı boş geçilemez")]
        //[Display(Name = "Ad :")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Soyad alanı boş geçilemez")]
        //[Display(Name = "Soyad :")]
        public string SurName { get; set; }

        //[Display(Name = "Email :")]
        public string Email { get; set; }
        //[Display(Name = "Resim :")]
        public string Picture { get; set; }
    }
}
