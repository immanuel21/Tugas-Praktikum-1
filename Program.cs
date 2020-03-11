using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title ="Program Kalkulator";

        Console.WriteLine("Pilihan menu kalkulator :");
        Console.WriteLine("1. Penjumlahan \n2. Pengurangan \n3. Perkalian \n4.Pembagian");
        Console.WriteLine();

        Console.Write("Input nomor menu [1..4] : ");
        int pilih = int.Parse(Console.ReadLine());

        Console.Write("Input nilai a =");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Input nilai b =");
        int b = Convert.ToInt32(Console.ReadLine());

        switch(pilih)
        {
            case 1:
                Console.WriteLine("Hasil penjumlahan {0} + {1} = {2}", a, b, penjumlahan(a, b));
            break;
            case 2:
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a,  b, pengurangan(a, b));
            break;
            case 3:
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a,b));
            break;
            case 4:
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
            break;
            default:
                Console.WriteLine("Maaf, menu yang ada Anada pilih tidak tersedia");
            break;
        }
        Console.WriteLine();
        Console.WriteLine("tekan sembarang key untuk keluar...");
        Console.ReadKey();
        }
        static int penjumlahan(int a, int b)
        {
            return a + b;
        }

         static int pengurangan(int a, int b)
        {
            return a - b;
        }

         static int perkalian(int a, int b)
        {
            return a * b;
        }

         static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
