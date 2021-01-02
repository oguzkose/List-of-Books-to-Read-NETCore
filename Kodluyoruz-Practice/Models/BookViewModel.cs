using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kodluyoruz_Practice.Models
{
    public class BookViewModel
    {
        [Required (ErrorMessage = "Bu alan boş bırakılamaz")]
        [Range(0, int.MaxValue, ErrorMessage = "aralık dışında değer girdiniz!! Lütfen 0 ile 2147483647 arasında bir değer giriniz")]
        public int Id { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [StringLength(30, ErrorMessage = "Max 30 karakter girebilirsiniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [StringLength(30, ErrorMessage = "Max 30 karakter girebilirsiniz")]  
        public string Author { get; set; }


        public string Publisher { get; set; }


    }
}
