using System;

namespace OefentoetsPeriodeEen
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Opdracht 1 - Declareer 2 variabele, een die een leeftijd aan geeft, 
             *              de tweede die aangeeft of je de toets hebt gehaald of niet. 
             * 
             * Opdracht 2 - Initialiseer de variabele die aangeeft of de toets 
             *              gehaald is of niet met dat de toets niet gehaald is
             * 
             * Opdracht 3 - Vraag aan de gebruiker de leeftijd en sla deze op 
             *              in de eerste variabele
             * 
             * Opdracht 4a - Maak een Array van getallen met een decimaal
             * Opdracht 4b - Loop door de Array heen en tel alle getallen bij elkaar op. 
             *               Toon aan het einde het totaal.
             * 
             * Opdracht 5 - Maak de code beter. Gebruik jouw kennis om de code zo aan te 
             *              passen dat het voor jou goed werkt, maar uiteraard gebruik je 
             *              goede/ passen oplossingen. Gebruik sowieso in je code de methode 
             *              GetAge() om de leeftijd te vragen.
             *              HINT: Array.
             */

            //Opdracht 1: Schrijf hieronder jouw oplossing


            Console.WriteLine("Opdracht 1 klaar");

            //Opdracht 2: Schrijf hieronder jouw oplossing


            Console.WriteLine("Opdracht 2 klaar");

            //Opdracht 3: Schrijf hieronder jouw oplossing


            Console.WriteLine("Opdracht 3 klaar");

            //Opdracht 4: Schrijf hieronder jouw oplossing


            Console.WriteLine("Opdracht 4 klaar");

            //Opdracht 5: Schrijf hieronder jouw oplossing

            int totalStudentAge = 0;
            int leeftijdStudent1;
            Console.Write("Student 1 wat is je leeftijd? ");
            leeftijdStudent1 = Convert.ToInt32(Console.ReadLine());
            totalStudentAge = totalStudentAge + leeftijdStudent1;
            int leeftijdStudent2;
            Console.Write("Student 2 wat is je leeftijd? ");
            leeftijdStudent2 = Convert.ToInt32(Console.ReadLine());
            totalStudentAge = totalStudentAge + leeftijdStudent2;
            int leeftijdStudent3;
            Console.Write("Student 3 wat is je leeftijd? ");
            leeftijdStudent3 = Convert.ToInt32(Console.ReadLine());
            totalStudentAge = totalStudentAge + leeftijdStudent3;
            int leeftijdStudent4;
            Console.Write("Student 4 wat is je leeftijd? ");
            leeftijdStudent4 = Convert.ToInt32(Console.ReadLine());
            totalStudentAge = totalStudentAge + leeftijdStudent4;

            Console.WriteLine("De leeftijd van alle studenten is " + totalStudentAge);
            Console.WriteLine("Opdracht 5 klaar");
        }


        //Zorg ervoor dat deze methode gebruikt wordt in jouw code.
        public int GetAge()
        {
            Console.Write("Wat is uw leeftijd? ");
            int returnAge = Convert.ToInt32(Console.ReadLine());
            return returnAge;
        }
    }
}
