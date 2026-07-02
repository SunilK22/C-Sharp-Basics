using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{

    internal class DisplayPersonalDetails
    {
        public (string name, int age, string place) getDetails()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your place: ");
            string place = Console.ReadLine();

            return (name, age, place);
        }

        public void displayData()
        {
            (string name, int age, string place) result = getDetails();

            Console.WriteLine($"Your name is {result.name} from {result.place} with age of {result.age}");

            if (result.age < 18)
            {
                Console.WriteLine("Junior Dev in the making");
            }
            else if (result.age >= 18 && result.age < 35)
            {
                Console.WriteLine("Prime learing years");
            }
            else if (result.age > 35)
            {
                Console.WriteLine("Experience is your superpower");
            }

            Console.WriteLine("Want to enter another person: yes/no");
            string isContinue = Console.ReadLine();

            while(isContinue.ToLower() == "yes")
            {
                displayData();
                break;
            }
            
        }
    }

}
