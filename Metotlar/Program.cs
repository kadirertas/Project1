using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Program
    {
        static void Main(string[] args)
        {
            urun urun1= new urun();

            urun1.ID = 123;
            urun1.Adi = "kayısı";
            urun1.Fiyati = 28;
            urun1.Aciklama = "amasya elması ";
            urun1.StokAdedi = 12; 

            urun urun2= new urun();

            urun2.ID = 1234;
            urun2.Adi = "armut"; 
            urun2.Fiyati= 29;
            urun2.Aciklama = "kars armudu"; 
            urun2.StokAdedi = 15;




            urun[] urunler = new urun[] {urun1,urun2};
            foreach (urun  urun in urunler)
            {
                Console.WriteLine(urun.ID);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("*********************");
                
            }

            Console.WriteLine("------------------metotlar------------------"); 
            
            SepetManager sepetManager= new SepetManager();
                
            sepetManager.Ekle(urun1); 
            sepetManager.Ekle(urun2);
            

         

        }
    }
}
