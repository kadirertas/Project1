using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class Dortislem
    {
        int sonuc; 
        public void Toplama(int sayi1, int sayi2)
        {
              sonuc = sayi1 + sayi2;
            Console.WriteLine("verilen iki sayinin TOPLAMİ : " + sonuc);
        }
        public void Cikarma( int sayi1, int sayi2)
        {
             if(sayi1> sayi2)
            {
                sonuc = sayi1 - sayi2; 

            }
             else
            {
                sonuc = sayi2 - sayi1; 
            }
            Console.WriteLine("verilen iki sayinin FARKİ : " + sonuc);
        }
        public void Carpma(int sayi1, int sayi2)
        {
            sonuc= sayi1 * sayi2;
            Console.WriteLine("verilen iki sayinin CARPİMİ : " + sonuc);
        }


        public void bolme (int sayi1, int sayi2)
        {
            double sonuc1= sayi1 / sayi2;
            Console.WriteLine("verilen iki sayinin BOLUMU : " + sonuc1);
        }


        
    }
}
