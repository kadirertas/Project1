using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {


        public void ekle(Musteri Musterix) {
        

            if (Musterix.Parasi>500)
            {
                Console.WriteLine("EKLEME SONUCU: Bizi Tercih Ettiğiniz İçin Teşekkürler  BANKAMIZA HOŞGELDNİZ "); 
            }
            else
            {

                Console.WriteLine("EKLEME SONUCU: Bankamızda Sizin için Bir kontejan bulunamadığından KAYIT İŞLEMİ TAMAMLANAMAMIŞTIR"); 
            }
        }
        public void doviz_yap(Musteri Musterix, float dolar_kuru=18) 
        {
            Double doviz =Musterix.Parasi/dolar_kuru;
            Console.WriteLine("DOVİZ SONUCU : Bankamızda bulunan paranıza göre  Dolar Miktarınız : "+ doviz); 
            
        }
        

        public void  Kayit_sil ( Musteri Musterix)
        {

            if (Musterix.Borcu_varmi == true)
            {
                Console.WriteLine("KAYIT SİLME : İSLEMİNİZ GERÇEKLESMİYOR \n LUTFEN BORCUNUZU ODEYİN "); 

            }
            else
            {
                Console.WriteLine("KAYIT SİLME : KAYDINIZ SONLANDIRILIMIŞTIR. :((( \n BU KAPI SİZE HER ZAMAN AÇIK ");
            }
        }
    }
}
