using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Atleta
    { public string Nome {  get; set; }
        public int Età { get; set; }
        public string Sport {  get; set; }
        
        public Atleta (string nome, int età, string sport) {
            Nome = nome;
            Età = età;
            Sport = sport;
        }

        public void StampaInformazioni()
        {
            Console.WriteLine($"Nome: {Nome}, Età: {Età}, Sport: {Sport}");
        }
    }
}
