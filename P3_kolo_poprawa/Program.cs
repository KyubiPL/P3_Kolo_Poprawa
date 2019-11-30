using System;

namespace P3_kolo_poprawa
{
    class Program
    {

        static void f(double []tab)
        {
            double suma = 0;

            suma = tab[0] * 0.23 + tab[1] * 0.07 + tab[2] * 0.03;

            Console.WriteLine(suma);
        }

        static void ff(double x,double y)
        {
            double oprocentowanie = 0.10;
            double dlug_k = x;


            for (int i = 0; i < y; i++)
            {

                dlug_k += dlug_k * oprocentowanie;
                
            }
            Console.WriteLine(dlug_k);

        }

        static void fff(string[,] tlum)
        {
            string slowo;
            Console.WriteLine("Wpisz słowo po polsku :");
            slowo = Console.ReadLine();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (slowo == tlum[i, j])
                    {
                        Console.WriteLine("Słowo znajduje się w słowniku jego tłumaczenie to : {0}", tlum[i, j + 1]);              
                    }
                    else
                    {
                        continue;
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            double[] kwoty = new double[3];
            kwoty[0] = 100;
            kwoty[1] = 200;
            kwoty[2] = 300;

            f(kwoty);

            Console.WriteLine();

            Console.WriteLine("Podaj kwotę startową");
            double x = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Podaj ilość miesięcy");
            double y = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();

            ff(x, y);
            Console.WriteLine();

            string[,] slownik = new string[2, 4];

            slownik[0, 0] = "pies";
            slownik[0, 1] = "dog";
            slownik[0, 2] = "papuga";
            slownik[0, 3] = "parrot";
            slownik[1, 0] = "kot";
            slownik[1, 1] = "cat";
            slownik[1, 2] = "mysz";
            slownik[1, 3] = "mouse";

            fff(slownik);

        }
    }
}

//Grupa F

//1.Napisz funkcję, która obliczy ile wynosi podatek VAT od zakupów. Jako parametr, przyjmij 3 kwoty.
//Pierwsza kwota to suma cen na które 23%,druga 7%, trzecia 3%.

//2.Napisz funkcję, która obliczy ile wyniesie dług, jeśli spłata spóźni się o kilka miesięcy. 
//Kwotę początkową i ilośc miesięcy wczytaj od użytkownika. Pamiętaj, że odsetki doliczane są co miesiać do kwoty z odsetkami z poprzednich miesiecy

//3.Stwórz mini słownik. Do tablicy dwuwymiarowej o dwóch wierszach wpisz kilka słow i ich angielskie tłumaczenia. Wczytaj słowo wpisane przez użytkownika
//po polsku. Wyszukaj go. Jeśli znajduje się w tablicy, wypisz tłumaczenie
