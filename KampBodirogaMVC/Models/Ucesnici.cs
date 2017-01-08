using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KampBodirogaMVC.Models
{
    [Table("Ucesnici")]
    public class Ucesnici
    {
        [Key]
        public int Id { get; set; }

        public string ImePrezime { get; set; }
        public DateTime Datum_Rodjenja { get; set; }
        public string Broj_Pasosa { get; set; }
        public string Jmbg { get; set; }
        public string Drzava { get; set; }
        public string Grad { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Klub { get; set; }
        public int Visina { get; set; }
        public int Tezina { get; set; }
        public string Pozicija { get; set; }
        public string Prevoz { get; set; }
        public string Oprema { get; set; }       
        public string Smjena { get; set; }
        public string Napomena { get; set; }
        public DateTime Datum_Unosa { get; set; }
    }
}