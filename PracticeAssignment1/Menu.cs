namespace PracticeAssignment1
{
    internal class Menu
    {
        public static List<Employee> AddEmployee(List<Employee> employeeList)
        {
            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();

            Console.WriteLine("Please enter your birthday");
            var birthdayInput = Console.ReadLine();

            DateTime birthday;

            while (!DateTime.TryParse(birthdayInput, out birthday))
            {
                Console.WriteLine("Invalid birthday, please try again");
                birthdayInput = Console.ReadLine();
            }

            Console.WriteLine("Please enter your salary");
            var salary = Console.ReadLine();

            var employee = new Employee
            {
                Name = name,
                Birthday = birthday,
                Salary = decimal.Parse(salary)
            };

            employeeList.Add(employee);

            Console.WriteLine($"Welcome to the company, {employee.Name}! " +
                $"Your salary is {employee.Salary} " +
                $"and your birthday is {employee.Birthday.ToShortDateString()}.");

            var daysTillNext = GetDaysUntilBirthday(employee.Birthday);
            Console.WriteLine($"It is {daysTillNext} days until the next birthday");

            return employeeList;
        }

        public static void DisplayEmployees(List<Employee> employeeList)
        {
            foreach(Employee employee in employeeList)
            {
                var daysUntilBirthday = GetDaysUntilBirthday(employee.Birthday);
                Console.WriteLine($"Employee {employee.Name} makes {employee.Salary} " +
                    $"and was born on {employee.Birthday.ToShortDateString()}. It is " +
                    $"{daysUntilBirthday} days until their next birthday");
            }
        }

        public static List<Employee> RemoveEmployee(List<Employee> employeeList, string name)
        {
            var employeeToRemove = employeeList.First(item => item.Name == name);
            employeeList.Remove(employeeToRemove);
            return employeeList;
        }

        private static int GetDaysUntilBirthday(DateTime birthday)
        {
            DateTime nextBirthday = new DateTime(DateTime.Today.Year, birthday.Month, birthday.Day);
            if (nextBirthday < DateTime.Today) //birthday already happened this year
            {
                nextBirthday = birthday.AddYears(1);
            }

            return (nextBirthday - DateTime.Today).Days;
        }
    }
}
