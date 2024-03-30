using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        class MainClass
        {
            static void Main(string[] args)
            {
                string modif;
                Console.WriteLine("Напишите что-то");
                var str = Console.ReadLine();

                Console.WriteLine("Укажите глубину эха");
                var deep = int.Parse(Console.ReadLine());

                Echo(str, deep);

                Console.ReadKey();
            }

            //kkk

            static void Echo(string saidworld, int deep)
            {
                var modif = saidworld;

                if (modif.Length > 2)
                {
                    modif = modif.Remove(0, 2);
                }

                Console.WriteLine("..." + modif);

                if (deep > 1)
                {
                    Echo(modif, deep - 1);
                }
            }
        }
    }
}
