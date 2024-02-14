using System;
 namespace fortnite
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1 = 4;
            int tal2 = 4;
            Console.WriteLine(Störst(tal1, tal2));

        }
        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            if(tal2>tal1)
            {
                return tal2;
            }
            else
            {
                return tal1;
            }
        }
    }
}