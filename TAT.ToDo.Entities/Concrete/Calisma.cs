using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAT.ToDo.Entities.Interfaces;

namespace TAT.ToDo.Entities.Concrete
{
    public class Calisma : ITablo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Ad { get; set; }
        [Column(TypeName = "ntext")]
        public string Aciklamasi { get; set; }
        public DateTime OlusturulmaTarih { get; set; }

        [ForeignKey("Kullanici")]
        public int KullanıcıId { get; set; }
        public Kullanici Kullanici { get; set; }



    }
}
