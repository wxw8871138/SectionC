using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionCTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.q1();
            //Program.q2();
            //Program.q3();
            //Program.q4();
            //Program.q5();
            Program.q6();
        }
        static void q1()
        {
            Console.WriteLine("question 1:");
            Console.Write("input your name:");
            String name = Console.ReadLine();
            Console.Write("input your gender:");
            String gender = Console.ReadLine();
            if (gender == "M")
            {
                gender = "Mr.";
            }
            else if (gender == "F")
            {
                gender = "Ms.";
            }
            Console.WriteLine("Good Morning {0} {1}", gender, name);
        }
        static void q2()
        {
            Console.WriteLine("question 2:");
            Console.Write("input your name:");
            String name = Console.ReadLine();
            Console.Write("input your gender:");
            String gender = Console.ReadLine();
            Console.Write("input your age:");
            String inputAge = Console.ReadLine();
            int age = Convert.ToInt32(inputAge);
            if (age < 40)
            {
                if (gender == "M")
                {
                    gender = "Mr.";
                }
                else if (gender == "F")
                {
                    gender = "Ms.";
                }
                Console.WriteLine("Good Morning {0} {1}", gender, name);

            }
            else
            {
                if (gender == "M")
                {
                    gender = "Uncle";
                }
                else if (gender == "F")
                {
                    gender = "Aunty";
                }
                Console.WriteLine("Good Morning {0} {1}", gender, name);
            }

        }
        static void q3()
        {
            Console.WriteLine("question 3:");
            Console.Write("input the grade:");
            string input = Console.ReadLine();
            int mark = Convert.ToInt32(input);
            if (mark < 0 || mark > 100)
            {
                Console.WriteLine("**Error**");
            }
            else if ((80 <= mark) && (mark <= 100))
            {
                Console.WriteLine("You scored {0} marks which is A grade.",mark);
            }
            else if ((60 <= mark) && (mark <= 79))
            {
                Console.WriteLine("You scored {0} marks which is B grade.", mark);
            }
            else if ((40 <= mark) && (mark <= 59))
            {
                Console.WriteLine("You scored {0} marks which is C grade.", mark);
            }
            else if ((0 < mark) && (mark <= 39))
            {
                Console.WriteLine("You scored {0} marks which is F grade.", mark);
            }
        }
        static void q4()
        {
            Console.WriteLine("question 4:");
            Console.Write("input the distance:");
            string input = Console.ReadLine();
            double distance = Convert.ToDouble(input);
            distance = distance * 10;
            distance = Math.Ceiling(distance);
            distance = distance / 10;
            double cost=0;
            if (distance <= 0.5)
            {
                cost = 2.40;
            }
            else if (( 0.5< distance) && (distance <= 9))
            {
                cost = 2.40 + (distance - 0.5) * 0.4;
            }
            else if (9<distance)
            {
                cost = 2.40+8.5*0.4+(distance - 9)*0.5;
            }
            Console.WriteLine("cost:{0:0.0}", cost);

        }
        static void q5()
        {
            Console.WriteLine("question 5:");
            Console.Write("input a three-digit number:");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            int a, b, c;
            a = number / 100;
            b = number / 10;
            b = b % 10;
            c = number % 10;
            if (number == a * a * a + b * b * b + c * c * c)
            {
                Console.WriteLine("True");
            }else
            {
                Console.WriteLine("False");
            }
        }
        static void q6()
        {

            Console.WriteLine("question 6:");
            Console.Write("TV number:");
            string input = Console.ReadLine();
            int tv = Convert.ToInt32(input);
            Console.Write("DVD number:");
            input = Console.ReadLine();
            int dvd = Convert.ToInt32(input);
            Console.Write("MP3 number:");
            input = Console.ReadLine();
            int mp3 = Convert.ToInt32(input);
            double price = tv * 900 + dvd * 500 + mp3 * 700;
            if (price <= 5000)
            {
                price = price;
            }
            else if(5000 < price && price <= 10000)
            {
                price = (tv * 900 + dvd * 500) * (1-0.1) + mp3 * 700;
            }
            else if (price > 10000)
            {
                price = (tv * 900 + dvd * 500) * (1-0.15) + mp3 * 700;
            }
            Console.WriteLine("Discounted price:{0}",price);
        }
    }
    
}
