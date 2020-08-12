﻿using System;

class Student
{
    private int average;

    public string Name { get; set; }
   
    public Student (string studentName,int studentAverage)
    {
        Name = studentName;
        Average = studentAverage;
    }
    public int Average
    {
        get
        {
            return average;
        }

        set
        {
            if (value > 0)
            {
                if(value <= 100)
                {
                    average = value; // assign instance varible 
                }
            }
        }
    }

    public string LetterGrade
    {
        get
        {
            string letterGrade = string.Empty;

            if(average>=90)
            {
                letterGrade = "A";
            }
            else if (average>=80)
            {
                letterGrade = "B";
            }
            else if (average >= 70)
            {
                letterGrade = "C";
            }
            else if (average >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            return letterGrade;
        }
    }
}