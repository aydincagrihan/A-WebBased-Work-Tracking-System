using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using YSKProje.ToDo.DataAccess.Interfaces;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Concrete
{
    public class RaporManager : IRaporService
    {
        private readonly IRaporDal _raporDal;

        public RaporManager(IRaporDal raporDal)
        {
            _raporDal = raporDal;
        }

        public Rapor GetirGorevileId(int id)
        {
            return _raporDal.GetirGorevileId(id);
        }

        public List<Rapor> GetirHepsi()
        {
            return _raporDal.GetirHepsi();
        }

        public Rapor GetirIdile(int id)
        {
            return _raporDal.GetirIdile(id);
        }

        public int GetirRaporSayisi()
        {
            return _raporDal.GetirRaporSayisi();
        }

        public int GetirRaporSayisiileAppUserId(int id)
        {
            return _raporDal.GetirRaporSayisiileAppUserId(id);
        }

        public void Guncelle(Rapor tablo)
        {
            _raporDal.Guncelle(tablo);
        }

        public void Kaydet(Rapor tablo)
        {
            _raporDal.Kaydet(tablo);
        }

        public void Sil(Rapor tablo)
        {
            _raporDal.Sil(tablo);
        }
    }
}
