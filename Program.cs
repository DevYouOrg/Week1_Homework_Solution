using System;

namespace DevYou_ClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mad Lib with challenge

            Console.Write("Enter adjective: ");
            string adjective1 = Console.ReadLine();

            Console.Write("Enter noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Enter a past tense verb: ");
            string pasteTenseVerb = Console.ReadLine();

            Console.Write("Enter an adverb: ");
            string adverb1 = Console.ReadLine();

            Console.Write("Enter adjective: ");
            string adjective2 = Console.ReadLine();

            Console.Write("Enter a noun :");
            string noun2 = Console.ReadLine();

            Console.Write("Enter noun: ");
            string noun3 = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            string adjective3 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb1 = Console.ReadLine();

            Console.Write("Enter an adverb: ");
            string adverb2 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb2 = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            string adjective4 = Console.ReadLine();

            Console.WriteLine("Here is the story...");
            Console.WriteLine();

            Console.WriteLine($" Today I went to the zoo. I saw a {adjective1} {noun1} jumping up and down in its tree. He {pasteTenseVerb} {adverb1} through the large tunnel that led to its {adjective2} {noun2}. I got some peanuts and passed them through the cage to a gigantic gray {noun3} towering above my head. Feeding that animal made me hungry. I went to get a {adjective3} scoop of icecream. It filled my stomach. Afterwards I had to {verb2} {adverb2} to catch our bus. When I got home I {pasteTenseVerb} my mom for a {adjective4} day at the zoo.");

        }
    }
}
