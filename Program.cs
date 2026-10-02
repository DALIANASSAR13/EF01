using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignments_Day01
{
    internal class Program
    {
        static void Main()
        {
            #region Part 1 - var

            #region 1. Basic var usage
            var Number = 10;
            var Text = "Ali";
            var Price = 99.5;
            var IsActive = true;
            var Arr = new int[] { 1, 2, 3, 4 };

            Console.WriteLine(Number.GetType());
            Console.WriteLine(Text.GetType());
            Console.WriteLine(Price.GetType());
            Console.WriteLine(IsActive.GetType());
            Console.WriteLine(Arr.GetType());
            #endregion

            #region 2. var vs explicit type
            int A1 = 5;
            string N1 = "Ahmed";
            double S1 = 3500.5;
            bool F1 = false;

            var A2 = 5;
            var N2 = "Ahmed";
            var S2 = 3500.5;
            var F2 = false;

            Console.WriteLine(A1.GetType() == A2.GetType());
            Console.WriteLine(N1.GetType() == N2.GetType());
            Console.WriteLine(S1.GetType() == S2.GetType());
            Console.WriteLine(F1.GetType() == F2.GetType());
            #endregion

            #endregion

            #region Part 2 - Anonymous Types

            #region 3. Anonymous type basics
            var Product = new { Name = "Laptop", Price = 25000.0, Quantity = 5 };
            Console.WriteLine(Product.Name);
            Console.WriteLine(Product.Price);
            Console.WriteLine(Product.Quantity);
            Console.WriteLine(Product);
            #endregion

            #region 4. Array of anonymous types
            var Students = new[]
            {
                new { Name = "Ali",  Grade = 85 },
                new { Name = "Sara", Grade = 92 },
                new { Name = "Omar", Grade = 78 }
            };

            foreach (var student in Students)
            {
                Console.WriteLine($"Name : {student.Name}, Grade : {student.Grade}");
            }
            #endregion

            #region 5. Nested anonymous type
            var Order = new
            {
                OrderId = 101,
                Total = 1500.75,
                Customer = new { Name = "Mona", City = "Cairo" }
            };

            Console.WriteLine($"Order Id : {Order.OrderId}");
            Console.WriteLine($"Total : {Order.Total}");
            Console.WriteLine($"Customer Name : {Order.Customer.Name}");
            Console.WriteLine($"Customer City : {Order.Customer.City}");
            Console.WriteLine(Order);
            #endregion

            #endregion

            #region Part 3 - Extension Methods

            #region 6. String extension method IsPalindrome
            string[] Words = { "level", "Madam", "hello", "racecar", "abc" };
            foreach (string word in Words)
            {
                Console.WriteLine($"{word} is palindrome ? {word.IsPalindrome()}");
            }
            #endregion

            #region 7. Int extension method IsPrime
            int[] Numbers = { 1, 2, 7, 10, 13, 25, 29 };
            foreach (int num in Numbers)
            {
                Console.WriteLine($"{num} is prime ? {num.IsPrime()}");
            }
            #endregion

            #region 8. Array extension method Sum
            int[] Arr02 = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Custom Array Sum: {Arr02.Sum()}");
            #endregion

            #endregion

            #region Part 4 - Collections

            #region 9. List basics
            List<string> Names = new List<string>();
            Names.Add("Ali");
            Names.Add("Sara");
            Names.Add("Omar");
            Names.Add("Mona");

            string SearchName = "Omar";
            bool Found = false;
            for (int i = 0; i < Names.Count; i++)
            {
                if (Names[i] == SearchName)
                {
                    Found = true;
                    break;
                }
            }
            Console.WriteLine(Found ? $"{SearchName} is found" : $"{SearchName} is not found");

            string RemoveName = "Sara";
            for (int i = 0; i < Names.Count; i++)
            {
                if (Names[i] == RemoveName)
                {
                    Names.RemoveAt(i);
                    break;
                }
            }

            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
            #endregion

            #region 10. List of custom objects
            List<Employee> Emps = new List<Employee>()
            {
                new Employee() { Name = "Ali",  Salary = 3000 },
                new Employee() { Name = "Sara", Salary = 5500 },
                new Employee() { Name = "Omar", Salary = 7200 },
                new Employee() { Name = "Mona", Salary = 4100 }
            };

            double MinSalary = 4000;
            foreach (Employee emp in Emps)
            {
                if (emp.Salary > MinSalary)
                    Console.WriteLine(emp);
            }
            #endregion

            #region 11. Dictionary basics
            Dictionary<string, int> Products = new Dictionary<string, int>();
            Products.Add("Laptop", 25000);
            Products.Add("Mouse", 300);
            Products.Add("Keyboard", 700);

            foreach (KeyValuePair<string, int> item in Products)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            #endregion

            #region 12. Dictionary lookup
            Dictionary<int, string> StudentsDic = new Dictionary<int, string>()
            {
                { 1, "Ali" },
                { 2, "Sara" },
                { 3, "Omar" }
            };

            Console.Write("Enter student Id : ");
            if (int.TryParse(Console.ReadLine(), out int Id))
            {
                if (StudentsDic.TryGetValue(Id, out string StudentName))
                    Console.WriteLine($"Student Name : {StudentName}");
                else
                    Console.WriteLine("Student not found");
            }
            else
            {
                Console.WriteLine("Invalid Id");
            }
            #endregion

            #region 13. Hashtable basics
            Hashtable Table = new Hashtable();
            Table.Add(1, "Ali");
            Table.Add("Two", 2);
            Table.Add(3.5, true);
            Table.Add('K', "Letter");

            foreach (DictionaryEntry entry in Table)
            {
                Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            }
            #endregion

            #region 14. Dictionary vs Hashtable
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            Dic.Add("EG", "Egypt");
            Dic.Add("SA", "Saudi Arabia");

            Hashtable Ht = new Hashtable();
            Ht.Add("EG", "Egypt");
            Ht.Add("SA", "Saudi Arabia");

            string C1 = Dic["EG"];
            string C2 = (string)Ht["EG"];

            Console.WriteLine(C1);
            Console.WriteLine(C2);
            #endregion

            #endregion
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Name is {Name}, Salary is {Salary}";
        }
    }

    public static class StringExtension
    {
        public static bool IsPalindrome(this string str)
        {
            if (string.IsNullOrEmpty(str)) return false;

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                if (char.ToLower(str[i]) != char.ToLower(str[j]))
                    return false;
            }
            return true;
        }
    }

    public static class IntExtension
    {
        public static bool IsPrime(this int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }

    public static class ArrayExtension
    {
        public static int Sum(this int[] arr)
        {
            if (arr == null) return 0;

            int Total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Total += arr[i];
            }
            return Total;
        }
    }
}