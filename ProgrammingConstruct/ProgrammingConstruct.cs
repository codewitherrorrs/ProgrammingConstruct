using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class ProgrammingConstruct
    {
        //If and Else Statement.
        //1.Write a C# Sharp program to accept two integers and check whether they are equal or not.
        public void AcceptInteger()
        {
            Console.WriteLine("Enter the Value : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            int secondInteger = Convert.ToInt32(Console.ReadLine());
            if (firstInteger == secondInteger)
                Console.WriteLine("Both are Equal");
            else
                Console.WriteLine("Both are Different");
        }
        //Even Odd
        public void EvenOdd()
        {
            Console.WriteLine("Enter the Value : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            if (firstInteger % 2 == 0)
                Console.WriteLine("Even Number");
            else
                Console.WriteLine("Odd Number");
        }
        //Age Candidates.
        public void AgeEligible()
        {
            Console.WriteLine("Enter the Value : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            if (firstInteger >= 18)
                Console.WriteLine("Eligible");
            else
                Console.WriteLine("Not Eligible");
        }
        public void LargestOfThree()
        {
            Console.WriteLine("Enter The 3 Integer Value : ");
            int firstValue = int.Parse(Console.ReadLine());
            int secondValue = int.Parse(Console.ReadLine());
            int thirdValue = int.Parse(Console.ReadLine());
            if (firstValue > secondValue && firstValue > thirdValue)
                Console.WriteLine($"First Value is greater : {firstValue}");
            else if (secondValue > firstValue && secondValue > thirdValue)
                Console.WriteLine($"Second Value is greater: {secondValue}");
            else if (firstValue == secondValue && firstValue == thirdValue && secondValue == firstValue && secondValue == thirdValue && thirdValue == secondValue && thirdValue == firstValue)
                Console.WriteLine($"All Value are Equals");
            else
                Console.WriteLine($"Third Value is greater : {thirdValue}");
        }

        //Admission Eligibility
        public void AdmissionEligibility()
        {
            Console.WriteLine("Enter the Marks of Maths : ");
            int maths = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Marks of Physic : ");
            int physic = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Marks of Chemistry : ");
            int chemistry = int.Parse(Console.ReadLine());
            int total = maths + physic + chemistry;
            if (total >= 180)
                Console.WriteLine("You are Eligible for admission");
            else if ((maths + chemistry) >= 140 || (maths + physic) >= 140)
                Console.WriteLine("Also Eligible for admission");
            else
                Console.WriteLine("You are not Eligible for admission");
        }
        //SwitchCase Week Day 
        public void CalculateWeekDay()
        {
            Console.WriteLine("Enter the WeekDay");
            int weekday = int.Parse(Console.ReadLine());
            switch(weekday)
            {
                case 1:
                    Console.WriteLine("Today is Monday");
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Today is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Today is Friday");
                    break;
                case 6:
                    Console.WriteLine("Today is Saturday");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Day");
                    break;
            }
        }
        //Arithmetic Problem
        public void ArithmeticProblem()
        {
            Console.WriteLine("Enter the Two Value : ");
            int firstvalue = int.Parse(Console.ReadLine());
            int secondValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose Number for Doing Operation");
            Console.WriteLine("Press 1 for Addition , 2 for Substraction , 3 for Multiplication , 4 for division ");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine($"Addition of Two Integer : {firstvalue + secondValue}");
                    break;
                case 2:
                    Console.WriteLine($"Substraction of Two Integer : {firstvalue - secondValue}");
                    break;
                case 3:
                    Console.WriteLine($"Multiplication of Two Integer : {firstvalue * secondValue}");
                    break;
                case 4:
                    Console.WriteLine($"Division of Two Integer : {firstvalue / secondValue}");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
        //Print a table.
        public void TableOfTwo()
        {
            Console.WriteLine("Enter the Number : ");
            int number = int.Parse(Console.ReadLine());
            for(int i=1;i<number; i++)
            {
                Console.WriteLine($"The Table of 2 * {i} = {2 * i}");
            }
        }
        //Sum Of Square of n.
        public void SumOfSquare()
        {
            Console.WriteLine("Enter the Number : ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Sum of Square : {i * i}");
            }
        }
        //Factorial
        public void Factorial()
        {
            Console.WriteLine("Enter the number to find Factorial : ");
            int value = int.Parse(Console.ReadLine());
            int fact = 1;
            int temp = value;
            if (value == 0)
            {
                Console.WriteLine("Factoria of Zero is Zero");
            }
            else if(value < 0)
            {
                Console.WriteLine("Factorial of Negative Number is not Possible");
            }
            else
            {
                int i = 0;
                while (i<value)
                {
                    fact = fact * value;
                    value--;
                }
                Console.WriteLine($"Factorial of {temp} is {fact}");
            }
        }
        //FlipCoin
        public void FlipCoin()
        {
            int flipCoin = 1;
            for (int i = 0; i < 20; i++)
            {
                Random random = new Random();
                int value = random.Next(2);
                if (flipCoin == value)
                    Console.WriteLine($"It's Head");
                else
                    Console.WriteLine($"Its Tail");
            }    
        }
        //Reverse Given String
        public void ReverseString()
        {
            Console.WriteLine("Enter the string");
            string userstring = Console.ReadLine();
            int length = userstring.Length;
            char[] character = userstring.ToCharArray();
            for(int p=length-1; p>=0; p--) 
                Console.WriteLine($"{character[p]}");
        }
    }
}
