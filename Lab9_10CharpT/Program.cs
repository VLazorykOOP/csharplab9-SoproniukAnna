//using Lab9_10CharpT;
using Lab9_10CharpT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("             Lab#9");
        Console.WriteLine("             Task1");
        string postfixExpression = "ab+c*";

        string prefixExpression = PostfixToPrefix(postfixExpression);
        Console.WriteLine("Postfix expression: " + postfixExpression);
        Console.WriteLine("Prefix expression: " + prefixExpression);
        //---------------------------------------------------------------------------
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("             Task2");
        Queue<Employee> lowSalaryEmployees = new Queue<Employee>();
        Queue<Employee> highSalaryEmployees = new Queue<Employee>();

        string[] lines = File.ReadAllLines("Task2.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            Employee employee = new Employee
            {
                LastName = parts[0],
                FirstName = parts[1],
                MiddleName = parts[2],
                Position = parts[3],
                Sex = (parts[4]),
                Age = int.Parse(parts[5]),
                Salary = double.Parse(parts[6])
            };

            if (employee.Salary < 10000)
                lowSalaryEmployees.Enqueue(employee);
            else
                highSalaryEmployees.Enqueue(employee);
        }

        Console.WriteLine("Employees with a low salary (less than 10,000):");
        PrintEmployees(lowSalaryEmployees);
        Console.WriteLine("\nEmployees with a high salary (10,000 or more):");
        PrintEmployees(highSalaryEmployees);


        static void PrintEmployees(Queue<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"LastName: {employee.LastName}, FirstName: {employee.FirstName}, MiddleName: {employee.MiddleName}, " +
                                  $"Position: {employee.Position}, Sex: {employee.Sex}, Age: {employee.Age}, Salary: {employee.Salary}");
            }
        }


        //---------------------------------------------------------------------------
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("             Task4");
        MusicDisc disc1 = new MusicDisc();

        disc1.AddSong("Star Shopping", "Lil Peep");
        disc1.AddSong("Fortnight", "Tasylor Swift");
        disc1.AddSong("HTT", "Platina");

        Console.WriteLine("Contents of disc1:");
        disc1.DisplayContents();

        string artistToSearch = "Platina";
        bool containsArtist = disc1.ContainsArtist(artistToSearch);
        Console.WriteLine($"\nDoes disc1 contain songs by {artistToSearch}? {containsArtist}");

        string songToRemove = "Star Shopping";
        disc1.RemoveSong(songToRemove);
        Console.WriteLine($"\nRemoved song '{songToRemove}' from disc1.");

        Console.WriteLine("\nContents of disc1 after removing a song:");
        disc1.DisplayContents();



    }

    //---------------------------------------------------------------------------
    //Task1
    static string PostfixToPrefix(string postfix)
    {
        Stack<string> stack = new Stack<string>();

        for (int i = 0; i < postfix.Length; i++)
        {
            char ch = postfix[i];

            if (IsOperand(ch))
                stack.Push(ch.ToString());
            else if (IsOperator(ch))
            {
                string operand1 = stack.Pop();
                string operand2 = stack.Pop();

                string expression = ch + operand2 + operand1;
                stack.Push(expression);
            }
        }
        return stack.Pop();
    }

    static bool IsOperand(char ch)
    {
        return (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z');
    }

    static bool IsOperator(char ch)
    {
        return ch == '+' || ch == '-' || ch == '*' || ch == '/';
    }
}

//Task2
class Employee
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string Position { get; set; }
    public string Sex { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
}