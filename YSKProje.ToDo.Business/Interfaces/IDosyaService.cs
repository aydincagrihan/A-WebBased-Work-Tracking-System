using System;
using System.Collections.Generic;
using System.Text;

namespace YSKProje.ToDo.Business.Interfaces
{
    public interface IDosyaService
    {
    /// <summary>
        /// Geriye üretmiş ve upload etmiş olduğu pdf dosyasının virtual pathini döner.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        string AktarPdf<T>(List<T> list) where T : class, new();
       /// <summary>
       /// Geriye excel verisini byte dizisi olarak döner.
       /// </summary>
       /// <typeparam name="T"></typeparam>
       /// <param name="list"></param>
       /// <returns></returns>
        byte[] AktarExcel<T>(List<T> list) where T : class, new();
    }
}
