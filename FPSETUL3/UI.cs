using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class UI
    {
        public static void enterprogram()
        {
            Console.WriteLine("Alegeti una dintre optiuni: ");
            Console.WriteLine("0-Iesire Program");
            Console.WriteLine("1-Intrare program");

            Console.Write(">>> ");

            string input;
            input=Console.ReadLine();
            switch(input)
            {
                case "0":
                    break;
                case "1":
                    printmenu();
                    break;
                default:
                    Console.WriteLine("Ati introdus o valoare incorecta. Va rugam incercati din nou. ");
                    enterprogram();
                    break;
            }
        }
        public static void printmenu()
        {
            Console.WriteLine("Alegeti una dintre optiuni: ");
            Console.WriteLine("0-Iesire Program");
            Console.WriteLine("1-Problema 1: Suma elementelor unui vector");
            Console.WriteLine("2-Problema 2: Cautarea pozitiei a unui element k dintr-un vector");
            Console.WriteLine("3-Problema 3: Min si max dintr-un vector");
            Console.WriteLine("4-Problema 4: Numarul aparitiilor min si max dintr-un vector");
            Console.WriteLine("5-Problema 5: Inserare element e in pozitia k intr-un vector");
            Console.WriteLine("6-Problema 6: Stergerea elementelui din vector de pe pozitia k");
            Console.WriteLine("7-Problema 7: Reversarea elementelor dintr-un vector");
            Console.WriteLine("8-Problema 8: Rotire spre stanga");
            Console.WriteLine("9-Problema 9: Rotiri de k ori spre stanga");
            Console.WriteLine("10-Problema 10: Cautare binara");
            Console.WriteLine("11-Problema 11: Ciurul lui Eratostene");
            Console.WriteLine("12-Problema 12: Sortare prin selectie");
            Console.WriteLine("13-Problema 13: Sortare prin insertie");
            Console.WriteLine("14-Problema 14: Mutare 0 uri la sfarsit (eficient)");
            Console.WriteLine("15-Problema 15: Eliminarea dubluri");
            Console.WriteLine("21-Problema 21: Operatii cu multimi neordonate");
            //mai are rost sa fac problema cu multimi ordonate? ar merge cam la fel, zic si eu =))

            Console.WriteLine("25-Problema 25: Interclasare vectori ordonati");
            Console.WriteLine("28-Problema 28: MergeSort pentru un vector");
            Console.WriteLine("29-Problema 29: Quicksort pentru un vector");

            Console.Write(">>> ");
        }

        public static void run()
        {
            enterprogram();
            string input;

            input=Console.ReadLine();
            switch(input)
            {
                case "0":                  
                    break;
                case"1":
                    Problema1.rezolvare();
                    break;
                case "2":
                    Problema2.rezolvare();
                    break;
                case "3":
                    Problema3.rezolvare();
                    break;
                case "4":
                    Problema4.rezolvare();
                    break;
                case "5":
                    Problema5.rezolvare();
                    break;
                case "6":
                    Problema6.rezolvare();
                    break;
                case "7":
                    Problema7.rezolvare();
                    break;
                case "8":
                    Problema8.rezolvare();
                    break;
                case "9":
                    Problema9.rezolvare();
                    break;
                case "10":
                    Problema10.rezolvare();
                    break;
                case "11":
                    Problema11.rezolvare();
                    break;
                case "12":
                    Problema12.rezolvare();
                    break;
                case "13":
                    Problema13.rezolvare();
                    break;
                case "14":
                    Problema14.rezolvare();
                    break;
                case "15":
                    Problema15.rezolvare();
                    break;
                case "21":
                    Problema21.rezolvare();
                    break;
                case "25":
                    Problema25.rezolvare();
                    break;
                case "28":
                    Problema28.rezolvare();
                    break;
                case "29":
                    Problema29.rezolvare();
                    break;
                default:
                    Console.WriteLine("Ati introdus un input gresit. Va rugam incercati din nou. ");
                    UI.run();
                    break;
            }
        }
    }
}
