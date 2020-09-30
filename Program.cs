using System;

namespace Quik_sort
{
    class Program
    {
        //cuantos numeros hay
        public static decimal numMax;
        //numero seleccionado
        public static int numSelec;
        //numero de enmedio
        public static decimal numMid;

        static void Ges()
        {
            numMid = Math.Round(numMax/2);
            System.Console.WriteLine(numMid);
            QuikSort();
        }
        static void QuikSort()
        {   
            if (numMid > numSelec)
            {
                numMax = numMid;
                Ges();
            }
            if (numMid < numSelec)
            {
                numMid =(numMid+(numMid/2));
                System.Console.WriteLine(numMid);
                QuikSort();
            }
            else
            {
                System.Console.WriteLine($"Es este? {numMid}");
            }
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("cuantos numeros hay?");
            numMax = Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("cual numero buscas?");
            numSelec = Convert.ToInt32(Console.ReadLine());
            Ges();
        }
    }
}
//consejo: no sirve para mas de 10 numeros