using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.DTO.DTOs.GorevDtos
{
    public class GorevListAllDto
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturulmaTarih { get; set; }
        public Aciliyet Aciliyet { get; set; }
        public AppUser AppUser { get; set; }
        public List<Rapor> Raporlar { get; set; }
    }
}
