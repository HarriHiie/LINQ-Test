using System;

namespace Töö
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("LINQ");
            Intersect();
            Take();
            
        }
        public static void Intersect()
        {
            //programm leiab millises osakonnas töötavad mõlemas osakonnas
            string[] employeesInDeptA = { "Mari", "Mart", "Albert", "Siim" };
            string[] employeesInDeptB = { "Albert", "Jüri", "Jaanus", "Mart" };

            var result = employeesInDeptA.Intersect(employeesInDeptB);

            Console.WriteLine("Ühised töötajad osakonnas A ja B:");
            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
        }
        public static void Take()
        {
            Console.WriteLine("");
            var Scores = new[] { "Liis", "Toomas", "Martin", "Artur" };

            var newScores = Scores.Take(3);

            foreach (var newScore in newScores)
            {
                Console.WriteLine(newScore);
            }
        }
    }
}   