using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace U1_W1_D5
{
    internal class Contribuente
    {
        private static string _Name;
        private static string _Surname;
        private static DateTime _DataNascita;
        private static string _CodiceFiscale;
        private static string _Sesso;
        private static string _ComuneDiResidenza;
        private static double _RedditoAnnuale;

        public static void Tasse()
        { 
            Console.WriteLine("=============================");
            Console.WriteLine("Inserisci il tuo nome:");
            _Name = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome:");
            _Surname = Console.ReadLine();           
            Console.WriteLine("Inserisci la tua data di nascita");
            _DataNascita = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il tuo sesso M/F");            
            Sesso();
            
            //Console.WriteLine($"{_DataNascita.Day}/{_DataNascita.Month}/{_DataNascita.Year}");
            Console.ReadLine();
        }
        private static void Sesso()
        {
            _Sesso = Console.ReadLine();
            if (_Sesso != "M" && _Sesso != "F" && _Sesso != "m" && _Sesso != "f")
            {
                Console.WriteLine("inserisci un sesso valido");
                Tasse();
            }
        }
    }
}
