using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAT.ToDo.Entities.Interfaces;

namespace TAT.ToDo.Entities.Concrete
{
    public class Calisma : ITablo
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; } 
        public DateTime OlusturulmaTarih { get; set; }
        public int KullanıcıId { get; set; }
        public Kullanici Kullanici { get; set; }



    }
}
