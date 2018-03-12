using System;
using static System.Console;

namespace National_Parks
{
    class TestPark
    {
        static void Main(string[] args)
        {
            Park park1 = new Park();
            park1.parkName = AquireStringValues("Name: ");
            park1.location = AquireStringValues("Location: ");
            park1.parkType = AquireStringValues("Type: ");
            park1.facilities = AquireStringValues("Facilities Available: ");
            park1.employees = AquireIntValues("How Many Park Employees: ");
            park1.annualVisitors = AquireIntValues("How Many Park Annual Visitors: ");
            park1.Budget = AquireDoubleValues("Annual Budget: ");
            park1.Fee = AquireDoubleValues("Fee Per Visitor: ");


            Park park2 = new Park("Heugonot", "Kerry GA", "Hiking, Biking, Camping");

            Park park3 = new Park("Aster Regional Park", "Maine", 5.00);

            Clear();

            //Printing out park1 object
            WriteLine(park1.ToString() + "\n\n");

            //Printing out park2 object
            WriteLine("Park: {0}\nPark Location: {1}\nFacilities Available: {2}\n\n", park2.parkName, park2.location, park2.facilities);

            WriteLine("Park: {0}\nPark Location: {1}\nEntrance Fee: {2:c}", park3.parkName, park3.location, park3.Fee);
            ReadKey();

        }

        //Asking the user for the string values
        static public String AquireStringValues(String whichString)
        {
            Write("Enter Park {0}", whichString);
            String inValue = ReadLine();

            return inValue;
        }

        //Asking the user for int values
        static public int AquireIntValues(String whichInt)
        {
            Write("Enter {0}", whichInt);
            String inValue = ReadLine();

            return int.Parse(inValue);
        }


        //Asking User For Park Annual Budget
        static double AquireDoubleValues(String whichDouble)
        {
            Write("Enter Park {0}", whichDouble);
            String inValue = ReadLine();

            return double.Parse(inValue);
        }

    }
}
