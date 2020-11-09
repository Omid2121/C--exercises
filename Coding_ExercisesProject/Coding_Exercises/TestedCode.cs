using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Exercises
{
    class TestedCode
    {
        /*
         *
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a letter");
            string a = Console.ReadLine();
            Console.WriteLine("Enter a letter");
            string b = Console.ReadLine();
            Console.WriteLine("Enter a letter");
            string c = Console.ReadLine();

            Console.WriteLine($"{c} {b} {a}");
            Console.ReadKey();
        }





         static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                width--;
            }
        }





         Console.Write("Input first number: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input operation: ");
            var operation = Console.ReadLine();
            Console.Write("Input second number: ");
            double num2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
            }
        }





        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("x = y² - 2y +1");
            Console.WriteLine();

            for (y = -5; y <= 5; y++)
            {
                x = y * y - 2 * y + 1;
                Console.WriteLine(
                    "y = {0} ; x=({0})² - 2*({0}) +1 = {1}",
                    y, x);
            }
        }




        float distance;
            float hour, min, sec;

            float timeSec;
            float mps;
            float kph, mph;

            Console.Write("Input distance(meters): ");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(hour): ");
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(minutes): ");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(seconds): ");
            sec = Convert.ToSingle(Console.ReadLine());
            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timeSec;
            kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;

            Console.WriteLine("Speed in meter is "+mps+"  Speed in km is "+kph+"Speed in miles is " + mph);






        static void Main(string[] args)
        {
            float r;
            float pi = 3.1415926535f;

            Console.Write("Radius: ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(4 * pi * (r * r));

            Console.WriteLine(4f / 3f * pi * (r * r * r));
        }





        Console.Write("Input a symbol: ");
            var userInput = Convert.ToChar(Console.ReadLine());
            var lst = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            if (lst.Contains(userInput))
                Console.WriteLine("It's a lowercase vowel.");
            else if (userInput >= '0' && userInput <= '9')
                Console.WriteLine("It's a digit.");
            else
                Console.WriteLine("It's another symbol.");






        static void Main(string[] args)
        {
            int evenNum, oddNum;
            Console.Write("Input a number: ");
            evenNum = int.Parse(Console.ReadLine());

            Console.Write("Input another number: ");
            oddNum = int.Parse(Console.ReadLine());

            if ((evenNum % 2 == 0) && (oddNum % 2 == 0))
            {
                Console.WriteLine("Numbers bothEven");
            }
            else
            {
                Console.WriteLine("there's a number odd");
            }
        }





        //**
        static void Main(string[] args)
        {
            string answer;
            string result;

            Console.Write("Input a Number : ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);
        }






         static void Main(string[] args)
        {
            int input1, input2;
            Console.WriteLine("input one: ");
            input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input two: ");
            input2 = Convert.ToInt32(Console.ReadLine());

            if (input1 == input2)
            {
                Console.WriteLine("inputs are equal", input1,input2);
            }
            else
            {
                Console.WriteLine("inputs are not equal",input1, input2);
            }
        }






         static void Main(string[] args)
        {
            int input1;
            Console.WriteLine("input the integer: ");
            input1 = Convert.ToInt32(Console.ReadLine());


            if (input1 % 2 == 0)
            {
                Console.WriteLine("your input is even", input1);
            }
            else
            {
                Console.WriteLine("your input is odd",input1);
            }
        }






        static void Main(string[] args)
        {
            int input1;
            Console.WriteLine("input the integer: ");
            input1 = Convert.ToInt32(Console.ReadLine());


            if (input1 > 0)
            {
                Console.WriteLine("your input is positive ", input1);
            }
            else
            {
                Console.WriteLine("your input is negative ", input1);
            }
        }






        static void Main(string[] args)
        {
            int input1;
            Console.WriteLine("input the year: ");
            input1 = Convert.ToInt32(Console.ReadLine());

            if (input1 % 400 == 0)
                Console.WriteLine("the year is not leap ", input1);
            
            else if (input1 % 100 == 0)
                Console.WriteLine("the year is not leap ", input1);
            
            else if (input1 % 4 == 0)
                Console.WriteLine("the year is not leap ", input1);
            
            else
                Console.WriteLine("the year is a leap ", input1);
            
        }






         static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three.");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three.");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest among three ");
            else
                Console.Write("The 3rd Number is the greatest among three ");
        }












*/
    }
}
