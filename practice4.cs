using System;

namespace firstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp;
            int count = 0, tcount = 0;
            temp = Console.ReadLine(); 
            for (int i = 0;i<temp.Length;i++)
            {
                if (temp[i] == ' ')
                {
                    tcount++;
                }
                else
                {
                    if (count < tcount)
                    {
                        count = tcount;
                    }
                    tcount = 0;
                }
            }
            Console.WriteLine("����i���� �i���i��� ����i�i�, �� ����������i �i����: " + count);
            Console.ReadKey();
        }
    }
}