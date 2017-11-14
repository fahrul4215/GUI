using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapiSayaBaru
{
    class Program
    {
        static void Main(string[] args)
        {
            Sapi sapiSaya;

            // Dengan Method Private
            sapiSaya = new Sapi();
            sapiSaya.GantiNama("songuku");

            Console.WriteLine("Nama sapi saya adalah : {0}", sapiSaya.LihatNama());
            Console.WriteLine("Ia berjenis kelmain   : {0}", sapiSaya.LihatJenisKelmain());
            Console.WriteLine("saat ini ia berusia   : {0}", sapiSaya.LihatUmur());

            // Dengan Method Public
            //sapiSaya.nama = "Boboho";
            //sapiSaya.jenisKelamin = "Jantan";
            //sapiSaya.umur = 17;
            //sapiSaya.berat = 1000;

            //Console.WriteLine("Nama sapi saya adalah : {0}", sapiSaya.nama);
            //Console.WriteLine("Ia berjenis kelmain : {0}", sapiSaya.jenisKelamin);
            //Console.WriteLine("saat ini ia berusia : {0}", sapiSaya.umur);
            //Console.WriteLine("Berat terakhir nya adalah : {0}", sapiSaya.berat);

            //sapiSaya.Makan();
            //sapiSaya.Melahirkan();
            //sapiSaya.Tidur();

            Console.ReadKey();
        }
    }
}
