// See https://aka.ms/new-console-template for more information

using PracticeAssignment1;

Console.WriteLine("Welcome to your new job!");

Console.WriteLine("Please enter your name");
var name = Console.ReadLine();

Console.WriteLine("Please enter your birthday");
var birthdayInput = Console.ReadLine();

DateTime birthday; 

while(!DateTime.TryParse(birthdayInput, out birthday))
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

Console.WriteLine($"Welcome to the company, {employee.Name}! " +
    $"Your salary is {employee.Salary} " +
    $"and your birthday is {employee.Birthday.ToShortDateString()}.");


DateTime myNextBirthday = new DateTime(DateTime.Today.Year, employee.Birthday.Month, employee.Birthday.Day);

if (myNextBirthday < DateTime.Today) //birthday already happened this year
{
    myNextBirthday = myNextBirthday.AddYears(1);
}

var daysUntilBirthday = (myNextBirthday - DateTime.Today).Days;
Console.WriteLine($"Your birthday will be in {daysUntilBirthday} days!");



