using System;
using System.Collections.Generic;
using System.Text;
using TAT.ToDo.Business.Interfaces;
using TAT.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using TAT.ToDo.Entities.Concrete;

namespace TAT.ToDo.Business.Concrete
{
    public class CalismaManager : ICalismaService
    {
        private readonly EfCalismaRepository efCalismaRepository;

        public CalismaManager()
        {
            efCalismaRepository = new EfCalismaRepository();
        }
        public void Kaydet(Calisma tablo)
        {
            efCalismaRepository.Kaydet(tablo);
        }

        public void Sil(Calisma tablo)
        {
            efCalismaRepository.Sil(tablo);
        }

        public void Güncelle(Calisma tablo)
        {
            efCalismaRepository.Güncelle(tablo);
        }

        public Calisma GetirIdile(int id)
        {
            return efCalismaRepository.GetirIdile(id);
        }

        public List<Calisma> GetirHepsi()
        {
            return efCalismaRepository.GetirHepsi();
        }
    }
}
