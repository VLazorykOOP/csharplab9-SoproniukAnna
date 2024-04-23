using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    /*internal class Program2
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("             Task3.1");
            string postfixExpression = "ab+c*";

            string prefixExpression = PostfixToPrefix(postfixExpression);
            Console.WriteLine("Postfix expression: " + postfixExpression);
            Console.WriteLine("Prefix expression: " + prefixExpression);


            Console.WriteLine("Task3.2");
            ArrayList lowSalaryEmployees = new ArrayList();
            ArrayList highSalaryEmployees = new ArrayList();

            string[] lines = System.IO.File.ReadAllLines("Task2.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                Employee employee = new Employee
                {
                    LastName = parts[0],
                    FirstName = parts[1],
                    MiddleName = parts[2],
                    Position = parts[3],
                    Sex = parts[4],
                    Age = int.Parse(parts[5]),
                    Salary = double.Parse(parts[6])
                };

                if (employee.Salary < 10000)
                    lowSalaryEmployees.Add(employee);
                else
                    highSalaryEmployees.Add(employee);
            }

            Console.WriteLine("Employees with a low salary (less than 10,000):");
            PrintEmployees(lowSalaryEmployees);
            Console.WriteLine("\nEmployees with a high salary (10,000 or more):");
            PrintEmployees(highSalaryEmployees);

            static void PrintEmployees(ArrayList employees)
            {
                foreach (Employee employee in employees)
                {
                    Console.WriteLine($"LastName: {employee.LastName}, FirstName: {employee.FirstName}, MiddleName: {employee.MiddleName}, " +
                                      $"Position: {employee.Position}, Sex: {employee.Sex}, Age: {employee.Age}, Salary: {employee.Salary}");
                }
            }


        }
        static string PostfixToPrefix(string postfix)
        {
            Stack stack = new Stack();

            for (int i = 0; i < postfix.Length; i++)
            {
                char ch = postfix[i];

                if (IsOperand(ch))
                    stack.Push(ch.ToString());
                else if (IsOperator(ch))
                {
                    ICloneable operand1 = (ICloneable)stack.Pop();
                    ICloneable operand2 = (ICloneable)stack.Pop();

                    string expression = ch + operand2.Clone().ToString() + operand1.Clone().ToString();
                    stack.Push(expression);
                }
            }
            return stack.Pop().ToString();
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


    class Employee : IComparable, ICloneable
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Position { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Employee otherEmployee = obj as Employee;
            if (otherEmployee != null)
                return this.Salary.CompareTo(otherEmployee.Salary);
            else
                throw new ArgumentException("Object is not an Employee");
        }

        public object Clone()
        {
            return new Employee
            {
                LastName = this.LastName,
                FirstName = this.FirstName,
                MiddleName = this.MiddleName,
                Position = this.Position,
                Sex = this.Sex,
                Age = this.Age,
                Salary = this.Salary
            };
        }
    }*/
}
