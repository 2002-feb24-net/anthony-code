using System;
namespace problem1PlanetAge
{
    class Program
    {
        //Main Method
        static void Main(string[] args)
        {
          int age = getAge();
          double ageInSeconds = ageToSeconds(age);
          agePlanet(ageInSeconds);

        }

        // Get User Age Input
        static int getAge()
        {
            Console.WriteLine("Please enter your age: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            return age;
        }

        // Convert User age to age in Seconds
        static double ageToSeconds(int input)
        {
          double ageToSeconds = input * 60;
          return ageToSeconds;
        }

        //Select Planet and Print data
        static void agePlanet(double ageInSeconds)
        {
            Console.WriteLine("Please select a planet");
            Console.WriteLine("1. Mercury\n2. Venus\n3. Earth\n4. Mars\n5. Jupiter\n6. Saturn\n7. Uranus\n8. Neptune\n9. Pluto ");
            string input1 = Console.ReadLine();
            

            //Mercury
            if (input1 == "1")
            {
            double mercury = 4222.6 * 120;
            double mercuryAge = ageInSeconds * mercury;
            System.Console.WriteLine(mercuryAge);
            }

            //Venus
            if (input1 == "2")
            {
            double venus = 2802.0 * 120;
            double venusAge = ageInSeconds * venus;
            }

            //Earth
            if (input1 == "3")
            {
            double earth = 24.0 * 120;
            double earthAge = ageInSeconds * earth;
            System.Console.WriteLine(earth);
            }

            //Mars
            if (input1 == "4")
            {
            double mars = 24.7 * 120;
            double marsAge = ageInSeconds * mars;
            }

            //Jupiter
            if (input1 == "5")
            {
            double jupiter = 9.9 * 120;
            double jupiterAge = ageInSeconds * jupiter;
            }

            //Saturn
            if (input1 == "6")
            {
            double saturn = 10.7 * 120;
            double saturnAge = ageInSeconds * saturn;
            }

            //Uranus
            if (input1 == "7")
            {
            double uranus = 17.2 * 120;
            double uranusAge = ageInSeconds * uranus;
            }

            //Neptune
            if (input1 == "8")
            {
            double neptune = 16.1 * 120;
            double neptuneAge = ageInSeconds * neptune;
            }

            //Pluto
            if (input1 == "9")
            {
            double pluto = 153.3 * 120;
            double plutoAge = ageInSeconds * pluto;
            }

        }

    }

}