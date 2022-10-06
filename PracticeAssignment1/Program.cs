// See https://aka.ms/new-console-template for more information

using PracticeAssignment1;

Console.WriteLine("Welcome to the program. Please choose from the following menu options:");
    Console.WriteLine("1: Add an employee");
    Console.WriteLine("2: View all current employees");
    Console.WriteLine("3: Remove an employee by name");
    Console.WriteLine("4: Exit");

List<Employee> employees = new List<Employee>();

string userInput = Console.ReadLine();

while(userInput != "4")
{
    
    if (userInput == "1")
    {
        employees = Menu.AddEmployee(employees);
    }
    else if (userInput == "2")
    {
        Menu.DisplayEmployees(employees);
    }
    else if (userInput == "3")
    {
        Console.WriteLine("Enter the name of the employee to remove");
        var name = Console.ReadLine();
        Menu.RemoveEmployee(employees, name);
    }
    else if (userInput == "4") //Exit
    {

    }
    Console.WriteLine("What next?");
    userInput = Console.ReadLine();
}

