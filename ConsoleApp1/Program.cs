using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marksheet1
{
    class Grader
    {
        static void Main(string[] args)

        {
            int r, m1, m2, m3, t;
            float p;
            string n;
            List<string> student = new LIst<string>();
            List<int> rollNo = new LIst<int>();
            List<int> m1 = new LIst<int>();
            List<int> m3 = new LIst<int>();
            List<int> m2 = new LIst<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Roll Number :");
                student.Add = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name :");
                rollNo.Add = Convert.toInt32(Console.ReadLine());
                Console.WriteLine("Mark of Subject1 : ");
                m1.Add = Convert.toInt32(Console.ReadLine());
                Console.WriteLine("Mark of Subject2 : ");
                m2.Add = Convert.toInt32(Console.ReadLine());
                Console.WriteLine("Mark of Subject3 : ");
                m3.Add = Convert.toInt32(Console.ReadLine());
            }
            Random r = new Random();

            int num1 = r.Next(0.4);
            int num2 = r.Next(0.4);
            int num3 = r.Next(0.4);
            int num4 = r.Next(0.4);
            int num5 = r.Next(0.4);





            m3 = Convert.ToInt32(Console.ReadLine());
            t = m1(1) + m2(1) + m3(1);

            p = t / 3.0f;
            Console.WriteLine("Total : " + t);
            Console.WriteLine("Percentage : " + p);
            if (p >= 35 && p < 50)
            {
                Console.WriteLine("Grade is C");
            }
            if (p >= 50 && p <= 60)
            {
                Console.WriteLine("Grade is B");
            }
            if (p > 60 && p <= 80)
            {
                Console.WriteLine("Grade is A");
            }
            if (p > 80 && p <= 100)
            {
                Console.WriteLine("Grade is A+");
            }
            Console.ReadLine();
        }
        public void student()
        {

        }
    }
}



