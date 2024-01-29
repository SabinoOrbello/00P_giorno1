using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veicolo veicolo1 = new Veicolo("Auto", "Toyota", 2022);
            Veicolo veicolo2 = new Veicolo("Bicicletta", "Trek", 2021);

            Console.WriteLine("Informazioni sui Veicoli:");
            veicolo1.StampaInformazioni();
            veicolo2.StampaInformazioni();
            Console.WriteLine("");


            Atleta atleta1 = new Atleta("Mario Rossi", 25, "Calcio");
            Atleta atleta2 = new Atleta("Anna Bianchi", 30, "Nuoto");
            Console.WriteLine("Informazioni sugli Atleti:");
            atleta1.StampaInformazioni();
            atleta2.StampaInformazioni();
            Console.WriteLine("");

            Dipendente dipendente1 = new Dipendente("Alessandro Verdi", "Sviluppatore", 50000);
            Dipendente dipendente2 = new Dipendente("Laura Neri", "Contabile", 45000);
            Console.WriteLine("Informazioni sui Dipendenti:");
            dipendente1.StampaInformazioni();
            dipendente2.StampaInformazioni();
            Console.WriteLine("");

            Animale animale1 = new Animale("Fido", "Cane", 4);
            Animale animale2 = new Animale("Whiskers", "Gatto", 3);
            Console.WriteLine("Informazioni sugli Animali:");
            animale1.StampaInformazioni();
            animale2.StampaInformazioni();

            Console.ReadLine();
        }
    }
}
