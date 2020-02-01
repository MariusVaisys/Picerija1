using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Picerija.Models
{
    public class Uzsakymas
    {
        public int UzsakymasId { get; set; }
        public List<UzsakymoInfo> UzsakymoInfos { get; set; }

        [Required(ErrorMessage ="Prasome irasyti varda")]
        [Display(Name="Vardas")]
        [StringLength(50)]
        public string Vardas { get; set; }

        [Required(ErrorMessage = "Prasome irasyti adresa")]
        [Display(Name = "Adresas")]
        [StringLength(150)]
        public string Adresas { get; set; }

        [Required(ErrorMessage = "Prasome irasyti telefono numeri")]
        [Display(Name = "Telefono numeris")]
        [StringLength(12)]
        [DataType(DataType.PhoneNumber)]
        public string TelefonoNumeris  { get; set; }

        [Required(ErrorMessage = "Prasome irasyti el pasto adresa")]
        [Display(Name = "Email")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal PilnasUzsakymas { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime UzsakytaLaikas { get; set; }
    }
}
