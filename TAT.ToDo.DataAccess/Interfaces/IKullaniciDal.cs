using System.Collections.Generic;
using TAT.ToDo.Entities.Concrete;

namespace TAT.ToDo.DataAccess.Interfaces
{
    public interface IKullaniciDal
    {
        void Kaydet(Kullanici tablo);
        void Sil(Kullanici tablo);
        void Güncelle(Kullanici tablo);
        Calisma GetirIdile(int id);
        List<Calisma> GetirHepsi();
    }
}
