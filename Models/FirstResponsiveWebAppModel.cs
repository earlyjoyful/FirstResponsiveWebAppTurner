using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppTurner.Models
{
    public class FirstResponsiveWebAppModel
    {
        [Required(ErrorMessage = "Please enter your name.")] 
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter your 4-digit birth year.")]
        [Range(1,2024, ErrorMessage = "Please enter a year between 1 and 2024.")] //unsure why this has double arrows for input/increment/decrement
        public int? BirthYear { get; set; }

        public const int THISYEAR = 2024;

        public int? AgeThisYear()
        {
            return (THISYEAR - BirthYear);

        }
    }
}
