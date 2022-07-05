using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
          
            
                char choose;
                Random comp = new Random();
                int w = 0;
                int l = 0;
                int d = 0;
                int sayacround = 0;
                tekrar:
                do
                {
                    Console.WriteLine("plase choose rock-paper-scissors");
                    choose = char.Parse(Console.ReadLine());
                } while (!(choose == 'r' || choose == 'p' || choose == 's'));
                sayacround++;
                int choosenum;
                if (choose == 'r')
                {
                    choosenum = 0;

                }
                else if (choose == 'p')
                {
                    choosenum = 1;
                }
                else
                {
                    choosenum = 2;
                }
                int compchoose = comp.Next(0, 3);
                switch (compchoose)
                {
                    case (0):
                        Console.WriteLine("Karşı tarafın seçimi = rock");
                        break;
                    case (1):
                        Console.WriteLine("Karşı tarafın seçimi = paper");
                        break;
                    case (2):
                        Console.WriteLine("Karşı tarafın seçimi = scissors");
                        break;
                }
                if (compchoose == 0)
                {
                    if (choosenum == 1)
                    {
                        Console.WriteLine("kazandın");
                        w++;
                    }
                    else if (choosenum == 2)
                    {
                        Console.WriteLine("kaybettin");
                        l++;
                    }
                    else
                    {
                        Console.WriteLine("berabere");
                        d++;
                    }
                }
                else if (compchoose == 1)
                {
                    if (choosenum == 2)
                    {
                        Console.WriteLine("kazandın");
                        w++;
                    }
                    else if (choosenum == 0)
                    {
                        Console.WriteLine("kaybettin");
                        l++;
                    }
                    else
                    {
                        Console.WriteLine("berabere");
                        d++;
                    }
                }
                else
                {
                    if (choosenum == 0)
                    {
                        Console.WriteLine("kazandın");
                        w++;
                    }
                    else if (choosenum == 1)
                    {
                        Console.WriteLine("kaybettin");
                        l++;
                    }
                    else
                    {
                        Console.WriteLine("berabere");
                        d++;
                    }
                }
                char tekrarT;
                do
                {

                    Console.WriteLine("tekrar denemek ister misin? y/n");
                    tekrarT = char.Parse(Console.ReadLine());
                } while (!(tekrarT == 'y' || tekrarT == 'n'));
                if (tekrarT == 'y')
                {
                    goto tekrar;
                }
                else
                {
                    Console.WriteLine(" Total round sayısı = {0} \nKazandığın round sayısı = {1} \nKaybettiğin round sayısı = {2} \nBeraber kaldığın round sayısı = {3}", sayacround, w, l, d);
                }

                Console.ReadLine();
         }
    }
}
