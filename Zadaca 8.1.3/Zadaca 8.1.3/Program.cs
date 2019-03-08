using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_8._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Novi objekt Zaposlenik
            Zaposlenik Z1 = new Zaposlenik("Josip", "Josipovic", "8788593686856");

            // Korisnik mora ispravno uneti broj bodova
            bool provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("Unesite broj bodova");

                try
                {
                    Z1.BrojBodova = double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }

                catch (FormatException ex) // specijalne greške
                {
                    Console.WriteLine("Greška:" + ex.Message);
                }
                catch (Exception ex)// ostale greške
                {
                    Console.WriteLine("Greška" + ex.Message);
                }
            }

            provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("Unesite vrijednost boda:");
                try
                {
                    Z1.VrijednostBoda = double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("Greška" + ex.Message);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Greška" + ex.Message);
                }
            }

            // ispis
            Console.WriteLine("Zaposlenik:" + Z1.Ime + "" + Z1.Prezime);
            Console.WriteLine("Neto:" + Z1.NetoIzracunPlace());
            Console.WriteLine("Porez:" + Z1.porez);
            Console.WriteLine("Bruto" + Z1.BrutoIzracunPlace());

            Console.ReadKey();










        }
    }

   
    
    
}
