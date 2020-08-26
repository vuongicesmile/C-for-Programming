﻿using System;

public class Date
{
    private int month;
    private int day;
    public int Year { get; private set; }

    public int Month
    {
        get
        {
            return month;
        }

       private set //make writing inacessible outside the class -lam nguoi vier ko the truy cap tu ben ngoai vao lop
        {
            if (value <= 0 || value > 12)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value), value, $"{nameof(Month)} must be 1-12");
            }//end if
            month = value;
        }
    }

    public int Day
    {
        get
        {
            return day;
        }

        private set
        {
            int[] daysPerMonth = {0,31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            //check if day in range of month
            if (value <= 0 || value >daysPerMonth[Month])
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Day)} out of range for current month/year");
            }
            // check for leap year
            if (Month == 2 && value == 29 &&
                !(Year % 400 == 0 || (Year % 4 == 0 && Year %100 != 0 )))
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Day)} out of range for current month/year");
            }
            day = value;
        }
    }

    public Date(int month,int day,int year)
    {
        Month = month;//validates month
        Year = year;
        Day = day;
        Console.WriteLine($"Date object constructor for date {this}");
    }
    public override string ToString() => $"{Month}/{Day}/{Year}";
}