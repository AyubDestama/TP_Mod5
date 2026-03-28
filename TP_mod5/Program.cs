using System;

namespace TP_mod5
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T x)
        {
            Console.WriteLine($"Halo user {x}");
        }
    }

    public class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {this.data}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric sapaan = new HaloGeneric();
            Console.Write("Masukkan nama panggilan praktikan: ");
            string namaInput = Console.ReadLine();
            sapaan.SapaUser(namaInput);

            Console.WriteLine("--------------------------------------------");

            Console.Write("Masukkan NIM praktikan: ");
            string nimInput = Console.ReadLine();

            DataGeneric<string> dataNim = new DataGeneric<string>(nimInput);

            dataNim.PrintData();

            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}