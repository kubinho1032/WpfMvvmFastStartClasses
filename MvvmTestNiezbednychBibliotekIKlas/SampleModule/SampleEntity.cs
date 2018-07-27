using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarsztatWpf.Infrastructure.DbHelper;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvvmTestNiezbednychBibliotekIKlas.SampleModule
{
    public class SampleEntity : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SampleEntity()
        {
            EntityState = System.Data.EntityState.Unchanged;
        }
        public SampleEntity(bool isnew)
        {
            this.Aktywny = true;
        }

        [Required(ErrorMessage = "Imie jest wymagane")]
        [StringLength(30, ErrorMessage = "Imie nie może być dłuższe niz 30 znaków")]
        [DataType(DataType.Text)]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [StringLength(100, ErrorMessage = "Nazwisko nie może być dłuższe niz 100 znaków")]
        [DataType(DataType.Text)]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Numer telefonu jest wymagany")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Numer telefonu musi zawierać 9 cyfr")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Nr_tel { get; set; }

        [Required]
        public bool Aktywny { get; set; }

        public override string ToString()
        {
            return (Imie + ' ' + Nazwisko).ToString();
        }
    }
}
