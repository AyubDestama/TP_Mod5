using System;

namespace TP_mod5
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T x)
        {
            Console.WriteLine($"Halo user {x}");
        }

        static void Main(string[] args)
        {
            HaloGeneric sapaan = new HaloGeneric();

            // Bagian Input:
            Console.Write("Masukkan nama panggilan praktikan: ");
            string namaInput = Console.ReadLine(); // Mengambil input dari user

            // 3. Memanggil method dengan input yang diberikan
            sapaan.SapaUser(namaInput);

            // Menahan console agar tidak langsung tertutup
            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}