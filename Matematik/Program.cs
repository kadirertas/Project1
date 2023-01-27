using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dortislem dortislem = new Dortislem();
            dortislem.Toplama(5, 8);
            dortislem.Cikarma(5, 8);
            dortislem.Carpma(5, 8);
            dortislem.bolme(8, 8);
            
             
            Console.ReadLine();

           

        }
    }
}
