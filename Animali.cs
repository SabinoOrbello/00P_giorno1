using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animale
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Età { get; set; }

        public Animale(string nome, string tipo, int età)
        {
            Nome = nome;
            Tipo = tipo;
            Età = età;
        }

        public void StampaInformazioni()
        {
            Console.WriteLine($"Nome: {Nome}, Tipo: {Tipo}, Età: {Età} anni");
        }
    }
}
