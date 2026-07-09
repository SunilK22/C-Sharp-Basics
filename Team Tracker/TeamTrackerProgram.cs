using System;
using System.Data;
using Team_Tracker;


class TeamTrackerProgram
{


    static void Main(string[] args)
    {
        List<Person> persons = new List<Person>();
        List<IWorkable> workables = new List<IWorkable>();

        while (true)
        {
            try
            {
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your role: ");
                string role = Console.ReadLine();
                Console.WriteLine("Enter your experience in years: ");
                int exp = Convert.ToInt32(Console.ReadLine());

                if (exp < 0)
                {
                    throw new InvalidExperienceException("got InvalidExperienceException");
                }
                Console.WriteLine("Enter programming language: ");
                string lang = Console.ReadLine();
                Console.WriteLine("Enter team size: ");
                int team = Convert.ToInt32(Console.ReadLine());

                if (team > 1)
                {
                    Manager m = new Manager(name, role, exp, team);
                    workables.Add(m);
                    persons.Add(m);
                }
                else
                {
                    Developer p = new Developer(name, role, exp, lang);
                    workables.Add(p);
                    persons.Add(p);
                }

                Console.WriteLine("Do you want to add more members? (yes/no)");

                string isContinue = Console.ReadLine();

                if (isContinue.ToLower() != "yes")
                {
                    break;
                }

            }
            catch (InvalidExperienceException e)
            {
                Console.WriteLine($"Please provide valid experience: {e.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input: got exception " + ex.Message);
                Console.WriteLine("Please provide valid details");
            }
            finally
            {
                Console.WriteLine("Input attemp complete");
            }
        }

        //foreach (var item in persons)
        //{
        //    item.Introduce();

        //}

        //foreach (var item in workables)
        //{
        //    item.DoWork();
        //}

        // Searching persons from list using LINQ

        // Search by name
        Console.WriteLine("Enter name to search: ");
        string searchName = Console.ReadLine();
        var found = persons.Where(p => p.Name.ToLower() == searchName.ToLower()).ToList();

        // filter by experience more than 2 years
        var experienced = persons.Where(p => p.Experience > 2).ToList();

        // sort alphabetically
        var sorted = persons.OrderBy(p => p.Name).ToList();

        // count role
        var devCount = persons.Count(p => p.Role.ToLower() == "dev");
        var managerCount = persons.Count(p => p.Role.ToLower() == "manager");

        Console.WriteLine("\n--- Search Result ---");
        found.ForEach(p => p.Introduce());

        Console.WriteLine("\n--- Experienced Members (2+ years) ---");
        experienced.ForEach(p => p.Introduce());

        Console.WriteLine("\n--- All Members Alphabetically ---");
        sorted.ForEach(p => p.Introduce());

        Console.WriteLine($"\nDevelopers: {devCount}, Managers: {managerCount}");


    }
}