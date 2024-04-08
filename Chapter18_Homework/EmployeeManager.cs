using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter18_Homework
{
    public class EmployeeManager
    {
        public static List<Employee> LoadData()
        {
            var empList = new List<Employee>();

            empList.Add(new Employee { FirstName = "John\n", LastName = "Doe\n", SocSecNumber = "111-22-3333\n", Address = "123 Main St.\n", City = "Highland\n", State = "IL\n", ZipCode = "62249\n" });
            empList.Add(new Employee { FirstName = "Mary\n", LastName = "Smith\n", SocSecNumber = "111-22-3334\n", Address = "234 Elm Way\n", City = "Belleville\n", State = "IL\n", ZipCode = "62223\n" });
            empList.Add(new Employee { FirstName = "Ken\n", LastName = "Cramer\n", SocSecNumber = "222-33-4567\n", Address = "1914 Oak St.\n", City = "St. Louis\n", State = "MO\n", ZipCode = "63113\n" });
            empList.Add(new Employee { FirstName = "Mike\n", LastName = "Adams\n", SocSecNumber = "192-32-2222\n", Address = "5619 Bell Way\n", City = "Belleville\n", State = "IL\n", ZipCode = "62223\n" });
            empList.Add(new Employee { FirstName = "Karen\n", LastName = "Crane\n", SocSecNumber = "333-44-5678\n", Address = "19 Park Place\n", City = "St. Louis\n", State = "MO\n", ZipCode = "63113\n" });
            empList.Add(new Employee { FirstName = "Bryan\n", LastName = "Kent\n", SocSecNumber = "333=55=7890\n", Address = "2312 Ninth St.\n", City = "St. Louis\n", State = "MO\n", ZipCode = "63113\n" });
            empList.Add(new Employee { FirstName = "Sven\n", LastName = "James\n", SocSecNumber = "888-77-6666\n", Address = "1800 Tenth Way\n", City = "St. Louis\n", State = "MO\n", ZipCode = "63113\n" });
            empList.Add(new Employee { FirstName = "Kent\n", LastName = "White\n", SocSecNumber = "777-66-5555\n", Address = "57 Board Pl.\n", City = "Belleville\n", State = "IL\n", ZipCode = "62223\n" });
            empList.Add(new Employee { FirstName = "Bill\n", LastName = "Green\n", SocSecNumber = "666-55-4444\n", Address = "22 Tree Way\n", City = "St. Louis\n", State = "MO\n", ZipCode = "63113\n" });
            empList.Add(new Employee { FirstName = "Bob\n", LastName = "Gold\n", SocSecNumber = "555-44-3333\n", Address = "4444 4th St.\n", City = "St. Louis\n", State = "MO\n", ZipCode = "63113\n" });
            empList.Add(new Employee { FirstName = "Fred\n", LastName = "Black\n", SocSecNumber = "444-33-2222\n", Address = "98 Forest Way\n", City = "Belleville\n", State = "IL\n", ZipCode = "62223\n" });
            empList.Add(new Employee { FirstName = "Jean\n", LastName = "Brown\n", SocSecNumber = "333-22-1111\n", Address = "5432 Green Dr.\n", City = "St. Louis\n", State = "MO\n", ZipCode = "63113\n" });
            empList.Add(new Employee { FirstName = "Jane\n", LastName = "Smith\n", SocSecNumber = "222-11-0000\n", Address = "51 Black Dr.\n", City = "St. Louis\n", State = "MO\n", ZipCode = "63113\n" });
            empList.Add(new Employee { FirstName = "Joan\n", LastName = "Stein\n", SocSecNumber = "111-00-9999\n", Address = "99 Kent Pl.\n", City = "St. Louis\n", State = "MO\n", ZipCode = "63113\n" });
            empList.Add(new Employee { FirstName = "Ben\n", LastName = "Jones\n", SocSecNumber = "222-33-4444\n", Address = "5050 One Way\n", City = "Belleville\n", State = "IL\n", ZipCode = "62223\n" });
            empList.Add(new Employee { FirstName = "Mark\n", LastName = "Freed\n", SocSecNumber = "333-44-5555\n", Address = "1912 Green Dr.\n", City = "St. Louis\n", State = "MO\n", ZipCode = "63113\n" });
            empList.Add(new Employee { FirstName = "Dick\n", LastName = "Jones\n", SocSecNumber = "444-55-6666\n", Address = "123 Forest Way\n", City = "St. Louis\n", State = "MO\n", ZipCode = "63113\n" });
            empList.Add(new Employee { FirstName = "Mike\n", LastName = "James\n", SocSecNumber = "777-88-9999\n", Address = "222 3rd St.\n", City = "St. Louis\n", State = "MO\n", ZipCode = "63113\n" });
            empList.Add(new Employee { FirstName = "Bill\n", LastName = "White\n", SocSecNumber = "888-99-0000\n", Address = "1910 Felt Way\n", City = "Belleville\n", State = "IL\n", ZipCode = "62223\n" });
            empList.Add(new Employee { FirstName = "Fred\n", LastName = "Bryant\n", SocSecNumber = "555-66-7777\n", Address = "145 Forest Way\n", City = "St. Louis\n", State = "MO\n", ZipCode = "63113\n" });

            return empList;
        }
    }
}
