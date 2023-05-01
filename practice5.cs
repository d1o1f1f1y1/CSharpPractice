using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp
{
    internal class Program
    {
        enum UniversitySubjects
        {
            Philosophy = 1,
            English,
            Law,
            Programming,
            HigherMath,
            DiscreteMath,
            ComputerArchitecture,
            ComputerNetworks,
            InformationSecurity,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("University Subjects:");
            foreach (UniversitySubjects s in Enum.GetValues(typeof(UniversitySubjects)))
            {
                Console.WriteLine($"{(int)s}. {s}");
            }
            Console.WriteLine();
            Console.WriteLine("Ñhoose the subjects you want to study:");
            string answer = Console.ReadLine();
            string[] answers = answer.Split(',');
            Console.WriteLine();
            Console.WriteLine("You have chosen these items:");
            for (int i = 0; i < answers.Length; i++)
            {
                foreach (UniversitySubjects s in Enum.GetValues(typeof(UniversitySubjects)))
                {
                    if ((int)s == Convert.ToInt32(answers[i]))
                    {
                        Console.WriteLine($"{(int)s}. {s}");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Author of the program Boiko Vladimir");
            Console.ReadLine();
        }

    }
}




