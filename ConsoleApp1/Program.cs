
/*
* C# Program to Generate the Marksheet of the Student
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marksheet1
{
    class Program
    {
        
public void Main()
       
        {
    int r, m1, m2, m3, t;
    float p;
    string n;
    Console.WriteLine("Enter Roll Number :");
    r = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Student Name :");
    n = Console.ReadLine();
    Console.WriteLine("Mark of Subject1 : ");
    m1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Mark of Subject2 : ");
    m2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Mark of Subject3 : ");
    m3 = Convert.ToInt32(Console.ReadLine());
    t = m1 + m2 + m3;
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
        public void studentProgram()
        {
            Random r = new Random();
            String[] a = new String { "Harpreet", "Varinder", "Sahijdeep", "Lovepreet", "Sukhdeep" };
            int num1 = r.Next(0.4);
            int num2 = r.Next(0.4);
            int num3 = r.Next(0.4);
            int num4 = r.Next(0.4);
            int num5 = r.Next(0.4);

            List<string> student = new LIst<string>();
            student.Add(a[num1]);
            student.Add(a[num2]);
            student.Add(a[num3]);
            student.Add(a[num4]);
            student.Add(a[num5]);

            String[] a = new String { "C#", "Java", "Python" };
            List<string> program = new List<string>();
            program.Add(a[r.Next(0, 3)]);
            program.Add(a[r.Next(0, 3)]);
            program.Add(a[r.Next(0, 3)]);

        }
    }
}




