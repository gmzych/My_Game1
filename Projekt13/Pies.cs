using System;
namespace Projekt13
{
    public class Pies
    {
        public uint Wiek { get; set; }
        public string Imie { get; set; }

        public Pies()
        {
            Imie = "Azor";

        }

        public Pies(uint podanaLiczba)
        {
            Wiek = podanaLiczba;
            Imie = "Azor";
        }

        public Pies(uint podanaLiczba, string podaneImie)
        {
            Wiek = podanaLiczba;
            Imie = podaneImie;

        }

        
    }
}
