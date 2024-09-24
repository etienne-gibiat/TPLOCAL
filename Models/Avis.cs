using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class Avis
    {
        public int Id { get; set; }


        [Required]
        public string? Nom { get; set; }


        [Required]
        public string? Prenom { get; set; }

        [Required]
        public string? Sexe { get; set; }

        [Required]
        public string? Adresse { get; set; }

        [RegularExpression(@"\d{2}[ ]?\d{3}")]
        [Display(Name = "Code postal")]
        [Required]
        public int? CodePostal { get; set; }


        [Required]
        public string? Ville { get; set; }


        [DataType(DataType.EmailAddress)]
        [Display(Name = "Adresse email")]
        [Required]
        public string? Email { get; set; }

        [Range(typeof(DateTime), "1/1/1966", "31/12/2020")]
        [DataType(DataType.Date)]
        [Display(Name = "Date début formation")]
        [Required]
        public DateTime DateFormation { get; set; }

        [Display(Name = "Formation suivie")]
        [Required]
        public string? Formation { get; set; }

        [Display(Name = "Formation cobol")]
        [Required]
        public string? AvisCobol{ get; set; }

        [Display(Name = "Formation c#")]
        [Required]
        public string? AvisCsharp { get; set; }

    }
}
