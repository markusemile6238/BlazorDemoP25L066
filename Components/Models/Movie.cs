using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemoP25L066.Components.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le titre est obligatoire")]
        [StringLength(50, ErrorMessage = "Maximum 50 caractères")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Le genre est obligatoire")]
        public string Genre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Le réalisateur est obligatoire")]
        public string Director { get; set; } = string.Empty;

        public Collection<Actor> Cast { get; set; }

        [Range(1900, 2100, ErrorMessage = "Année invalide")]
        public int Year { get; set; } = new();

        [Required(ErrorMessage = "L'image (Fanart) est obligatoire")]
        [Url(ErrorMessage = "URL invalide")]
        public string Fanart { get; set; } = string.Empty;
        public string? BackArt { get; set; } = string.Empty;

        public bool Favorit { get; set; } = false;
    }
}
