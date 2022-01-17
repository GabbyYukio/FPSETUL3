using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class multime
    {
        //::::::::::::::::::Constructori
        public int[] data;
        public multime(string input)
        {
            this.data=new int[input.Length];
            for(int i=0;i<input.Length;i++)
            {
                char c = input[i];
                this.data[i]=int.Parse(c.ToString());
            }
        }

        public multime()
        {
            this.data = new int[9999];
        }


        //::::::::::::Functii
        public static multime Reuniune(multime x, multime y)
        {
            multime rezultat = Concatanare(x, y);
            rezultat.RemoveDuplicates();
            return rezultat;
        }

        public static multime Intersectia(multime x, multime y)//returneaza o multime care interesecteaza elementele din multimea x si y
        {
            multime rezultat = new multime();//declaram rezultatul ca nou obiect
            int n = 0;//pozitia pentru rezultat
            for(int i=0; i<x.data.Length; i++)
                for(int j=0; j<y.data.Length; j++)
                    if(x.data[i]==y.data[j])//cand gaseste un element comun 
                    {
                        rezultat.data[n] = x.data[i];//il pune in rezultat
                        n++;//adunam n-ul pentru pozitii
                    }
            rezultat.RemoveDuplicates();//ca sa eliminam duplicaturile
            return rezultat;
        }
        public static multime Diferenta(multime x, multime y)// returneaza o multime ca si diferenta dintre x si y
        {
            multime rezultat = new multime();
            int n = 0, i=0, j=0;
            bool comun = false;
            while (i < x.data.Length)
            {
                while (j < y.data.Length)
                {
                    if (x.data[i] == y.data[j])
                        comun = true;
                    j++;
                }
                if (comun == false)
                {
                    rezultat.data[n] = x.data[i];
                    n++;
                }
                i++;
            }
            return rezultat;
        }
        public static multime Concatanare(multime x, multime y)
        {
            multime solutie= new multime();
            for(int i=0; i<x.data.Length; i++)
                solutie.data[i]=x.data[i];
            for(int i=x.data.Length; i<x.data.Length+y.data.Length; i++)
                solutie.data[i]=y.data[i];
            solutie.Trim(x.data.Length + y.data.Length);
            return solutie;
        }

        //:::::::::::::Proprietati
        public void Afisare()
        {
            for(int i=0; i<this.data.Length; i++)
                Console.Write("{0}",this.data[i]);
        }

        private void Trim(int a)//removes all elements from multime up to index a 
        {
            multime copie = this;
            this.data = new int[a];
            for (int i = 0; i < a; i++)
                this.data[i] = copie.data[i];
        }

        private void RemoveElement(int a)//removes the element from index a
        {
            for (int i = a; i < this.data.Length; i++)
                this.data[i] = this.data[i + 1];
            this.Trim(this.data.Length-1);
        }

        private void RemoveDuplicates()
        {
            for(int i=0; i<this.data.Length; i++)
                 for(int j=0; j<this.data.Length; j++)
                     if (this.data[i] == this.data[j] && i != j)
                          this.RemoveElement(j);
        }
    }
    class Problema21
    {
        private static string cin(string mesaj)
        {
            Console.WriteLine(mesaj);
            Console.Write(">>> ");
            string input = Console.ReadLine();
            input = string.Join("", input.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            return input;
        }
        private static void intersectie()
        {

            multime x = new multime(cin("Va rog introduceti elementele pentru prima multime, fiecare separat printr-un spatiu"));
            multime y = new multime(cin("Va rog introduceti elementele pentru a doua multime, fiecare separat printr-un spatiu"));

            multime rezultat = multime.Intersectia(x, y);
            rezultat.Afisare();
        }

        private static void reuniune()
        {
            multime x = new multime(cin("Va rog introduceti elementele pentru prima multime, fiecare separat printr-un spatiu"));
            multime y = new multime(cin("Va rog introduceti elementele pentru a doua multime, fiecare separat printr-un spatiu"));

            multime rezultat = multime.Reuniune(x, y);
            rezultat.Afisare();
        }
        private static void diferenta()
        {
            multime x = new multime(cin("Va rog introduceti elementele pentru prima multime, fiecare separat printr-un spatiu"));
            multime y = new multime(cin("Va rog introduceti elementele pentru a doua multime, fiecare separat printr - un spatiu"));

            multime rezultat = multime.Diferenta(x, y);
            rezultat.Afisare();
        }
        private static void diferenta2()
        {
            multime x = new multime(cin("Va rog introduceti elementele pentru prima multime, fiecare separat printr-un spatiu"));
            multime y = new multime(cin("Va rog introduceti elementele pentru a doua multime, fiecare separat printr-un spatiu"));

            multime rezultat = multime.Diferenta(y, x);
            rezultat.Afisare();
        }
        private static void user_input()
        {
            Console.Write(">>> ");
            string input = Console.ReadLine();
            switch( input)
            {
                case "1":
                    intersectie();
                    break;
                case "2":
                    reuniune();
                    break;
                case "3":
                    diferenta();
                    break;
                case "4":
                    diferenta2();
                    break;
            }
        }
        private static void printmenu()
        {
            Console.WriteLine("Va rog alegeti dintre optiunile" );
            Console.WriteLine("1-Interesctia dintre cele doua multimi: ");
            Console.WriteLine("2-Reuniunea dintre cele doua multi: ");
            Console.WriteLine("3-Diferenta dintre primul si al doilea(elementele care sunt in primul dar nu si in al doilea)");
            Console.WriteLine("4-Diferenta dintre al doilea si primul (elementele care sunt in al doilea dar nu si in primul)");
        }
        public static void rezolvare()
        {
            printmenu();
            user_input();
        }
    }
}
