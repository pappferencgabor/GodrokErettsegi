using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Godrok
{
    internal class Program
    {
        static List<int> melysegek = new List<int>();

        static void Main(string[] args)
        {
            melysegek = File.ReadAllLines("sources\\melyseg.txt").Select(x => int.Parse(x)).ToList();

            Console.WriteLine("1. feladat");
            Console.WriteLine($"A fájl adatainak száma: {melysegek.Count}");
            Console.WriteLine();

            Console.WriteLine("2. feladat");
            Console.Write("Adjon meg egy távolságértéket! ");
            int tav = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ezen a helyen a felszín {melysegek[tav]} méter mélyen van.");
            Console.WriteLine();

            Console.WriteLine("3. feladat");
            Console.WriteLine($"{Math.Round(Convert.ToDouble(melysegek.Where(x => x == 0).Count()) / Convert.ToDouble(melysegek.Count) * 100, 2)}");
            Console.WriteLine();

            int elozoszam = 0;
            string godor = "";
            List<string> godrok = new List<string>();

            foreach (var elem in melysegek)
            {
                if (elem > 0)
                {
                    godor += $"{elem} ";
                }
                if (elem == 0 && elozoszam > 0)
                {
                    godrok.Add(godor);
                    godor = "";
                }
                elozoszam = elem;
            }
            File.WriteAllLines("sources\\godrok.txt", godrok);

            Console.WriteLine("5. feladat");
            Console.WriteLine($"A gödrök száma: {godrok.Count}");
            Console.WriteLine();

            Console.WriteLine("6. feladat");
            if (melysegek[tav] > 0)
            {
                Console.WriteLine("a)");
                int kezdopont = 7;
                int vegpont = 22;
                Console.WriteLine($"A gödör kezdete: {kezdopont} méter, a gödör vége: {vegpont} méter. ");

                Console.WriteLine("b)");
                Console.WriteLine();

                Console.WriteLine("c)");
                Console.WriteLine();

                Console.WriteLine("d)");
                Console.WriteLine();

                Console.WriteLine("e)");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Az adott helyen nincs gödör.");
            }
        }
    }
}