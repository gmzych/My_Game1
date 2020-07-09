using System;
namespace Projekt13
{
    class Kot:Zwierze,ILadowy
    {
        public string Dzwiek { get; set; } = "miau";

        public void IleMaNog()
        {
            Console.WriteLine("Kot ma cztery nogi ");
        }

       
    }
}
