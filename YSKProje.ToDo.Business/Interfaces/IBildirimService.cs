using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Interfaces
{
    public interface IBildirimService : IGenericService<Bildirim>
    {
        List<Bildirim> GetirOkunmayanlar(int AppUserId);
        int GetirOkunmayanSayisiileAppUserId(int AppUserId);
    }
}
