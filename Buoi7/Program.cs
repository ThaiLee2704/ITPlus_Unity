using System;
using System.Collections;
using System.Collections.Generic;

namespace Buoi7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(id: 1, name: "Thai", _class: "1A", score: 8, gender: Student.GENDER.MALE)
            };

            foreach (Student std in students)
            {
                std.PrintInfo();
                if (!std.subScores.TryAdd(Student.SUBJECT.MATH, 10))
                {
                    std.subScores[Student.SUBJECT.MATH] = 10;
                }
            }
        }

    }
}
