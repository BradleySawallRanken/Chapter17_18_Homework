using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter18_Homework
{
    internal class Program
    {
        const string NOTHINGINPUTTED = "No Value Inputted for Search Criteria";
        const string NOLASTNAMEFOUND = "No Matching Employee Last NameFound";
        const string NOADDRESSFOUND = "No Matching Employee Address Found";
        const string NOCITYFOUND = "No Matching Employee City Found";
        const string NOSTATEFOUND = "No Matching Employee State Found";
        const string NOZIPCODEFOUND = "No Matching Employee ZipCode Found";


        static List<Employee> employees = EmployeeManager.LoadData();
        static void Main(string[] args)
        {
            int option;
            bool runAgain = true;

            while (runAgain)
            {
                option = ShowMenu();
                CallCorrectFunction(option);
                runAgain = AnotherTime();
            }
        }
        static int ShowMenu()
        {
            Console.Clear();

            string option = "";
            int optionChosen = 0;
            bool result;

            string menuStr = "Please choose one of the following options\n";
            menuStr += "Enter a 1 to show all employees last name ascending\n";
            menuStr += "Enter a 2 to show all employees by address ascending\n";
            menuStr += "Enter a 3 to show all employees by city ascending\n";
            menuStr += "Enter a 4 to show all employees by state ascending\n";
            menuStr += "Enter a 5 to show all employees by zipcode ascending\n";
            menuStr += "Enter a 6 to show one or more employees by last name\n";
            menuStr += "Enter a 7 to show one or more employees by address\n";
            menuStr += "Enter a 8 to show one or more employees by city\n";
            menuStr += "Enter a 9 to exit the program now\n\n";
            menuStr += "Please enter a 1, 2, 3, 4, 5, 6, 7, 8, or 9 now: \n";

            Write(menuStr);
            option = ReadLine();

            result = int.TryParse(option, out optionChosen);

            if (!result)
            {
                Write("You Must Enter A Number! Please Try Again: ");
                ReadLine();
                ShowMenu();
            }

            else if (optionChosen < 1 || optionChosen > 9)
            {
                Write("You Must Enter A Number! Please Try Again: ");
                ReadLine();
                ShowMenu();
            }
            return optionChosen;
        }
        static void CallCorrectFunction(int option)
        {
            switch (option)
            {
                case 1:
                    ShowEmployeesByLastNameAscending();
                    break;

                case 2:
                    ShowEmployeesByAddressAscending();
                    break;

                case 3:
                    ShowEmployeesByCityAscending();
                    break;

                case 4:
                    ShowEmployeesByStateAscending();
                    break;

                case 5:
                    ShowEmployeesByZipCodeAscending();
                    break;

                case 6:
                    ShowEmployeesByLastNameCriteria();
                    break;

                case 7:
                    ShowEmployeesByAddressCriteria();
                    break;

                case 8:
                    ShowEmployeesByCityCriteria();
                    break;

                case 9:
                    ExitProgramNow();
                    break;

                default:
                    break;
            }

        }

        static void ShowEmployeesByLastNameAscending()
        {
            Console.Clear();

            var lastNameAscending =
                from e in employees
                orderby e.LastName ascending, e.FirstName ascending
                select e;

            Console.WriteLine("All Employees By Last Name In Ascending Order:\n");
            foreach (var e in lastNameAscending)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }

        static void ShowEmployeesByAddressAscending()
        {
            Console.Clear();

            var addressAscending =
                from e in employees
                orderby e.Address, e.LastName ascending, e.FirstName ascending
                select e;

            Console.WriteLine("All Employees By Address In Ascending Order:\n");
            foreach (var e in addressAscending)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }

        static void ShowEmployeesByCityAscending()
        {
            Console.Clear();

            var stateAscending =
                from e in employees
                orderby e.City, e.LastName ascending, e.FirstName ascending
                select e;

            Console.WriteLine("All Employees By City In Ascending Order:\n");
            foreach (var e in stateAscending)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
        static void ShowEmployeesByStateAscending()
        {
            Console.Clear();

            var stateAscending =
                from e in employees
                orderby e.State, e.LastName ascending, e.FirstName ascending
                select e;

            Console.WriteLine("All Employees By State In Ascending Order:\n");
            foreach (var e in stateAscending)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
        static void ShowEmployeesByZipCodeAscending()
        {
            Console.Clear();

            var zipCodeAscending =
                from e in employees
                orderby e.ZipCode, e.LastName ascending, e.FirstName ascending
                select e;

            Console.WriteLine("All Employees By Zip Code In Ascending Order:\n");
            foreach (var e in zipCodeAscending)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }

        static void ShowEmployeesByLastNameCriteria()
        {
            Console.Clear();

            string lastName;
            Write("Enter an employee last name to search for (full or partial): ");
            lastName = ReadLine();

            if (lastName.Trim() == "")
            {
                WriteLine(NOTHINGINPUTTED);
            }
            else
            {
                var lastNames =
                    from e in employees
                    orderby e.LastName ascending
                    where e.LastName.ToUpper().Contains(lastName.ToUpper())
                    select e;

                WriteLine("\nLast Names Matching Inputted Criteria: ");
                if (lastNames.Count() < 1)
                {
                    WriteLine(NOLASTNAMEFOUND);
                    ReadLine();
                    return;
                }
                foreach (var ln in lastNames)
                {
                    WriteLine(ln);
                    ReadLine();
                }
            }
        }
        static void ShowEmployeesByAddressCriteria()
        {
            Console.Clear();

            string Address;
            Write("Enter an employee address to search for (full or partial): ");
            Address = ReadLine();

            if (Address.Trim() == "")
            {
                WriteLine(NOTHINGINPUTTED);
            }
            else
            {
                var addresses =
                    from e in employees
                    orderby e.LastName ascending
                    where e.Address.ToUpper().Contains(Address.ToUpper())
                    select e;

                WriteLine("\nAddresses Matching Inputted Criteria: ");
                if (addresses.Count() < 1)
                {
                    WriteLine(NOADDRESSFOUND);
                    ReadLine();
                    return;
                }
                foreach (var ln in addresses)
                {
                    WriteLine(ln);
                    ReadLine();
                }
            }
        }
        static void ShowEmployeesByCityCriteria()
        {
            Console.Clear();

            string city;
            Write("Enter an employee city to search for (full or partial): ");
            city = ReadLine();

            if (city.Trim() == "")
            {
                WriteLine(NOTHINGINPUTTED);
            }
            else
            {
                var cities =
                    from e in employees
                    orderby e.City ascending
                    where e.City.ToUpper().Contains(city.ToUpper())
                    select e;

                WriteLine("\nCities Matching Inputted Criteria: ");
                if (cities.Count() < 1)
                {
                    WriteLine(NOCITYFOUND);
                    ReadLine();
                    return;
                }
                foreach (var ln in cities)
                {
                    WriteLine(ln);
                    ReadLine();
                }
            }
        }
        static void ExitProgramNow()
        {
            Clear();
            WriteLine("Program Terminating Normally. Bye for now.");
            ReadLine();
            Environment.Exit(0);
        }

        static bool AnotherTime()
        {
            Write("Run Program Again?!? (Y / N): ");
            string again = ReadLine().ToUpper();

            return again.StartsWith("Y");
        }

    }
}
