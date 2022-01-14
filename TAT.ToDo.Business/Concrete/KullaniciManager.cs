using System;
using System.Collections.Generic;
using System.Text;
using TAT.ToDo.Business.Interfaces;
using TAT.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using TAT.ToDo.DataAccess.Interfaces;
using TAT.ToDo.Entities.Concrete;

namespace TAT.ToDo.Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {

        private readonly EfKullaniciRepository efKullaniciRepository;

        public KullaniciManager()
        {
            efKullaniciRepository = new EfKullaniciRepository();
        }
        public void Kaydet(Kullanici tablo)
        {
            efKullaniciRepository.Kaydet(tablo);
        }

        public void Sil(Kullanici tablo)
        {
            efKullaniciRepository.Sil(tablo);
        }

        public void Güncelle(Kullanici tablo)
        {
            efKullaniciRepository.Güncelle(tablo);
        }

        public Kullanici GetirIdile(int id)
        {
            return efKullaniciRepository.GetirIdile(id);
        }

        public List<Kullanici> GetirHepsi()
        {
            return efKullaniciRepository.GetirHepsi();
        }
    }
}
