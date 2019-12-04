using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        public string YourName { get; set; }
        [Required]
        public string DojoLocation{ get; set;}
        [Required]
        public string FavoriteLanguage { get; set; }
        [Required]
        [MaxLength(35)]
        public string Comment { get; set; }
    }
}