using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Formulaarz.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Proszę podaj Imię")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Proszę podaj Nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Proszę podaj Email")]
        [EmailAddress(ErrorMessage = "Proszę podaj prawidłowy adres e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podaj Hasło")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków")]
        [RegularExpression("(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+", ErrorMessage = "Hasło musi zawierać małą i wielką literę oraz cyfrę")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Proszę potwierdzić Hasło")]
        [DataType(DataType.Password)]
        [Compare("Haslo", ErrorMessage = "Hasła nie są takie same")]
        public string PotwierdzenieHasla { get; set; }

        [Phone(ErrorMessage = "Proszę podaj prawidłowy numer telefonu")]
        public string NrTelefonu { get; set; }

        [Range(11, 80, ErrorMessage = "Wiek musi być między 10 a 80")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Proszę wybierz Miasto")]
        public Miasta Miasto { get; set; }
    }

    public enum Miasta
    {
        Warszawa,
        Krakow,
        Wroclaw,
        Gdansk,
        Poznan
    }
}
