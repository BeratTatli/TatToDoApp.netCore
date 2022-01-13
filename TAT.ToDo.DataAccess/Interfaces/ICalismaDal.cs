using System.Collections.Generic;
using TAT.ToDo.Entities.Concrete;

namespace TAT.ToDo.DataAccess.Interfaces
{
    public interface ICalismaDal
    {
        void Kaydet(Calisma tablo);
        void Sil(Calisma tablo);
        void Güncelle(Calisma tablo);
        Calisma GetirIdile(int id);
        List<Calisma> GetirHepsi();


    }
}
