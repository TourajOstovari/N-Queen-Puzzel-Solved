namespace NQueen2021
{
    using System;
    using static System.Console;
    class Program
    {
        public static int SizeXY { get; set; }
        static byte[,] Puzzel;
        static System.Collections.ArrayList Container = new System.Collections.ArrayList();
        static System.Collections.ArrayList Container_Won = new System.Collections.ArrayList();
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Blue;
            Title = "N-Queen Problem Solver";
            WriteLine("Hello World! It is developed by Mr. Touraj Ostovari. FOR FREE AND FUN");
            Write("Puzzel Size? ");
            SizeXY = int.Parse(Console.ReadLine());
            Puzzel = new byte[SizeXY, SizeXY];
            while (true)
            {
                Initialize();
            }

            //   ForegroundColor = ConsoleColor.White;
            //   PrintPuzzel(Puzzel);


            // ========================================================== //



        }
        static bool CheckPlus(byte[,] Pz)
        {
            
            Checker ck = new Checker();
            if (ck.Sotoni(Pz) == false && ck.Zarbdari(Pz) == false && !Container_Won.Contains(Pz))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Found a pattern for 8-Queen");
                PrintPuzzel(Pz);
                if(!Container_Won.Contains(Pz) || !Container.Contains(Pz))
                {
                    Container.Add(Pz);
                    Container_Won.Add(Pz);
                }
                Console.WriteLine("\n\tPress any key to continue ...");
                Console.ReadKey();
            }
            return false;
        }
        static void Initialize()
        {
            Random rnd = new Random();
            do
            {
                for (int i = 0; i < SizeXY; i++)
                {
                    Puzzel[i, rnd.Next(0, (SizeXY))] = 1;
                }
                Console.Clear();
                //Puzzel[0, 2] = 1;
                //Puzzel[1, 5] = 1;
                //Puzzel[2, 7] = 1;
                //Puzzel[3, 0] = 1;
                //Puzzel[4, 3] = 1;
                //Puzzel[5, 6] = 1;
                //Puzzel[6, 4] = 1;
                //Puzzel[7, 1] = 1;
                PrintPuzzel(Puzzel);
                if (!Container.Contains(Puzzel) && !Container_Won.Contains(Puzzel))
                {
                    Container.Add(Puzzel);
                    CheckPlus(Puzzel);
                }
                Puzzel = new byte[SizeXY, SizeXY];
                System.Threading.Thread.Sleep(5);
            } while (true);
        }
        static void PrintPuzzel(byte[,] Pz)
        {
            for (int i1 = 0; i1 < SizeXY; i1++)
            {
                for (int i2 = 0; i2 < SizeXY; i2++)
                {
                    if (Pz[i1, i2] == 0)
                        Write("0\t");
                    else
                        Write("1\t");
                }
                Write("\n");
            }
        }
    }
}
