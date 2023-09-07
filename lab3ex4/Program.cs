using System;

namespace lab3ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("marimea vectorului:");
            int n = int.Parse(Console.ReadLine());
            int[] tabel = new int[n];
          



            scriereTabel(tabel);
            Console.WriteLine("valoare maxima a vectorului:" +getMax(tabel));
            Console.WriteLine("valoare minima a vectorului:" + getMin(tabel));
            Console.WriteLine("numerele divizbile cu 3 sunt :");
            divizible3Numbers(tabel);
            Console.WriteLine("numere prime :"); isPrim(tabel);



        }

        static void scriereTabel(int[] parametru)
        {
            for (int i = 0; i < parametru.Length; i++)
            {
                Console.WriteLine("introdu elementul [:" + i + "]");
                parametru[i] = int.Parse(Console.ReadLine());
            }
        }

        static int getMax(int[]x)
        {
            int max = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (max < x[i])
                {
                    max = x[i];
                }
            }

            return max;

        }
        static int getMin(int[] x)
        {
            int min = x[0];
            for (int i = 0; i < x.Length; i++)
            {
                if (min > x[i])
                {
                    min = x[i];
                }
            }

            return min;

        }
        static void divizible3Numbers(int[] x)
        {
           
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 3 == 0)
                {
                    Console.WriteLine(x[i]);
                }
            }

           

        }
        static void isPrim(int[] x)
        {
           
            for (int i = 0; i < x.Length; i++)
            {
                int a = 0;
                for (int j = 1; j <= x[i]; j++)
                {
                    if (x[i] % j == 0) a++;

                }

                if (a == 2)
                {
                    Console.WriteLine(x[i]);

                }
               
            }


        }


        static void  citireTabel(int[] parametru)
        {
            for (int i = 0; i < parametru.Length; i++)
            {

                Console.WriteLine("elementul :[" + i + "]este: " + parametru[i] + "");
            }
        }
    }
}
