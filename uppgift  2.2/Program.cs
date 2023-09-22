using System;
namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hur långt hoppade elin?");
            string elin = Console.ReadLine();
            Console.WriteLine("ok men hur långt hoppade Alma då?");
            string alma = Console.ReadLine();
            double elinhopp = double.Parse(elin);
            double almahopp = double.Parse(alma);
            double skillnad = elinhopp - almahopp;
            Console.WriteLine("elin hoppade " + skillnad + " meter längre än alma");












        }
    }
}