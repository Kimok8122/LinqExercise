﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numberListAbove = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax.
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers

            Console.WriteLine(numberListAbove.Sum());
            Console.WriteLine("------------------");
            Console.WriteLine(numberListAbove.Average());



            //Order numbers in ascending order and decsending order. Print each to console.

            var ascendOrder = numberListAbove.OrderBy(item => item);

            Console.WriteLine("------------------");

            foreach (var ascenOutcome in ascendOrder)
            {
                Console.WriteLine($"{ascenOutcome},");
            }

            var descendOrder = numberListAbove.OrderByDescending(item2 => item2);

            Console.WriteLine("------------------");

            foreach (var descenOutcome in descendOrder)
            {
                Console.WriteLine($"{descenOutcome},");
            }


            //Print to the console only the numbers greater than 6

            var numIsMoreThan6 = numberListAbove.Where(num => num > 6);

            Console.WriteLine("----");

            foreach (var moreThanOutcome in numIsMoreThan6)
            {
                Console.WriteLine(moreThanOutcome);
            }
            Console.WriteLine("----");

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            foreach ( var onlyOrderBy4 in ascendOrder.Take(4))
            {
                Console.WriteLine(onlyOrderBy4);

            }
            Console.WriteLine("----");

            //Change the value at index 4 to your age, then print the numbers in decsending order

            numberListAbove.SetValue(45, 4);

            var descendWithAge = numberListAbove.OrderByDescending(num => num);

            foreach (var descWithAgeOutcome in descendWithAge)
            {
                Console.WriteLine(descWithAgeOutcome);
            }

            var aescendWithAge = numberListAbove.OrderBy(num => num);

            Console.WriteLine("----");

            foreach (var adscWithAgeOutcome in aescendWithAge)
            {
                Console.WriteLine(adscWithAgeOutcome);
            }


            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.

            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.

            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35

            //Add an employee to the end of the list without using employees.Add()

            
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
