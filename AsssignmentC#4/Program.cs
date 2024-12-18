using System.Reflection.Metadata;
using System.Reflection;
using System.Threading.Channels;
using System.Data.Common;
using System.Security.Cryptography;
#region Q1
//Difference Between Passing Value Type Parameters by Value and by Reference
// By Value: A copy of the variable is passed to the function. Changes made to the parameter inside the function do not affect the original variable.
// By Reference: A reference to the original variable is passed.Changes made to the parameter inside the function affect the original variable.
/* using System;

namespace Q1
{
    class Program
    {
        static void ModifyByValue(int x)
        {
            x += 10;
        }

        static void ModifyByReference(ref int x)
        {
            x += 10;
        }

        static void Main()
        {
            int number = 20;
            Console.WriteLine($"Original number: {number}");

            ModifyByValue(number);
            Console.WriteLine($"After ModifyByValue: {number}");

            ModifyByReference(ref number);
            Console.WriteLine($"After ModifyByReference: {number}");
        }
    }
}
*/
#endregion


#region Q2
//Difference Between Passing Reference Type Parameters by Value and by Reference
//By Value: A copy of the reference is passed.Changes to the object are reflected in the original because both the original and the parameter point to the same object.
//By Reference: A reference to the reference is passed, allowing the function to change which object the reference points to.using System;

/* namespace Q2
{
    class Program
    {
        static void ModifyByValue(string[] arr) => arr[0] = "Changed";

        static void ModifyByReference(ref string[] arr) => arr = new string[] { "New Array" };

        static void Main()
        {
            string[] myArray = { "Original" };
            Console.WriteLine($"Before: {myArray[0]}");

            ModifyByValue(myArray);
            Console.WriteLine($"After ModifyByValue: {myArray[0]}");

            ModifyByReference(ref myArray);
            Console.WriteLine($"After ModifyByReference: {myArray[0]}");
        }
    }
} */
#endregion


#region Q3
/* using System;

namespace Q3
{
    class Program
    {
        static (int sum, int difference) AddAndSubtract(int a, int b)
        {
            return (a + b, a - b);
        }

        static void Main()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            var result = AddAndSubtract(num1, num2);
            Console.WriteLine($"Sum: {result.sum}, Difference: {result.difference}");
        }
    }
} */
#endregion

#region Q4
/* using System;

namespace Q4
{
    class Program
    {
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"The sum of the digits of the number {num} is: {SumOfDigits(num)}");
        }
    }
} */
#endregion


#region Q5
/*
using System;

namespace Q5
{
    class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num} is {(IsPrime(num) ? "a Prime Number" : "not a Prime Number")}");
        }
    }
} */
#endregion


#region Q6
/* using System;

namespace Q6
{
    class Program
    {
        static void MinMaxArray(int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];
            foreach (var item in arr)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }
        }

        static void Main()
        {
            int[] numbers = { 3, 5, 1, 8, 7 };
            MinMaxArray(numbers, out int min, out int max);

            Console.WriteLine($"Minimum: {min}, Maximum: {max}");
        }
    }
} */
#endregion


#region Q7
/* using System;

namespace Q7
{
   class Program
   {
       static int Factorial(int number)
       {
           int result = 1;
           for (int i = 1; i <= number; i++)
           {
               result *= i;
           }
           return result;
       }

       static void Main()
       {
           Console.Write("Enter a number: ");
           int num = int.Parse(Console.ReadLine());

           Console.WriteLine($"Factorial of {num} is: {Factorial(num)}");
       }
   }
} */
#endregion


#region Q8
/*
 using System;

namespace Q8
{
    class Program
    {
        static string ChangeChar(string str, int index, char newChar)
        {
            char[] chars = str.ToCharArray();
            chars[index] = newChar;
            return new string(chars);
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter index to modify: ");
            int index = int.Parse(Console.ReadLine());

            Console.Write("Enter new character: ");
            char newChar = Console.ReadKey().KeyChar;

            Console.WriteLine();
            Console.WriteLine($"Modified string: {ChangeChar(input, index, newChar)}");
        }
    }
} */
#endregion




