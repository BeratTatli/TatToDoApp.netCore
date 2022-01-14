using System;
using System.Collections.Generic;
using System.Text;
using TAT.ToDo.Entities.Interfaces;

namespace TAT.ToDo.Business.Interfaces
{
    public interface IGenericService<Tablo> where Tablo:class,ITablo,new()
    {
        void Kaydet(Tablo tablo);
        void Sil(Tablo tablo);
        void Güncelle(Tablo tablo);
        Tablo GetirIdile(int id);
        List<Tablo> GetirHepsi();
    }
}
