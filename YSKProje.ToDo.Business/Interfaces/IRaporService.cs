using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Interfaces
{
    public interface IRaporService : IGenericService<Rapor>
    {
        Rapor GetirGorevileId(int id);
        int GetirRaporSayisiileAppUserId(int id);
        int GetirRaporSayisi();
    }
}
