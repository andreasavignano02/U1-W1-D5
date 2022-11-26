using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
            Console.WriteLine("inserisci il tuo codice fiscale:");
            _CodiceFiscale= Console.ReadLine();
            Console.WriteLine("Inserisci il tuo comune di residenza");
            _ComuneDiResidenza = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo reddito lordo annuale:");
            _RedditoAnnuale = double.Parse(Console.ReadLine());
            Console.WriteLine("==========================");
            Console.WriteLine($"Contribuente : {_Name}{_Surname}");
            Console.WriteLine($"nato il {_DataNascita.Day}/{_DataNascita.Month}/{_DataNascita.Year} ({_Sesso})");
            Console.WriteLine($"residente in {_ComuneDiResidenza}");
            Console.WriteLine($"codice fiscale: {_CodiceFiscale}");
            Console.WriteLine($"Reddito dichiarato: {_RedditoAnnuale}");
            imposta();
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
        private static void imposta()
        {
            double impostadapagare;
            if (_RedditoAnnuale >= 0 && _RedditoAnnuale <= 15.000)
            {
                impostadapagare  = (_RedditoAnnuale * 23) / 100;
                Console.WriteLine($"IMPOSTA DA VERSARE {impostadapagare}");

            }
            else if (_RedditoAnnuale >= 15.001 && _RedditoAnnuale <= 28000) 
            {
                impostadapagare = 3.450 + ((_RedditoAnnuale * 27) / 100);
                Console.WriteLine($"IMPOSTA DA VERSARE {impostadapagare}");
            }
            else if (_RedditoAnnuale >= 28.001 && _RedditoAnnuale <= 55.000)
            {
                impostadapagare = 6.960 + ((_RedditoAnnuale * 38) / 100);
                Console.WriteLine($"IMPOSTA DA VERSARE {impostadapagare}");
            }
            else if (_RedditoAnnuale >= 55.001 && _RedditoAnnuale <= 75.000) 
            {
                impostadapagare = 17.220 + ((_RedditoAnnuale * 41) / 100);
                Console.WriteLine($"IMPOSTA DA VERSARE {impostadapagare}");
            }
            else if (_RedditoAnnuale >= 75.001)
            {
                impostadapagare = 25.420 + ((_RedditoAnnuale * 43) / 100);
                Console.WriteLine($"IMPOSTA DA VERSARE {impostadapagare}");
            }
        }
    }
}
