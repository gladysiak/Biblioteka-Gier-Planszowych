using System.ComponentModel.DataAnnotations;

namespace Biblioteka_Gier_Planszowych.Models
{
    public class Uzytkownik
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Proszę wpisz swoje Imię")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Proszę wpisz swoje nazwisko")]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Proszę wpisz swój login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Proszę wpisać hasło")]
        [DataType(DataType.Password)]
        public string Haslo { get; set; }
        public int Uprawnienia { get; set; }

    }
}
