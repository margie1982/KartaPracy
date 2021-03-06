﻿using System;

namespace KartaPracy.Dtos
{
    using System.ComponentModel.DataAnnotations;
    using Models;
    using Repozytorium.Models;

    public class SklepDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nazwa { get; set; }


        [Display(Name = "Kontakt do sklepu ")]
        public Kontakt Kontakt { get; set; }

        [Display(Name = "Właściciel/osoba do kontaktu")]
        public byte KontaktId { get; set; }


        public FormatSklepu FormatSklepu { get; set; }
        [Display(Name = "Proponowana umowa")]
        public byte FormatSklepuId { get; set; }


        public string Nip { get; set; }

        [Required]
        [Display(Name = "Miejscowość")]
        public string Miejscowosc { get; set; }

        [Required]
        [Display(Name = "Ulica")]
        public string Ulica { get; set; }

        [Display(Name = "Numer lokalu")]
        public string NrLokalu { get; set; }

        [Display(Name = "Kod pocztowy")]
        public string Kod { get; set; }

        public string Uwagi { get; set; }

        [Display(Name = "Czy jest parking")]
        public bool CzyParking { get; set; }

        [Display(Name = "Powierzchnia")]
        public string Powierzchnia { get; set; }


        [Display(Name = "Typ sklepu")]
        public string TypSklepu { get; set; }

        [Display(Name = "Czy jest w sieci?")]
        public bool CzySieciowy { get; set; }

        public DateTime DataUtworzeniaSklepu { get; set; }
    }
}