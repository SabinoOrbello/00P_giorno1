using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dipendente
    {
        public string Nome { get; set; }
        public string Ruolo { get; set; }
        public decimal Stipendio { get; set; }

        public Dipendente(string nome, string ruolo, decimal stipendio)
        {
            Nome = nome;
            Ruolo = ruolo;
            Stipendio = stipendio;
        }

        public void StampaInformazioni()
        {
            Console.WriteLine($"Nome: {Nome}, Ruolo: {Ruolo}, Stipendio: {Stipendio:C}");
        }
    }
}
