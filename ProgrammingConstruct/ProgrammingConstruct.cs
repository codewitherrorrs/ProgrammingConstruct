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

    }
}
