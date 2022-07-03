using System.ComponentModel.DataAnnotations;

namespace Biblioteka_Gier_Planszowych.Models
{
    [Serializable]
    public class Gra_Planszowa
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Proszę wpisz nazwę gry planszowej")]
        public string Tytuł { get; set; } = string.Empty;
        public string Wydawca { get; set; } = string.Empty;
        public string Gatunek { get; set; } = string.Empty;

        public string Opis { get; set; } = string.Empty;
        public string Login { get; set; }
        
    }
}
