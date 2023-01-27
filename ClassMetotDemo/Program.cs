using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1= new Musteri();

            Musteri1.ID = 986526;
            Musteri1.Adi = "Ahmet";
            Musteri1.Parasi = 499;
            Musteri1.Meslek = "Yazılım Mühendisi";
            Musteri1.Borcu_varmi = false; 


            Musteri Musteri2 = new Musteri();
            
            Musteri2.ID = 9846151;
            Musteri2.Adi = "Mehmet";
            Musteri2.Parasi = 8653;
            Musteri2.Meslek = "CEO";
            Musteri2.Borcu_varmi = true; 




            Musteri Musteri3 = new Musteri();

            Musteri3.ID = 465233;
            Musteri3.Adi = "Selami";
            Musteri3.Parasi = 86853;
            Musteri3.Meslek = "lojistik firma genel müdürü ";
            Musteri3.Borcu_varmi = false;


            Musteri[] Musteriler = new Musteri[] { Musteri1, Musteri2, Musteri3 };

            foreach (Musteri item in Musteriler)
            {
                Console.WriteLine(item.ID);
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Parasi);
                Console.WriteLine(item.Meslek);
                Console.WriteLine("---------------------------------------");
                MusteriManager MusteriManager1= new MusteriManager();
              MusteriManager1.ekle(item);
                Console.WriteLine("---------------------------------------");
                MusteriManager1.doviz_yap(item);
                Console.WriteLine("---------------------------------------");
                MusteriManager1.Kayit_sil(item);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("\n\n\n"); 

            }
            

            Console.ReadLine();



        }
    }
}
