// See https://aka.ms/new-console-template for more information
using System;
using Example;
using Microsoft.VisualBasic;

namespace Example
{

    class Program
    {
        static void Main(string[] args)
        {
            const int NUM_STRUDENTS = 5;
            Array students = Array.CreateInstance(typeof(Student), NUM_STRUDENTS);

            int sum = 0;
            double scoreMean = 0.0;

            Console.WriteLine("{0}명의 학생의 점수를 입력하세요.", NUM_STRUDENTS);
            for (int i = 0; i < NUM_STRUDENTS; i++)
            {
                int iNumber = i + 1;
                string score = Console.ReadLine();
                int iScore = Convert.ToInt32(score);

                Student student = new Student(iNumber, iScore);
                students.SetValue(student, i);
            }

        }
    }
}