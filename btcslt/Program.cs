using System;
using System.Text;

namespace BaitapCSLT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            BT1();
            BT2();
            BT3();
            BT4();
            BT5();
            BT6();
            BT7();
            BT8();
            BT9();
            BT10();
            BT11();
            BT12();
            BT13();
            BT14();
            BT15();
            BT16();
            BT17();
            BT18();
            BT19();
            BT20();
            BT21();
            BT22();
            BT23();

            Console.ReadKey();
        }

        static void BT1()
        {
            Console.WriteLine("--- BT1: Print Hello and Name ---");
            Console.WriteLine("Hello:");
            Console.WriteLine("Alexandra Abramo");
        }

        static void BT2()
        {
            Console.WriteLine("--- BT2: Sum of Two Numbers ---");
            int a = 25, b = 35;
            Console.WriteLine("Sum of {0} and {1} is: {2}", a, b, a + b);
        }

        static void BT3()
        {
            Console.WriteLine("--- BT3: Divide Two Numbers ---");
            double a = 10.0, b = 2.0;
            Console.WriteLine("{0} divided by {1} is: {2}", a, b, a / b);
        }

        static void BT4()
        {
            Console.WriteLine("--- BT4: Specified Operations ---");
            Console.WriteLine("-1 + 4 * 6 = {0}", -1 + 4 * 6);
            Console.WriteLine("(35 + 5) % 7 = {0}", (35 + 5) % 7);
            Console.WriteLine("14 + -4 * 6 / 11 = {0}", 14 + -4 * 6 / 11);
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = {0}", 2 + 15 / 6 * 1 - 7 % 2);
        }

        static void BT5()
        {
            Console.WriteLine("--- BT5: Swap Two Numbers ---");
            Console.Write("Input First Number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Input Second Number: ");
            int n2 = int.Parse(Console.ReadLine());

            int temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine("After Swapping: First={0}, Second={1}", n1, n2);
        }

        static void BT6()
        {
            Console.WriteLine("--- BT6: Multiply Three Numbers ---");
            Console.Write("Input num1, num2, num3: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} * {2} = {3}", a, b, c, a * b * c);
        }

        static void BT7()
        {
            Console.WriteLine("--- BT7: Arithmetic Operations ---");
            Console.Write("Input num1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Input num2: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 + n2);
            Console.WriteLine("{0} - {1} = {2}", n1, n2, n1 - n2);
            Console.WriteLine("{0} * {1} = {2}", n1, n2, n1 * n2);

            if (n2 != 0)
            {
                Console.WriteLine("{0} / {1} = {2}", n1, n2, n1 / n2);
                Console.WriteLine("{0} mod {1} = {2}", n1, n2, n1 % n2);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }

        static void BT8()
        {
            Console.WriteLine("--- BT8: Multiplication Table ---");
            Console.Write("Input a number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
        }

        static void BT9()
        {
            Console.WriteLine("--- BT9: Average of Four Numbers ---");
            double s = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Input number {0}: ", i);
                s += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Average: {0}", s / 4);
        }

        static void BT10()
        {
            Console.WriteLine("--- BT10: Formulas ---");
            Console.Write("Input x, y, z: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("(x+y)*z = {0}", (x + y) * z);
            Console.WriteLine("x*y + y*z = {0}", x * y + y * z);
        }

        static void BT11()
        {
            Console.WriteLine("--- BT11: Age Message ---");
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("You look older than {0}", age);
        }

        static void BT12()
        {
            Console.WriteLine("--- BT12: Repeat Number Rows ---");
            Console.Write("Input a number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", x);
            Console.WriteLine("{0}{0}{0}{0}", x);
            Console.WriteLine("{0} {0} {0} {0}", x);
            Console.WriteLine("{0}{0}{0}{0}", x);
        }

        static void BT13()
        {
            Console.WriteLine("--- BT13: Rectangle Pattern ---");
            Console.Write("Input a number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", x);
            for (int i = 0; i < 3; i++) Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0}{0}{0}", x);
        }

        static void BT14()
        {
            Console.WriteLine("--- BT14: Temperature Conversion ---");
            Console.Write("Input Celsius: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Kelvin: {0}", c + 273.15);
            Console.WriteLine("Fahrenheit: {0}", (c * 9.0 / 5.0) + 32);
        }

        static void BT15()
        {
            Console.WriteLine("--- BT15: Remove Characters ---");
            string str = "w3resource";
            Console.WriteLine(str.Remove(1, 1));
            Console.WriteLine(str.Remove(9, 1));
            Console.WriteLine(str.Remove(0, 1));
        }

        static void BT16()
        {
            Console.WriteLine("--- BT16: Swap First and Last ---");
            string Swap(string s)
            {
                if (s.Length <= 1) return s;
                return s[s.Length - 1] + s.Substring(1, s.Length - 2) + s[0];
            }
            Console.WriteLine(Swap("w3resource"));
            Console.WriteLine(Swap("Python"));
        }

        static void BT17()
        {
            Console.WriteLine("--- BT17: Add First Char to Both Ends ---");
            Console.Write("Input string: ");
            string s = Console.ReadLine();
            if (s.Length >= 1)
            {
                string f = s.Substring(0, 1);
                Console.WriteLine(f + s + f);
            }
        }

        static void BT18()
        {
            Console.WriteLine("--- BT18: Check Positive/Negative ---");
            Console.Write("Input two numbers: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("One positive, one negative? " + ((x < 0 && y > 0) || (x > 0 && y < 0)));
        }

        static void BT19()
        {
            Console.WriteLine("--- BT19: Sum or Triple Sum ---");
            int SumTriple(int a, int b) => (a == b) ? (a + b) * 3 : a + b;
            Console.WriteLine("2, 2 -> " + SumTriple(2, 2));
            Console.WriteLine("3, 2 -> " + SumTriple(3, 2));
        }

        static void BT20()
        {
            Console.WriteLine("--- BT20: Absolute Difference ---");
            Console.Write("Input two numbers: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int diff = Math.Abs(x - y);
            Console.WriteLine("Result: " + (x > y ? diff * 2 : diff));
        }
        
        static void BT21()
        {
            Console.WriteLine("--- BT21: Check for 20 or Sum Equals 20 ---");
            Console.Write("Input two numbers: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: " + (x == 20 || y == 20 || x + y == 20));
        }

        static void BT22()
        {
            Console.WriteLine("--- BT22: Check if a Number is Within 20 of 100 or 200 ---");
            Console.Write("Input a number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: " + (Math.Abs(x - 100) <= 20 || Math.Abs(x - 200) <= 20));
        }

        static void BT23()
        {
            Console.WriteLine("--- BT23: 23. Convert String to Lowercase ---");
            Console.Write("Input a string: ");
            string s = Console.ReadLine();
            Console.WriteLine("Result: " + s.ToLower());
        }
    }
}
 
