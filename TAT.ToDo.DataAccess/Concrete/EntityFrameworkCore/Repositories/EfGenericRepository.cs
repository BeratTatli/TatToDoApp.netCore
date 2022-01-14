using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TAT.ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using TAT.ToDo.DataAccess.Interfaces;
using TAT.ToDo.Entities.Concrete;
using TAT.ToDo.Entities.Interfaces;

namespace TAT.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<Tablo>:IGenericDal<Tablo>
    where Tablo:class,ITablo,new()
    {
        public void Kaydet(Tablo tablo)
        {
            using var context = new ToDoContext();
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();
        }

        public void Sil(Tablo tablo)
        {
            using var context = new ToDoContext();
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();
        }

        public void Güncelle(Tablo tablo)
        {
            using var context = new ToDoContext();
            context.Set<Tablo>().Update(tablo);
            //context.Entry(tablo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public Tablo GetirIdile(int id)
        {
            using var context = new ToDoContext();
            return context.Set<Tablo>().Find(id);
        }

        public List<Tablo> GetirHepsi()
        {
            using var context = new ToDoContext();
            return context.Set<Tablo>().ToList();
        }
    }
}
