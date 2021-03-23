using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Entities.Interfaces;

namespace YSKProje.ToDo.Business.Interfaces
{
    public interface IGenericService<Tablo> where Tablo : class, ITablo, new()
    {
        void Kaydet(Tablo tablo);
        void Sil(Tablo tablo);
        void Guncelle(Tablo tablo);
        Tablo GetirIdile(int id);
        List<Tablo> GetirHepsi();
    }
}
