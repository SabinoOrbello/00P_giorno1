using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Veicolo
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public int Anno { get; set; }

        public Veicolo(string tipo, string marca, int anno)
        {
            Tipo = tipo;
            Marca = marca;
            Anno = anno;
        }

        public void StampaInformazioni()
        {
            Console.WriteLine($"Tipo: {Tipo}, Marca: {Marca}, Anno: {Anno}");
        }
    }
}
