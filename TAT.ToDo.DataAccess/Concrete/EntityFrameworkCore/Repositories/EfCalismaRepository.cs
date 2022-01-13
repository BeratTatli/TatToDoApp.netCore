using System;
using System.Collections.Generic;
using TAT.ToDo.DataAccess.Interfaces;
using TAT.ToDo.Entities.Concrete;

namespace TAT.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCalismaRepository : ICalismaDal
    {
        public void Kaydet(Calisma tablo)
        {
            throw new NotImplementedException();
        }

        public void Sil(Calisma tablo)
        {
            throw new NotImplementedException();
        }

        public void Güncelle(Calisma tablo)
        {
            throw new NotImplementedException();
        }

        public Calisma GetirIdile(int id)
        {
            throw new NotImplementedException();
        }

        public List<Calisma> GetirHepsi()
        {
            throw new NotImplementedException();
        }
    }
}
